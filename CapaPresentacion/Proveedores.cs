using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class Proveedores : Form
    {
        private ProveedoresCN _proveedoresCN = new ProveedoresCN();
        private DataTable tablaProveedores;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            tablaProveedores =
                _proveedoresCN.ObtenerProveedores()
                .Tables["GetProveedores"];

            dataGridView1.DataSource = tablaProveedores;
        }


        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            cboEstatus.Enabled = true;

            cmdGuardar.Enabled = true;
            cmdCancelar.Enabled = true;

            txtIdProveedor.Clear();
        }


        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                bool status = cboEstatus.SelectedIndex == 0;

                if (nombre == "" || telefono == "" ||
                    direccion == "" || cboEstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                int nuevoID =
                    _proveedoresCN.InsertarProveedor(
                        nombre,
                        telefono,
                        direccion,
                        status);

                MessageBox.Show("Proveedor agregado correctamente");

                tablaProveedores.Rows.Add(
                    nuevoID,
                    nombre,
                    telefono,
                    direccion,
                    status,
                    DateTime.Now
                );

                txtNombre.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();

                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
                cboEstatus.Enabled = false;

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
                "Ingrese el ID del proveedor:",
                "Buscar Proveedor",
                "");

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (!int.TryParse(input, out int idProveedor))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            DataTable dt =
                _proveedoresCN.ObtenerProveedorPorId(idProveedor)
                .Tables["GetProveedorByID"];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Proveedor no encontrado");
                return;
            }

            DataRow row = dt.Rows[0];

            txtIdProveedor.Text = row["ProveedorID"].ToString();
            txtNombre.Text = row["Nombre"].ToString();
            txtTelefono.Text = row["Telefono"].ToString();
            txtDireccion.Text = row["Direccion"].ToString();

            bool status = Convert.ToBoolean(row["Status"]);
            cboEstatus.SelectedIndex = status ? 0 : 1;

            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            cboEstatus.Enabled = false;

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
                    Convert.ToInt32(txtIdProveedor.Text);

                string nombre = txtNombre.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                bool status = cboEstatus.SelectedIndex == 0;

                _proveedoresCN.ActualizarProveedor(
                    id,
                    nombre,
                    telefono,
                    direccion,
                    status);

                MessageBox.Show("Proveedor actualizado");

                tablaProveedores =
                    _proveedoresCN.ObtenerProveedores()
                    .Tables["GetProveedores"];

                dataGridView1.DataSource =
                    tablaProveedores;

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
                Convert.ToInt32(txtIdProveedor.Text);

            DialogResult resp = MessageBox.Show(
                $"¿Eliminar proveedor {id}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.No)
                return;

            _proveedoresCN.EliminarProveedor(id);

            MessageBox.Show("Proveedor eliminado");

            DataRow[] filas = tablaProveedores.Select(
                $"ProveedorID = {id}"
            );

            if (filas.Length > 0)
            {
                tablaProveedores.Rows.Remove(filas[0]);
            }

            dataGridView1.DataSource =
                tablaProveedores;
            cmdCancelar_Click(sender, e);
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            cboEstatus.Enabled = false;

            txtIdProveedor.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cboEstatus.SelectedIndex = -1;

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
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            cboEstatus.Enabled = true;

            cmdEditar.Visible = true;
            cmdEditar.Enabled = true;

            cmdEliminar.Visible = false;
            cmdEliminar.Enabled = false;

            cmdGuardar.Enabled = false;
            cmdNuevo.Enabled = false;

            cmdPermitirEdicion.Enabled = false;
            cmdPermitirEdicion.Visible = false;
        }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            ConsultaProveedores consulta = new ConsultaProveedores();
            consulta.ShowDialog();
        }
    }
}