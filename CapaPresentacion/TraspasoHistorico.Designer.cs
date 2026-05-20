using System.Security.Principal;

namespace CapaPresentacion
{
    partial class TraspasoHistorico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelAccent = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.panelCardMovimientos = new System.Windows.Forms.Panel();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.chkIncluirMovimientos = new System.Windows.Forms.CheckBox();
            this.lblDescMovimientos = new System.Windows.Forms.Label();
            this.lblTituloMovimientos = new System.Windows.Forms.Label();
            this.panelCardCatalogos = new System.Windows.Forms.Panel();
            this.lblSiempreIncluido = new System.Windows.Forms.Label();
            this.lblDescCatalogos = new System.Windows.Forms.Label();
            this.lblTituloCatalogos = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCardMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.panelCardCatalogos.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(580, 90);
            this.panelHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Traspaso a Histórico";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitulo.Location = new System.Drawing.Point(21, 63);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Archivado de registros a la base de datos histórica";

            // panelAccent
            this.panelAccent.BackColor = System.Drawing.Color.FromArgb(93, 202, 165);
            this.panelAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccent.Location = new System.Drawing.Point(0, 90);
            this.panelAccent.Name = "panelAccent";
            this.panelAccent.Size = new System.Drawing.Size(580, 5);
            this.panelAccent.TabIndex = 1;

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelContent.Controls.Add(this.panelCardCatalogos);
            this.panelContent.Controls.Add(this.panelCardMovimientos);
            this.panelContent.Controls.Add(this.btnEjecutar);
            this.panelContent.Controls.Add(this.lblEstado);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 95);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(580, 335);
            this.panelContent.TabIndex = 2;

            // panelCardCatalogos
            this.panelCardCatalogos.BackColor = System.Drawing.Color.White;
            this.panelCardCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardCatalogos.Controls.Add(this.lblTituloCatalogos);
            this.panelCardCatalogos.Controls.Add(this.lblDescCatalogos);
            this.panelCardCatalogos.Controls.Add(this.lblSiempreIncluido);
            this.panelCardCatalogos.Location = new System.Drawing.Point(20, 20);
            this.panelCardCatalogos.Name = "panelCardCatalogos";
            this.panelCardCatalogos.Size = new System.Drawing.Size(260, 185);
            this.panelCardCatalogos.TabIndex = 0;

            // lblTituloCatalogos
            this.lblTituloCatalogos.AutoSize = true;
            this.lblTituloCatalogos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloCatalogos.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTituloCatalogos.Location = new System.Drawing.Point(14, 14);
            this.lblTituloCatalogos.Name = "lblTituloCatalogos";
            this.lblTituloCatalogos.TabIndex = 0;
            this.lblTituloCatalogos.Text = "Catálogos";

            // lblDescCatalogos
            this.lblDescCatalogos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescCatalogos.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDescCatalogos.Location = new System.Drawing.Point(14, 50);
            this.lblDescCatalogos.Name = "lblDescCatalogos";
            this.lblDescCatalogos.Size = new System.Drawing.Size(230, 86);
            this.lblDescCatalogos.TabIndex = 1;
            this.lblDescCatalogos.Text = "Categorías, Proveedores, Clientes y Productos. Solo se archivan registros nuevos que aún no están en el histórico.";

            // lblSiempreIncluido
            this.lblSiempreIncluido.AutoSize = true;
            this.lblSiempreIncluido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSiempreIncluido.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblSiempreIncluido.Location = new System.Drawing.Point(14, 152);
            this.lblSiempreIncluido.Name = "lblSiempreIncluido";
            this.lblSiempreIncluido.TabIndex = 2;
            this.lblSiempreIncluido.Text = "✓ Siempre incluido";

            // panelCardMovimientos
            this.panelCardMovimientos.BackColor = System.Drawing.Color.White;
            this.panelCardMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardMovimientos.Controls.Add(this.lblTituloMovimientos);
            this.panelCardMovimientos.Controls.Add(this.lblDescMovimientos);
            this.panelCardMovimientos.Controls.Add(this.chkIncluirMovimientos);
            this.panelCardMovimientos.Controls.Add(this.numAnio);
            this.panelCardMovimientos.Location = new System.Drawing.Point(300, 20);
            this.panelCardMovimientos.Name = "panelCardMovimientos";
            this.panelCardMovimientos.Size = new System.Drawing.Size(260, 185);
            this.panelCardMovimientos.TabIndex = 1;

            // lblTituloMovimientos
            this.lblTituloMovimientos.AutoSize = true;
            this.lblTituloMovimientos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloMovimientos.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTituloMovimientos.Location = new System.Drawing.Point(14, 14);
            this.lblTituloMovimientos.Name = "lblTituloMovimientos";
            this.lblTituloMovimientos.TabIndex = 0;
            this.lblTituloMovimientos.Text = "Movimientos";

            // lblDescMovimientos
            this.lblDescMovimientos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescMovimientos.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDescMovimientos.Location = new System.Drawing.Point(14, 50);
            this.lblDescMovimientos.Name = "lblDescMovimientos";
            this.lblDescMovimientos.Size = new System.Drawing.Size(230, 55);
            this.lblDescMovimientos.TabIndex = 1;
            this.lblDescMovimientos.Text = "Compras, Lavado de Pollo, Pedidos y Ventas. Se eliminarán del sistema principal al archivar.";

            // chkIncluirMovimientos
            this.chkIncluirMovimientos.AutoSize = true;
            this.chkIncluirMovimientos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIncluirMovimientos.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.chkIncluirMovimientos.Location = new System.Drawing.Point(14, 114);
            this.chkIncluirMovimientos.Name = "chkIncluirMovimientos";
            this.chkIncluirMovimientos.Size = new System.Drawing.Size(185, 21);
            this.chkIncluirMovimientos.TabIndex = 2;
            this.chkIncluirMovimientos.Text = "Incluir movimientos del año:";
            this.chkIncluirMovimientos.CheckedChanged += new
System.EventHandler(this.chkIncluirMovimientos_CheckedChanged);

            // numAnio
            this.numAnio.Enabled = false;
            this.numAnio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numAnio.Location = new System.Drawing.Point(14, 142);
            this.numAnio.Maximum = new decimal(new int[] { 2099, 0, 0, 0 });
            this.numAnio.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(110, 28);
            this.numAnio.TabIndex = 3;
            this.numAnio.Value = new decimal(new int[] { 2024, 0, 0, 0 });

            // btnEjecutar
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(20, 224);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(540, 44);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar Traspaso";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblEstado.Location = new System.Drawing.Point(20, 282);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 21);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Visible = false;

            // TraspasoHistorico
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(580, 430);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelAccent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TraspasoHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Traspaso a Histórico";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelCardMovimientos.ResumeLayout(false);
            this.panelCardMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.panelCardCatalogos.ResumeLayout(false);
            this.panelCardCatalogos.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelAccent;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCardCatalogos;
        private System.Windows.Forms.Label lblTituloCatalogos;
        private System.Windows.Forms.Label lblDescCatalogos;
        private System.Windows.Forms.Label lblSiempreIncluido;
        private System.Windows.Forms.Panel panelCardMovimientos;
        private System.Windows.Forms.Label lblTituloMovimientos;
        private System.Windows.Forms.Label lblDescMovimientos;
        private System.Windows.Forms.CheckBox chkIncluirMovimientos;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblEstado;
    }
}