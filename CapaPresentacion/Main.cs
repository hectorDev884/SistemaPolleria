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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.ShowDialog();
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.ShowDialog();
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.ShowDialog();
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            Venta frm = new Venta();
            frm.ShowDialog();
        }

        private void cmdCompras_Click(object sender, EventArgs e)
        {
            Compra frm = new Compra();
            frm.ShowDialog();
        }

        private void cmdLavarPollo_Click(object sender, EventArgs e)
        {
            LavarPollo lavarPollo = new LavarPollo();
            lavarPollo.ShowDialog();
        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {

            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}
