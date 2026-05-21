using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // ── Catálogos ─────────────────────────────────────────────
        private void mnuCategorias_Click(object sender, EventArgs e)
        {
            new Categorias().ShowDialog();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            new Productos().ShowDialog();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            new Clientes().ShowDialog();
        }

        private void mnuProveedores_Click(object sender, EventArgs e)
        {
            new Proveedores().ShowDialog();
        }

        // ── Movimientos ───────────────────────────────────────────
        private void mnuVentas_Click(object sender, EventArgs e)
        {
            new Venta().ShowDialog();
        }

        private void mnuCompras_Click(object sender, EventArgs e)
        {
            new Compra().ShowDialog();
        }

        private void mnuLavarPollo_Click(object sender, EventArgs e)
        {
            new LavarPollo().ShowDialog();
        }

        // ── Reportes y Consultas ──────────────────────────────────
        private void mnuReportes_Click(object sender, EventArgs e)
        {
            new Reportes().ShowDialog();
        }

        private void mnuConsultasVentas_Click(object sender, EventArgs e)
        {
            new ConsultasVentas().ShowDialog();
        }

        private void mnuConsultasCompras_Click(object sender, EventArgs e)
        {
            new ConsultasCompras().ShowDialog();
        }

        private void mnuConsultasLavado_Click(object sender, EventArgs e)
        {
            new ConsultasLavadoPollo().ShowDialog();
        }

        private void mnuConsultaClientes_Click(object sender, EventArgs e)
        {
            new ConsultaClientes().ShowDialog();
        }

        private void mnuConsultaProveedores_Click(object sender, EventArgs e)
        {
            new ConsultaProveedores().ShowDialog();
        }

        private void mnuBitacora_Click(object sender, EventArgs e)
        {
            new Bitacora().ShowDialog();
        }

        // ── Utilería ──────────────────────────────────────────────
        private void mnuUtileriaItem_Click(object sender, EventArgs e)
        {
            new Utileria().ShowDialog();
        }

        private void mnuTraspasoHistorico_Click(object sender, EventArgs e)
        {
            new TraspasoHistorico().ShowDialog();
        }

        private void mnuAyuda_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "polleria.chm");
            if (File.Exists(ruta))
                Process.Start(ruta);
            else
                MessageBox.Show("No se encontró el archivo de ayuda.", "Ayuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
