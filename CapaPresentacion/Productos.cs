using CapaNegocio;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        private ProductosCN _productosCN = new ProductosCN();
        private DataTable tablaProductos;
        private CategoriasCN _categoriasCN = new CategoriasCN();

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            tablaProductos =
                _productosCN.ObtenerProductos()
                .Tables["GetProductos"];

            dataGridView1.DataSource = tablaProductos;

            FillComboUnidadMedida();
            FillComboCategorias();


        }

        private void FillComboUnidadMedida()
        {
            cboUnidadMedida.Items.Clear();

            cboUnidadMedida.Items.Add("Pieza");
            cboUnidadMedida.Items.Add("Caja");
            cboUnidadMedida.Items.Add("Litro");
            cboUnidadMedida.Items.Add("Kilo");
            cboUnidadMedida.Items.Add("Metro");

            cboUnidadMedida.SelectedIndex = -1; // nada seleccionado
        }

        private void FillComboCategorias()
        {
            DataTable dt = _categoriasCN.ObtenerCategorias().Tables["GetCategorias"];

            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "CategoriaID";
            cboCategoria.DataSource = dt;

            cboUnidadMedida.SelectedIndex = -1;
        }
        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtExistencia.Enabled = true;
            txtPrecio.Enabled = true;
            cboEstatus.Enabled = true;

            cmdGuardar.Enabled = true;
            cmdCancelar.Enabled = true;

            cmdPermitirEdicion.Enabled = false;
            cboCategoria.Enabled = true;
            cboUnidadMedida.Enabled = true;

            txtIdProducto.Clear();
            txtIdProducto.Enabled = true;
            txtNombre.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string codigo = txtIdProducto.Text.Trim();

                if (!int.TryParse(txtExistencia.Text, out int existencia))
                {
                    MessageBox.Show("Existencia inválida");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Precio inválido");
                    return;
                }

                bool status = cboEstatus.SelectedIndex == 0;

                if (nombre == "" || cboEstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                int categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                string unidadMedida = cboUnidadMedida.Text;

                _productosCN.InsertarProducto(
                    codigo,
                    nombre,
                    existencia,
                    precio,
                    status,
                    categoria,
                    unidadMedida
                ); //TODO obtener correctamente unidad medida y categorias

                MessageBox.Show("Producto agregado correctamente");

                tablaProductos =
                    _productosCN.ObtenerProductos()
                    .Tables["GetProductos"];

                dataGridView1.DataSource = tablaProductos;

                cmdCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
                "Ingrese el codigo del producto:",
                "Buscar Producto",
                ""
            );

            DataTable dt =
                _productosCN.ObtenerProductoPorCodigo(input)
                .Tables["GetProductoByCodigo"];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            DataRow row = dt.Rows[0];

            txtIdProducto.Text = row["CodigoProducto"].ToString();
            txtNombre.Text = row["Nombre"].ToString();
            txtExistencia.Text = Convert.ToInt32(row["Existencia"]).ToString();
            txtPrecio.Text = row["PrecioVenta"].ToString();
            //Rellenar cbo correctamente


            bool status = Convert.ToBoolean(row["Status"]);
            cboEstatus.SelectedIndex = status ? 0 : 1;
            cboCategoria.SelectedValue = row["CategoriaID"];
            cboUnidadMedida.SelectedItem = row["UnidadMedida"].ToString();

            txtNombre.Enabled = false;
            txtExistencia.Enabled = false;
            txtPrecio.Enabled = false;
            cboEstatus.Enabled = false;

            cmdEditar.Visible = false;
            cmdEditar.Enabled = false;
            cmdPermitirEdicion.Visible = true;
            cmdPermitirEdicion.Enabled = true;


            cmdEliminar.Visible = true;
            cmdEliminar.Enabled = true;

            cmdGuardar.Enabled = false;
            cmdNuevo.Enabled = false;
        }
        private void cmdEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtIdProducto.Text;
                string nombre = txtNombre.Text;

                // Obtienes el ProductoID real desde la BD con el código
                DataSet ds = _productosCN.ObtenerProductoPorCodigo(codigo);
                if (ds.Tables["GetProductoByCodigo"].Rows.Count == 0)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                int id = Convert.ToInt32(ds.Tables["GetProductoByCodigo"].Rows[0]["ProductoID"]); // ✅ ID real

                if (!int.TryParse(txtExistencia.Text, out int existencia))
                {
                    MessageBox.Show("Existencia inválida");
                    return;
                }
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Precio inválido");
                    return;
                }

                bool status = cboEstatus.SelectedIndex == 0;
                string unidadMedida = cboUnidadMedida.Text;
                int categoria = Convert.ToInt32(cboCategoria.SelectedValue);

                _productosCN.ActualizarProducto(id, codigo, nombre, existencia, precio, status, categoria, unidadMedida);
                MessageBox.Show("Producto actualizado");
                tablaProductos = _productosCN.ObtenerProductos().Tables["GetProductos"];
                dataGridView1.DataSource = tablaProductos;
                cmdCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProducto.Text);

            DialogResult resp = MessageBox.Show(
                $"¿Desea eliminar el producto {id}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.No)
                return;

            try
            {
                _productosCN.EliminarProducto(id);

                MessageBox.Show("Producto eliminado");

                tablaProductos =
                    _productosCN.ObtenerProductos()
                    .Tables["GetProductos"];

                dataGridView1.DataSource = tablaProductos;

                cmdCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtExistencia.Enabled = false;
            txtPrecio.Enabled = false;
            cboEstatus.Enabled = false;

            txtIdProducto.Clear();
            txtNombre.Clear();
            txtExistencia.Clear();
            txtPrecio.Clear();

            cboEstatus.SelectedIndex = -1;

            cmdGuardar.Enabled = false;
            cmdEditar.Enabled = false;
            cmdEliminar.Enabled = false;

            cmdEditar.Visible = false;
            cmdEliminar.Visible = false;

            cmdPermitirEdicion.Visible = false;
            cmdNuevo.Enabled = true;
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmdPermitirEdicion_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtExistencia.Enabled = false;
            txtPrecio.Enabled = false;
            cboEstatus.Enabled = false;

            cmdEditar.Visible = true;
            cmdEditar.Enabled = true;
            cmdPermitirEdicion.Visible = true;

            txtExistencia.Enabled = true;
            txtNombre.Enabled = true;
            cboUnidadMedida.Enabled = true;
            cboCategoria.Enabled = true;
            cboEstatus.Enabled = true;
            txtPrecio.Enabled = true;
        }
    }
}
