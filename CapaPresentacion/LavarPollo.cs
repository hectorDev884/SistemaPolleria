using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class LavarPollo : Form
    {
        private ProductoLavadoCN _productoLavadoCN = new ProductoLavadoCN();
        private ProductosCN _productosCN = new ProductosCN();
        private HistoricoCN _historicoCN = new HistoricoCN();

        private int _productoLavadoID = 0;
        private int _productoVivoID = 0;

        public LavarPollo()
        {
            InitializeComponent();
        }

        private void LavarPollo_Load(object sender, EventArgs e) { }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

                // ── 454545 = Pollo Vivo ────────────────────────────────────
                DataTable dtVivo =
                    _productosCN.ObtenerProductoPorCodigo("22290696")
                    .Tables["GetProductoByCodigo"];

                if (dtVivo == null || dtVivo.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el Pollo Vivo.");
                    return;
                }

                DataRow rowVivo = dtVivo.Rows[0];

                _productoVivoID = Convert.ToInt32(rowVivo["ProductoID"]);
                txtIdProducto.Text = _productoVivoID.ToString();
                txtCodigo.Text = rowVivo["CodigoProducto"].ToString();
                txtUnidadMedida.Text = rowVivo["UnidadMedida"].ToString();
                txtExistencia.Text = rowVivo["Existencia"].ToString();

                // Llenar cboProducto con el nombre del Pollo Vivo
                cboProducto.Items.Clear();
                cboProducto.Items.Add(rowVivo["Nombre"].ToString());
                cboProducto.SelectedIndex = 0;

                // ── 123654789 = Pollo Lavado ───────────────────────────────
                DataTable dtLavado =
                    _productosCN.ObtenerProductoPorCodigo("22290697")
                    .Tables["GetProductoByCodigo"];

                if (dtLavado == null || dtLavado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el Pollo Lavado.");
                    return;
                }

                DataRow rowLavado = dtLavado.Rows[0];

                _productoLavadoID = Convert.ToInt32(rowLavado["ProductoID"]);
                txtLavadoId.Text = _productoLavadoID.ToString();
                txtLavadoCodigo.Text = rowLavado["CodigoProducto"].ToString();
                txtLavadoUnidadMedida.Text = rowLavado["UnidadMedida"].ToString();
                txtLavadoActual.Text = rowLavado["Existencia"].ToString();
                txtLavadoActualizado.Text = rowLavado["Existencia"].ToString();

                // Llenar cboPolloLavado con el nombre del Pollo Lavado
                cboPolloLavado.Items.Clear();
                cboPolloLavado.Items.Add(rowLavado["Nombre"].ToString());
                cboPolloLavado.SelectedIndex = 0;

                LimpiarCamposUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar formulario: " + ex.Message);
            }
        }

        // cboProducto ya no necesita SelectedIndexChanged porque es fijo (454545)
        // cboPolloLavado tampoco porque es fijo (123654789)
        // Ambos son solo informativos, los IDs ya están en memoria desde cmdNuevo

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularRestante();
        }

        private void txtCantidadDespedicios_TextChanged(object sender, EventArgs e)
        {
            CalcularCantidadLavada();
        }

        private void CalcularRestante()
        {
            try
            {
                if (!decimal.TryParse(txtExistencia.Text, out decimal existencia)) return;
                if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad)) return;

                txtRestante.Text = (existencia - cantidad).ToString("F2");
                CalcularCantidadLavada();
            }
            catch { }
        }

        private void CalcularCantidadLavada()
        {
            try
            {
                if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad)) return;
                if (!decimal.TryParse(txtCantidadDesperdicios.Text, out decimal desperdicios)) return;

                decimal lavada = Math.Max(cantidad - desperdicios, 0);

                if (decimal.TryParse(txtLavadoActual.Text, out decimal lavadoActual))
                    txtLavadoActualizado.Text = (lavadoActual + lavada).ToString("F2");
            }
            catch { }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_productoLavadoID == 0 || _productoVivoID == 0)
                {
                    MessageBox.Show("Primero haz clic en Nuevo para cargar el formulario.");
                    return;
                }

                if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida.");
                    return;
                }

                if (!decimal.TryParse(txtCantidadDesperdicios.Text, out decimal desperdicios) || desperdicios < 0)
                {
                    MessageBox.Show("Ingresa una cantidad de desperdicios válida.");
                    return;
                }

                if (desperdicios > cantidad)
                {
                    MessageBox.Show("Los desperdicios no pueden superar la cantidad a lavar.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que quieres guardar esto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes) return;

                _productoLavadoCN.InsertarLavadoPollo(
                    DateTime.Now,
                    _productoVivoID,
                    _productoLavadoID,
                    cantidad,
                    desperdicios);

                MessageBox.Show("Lavado registrado correctamente.");
                LimpiarCamposUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposUsuario();
        }

        private void LimpiarCamposUsuario()
        {
            txtCantidad.Clear();
            txtCantidadDesperdicios.Clear();
            txtRestante.Text = "0.00";
            txtLavadoActualizado.Text = txtLavadoActual.Text;
            txtCantidad.Focus();
        }

        private void txtExistencia_TextChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            ConsultasLavadoPollo consultasLavadoPollo = new ConsultasLavadoPollo();
            consultasLavadoPollo.ShowDialog();
        }

        private void cmdHistorico_Click(object sender, EventArgs e)
        {
        }

        private void cmdHistorico_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form dialog = new Form()
                {
                    Width = 320,
                    Height = 170,
                    Text = "Paso a Historicos - Lavado de Pollo",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                Label lbl = new Label() { Left = 20, Top = 20, Text = "Anio a transferir:", Width = 120, Font = new System.Drawing.Font("Segoe UI", 10F) };
                NumericUpDown nud = new NumericUpDown() { Left = 20, Top = 48, Width = 100, Minimum = 2000, Maximum = 2100, Value = DateTime.Now.Year, Font = new System.Drawing.Font("Segoe UI", 10F) };
                Button btnOk = new Button() { Text = "Transferir", Left = 160, Top = 20, Width = 120, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = System.Drawing.Color.FromArgb(5, 150, 105), ForeColor = System.Drawing.Color.White, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold) };
                Button btnCancel = new Button() { Text = "Cancelar", Left = 160, Top = 65, Width = 120, Height = 35, FlatStyle = FlatStyle.Flat };

                btnOk.Click += (s, ev) => { dialog.DialogResult = DialogResult.OK; dialog.Close(); };
                btnCancel.Click += (s, ev) => { dialog.DialogResult = DialogResult.Cancel; dialog.Close(); };

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(nud);
                dialog.Controls.Add(btnOk);
                dialog.Controls.Add(btnCancel);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int anio = (int)nud.Value;

                    DialogResult confirm = MessageBox.Show(
                        string.Format("Se transferira el historial de Lavado de Pollo del anio {0} a la base historica. Una vez transferidos se eliminaran del sistema actual. Confirma?", anio),
                        "Confirmar transferencia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm != DialogResult.Yes) return;

                    _historicoCN.PasarLavadoPolloAHistorico(anio);
                    MessageBox.Show("Lavado de pollo transferido correctamente al historico.", "Transferencia completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al transferir lavado de pollo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}