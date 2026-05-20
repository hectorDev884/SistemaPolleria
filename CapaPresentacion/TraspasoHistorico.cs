using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class TraspasoHistorico : Form
    {
        private readonly HistoricoCN _historicoCN = new HistoricoCN();

        public TraspasoHistorico()
        {
            InitializeComponent();
            numAnio.Value = DateTime.Now.Year;
        }

        private void chkIncluirMovimientos_CheckedChanged(object sender, EventArgs e)
        {
            numAnio.Enabled = chkIncluirMovimientos.Checked;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int? anio = chkIncluirMovimientos.Checked ? (int?)(int)numAnio.Value : null;

            string mensaje = anio.HasValue
                ? $"Se archivarán los catálogos Y los movimientos del año {anio}.\n\n" +
                  $"Los movimientos del año {anio} serán ELIMINADOS de la base de datos principal.\n\n" +
                  "¿Desea continuar?"
                : "Se archivarán los catálogos (Categorías, Proveedores, Clientes y Productos).\n" +
                  "Solo se copiarán registros nuevos; no se elimina nada del sistema principal.\n\n" +
                  "¿Desea continuar?";

            if (MessageBox.Show(mensaje, "Confirmar traspaso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            SetEstado("Ejecutando traspaso...", false);
            try
            {
                _historicoCN.PasarTodoAHistorico(anio);
                SetEstado("Traspaso completado exitosamente.", true);
                MessageBox.Show("Traspaso a histórico realizado con éxito.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetEstado("Error al ejecutar el traspaso.", true);
                MessageBox.Show("Error al realizar el traspaso:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetEstado(string mensaje, bool habilitar)
        {
            lblEstado.Text = mensaje;
            lblEstado.Visible = true;
            btnEjecutar.Enabled = habilitar;
            chkIncluirMovimientos.Enabled = habilitar;
            Application.DoEvents();
        }
    }
}