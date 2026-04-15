using CapaNegocio;
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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClientesCN clientesCN = new ClientesCN();

            DateTime fechaSeleccionada = dtpFechaRegistro.Value;

            DataSet ds = clientesCN.ObtenerClientesPorFecha(fechaSeleccionada);

            dgvClientes.DataSource = ds.Tables["GetClientesByFecha"];
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            ClientesCN clientesCN = new ClientesCN();
            DataSet ds = clientesCN.ObtenerClientesActivos();
            dgvClientes.DataSource = ds.Tables["GetClientesActivos"];
        }
    }
}
