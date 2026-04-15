using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Venta : Form
    {
        private VentasCN _ventasCN = new VentasCN();
        private ProductosCN _productosCN = new ProductosCN();
        private ClientesCN _clientesCN = new ClientesCN();
        private CategoriasCN _categoriasCN = new CategoriasCN();

        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {

            try
            {
                txtIdVenta.Text = _ventasCN.ObtenerUltimaVentaID().ToString();

                DataTable dtCategorias =
                    _categoriasCN.ObtenerCategorias()
                    .Tables["GetCategorias"];

                cboCategoria.DataSource = dtCategorias;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "CategoriaID";

                cboCategoria.SelectedIndex = -1;

                cboProducto.Enabled = false;
                cboCliente.Enabled = false;

                dataGridView1.AllowUserToAddRows = false;

                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar formulario: " + ex.Message);
            }
        }

        private void radioVenta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioVenta.Checked)
                {
                    DataTable dtClientes =
                        _clientesCN.ObtenerClientes()
                        .Tables["GetClientes"];

                    cboCliente.DataSource = dtClientes;
                    cboCliente.DisplayMember = "Nombre";
                    cboCliente.ValueMember = "ClienteID";

                    cboCliente.Enabled = true;
                }
                else
                {
                    cboCliente.DataSource = null;
                    cboCliente.Enabled = false;
                    txtIdCliente.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCategoria.SelectedIndex == -1 || cboCategoria.SelectedValue == null)
                    return;

                if (!int.TryParse(cboCategoria.SelectedValue.ToString(), out int categoriaID))
                    return;

                categoriaID = Convert.ToInt32(cboCategoria.SelectedValue);

                DataTable dtProductos =
                    _productosCN.ObtenerProductosPorCategoria(categoriaID)
                    .Tables["GetProductosByCategoria"];

                cboProducto.DataSource = dtProductos;
                cboProducto.DisplayMember = "Producto";
                cboProducto.ValueMember = "ProductoID";

                cboProducto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese cantidad");
                    return;
                }

                int productoID = Convert.ToInt32(txtIdProducto.Text);
                string codigo = txtCodigo.Text;
                string producto = cboProducto.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string categoria = cboCategoria.Text;
                string unidad = txtUnidadMedida.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductoID"].Value) == productoID)
                    {
                        // Sumar cantidad y recalcular subtotal
                        int cantidadExistente = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        int nuevaCantidad = cantidadExistente + cantidad;
                        decimal nuevoSubtotal = precio * nuevaCantidad;

                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["Subtotal"].Value = nuevoSubtotal;

                        // Limpiar y salir
                        LimpiarCamposProducto();
                        return;
                    }
                }

                // Si no existe, agregar fila nueva normal
                decimal subtotal = precio * cantidad;
                dataGridView1.Rows.Add(productoID, codigo, producto, precio, categoria, unidad, cantidad, subtotal);

                LimpiarCamposProducto();
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue productos a la venta");
                    return;
                }

                // Armar el DataTable de detalles
                DataTable detalles = new DataTable();
                detalles.Columns.Add("ProductoID", typeof(int));
                detalles.Columns.Add("PrecioUnitario", typeof(decimal));
                detalles.Columns.Add("Cantidad", typeof(int));
                detalles.Columns.Add("Subtotal", typeof(decimal));

                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    total += subtotal;

                    detalles.Rows.Add(productoID, precio, cantidad, subtotal);
                }

                // Si hay cliente lo mandamos, sino null
                int? clienteID = null;
                if (radioVenta.Checked && txtIdCliente.Text.Trim() != "")
                    clienteID = Convert.ToInt32(txtIdCliente.Text);

                _ventasCN.InsertarVentaCompleta(DateTime.Now, total, clienteID, detalles);

                MessageBox.Show("Venta guardada correctamente");

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar venta: " + ex.Message);
            }
        }

        private void cboCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1 || cboCliente.SelectedValue == null)
                return;

            if (!int.TryParse(cboCliente.SelectedValue.ToString(), out _))
                return;

            txtIdCliente.Text = cboCliente.SelectedValue.ToString();
        }

        private void cboProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1 || cboProducto.SelectedItem == null)
                return;

            DataRowView row = cboProducto.SelectedItem as DataRowView;
            if (row == null)
                return;

            txtIdProducto.Text = row["ProductoID"].ToString();
            txtCodigo.Text = row["CodigoProducto"].ToString();
            txtPrecio.Text = row["PrecioVenta"].ToString();
            txtUnidadMedida.Text = row["UnidadMedida"].ToString();
        }

        private void LimpiarFormulario()
        {
            dataGridView1.Rows.Clear();

            cboCategoria.SelectedIndex = -1;
            cboProducto.DataSource = null;
            cboProducto.Enabled = false;

            txtIdProducto.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtUnidadMedida.Clear();
            txtCantidad.Clear();
            txtIdCliente.Clear();

            radioVenta.Checked = false;

            cboCliente.DataSource = null;
            cboCliente.Enabled = false;

            txtSubtotal.Text = "0.00";
            txtTotal.Text = "0.00";
        }

        private void LimpiarCamposProducto()
        {
            cboCategoria.SelectedIndex = -1;
            cboProducto.DataSource = null;
            cboProducto.Enabled = false;
            txtIdProducto.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtUnidadMedida.Clear();
            txtCantidad.Clear();
            cboCliente.Enabled = false;
            txtCantidad.Focus();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value != null)
                    total += Convert.ToDecimal(row.Cells[7].Value);
            }

            txtSubtotal.Text = total.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            ConsultasVentas consultasVentas = new ConsultasVentas();
            consultasVentas.ShowDialog();
        }
    }
}