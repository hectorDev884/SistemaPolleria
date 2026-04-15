using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class Clientes : Form
    {
        private ClientesCN _clientesCN = new ClientesCN();
        private DataTable tablaClientes;
        public Clientes()
        {
            InitializeComponent();
        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            tablaClientes = _clientesCN.ObtenerClientes().Tables["GetClientes"];
            dataGridView1.DataSource = tablaClientes;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();

                // Status por defecto = 1 (true)
                bool status = cboEstatus.SelectedIndex == 0;

                if (nombre == "" || apellido == "" || telefono == "" || cboEstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                int nuevoID = _clientesCN.InsertarCliente(
                    nombre,
                    apellido,
                    telefono,
                    status
                );

                MessageBox.Show("Cliente agregado correctamente");

                // refrescar grid
                tablaClientes.Rows.Add(
                    nuevoID,
                    nombre,
                    apellido,
                    telefono,
                    status
                );

                // limpiar cajas
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();

                txtNombre.Focus();

                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                cboEstatus.Enabled = false;
                cmdCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtIdCliente.Text);

            DialogResult resp = MessageBox.Show(
                $"¿Desea eliminar el cliente {id}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.No)
                return;

            try
            {

                _clientesCN.EliminarCliente(id);

                MessageBox.Show("Cliente eliminado");

                // recargar el grid
                DataRow[] filas = tablaClientes.Select(
                    $"ClienteID = {id}"
                );

                if (filas.Length > 0)
                {
                    tablaClientes.Rows.Remove(filas[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            cboEstatus.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdCancelar.Enabled = true;
            txtIdCliente.Clear();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            cboEstatus.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdCancelar.Enabled = false;

            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            cboEstatus.SelectedIndex = -1;
            // deshabilitar eliminar
            cmdEliminar.Visible = false;
            cmdEliminar.Enabled = false;

            //  deshabilitar guardar cambios
            cmdEditar.Enabled = false;
            cmdEditar.Visible = false;

            cmdNuevo.Enabled = true;
            txtIdCliente.Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
            "Ingrese el ID del cliente:",
            "Editar Cliente",
            ""
             );

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (!int.TryParse(input, out int idCliente))
            {
                MessageBox.Show("ID inválido");
                return;
            }

            DataTable dt = _clientesCN
                .ObtenerClientePorId(idCliente)
                .Tables["GetClienteByID"];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            DataRow row = dt.Rows[0];

            txtIdCliente.Text = row["ClienteID"].ToString();
            txtNombre.Text = row["Nombre"].ToString();
            txtApellido.Text = row["Apellido"].ToString();
            txtTelefono.Text = row["Telefono"].ToString();

            bool status = Convert.ToBoolean(row["Status"]);
            cboEstatus.SelectedIndex = status ? 0 : 1;

            // habilitar edición
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            cboEstatus.Enabled = true;
            cmdGuardar.Enabled = false;
            cmdCancelar.Enabled = true;

            // habilitar eliminar
            cmdEliminar.Visible = true;
            cmdEliminar.Enabled = true;

            //habilitar guardar cambios
            cmdEditar.Enabled = true;
            cmdEditar.Visible = true;

            cmdNuevo.Enabled = false;
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdCliente.Text.Trim());

                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();

                // 0 = Activo (true)
                // 1 = Inactivo (false)
                bool status = cboEstatus.SelectedIndex == 0;

                if (nombre == "" || apellido == "" || telefono == "" || cboEstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                _clientesCN.ActualizarCliente(
                    id,
                    nombre,
                    apellido,
                    telefono,
                    status
                );

                MessageBox.Show("Cliente actualizado correctamente");

                // refrescar grid
                tablaClientes = _clientesCN.ObtenerClientes()
                    .Tables["GetClientes"];

                dataGridView1.DataSource = tablaClientes;

                // bloquear controles
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                cboEstatus.Enabled = false;

                // limpiar
                txtIdCliente.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                cboEstatus.SelectedIndex = -1;

                // habilitar eliminar
                cmdEliminar.Visible = false;
                cmdEliminar.Enabled = false;

                //habilitar guardar cambios
                cmdEditar.Enabled = false;
                cmdEditar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.ShowDialog();
        }
    }


}
