using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Utileria : Form
    {
        private readonly string _masterConn;
        private const string DatabaseName = "Polleria";
        private const string SqlBackupDir = @"C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup";

        public Utileria()
        {
            InitializeComponent();
            string baseConn = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            _masterConn = System.Text.RegularExpressions.Regex.Replace(
                baseConn,
                @"Initial Catalog=[^;]+",
                "Initial Catalog=master",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar respaldo";
                dlg.Filter = "Archivo de respaldo (*.bak)|*.bak";
                dlg.FileName = $"{DatabaseName}_{DateTime.Now:yyyyMMdd_HHmm}.bak";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                string rutaDestino = dlg.FileName;
                string rutaTemporal = Path.Combine(SqlBackupDir, Path.GetFileName(rutaDestino));
                SetEstado("Realizando respaldo...", false);

                try
                {
                    using (SqlConnection con = new SqlConnection(_masterConn))
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandTimeout = 300;
                        cmd.CommandText =
                            $"BACKUP DATABASE [{DatabaseName}] TO DISK = @ruta " +
                            "WITH FORMAT, INIT, NAME = N'Respaldo Polleria'";
                        cmd.Parameters.AddWithValue("@ruta", rutaTemporal);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    File.Copy(rutaTemporal, rutaDestino, overwrite: true);
                    File.Delete(rutaTemporal);

                    SetEstado($"Respaldo completado: {Path.GetFileName(rutaDestino)}", true);
                    MessageBox.Show("Respaldo realizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (File.Exists(rutaTemporal)) File.Delete(rutaTemporal);
                    SetEstado("Error al realizar el respaldo.", true);
                    MessageBox.Show("Error al respaldar:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Seleccionar archivo de respaldo";
                dlg.Filter = "Archivo de respaldo (*.bak)|*.bak";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                string rutaOrigen = dlg.FileName;

                DialogResult confirm = MessageBox.Show(
                    $"Se restaurará la base de datos '{DatabaseName}' desde:\n{rutaOrigen}\n\n" +
                    "Todos los cambios no respaldados se perderán.\n¿Desea continuar?",
                    "Confirmar restauración",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                string rutaTemporal = Path.Combine(SqlBackupDir, Path.GetFileName(rutaOrigen));
                SetEstado("Restaurando base de datos...", false);

                try
                {
                    File.Copy(rutaOrigen, rutaTemporal, overwrite: true);

                    using (SqlConnection con = new SqlConnection(_masterConn))
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandTimeout = 300;
                        cmd.CommandText =
                            $"ALTER DATABASE [{DatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                            $"RESTORE DATABASE [{DatabaseName}] FROM DISK = @ruta WITH REPLACE; " +
                            $"ALTER DATABASE [{DatabaseName}] SET MULTI_USER;";
                        cmd.Parameters.AddWithValue("@ruta", rutaTemporal);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    SetEstado($"Restauración completada desde: {Path.GetFileName(rutaOrigen)}", true);
                    MessageBox.Show("Base de datos restaurada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    SetEstado("Error al restaurar la base de datos.", true);
                    MessageBox.Show("Error al restaurar:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (File.Exists(rutaTemporal)) File.Delete(rutaTemporal);
                }
            }
        }

        private void SetEstado(string mensaje, bool mostrar)
        {
            lblEstado.Text = mensaje;
            lblEstado.Visible = mostrar;
            btnBackup.Enabled = mostrar;
            btnRestore.Enabled = mostrar;
            Application.DoEvents();
        }
    }
}
