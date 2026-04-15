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
    public partial class ConsultasCompras : Form
    {
        private ComprasCN _comprasCN = new ComprasCN();
        private ProveedoresCN _proveedoresCN = new ProveedoresCN();

        public ConsultasCompras()
        {
            InitializeComponent();
        }


        private void CargarProveedores()
        {
            DataSet ds = _proveedoresCN.ObtenerProveedores();
            DataTable dt = ds.Tables[0];

            cboProveedores.DisplayMember = "Nombre";
            cboProveedores.ValueMember = "ProveedorID";
            cboProveedores.DataSource = dt;
            cboProveedores.SelectedIndex = -1;
        }

        private void cmdPorFecha_Click(object sender, EventArgs e)
        {
            DataSet ds = _comprasCN.ObtenerComprasPorFecha(dtpInicio.Value, dtpFin.Value);
            dataGridView1.DataSource = ds.Tables["GetComprasPorFecha"];
        }
        private void cmdPorProveedor_Click(object sender, EventArgs e)
        {
            if (cboProveedores.SelectedValue == null) return;

            int proveedorID = Convert.ToInt32(cboProveedores.SelectedValue);
            DataSet ds = _comprasCN.ObtenerComprasPorProveedor(proveedorID);
            dataGridView1.DataSource = ds.Tables["GetComprasPorProveedor"];
        }

        private void ConsultasCompras_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}