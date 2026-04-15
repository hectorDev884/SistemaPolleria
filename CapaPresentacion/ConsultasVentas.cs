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
    public partial class ConsultasVentas : Form
    {
        private VentasCN _ventasCN = new VentasCN();
        private ClientesCN _clientesCN = new ClientesCN();

        public ConsultasVentas()
        {
            InitializeComponent();
        }

        private void ConsultasVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            DataSet ds = _clientesCN.ObtenerClientes();
            DataTable dt = ds.Tables[0];

            cboClientes.DisplayMember = "Nombre";
            cboClientes.ValueMember = "ClienteID";
            cboClientes.DataSource = dt;
            cboClientes.SelectedIndex = -1;
        }

        private void cmdPorFecha_Click(object sender, EventArgs e)
        {
            DataTable dt = _ventasCN.GetVentasPorFecha(dtpInicio.Value, dtpFin.Value);
            dataGridView1.DataSource = dt;
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedValue == null) return;

            int clienteID = Convert.ToInt32(cboClientes.SelectedValue);
            DataSet ds = _ventasCN.ObtenerVentasPorCliente(clienteID);
            dataGridView1.DataSource = ds.Tables["GetVentasPorCliente"];
        }

        private void cmdTopProductos_Click(object sender, EventArgs e)
        {
            int top = Convert.ToInt32(nudTop.Value);
            DataSet ds = _ventasCN.ObtenerTopProductosVendidos(top);
            dataGridView1.DataSource = ds.Tables["GetTopProductos"];
        }
    }
}