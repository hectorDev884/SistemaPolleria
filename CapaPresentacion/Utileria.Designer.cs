namespace CapaPresentacion
{
    partial class Utileria
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
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelCardBackup = new System.Windows.Forms.Panel();
            this.lblTituloBackup = new System.Windows.Forms.Label();
            this.lblDescBackup = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panelCardRestore = new System.Windows.Forms.Panel();
            this.lblTituloRestore = new System.Windows.Forms.Label();
            this.lblDescRestore = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelCardBackup.SuspendLayout();
            this.panelCardRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(620, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(21, 63);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(312, 21);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Respaldo y restauración de la base de datos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(361, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Utilería del Sistema";
            // 
            // panelAccent
            // 
            this.panelAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.panelAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccent.Location = new System.Drawing.Point(0, 90);
            this.panelAccent.Name = "panelAccent";
            this.panelAccent.Size = new System.Drawing.Size(620, 5);
            this.panelAccent.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelContent.Controls.Add(this.lblEstado);
            this.panelContent.Controls.Add(this.panelCards);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 95);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(620, 285);
            this.panelContent.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblEstado.Location = new System.Drawing.Point(20, 233);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblEstado.Size = new System.Drawing.Size(0, 32);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Visible = false;
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.panelCardBackup);
            this.panelCards.Controls.Add(this.panelCardRestore);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(20, 20);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(580, 200);
            this.panelCards.TabIndex = 0;
            // 
            // panelCardBackup
            // 
            this.panelCardBackup.BackColor = System.Drawing.Color.White;
            this.panelCardBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardBackup.Controls.Add(this.lblTituloBackup);
            this.panelCardBackup.Controls.Add(this.lblDescBackup);
            this.panelCardBackup.Controls.Add(this.btnBackup);
            this.panelCardBackup.Location = new System.Drawing.Point(0, 0);
            this.panelCardBackup.Name = "panelCardBackup";
            this.panelCardBackup.Size = new System.Drawing.Size(280, 190);
            this.panelCardBackup.TabIndex = 0;
            // 
            // lblTituloBackup
            // 
            this.lblTituloBackup.AutoSize = true;
            this.lblTituloBackup.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTituloBackup.Location = new System.Drawing.Point(16, 16);
            this.lblTituloBackup.Name = "lblTituloBackup";
            this.lblTituloBackup.Size = new System.Drawing.Size(115, 30);
            this.lblTituloBackup.TabIndex = 0;
            this.lblTituloBackup.Text = "Respaldar";
            // 
            // lblDescBackup
            // 
            this.lblDescBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDescBackup.Location = new System.Drawing.Point(16, 48);
            this.lblDescBackup.Name = "lblDescBackup";
            this.lblDescBackup.Size = new System.Drawing.Size(248, 50);
            this.lblDescBackup.TabIndex = 1;
            this.lblDescBackup.Text = "Genera un archivo .bak con el respaldo completo de la base de datos.";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(16, 130);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(248, 40);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Crear Respaldo";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // panelCardRestore
            // 
            this.panelCardRestore.BackColor = System.Drawing.Color.White;
            this.panelCardRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardRestore.Controls.Add(this.lblTituloRestore);
            this.panelCardRestore.Controls.Add(this.lblDescRestore);
            this.panelCardRestore.Controls.Add(this.btnRestore);
            this.panelCardRestore.Location = new System.Drawing.Point(300, 0);
            this.panelCardRestore.Name = "panelCardRestore";
            this.panelCardRestore.Size = new System.Drawing.Size(280, 190);
            this.panelCardRestore.TabIndex = 1;
            // 
            // lblTituloRestore
            // 
            this.lblTituloRestore.AutoSize = true;
            this.lblTituloRestore.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTituloRestore.Location = new System.Drawing.Point(16, 16);
            this.lblTituloRestore.Name = "lblTituloRestore";
            this.lblTituloRestore.Size = new System.Drawing.Size(112, 30);
            this.lblTituloRestore.TabIndex = 0;
            this.lblTituloRestore.Text = "Restaurar";
            // 
            // lblDescRestore
            // 
            this.lblDescRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDescRestore.Location = new System.Drawing.Point(16, 48);
            this.lblDescRestore.Name = "lblDescRestore";
            this.lblDescRestore.Size = new System.Drawing.Size(248, 50);
            this.lblDescRestore.TabIndex = 1;
            this.lblDescRestore.Text = "Restaura la base de datos a partir de un archivo .bak existente.";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(16, 130);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(248, 40);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restaurar Base de Datos";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // Utileria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelAccent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Utileria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utilería del Sistema";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelCardBackup.ResumeLayout(false);
            this.panelCardBackup.PerformLayout();
            this.panelCardRestore.ResumeLayout(false);
            this.panelCardRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelAccent;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelCardBackup;
        private System.Windows.Forms.Label lblTituloBackup;
        private System.Windows.Forms.Label lblDescBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panelCardRestore;
        private System.Windows.Forms.Label lblTituloRestore;
        private System.Windows.Forms.Label lblDescRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblEstado;
    }
}
