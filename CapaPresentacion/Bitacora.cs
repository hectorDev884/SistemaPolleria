using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Bitacora : Form
    {
        private BitacoraCN _bitacoraCN = new BitacoraCN();

        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                DataSet ds = _bitacoraCN.ObtenerErrors();
                dataGridView1.DataSource = ds.Tables["sp_GetErrors"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bitácora: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}