using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Compra : Form
    {
        private ComprasCN _comprasCN = new ComprasCN();
        private ProductosCN _productosCN = new ProductosCN();
        private ProveedoresCN _proveedoresCN = new ProveedoresCN();
        private CategoriasCN _categoriasCN = new CategoriasCN();
        private HistoricoCN _historicoCN = new HistoricoCN();

        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar proveedores
                DataTable dtProveedores =
                    _proveedoresCN.ObtenerProveedores()
                    .Tables["GetProveedores"];
                txtIdCompra.Text = (_comprasCN.ObtenerUltimaCompraID() + 1).ToString();

                cboProveedor.DataSource = dtProveedores;
                cboProveedor.DisplayMember = "Nombre";
                cboProveedor.ValueMember = "ProveedorID";
                cboProveedor.SelectedIndex = -1;

                // Cargar categorías
                DataTable dtCategorias =
                    _categoriasCN.ObtenerCategorias()
                    .Tables["GetCategorias"];

                cboCategoria.DataSource = dtCategorias;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "CategoriaID";
                cboCategoria.SelectedIndex = -1;

                cboProducto.Enabled = false;

                dataGridView1.AllowUserToAddRows = false;

                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar formulario: " + ex.Message);
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

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1 || cboProducto.SelectedItem == null)
                return;

            DataRowView row = cboProducto.SelectedItem as DataRowView;
            if (row == null)
                return;

            txtIdProducto.Text = row["ProductoID"].ToString();
            txtCodigo.Text = row["CodigoProducto"].ToString();
            txtUnidadMedida.Text = row["UnidadMedida"].ToString();
            // txtPrecio lo llena el usuario manualmente, no se toca aquí
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

                if (txtPrecio.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese precio unitario");
                    return;
                }

                int productoID = Convert.ToInt32(txtIdProducto.Text);
                string codigo = txtCodigo.Text;
                string producto = cboProducto.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string categoria = cboCategoria.Text;
                string unidad = txtUnidadMedida.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                // Si ya existe el producto en el grid, sumar cantidad
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductoID"].Value) == productoID)
                    {
                        int cantidadExistente = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        int nuevaCantidad = cantidadExistente + cantidad;
                        decimal nuevoSubtotal = precio * nuevaCantidad;

                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["Subtotal"].Value = nuevoSubtotal;

                        LimpiarCamposProducto();
                        ActualizarTotal();
                        return;
                    }
                }

                // Si no existe, agregar fila nueva
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
                if (cboProveedor.SelectedIndex == -1 || cboProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor");
                    return;
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue productos a la compra");
                    return;
                }

                // Armar DataTable de detalles
                DataTable detalles = new DataTable();
                detalles.Columns.Add("ProductoID", typeof(int));
                detalles.Columns.Add("Cantidad", typeof(int));
                detalles.Columns.Add("PrecioUnitario", typeof(decimal));
                detalles.Columns.Add("Subtotal", typeof(decimal));

                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    total += subtotal;

                    detalles.Rows.Add(productoID, cantidad, precio, subtotal);
                }

                int proveedorID = Convert.ToInt32(cboProveedor.SelectedValue);

                _comprasCN.InsertarCompraCompleta(proveedorID, DateTime.Now, total, detalles);

                MessageBox.Show("Compra guardada correctamente");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar compra: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            dataGridView1.Rows.Clear();

            cboProveedor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            cboProducto.DataSource = null;
            cboProducto.Enabled = false;

            txtIdProducto.Clear();
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtUnidadMedida.Clear();
            txtCantidad.Clear();

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

            txtCantidad.Focus();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            txtSubtotal.Text = total.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedor.SelectedIndex == -1 || cboProveedor.SelectedValue == null)
                return;

            if (!int.TryParse(cboProveedor.SelectedValue.ToString(), out _))
                return;

            txtIdProveedor.Text = cboProveedor.SelectedValue.ToString();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ConsultasCompras consultasCompras = new ConsultasCompras();
            consultasCompras.ShowDialog();
        }

        private void cmdHistorico_Click(object sender, EventArgs e)
        {

        }

        private void cmdHistorico_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form dialog = new Form()
                {
                    Width = 320,
                    Height = 170,
                    Text = "Paso a Historicos - Compras",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                Label lbl = new Label() { Left = 20, Top = 20, Text = "Anio a transferir:", Width = 120, Font = new System.Drawing.Font("Segoe UI", 10F) };
                NumericUpDown nud = new NumericUpDown() { Left = 20, Top = 48, Width = 100, Minimum = 2000, Maximum = 2100, Value = DateTime.Now.Year, Font = new System.Drawing.Font("Segoe UI", 10F) };
                Button btnOk = new Button() { Text = "Transferir", Left = 160, Top = 20, Width = 120, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = System.Drawing.Color.FromArgb(5, 150, 105), ForeColor = System.Drawing.Color.White, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold) };
                Button btnCancel = new Button() { Text = "Cancelar", Left = 160, Top = 65, Width = 120, Height = 35, FlatStyle = FlatStyle.Flat };

                btnOk.Click += (s, ev) => { dialog.DialogResult = DialogResult.OK; dialog.Close(); };
                btnCancel.Click += (s, ev) => { dialog.DialogResult = DialogResult.Cancel; dialog.Close(); };

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(nud);
                dialog.Controls.Add(btnOk);
                dialog.Controls.Add(btnCancel);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int anio = (int)nud.Value;

                    DialogResult confirm = MessageBox.Show(
                        string.Format("Se transferiran Compras y DetalleCompras del anio {0} a la base historica. Una vez transferidos se eliminaran del sistema actual. Confirma?", anio),
                        "Confirmar transferencia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm != DialogResult.Yes) return;

                    _historicoCN.PasarComprasAHistorico(anio);
                    MessageBox.Show("Compras transferidas correctamente al historico.", "Transferencia completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al transferir compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}