namespace CapaPresentacion
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLavarPollo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalisis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.sepA1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConsultasVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultasCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultasLavado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.sepA2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtileria = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtileriaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepUtileria1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTraspasoHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.sepUtileria2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAccent = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogos,
            this.mnuMovimientos,
            this.mnuAnalisis,
            this.mnuUtileria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 31);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuCatalogos
            // 
            this.mnuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategorias,
            this.mnuProductos,
            this.mnuClientes,
            this.mnuProveedores});
            this.mnuCatalogos.Name = "mnuCatalogos";
            this.mnuCatalogos.Size = new System.Drawing.Size(100, 27);
            this.mnuCatalogos.Text = "Catálogos";
            // 
            // mnuCategorias
            // 
            this.mnuCategorias.Name = "mnuCategorias";
            this.mnuCategorias.Size = new System.Drawing.Size(188, 28);
            this.mnuCategorias.Text = "Categorías";
            this.mnuCategorias.Click += new System.EventHandler(this.mnuCategorias_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(188, 28);
            this.mnuProductos.Text = "Productos";
            this.mnuProductos.Click += new System.EventHandler(this.mnuProductos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(188, 28);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuProveedores
            // 
            this.mnuProveedores.Name = "mnuProveedores";
            this.mnuProveedores.Size = new System.Drawing.Size(188, 28);
            this.mnuProveedores.Text = "Proveedores";
            this.mnuProveedores.Click += new System.EventHandler(this.mnuProveedores_Click);
            // 
            // mnuMovimientos
            // 
            this.mnuMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVentas,
            this.mnuCompras,
            this.mnuLavarPollo});
            this.mnuMovimientos.Name = "mnuMovimientos";
            this.mnuMovimientos.Size = new System.Drawing.Size(122, 27);
            this.mnuMovimientos.Text = "Movimientos";
            // 
            // mnuVentas
            // 
            this.mnuVentas.Name = "mnuVentas";
            this.mnuVentas.Size = new System.Drawing.Size(176, 28);
            this.mnuVentas.Text = "Ventas";
            this.mnuVentas.Click += new System.EventHandler(this.mnuVentas_Click);
            // 
            // mnuCompras
            // 
            this.mnuCompras.Name = "mnuCompras";
            this.mnuCompras.Size = new System.Drawing.Size(176, 28);
            this.mnuCompras.Text = "Compras";
            this.mnuCompras.Click += new System.EventHandler(this.mnuCompras_Click);
            // 
            // mnuLavarPollo
            // 
            this.mnuLavarPollo.Name = "mnuLavarPollo";
            this.mnuLavarPollo.Size = new System.Drawing.Size(176, 28);
            this.mnuLavarPollo.Text = "Lavar Pollo";
            this.mnuLavarPollo.Click += new System.EventHandler(this.mnuLavarPollo_Click);
            // 
            // mnuAnalisis
            // 
            this.mnuAnalisis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportes,
            this.sepA1,
            this.mnuConsultasVentas,
            this.mnuConsultasCompras,
            this.mnuConsultasLavado,
            this.mnuConsultaClientes,
            this.mnuConsultaProveedores,
            this.sepA2,
            this.mnuBitacora});
            this.mnuAnalisis.Name = "mnuAnalisis";
            this.mnuAnalisis.Size = new System.Drawing.Size(183, 27);
            this.mnuAnalisis.Text = "Reportes y Consultas";
            // 
            // mnuReportes
            // 
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(291, 28);
            this.mnuReportes.Text = "Reportes";
            this.mnuReportes.Click += new System.EventHandler(this.mnuReportes_Click);
            // 
            // sepA1
            // 
            this.sepA1.Name = "sepA1";
            this.sepA1.Size = new System.Drawing.Size(288, 6);
            // 
            // mnuConsultasVentas
            // 
            this.mnuConsultasVentas.Name = "mnuConsultasVentas";
            this.mnuConsultasVentas.Size = new System.Drawing.Size(291, 28);
            this.mnuConsultasVentas.Text = "Consultas de Ventas";
            this.mnuConsultasVentas.Click += new System.EventHandler(this.mnuConsultasVentas_Click);
            // 
            // mnuConsultasCompras
            // 
            this.mnuConsultasCompras.Name = "mnuConsultasCompras";
            this.mnuConsultasCompras.Size = new System.Drawing.Size(291, 28);
            this.mnuConsultasCompras.Text = "Consultas de Compras";
            this.mnuConsultasCompras.Click += new System.EventHandler(this.mnuConsultasCompras_Click);
            // 
            // mnuConsultasLavado
            // 
            this.mnuConsultasLavado.Name = "mnuConsultasLavado";
            this.mnuConsultasLavado.Size = new System.Drawing.Size(291, 28);
            this.mnuConsultasLavado.Text = "Consultas de Lavado";
            this.mnuConsultasLavado.Click += new System.EventHandler(this.mnuConsultasLavado_Click);
            // 
            // mnuConsultaClientes
            // 
            this.mnuConsultaClientes.Name = "mnuConsultaClientes";
            this.mnuConsultaClientes.Size = new System.Drawing.Size(291, 28);
            this.mnuConsultaClientes.Text = "Consultas de Clientes";
            this.mnuConsultaClientes.Click += new System.EventHandler(this.mnuConsultaClientes_Click);
            // 
            // mnuConsultaProveedores
            // 
            this.mnuConsultaProveedores.Name = "mnuConsultaProveedores";
            this.mnuConsultaProveedores.Size = new System.Drawing.Size(291, 28);
            this.mnuConsultaProveedores.Text = "Consultas de Proveedores";
            this.mnuConsultaProveedores.Click += new System.EventHandler(this.mnuConsultaProveedores_Click);
            // 
            // sepA2
            // 
            this.sepA2.Name = "sepA2";
            this.sepA2.Size = new System.Drawing.Size(288, 6);
            // 
            // mnuBitacora
            // 
            this.mnuBitacora.Name = "mnuBitacora";
            this.mnuBitacora.Size = new System.Drawing.Size(291, 28);
            this.mnuBitacora.Text = "Bitácora de Errores";
            this.mnuBitacora.Click += new System.EventHandler(this.mnuBitacora_Click);
            // 
            // mnuUtileria
            // 
            this.mnuUtileria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUtileriaItem,
            this.sepUtileria1,
            this.mnuTraspasoHistorico,
            this.sepUtileria2,
            this.mnuAyuda});
            this.mnuUtileria.Name = "mnuUtileria";
            this.mnuUtileria.Size = new System.Drawing.Size(78, 27);
            this.mnuUtileria.Text = "Utilería";
            // 
            // mnuUtileriaItem
            // 
            this.mnuUtileriaItem.Name = "mnuUtileriaItem";
            this.mnuUtileriaItem.Size = new System.Drawing.Size(279, 28);
            this.mnuUtileriaItem.Text = "Respaldo y Restauración";
            this.mnuUtileriaItem.Click += new System.EventHandler(this.mnuUtileriaItem_Click);
            // 
            // sepUtileria1
            // 
            this.sepUtileria1.Name = "sepUtileria1";
            this.sepUtileria1.Size = new System.Drawing.Size(276, 6);
            // 
            // mnuTraspasoHistorico
            // 
            this.mnuTraspasoHistorico.Name = "mnuTraspasoHistorico";
            this.mnuTraspasoHistorico.Size = new System.Drawing.Size(279, 28);
            this.mnuTraspasoHistorico.Text = "Traspaso a Histórico";
            this.mnuTraspasoHistorico.Click += new System.EventHandler(this.mnuTraspasoHistorico_Click);
            // 
            // sepUtileria2
            // 
            this.sepUtileria2.Name = "sepUtileria2";
            this.sepUtileria2.Size = new System.Drawing.Size(276, 6);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(279, 28);
            this.mnuAyuda.Text = "Ayuda";
            this.mnuAyuda.Click += new System.EventHandler(this.mnuAyuda_Click);
            // 
            // panelAccent
            // 
            this.panelAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.panelAccent.Location = new System.Drawing.Point(0, 28);
            this.panelAccent.Name = "panelAccent";
            this.panelAccent.Size = new System.Drawing.Size(480, 4);
            this.panelAccent.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(480, 64);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema Pollería";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAyuda
            // 
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(140)))));
            this.lblAyuda.Location = new System.Drawing.Point(0, 152);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(480, 30);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Seleccione una opción del menú para continuar";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(493, 260);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelAccent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión — Pollería";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuLavarPollo;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalisis;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripSeparator sepA1;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultasVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultasCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultasLavado;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaProveedores;
        private System.Windows.Forms.ToolStripSeparator sepA2;
        private System.Windows.Forms.ToolStripMenuItem mnuBitacora;
        private System.Windows.Forms.ToolStripMenuItem mnuUtileria;
        private System.Windows.Forms.ToolStripMenuItem mnuUtileriaItem;
        private System.Windows.Forms.ToolStripSeparator sepUtileria1;
        private System.Windows.Forms.ToolStripMenuItem mnuTraspasoHistorico;
        private System.Windows.Forms.ToolStripSeparator sepUtileria2;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.Panel panelAccent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAyuda;
    }
}
