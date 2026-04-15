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
    public partial class ConsultaProveedores : Form
    {
        public ConsultaProveedores()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProveedoresCN proveedoresCN = new ProveedoresCN();

            DateTime fechaSeleccionada = dtpFechaRegistro.Value;

            DataSet ds = proveedoresCN.ObtenerProveedoresPorFecha(fechaSeleccionada);

            dgvProveedores.DataSource = ds.Tables["GetProveedoresByFecha"];
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            ProveedoresCN proveedoresCN = new ProveedoresCN();
            DataSet ds = proveedoresCN.ObtenerProveedoresActivos();
            dgvProveedores.DataSource = ds.Tables["GetProveedoresActivos"];
        }
    }
}
