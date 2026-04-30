namespace CapaPresentacion
{
    partial class Reportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.cmdClientesGeneral = new System.Windows.Forms.Button();
            this.cmdProveedoresGeneral = new System.Windows.Forms.Button();
            this.cmdProductosGeneral = new System.Windows.Forms.Button();
            this.cmdVentasPorFecha = new System.Windows.Forms.Button();
            this.cmdComprasPorFecha = new System.Windows.Forms.Button();
            this.cmdComprasPorProveedor = new System.Windows.Forms.Button();
            this.cmdVentasPorCliente = new System.Windows.Forms.Button();
            this.cmdProductosMasVendidos = new System.Windows.Forms.Button();
            this.cmdLavadasPorFecha = new System.Windows.Forms.Button();
            this.cmdDesperdiciosPorFecha = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1453, 65);
            this.pnlHeader.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 41);
            this.label5.TabIndex = 114;
            this.label5.Text = "Reportes";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.Controls.Add(this.dtpInicio);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.dtpFin);
            this.pnlFiltros.Controls.Add(this.label4);
            this.pnlFiltros.Controls.Add(this.cboCliente);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.cboProveedor);
            this.pnlFiltros.Controls.Add(this.lblTop);
            this.pnlFiltros.Controls.Add(this.nudTop);
            this.pnlFiltros.Location = new System.Drawing.Point(0, 65);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1453, 105);
            this.pnlFiltros.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Fecha inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(30, 43);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(220, 30);
            this.dtpInicio.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(270, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 120;
            this.label2.Text = "Fecha fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(270, 43);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(220, 30);
            this.dtpFin.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(515, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 128;
            this.label4.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(515, 43);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(200, 31);
            this.cboCliente.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(740, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 126;
            this.label3.Text = "Proveedor:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(740, 43);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(200, 31);
            this.cboProveedor.TabIndex = 125;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.lblTop.Location = new System.Drawing.Point(965, 14);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(44, 23);
            this.lblTop.TabIndex = 202;
            this.lblTop.Text = "Top:";
            // 
            // nudTop
            // 
            this.nudTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTop.Location = new System.Drawing.Point(965, 43);
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(80, 30);
            this.nudTop.TabIndex = 129;
            this.nudTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlBotones.Controls.Add(this.cmdClientesGeneral);
            this.pnlBotones.Controls.Add(this.cmdProveedoresGeneral);
            this.pnlBotones.Controls.Add(this.cmdProductosGeneral);
            this.pnlBotones.Controls.Add(this.cmdVentasPorFecha);
            this.pnlBotones.Controls.Add(this.cmdComprasPorFecha);
            this.pnlBotones.Controls.Add(this.cmdComprasPorProveedor);
            this.pnlBotones.Controls.Add(this.cmdVentasPorCliente);
            this.pnlBotones.Controls.Add(this.cmdProductosMasVendidos);
            this.pnlBotones.Controls.Add(this.cmdLavadasPorFecha);
            this.pnlBotones.Controls.Add(this.cmdDesperdiciosPorFecha);
            this.pnlBotones.Location = new System.Drawing.Point(0, 170);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1453, 204);
            this.pnlBotones.TabIndex = 203;
            // 
            // cmdClientesGeneral
            // 
            this.cmdClientesGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.cmdClientesGeneral.FlatAppearance.BorderSize = 0;
            this.cmdClientesGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClientesGeneral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientesGeneral.ForeColor = System.Drawing.Color.White;
            this.cmdClientesGeneral.Location = new System.Drawing.Point(284, 10);
            this.cmdClientesGeneral.Name = "cmdClientesGeneral";
            this.cmdClientesGeneral.Size = new System.Drawing.Size(165, 77);
            this.cmdClientesGeneral.TabIndex = 116;
            this.cmdClientesGeneral.Text = "General Clientes";
            this.cmdClientesGeneral.UseVisualStyleBackColor = false;
            this.cmdClientesGeneral.Click += new System.EventHandler(this.cmdClientesGeneral_Click);
            // 
            // cmdProveedoresGeneral
            // 
            this.cmdProveedoresGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.cmdProveedoresGeneral.FlatAppearance.BorderSize = 0;
            this.cmdProveedoresGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProveedoresGeneral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProveedoresGeneral.ForeColor = System.Drawing.Color.White;
            this.cmdProveedoresGeneral.Location = new System.Drawing.Point(464, 10);
            this.cmdProveedoresGeneral.Name = "cmdProveedoresGeneral";
            this.cmdProveedoresGeneral.Size = new System.Drawing.Size(165, 77);
            this.cmdProveedoresGeneral.TabIndex = 136;
            this.cmdProveedoresGeneral.Text = "Proveedores General";
            this.cmdProveedoresGeneral.UseVisualStyleBackColor = false;
            this.cmdProveedoresGeneral.Click += new System.EventHandler(this.cmdProveedoresGeneral_Click);
            // 
            // cmdProductosGeneral
            // 
            this.cmdProductosGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.cmdProductosGeneral.FlatAppearance.BorderSize = 0;
            this.cmdProductosGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProductosGeneral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductosGeneral.ForeColor = System.Drawing.Color.White;
            this.cmdProductosGeneral.Location = new System.Drawing.Point(644, 10);
            this.cmdProductosGeneral.Name = "cmdProductosGeneral";
            this.cmdProductosGeneral.Size = new System.Drawing.Size(165, 77);
            this.cmdProductosGeneral.TabIndex = 137;
            this.cmdProductosGeneral.Text = "Productos General";
            this.cmdProductosGeneral.UseVisualStyleBackColor = false;
            this.cmdProductosGeneral.Click += new System.EventHandler(this.cmdProductosGeneral_Click);
            // 
            // cmdVentasPorFecha
            // 
            this.cmdVentasPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.cmdVentasPorFecha.FlatAppearance.BorderSize = 0;
            this.cmdVentasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVentasPorFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasPorFecha.ForeColor = System.Drawing.Color.White;
            this.cmdVentasPorFecha.Location = new System.Drawing.Point(824, 10);
            this.cmdVentasPorFecha.Name = "cmdVentasPorFecha";
            this.cmdVentasPorFecha.Size = new System.Drawing.Size(165, 77);
            this.cmdVentasPorFecha.TabIndex = 121;
            this.cmdVentasPorFecha.Text = "Ventas por fecha";
            this.cmdVentasPorFecha.UseVisualStyleBackColor = false;
            this.cmdVentasPorFecha.Click += new System.EventHandler(this.cmdVentasPorFecha_Click);
            // 
            // cmdComprasPorFecha
            // 
            this.cmdComprasPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.cmdComprasPorFecha.FlatAppearance.BorderSize = 0;
            this.cmdComprasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprasPorFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasPorFecha.ForeColor = System.Drawing.Color.White;
            this.cmdComprasPorFecha.Location = new System.Drawing.Point(1004, 10);
            this.cmdComprasPorFecha.Name = "cmdComprasPorFecha";
            this.cmdComprasPorFecha.Size = new System.Drawing.Size(165, 77);
            this.cmdComprasPorFecha.TabIndex = 123;
            this.cmdComprasPorFecha.Text = "Compras por fecha";
            this.cmdComprasPorFecha.UseVisualStyleBackColor = false;
            this.cmdComprasPorFecha.Click += new System.EventHandler(this.cmdComprasPorFecha_Click);
            // 
            // cmdComprasPorProveedor
            // 
            this.cmdComprasPorProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmdComprasPorProveedor.FlatAppearance.BorderSize = 0;
            this.cmdComprasPorProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprasPorProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasPorProveedor.ForeColor = System.Drawing.Color.White;
            this.cmdComprasPorProveedor.Location = new System.Drawing.Point(284, 105);
            this.cmdComprasPorProveedor.Name = "cmdComprasPorProveedor";
            this.cmdComprasPorProveedor.Size = new System.Drawing.Size(165, 77);
            this.cmdComprasPorProveedor.TabIndex = 130;
            this.cmdComprasPorProveedor.Text = "Compras por proveedor";
            this.cmdComprasPorProveedor.UseVisualStyleBackColor = false;
            this.cmdComprasPorProveedor.Click += new System.EventHandler(this.cmdComprasPorProveedor_Click);
            // 
            // cmdVentasPorCliente
            // 
            this.cmdVentasPorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmdVentasPorCliente.FlatAppearance.BorderSize = 0;
            this.cmdVentasPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVentasPorCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasPorCliente.ForeColor = System.Drawing.Color.White;
            this.cmdVentasPorCliente.Location = new System.Drawing.Point(464, 105);
            this.cmdVentasPorCliente.Name = "cmdVentasPorCliente";
            this.cmdVentasPorCliente.Size = new System.Drawing.Size(165, 77);
            this.cmdVentasPorCliente.TabIndex = 135;
            this.cmdVentasPorCliente.Text = "Ventas por cliente";
            this.cmdVentasPorCliente.UseVisualStyleBackColor = false;
            this.cmdVentasPorCliente.Click += new System.EventHandler(this.cmdVentasPorCliente_Click);
            // 
            // cmdProductosMasVendidos
            // 
            this.cmdProductosMasVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmdProductosMasVendidos.FlatAppearance.BorderSize = 0;
            this.cmdProductosMasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProductosMasVendidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductosMasVendidos.ForeColor = System.Drawing.Color.White;
            this.cmdProductosMasVendidos.Location = new System.Drawing.Point(644, 105);
            this.cmdProductosMasVendidos.Name = "cmdProductosMasVendidos";
            this.cmdProductosMasVendidos.Size = new System.Drawing.Size(165, 77);
            this.cmdProductosMasVendidos.TabIndex = 133;
            this.cmdProductosMasVendidos.Text = "Productos más vendidos";
            this.cmdProductosMasVendidos.UseVisualStyleBackColor = false;
            this.cmdProductosMasVendidos.Click += new System.EventHandler(this.cmdProductosMasVendidos_Click);
            // 
            // cmdLavadasPorFecha
            // 
            this.cmdLavadasPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmdLavadasPorFecha.FlatAppearance.BorderSize = 0;
            this.cmdLavadasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLavadasPorFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLavadasPorFecha.ForeColor = System.Drawing.Color.White;
            this.cmdLavadasPorFecha.Location = new System.Drawing.Point(824, 105);
            this.cmdLavadasPorFecha.Name = "cmdLavadasPorFecha";
            this.cmdLavadasPorFecha.Size = new System.Drawing.Size(165, 77);
            this.cmdLavadasPorFecha.TabIndex = 132;
            this.cmdLavadasPorFecha.Text = "Lavadas por fecha";
            this.cmdLavadasPorFecha.UseVisualStyleBackColor = false;
            this.cmdLavadasPorFecha.Click += new System.EventHandler(this.cmdLavadasPorFecha_Click);
            // 
            // cmdDesperdiciosPorFecha
            // 
            this.cmdDesperdiciosPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmdDesperdiciosPorFecha.FlatAppearance.BorderSize = 0;
            this.cmdDesperdiciosPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDesperdiciosPorFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesperdiciosPorFecha.ForeColor = System.Drawing.Color.White;
            this.cmdDesperdiciosPorFecha.Location = new System.Drawing.Point(1004, 105);
            this.cmdDesperdiciosPorFecha.Name = "cmdDesperdiciosPorFecha";
            this.cmdDesperdiciosPorFecha.Size = new System.Drawing.Size(165, 77);
            this.cmdDesperdiciosPorFecha.TabIndex = 131;
            this.cmdDesperdiciosPorFecha.Text = "Desperdicios por fecha";
            this.cmdDesperdiciosPorFecha.UseVisualStyleBackColor = false;
            this.cmdDesperdiciosPorFecha.Click += new System.EventHandler(this.cmdDesperdiciosPorFecha_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(10, 380);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1433, 367);
            this.reportViewer1.TabIndex = 122;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1453, 757);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button cmdVentasPorFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button cmdClientesGeneral;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button cmdComprasPorFecha;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.Button cmdComprasPorProveedor;
        private System.Windows.Forms.Button cmdDesperdiciosPorFecha;
        private System.Windows.Forms.Button cmdLavadasPorFecha;
        private System.Windows.Forms.Button cmdProductosMasVendidos;
        private System.Windows.Forms.Button cmdVentasPorCliente;
        private System.Windows.Forms.Button cmdProveedoresGeneral;
        private System.Windows.Forms.Button cmdProductosGeneral;
    }
}
