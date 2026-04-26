using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        private ProveedoresCN _proveedoresCN = new ProveedoresCN();
        private ClientesCN _clientesCN = new ClientesCN();
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            try
            {
                // Cargar proveedores
                DataTable dtProveedores =
                    _proveedoresCN.ObtenerProveedores()
                    .Tables["GetProveedores"];

                cboProveedor.DataSource = dtProveedores;
                cboProveedor.DisplayMember = "Nombre";
                cboProveedor.ValueMember = "ProveedorID";
                cboProveedor.SelectedIndex = -1;

                DataSet ds = _clientesCN.ObtenerClientes();
                DataTable dt = ds.Tables[0];

                cboCliente.DisplayMember = "Nombre";
                cboCliente.ValueMember = "ClienteID";
                cboCliente.DataSource = dt;
                cboCliente.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar formulario: " + ex.Message);
            }

        }

        private void cmdVentasPorFecha_Click(object sender, EventArgs e)
        {
            VentasCN negocio = new VentasCN();

            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            DataTable datos = negocio.GetVentasPorFecha(fechaInicio, fechaFin);

            ReportDataSource rds = new ReportDataSource("DataSet1", datos);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath,
                "Reportes",
                "ReporteVentasPorFecha.rdlc"
            );
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void cmdClientesGeneral_Click(object sender, EventArgs e)
        {
            ClientesCN negocio = new ClientesCN();


            DataTable datos = negocio.ObtenerClientes().Tables["GetClientes"];

            ReportDataSource rds = new ReportDataSource("DataSet1", datos);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath,
                "Reportes",
                "ReporteClientesGeneral.rdlc"
            );
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void cmdComprasPorFecha_Click(object sender, EventArgs e)
        {
            ComprasCN negocio = new ComprasCN();
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            DataSet datos = negocio.ObtenerComprasPorFecha(fechaInicio, fechaFin);
            DataTable tabla = datos.Tables["GetComprasPorFecha"];

            ReportParameter p1 = new ReportParameter("FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
            ReportParameter p2 = new ReportParameter("FechaFin", fechaFin.ToString("yyyy-MM-dd"));

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath,
                "Reportes",
                "ReporteComprasPorFecha.rdlc"
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
            reportViewer1.RefreshReport();
        }

        private void cmdComprasPorProveedor_Click(object sender, EventArgs e)
        {
            ComprasCN negocio = new ComprasCN();
            int proveedorID = Convert.ToInt32(cboProveedor.SelectedValue);

            DataSet datos = negocio.ObtenerComprasPorProveedor(proveedorID);
            DataTable tabla = datos.Tables["GetComprasPorProveedor"];

            ReportParameter p1 = new ReportParameter("Proveedor", proveedorID.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteComprasPorProveedor.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            reportViewer1.RefreshReport();
        }

        private void cmdVentasPorCliente_Click(object sender, EventArgs e)
        {
            VentasCN negocio = new VentasCN();
            int clienteID = Convert.ToInt32(cboCliente.SelectedValue);

            DataSet datos = negocio.ObtenerVentasPorCliente(clienteID);
            DataTable tabla = datos.Tables["GetVentasPorCliente"];

            ReportParameter p1 = new ReportParameter("Cliente", clienteID.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteVentasPorCliente.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            reportViewer1.RefreshReport();
        }

        private void cmdProductosMasVendidos_Click(object sender, EventArgs e)
        {
            VentasCN negocio = new VentasCN();
            int top = (int)nudTop.Value;

            DataSet datos = negocio.ObtenerTopProductosVendidos(top);
            DataTable tabla = datos.Tables["GetTopProductos"];

            ReportParameter p1 = new ReportParameter("Numero", top.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteProductosMasVendidos.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            reportViewer1.RefreshReport();
        }

        private void cmdLavadasPorFecha_Click(object sender, EventArgs e)
        {
            ProductoLavadoCN negocio = new ProductoLavadoCN();
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            DataSet datos = negocio.ObtenerLavadosPorFecha(fechaInicio, fechaFin);
            DataTable tabla = datos.Tables["GetLavadosPorFecha"];

            ReportParameter p1 = new ReportParameter("FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
            ReportParameter p2 = new ReportParameter("FechaFin", fechaFin.ToString("yyyy-MM-dd"));

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteLavadasPorFecha.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
            reportViewer1.RefreshReport();
        }

        private void cmdDesperdiciosPorFecha_Click(object sender, EventArgs e)
        {
            ProductoLavadoCN negocio = new ProductoLavadoCN();
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            DataSet datos = negocio.ObtenerResumenDesperdicioPorFecha(fechaInicio, fechaFin);
            DataTable tabla = datos.Tables["GetResumenDesperdicio"];

            ReportParameter p1 = new ReportParameter("FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
            ReportParameter p2 = new ReportParameter("FechaFin", fechaFin.ToString("yyyy-MM-dd"));

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteDesperdiciosPorFecha.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
            reportViewer1.RefreshReport();
        }

        private void cmdProveedoresGeneral_Click(object sender, EventArgs e)
        {
            ProveedoresCN negocio = new ProveedoresCN();

            DataTable tabla = negocio.ObtenerProveedores().Tables["GetProveedores"];

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteProveedoresGeneral.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void cmdProductosGeneral_Click(object sender, EventArgs e)
        {
            ProductosCN negocio = new ProductosCN();

            DataTable tabla = negocio.ObtenerProductos().Tables["GetProductos"];

            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);

            reportViewer1.LocalReport.ReportPath = Path.Combine(
                Application.StartupPath, "Reportes", "ReporteProductosGeneral.rdlc");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
