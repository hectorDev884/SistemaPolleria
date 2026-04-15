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
    public partial class ConsultasLavadoPollo : Form
    {
        private ProductoLavadoCN _lavadoCN = new ProductoLavadoCN();

        public ConsultasLavadoPollo()
        {
            InitializeComponent();
        }

        private void cmdPorFecha_Click(object sender, EventArgs e)
        {
            DataSet ds = _lavadoCN.ObtenerLavadosPorFecha(dtpInicio.Value, dtpFin.Value);
            dataGridView1.DataSource = ds.Tables["GetLavadosPorFecha"];
        }

        private void cmdResumenDesperdicio_Click(object sender, EventArgs e)
        {
            DataSet ds = _lavadoCN.ObtenerResumenDesperdicioPorFecha(dtpInicio.Value, dtpFin.Value);
            dataGridView1.DataSource = ds.Tables["GetResumenDesperdicio"];
        }
    }
}