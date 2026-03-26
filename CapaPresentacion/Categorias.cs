using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class Categorias : Form
    {
        private CategoriasCN _categoriasCN = new CategoriasCN();
        private DataTable tablaCategorias;

        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            tablaCategorias =
                _categoriasCN.ObtenerCategorias()
                .Tables["GetCategorias"];

            dataGridView1.DataSource = tablaCategorias;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;

            cmdGuardar.Enabled = true;
            cmdCancelar.Enabled = true;

            txtIdCategoria.Clear();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                if (nombre == "" || descripcion == "")
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                int nuevoID =
                    _categoriasCN.InsertarCategoria(
                        nombre,
                        descripcion);

                MessageBox.Show("Categoría agregada correctamente");

                tablaCategorias.Rows.Add(
                    nuevoID,
                    nombre,
                    descripcion
                );

                txtNombre.Clear();
                txtDescripcion.Clear();

                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;

                cmdCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
                "Ingrese el ID de la categoría:",
                "Buscar Categoría",
                "");

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (!int.TryParse(input, out int idCategoria))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            DataTable dt =
                _categoriasCN.ObtenerCategoriaPorId(idCategoria)
                .Tables["GetCategoriaByID"];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Categoría no encontrada");
                return;
            }

            DataRow row = dt.Rows[0];

            txtIdCategoria.Text = row["CategoriaID"].ToString();
            txtNombre.Text = row["Nombre"].ToString();
            txtDescripcion.Text = row["Descripcion"].ToString();

            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;

            cmdEditar.Visible = false;
            cmdEditar.Enabled = false;
            cmdPermitirEdicion.Visible = true;
            cmdPermitirEdicion.Enabled = true;
            cmdEliminar.Visible = true;
            cmdEliminar.Enabled = true;

            cmdGuardar.Enabled = false;
            cmdCancelar.Enabled = true;
            cmdNuevo.Enabled = false;
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id =
                    Convert.ToInt32(txtIdCategoria.Text);

                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                _categoriasCN.ActualizarCategoria(
                    id,
                    nombre,
                    descripcion);

                MessageBox.Show("Categoría actualizada");

                tablaCategorias =
                    _categoriasCN.ObtenerCategorias()
                    .Tables["GetCategorias"];

                dataGridView1.DataSource =
                    tablaCategorias;

                cmdCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar: " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int id =
                Convert.ToInt32(txtIdCategoria.Text);

            DialogResult resp = MessageBox.Show(
                $"¿Eliminar categoría {id}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.No)
                return;

            _categoriasCN.EliminarCategoria(id);

            MessageBox.Show("Categoría eliminada");

            DataRow[] filas = tablaCategorias.Select(
                $"CategoriaID = {id}"
            );

            if (filas.Length > 0)
            {
                tablaCategorias.Rows.Remove(filas[0]);
            }

            dataGridView1.DataSource =
                tablaCategorias;

            cmdCancelar_Click(sender, e);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;

            txtIdCategoria.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();

            cmdEditar.Visible = false;
            cmdEliminar.Visible = false;

            cmdPermitirEdicion.Visible = false;
            cmdPermitirEdicion.Enabled = false;

            cmdNuevo.Enabled = true;
            cmdGuardar.Enabled = false;
        }

        private void cmdPermitirEdicion_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;

            cmdEditar.Visible = true;
            cmdEditar.Enabled = true;

            cmdEliminar.Visible = false;
            cmdEliminar.Enabled = false;

            cmdGuardar.Enabled = false;
            cmdNuevo.Enabled = false;

            cmdPermitirEdicion.Enabled = false;
            cmdPermitirEdicion.Visible = false;
        }
    }
}