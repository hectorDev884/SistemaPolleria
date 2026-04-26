namespace CapaPresentacion
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdVentasPorFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmdClientesGeneral = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmdComprasPorFecha = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.cmdComprasPorProveedor = new System.Windows.Forms.Button();
            this.cmdDesperdiciosPorFecha = new System.Windows.Forms.Button();
            this.cmdLavadasPorFecha = new System.Windows.Forms.Button();
            this.cmdProductosMasVendidos = new System.Windows.Forms.Button();
            this.cmdVentasPorCliente = new System.Windows.Forms.Button();
            this.cmdProveedoresGeneral = new System.Windows.Forms.Button();
            this.cmdProductosGeneral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVentasPorFecha
            // 
            this.cmdVentasPorFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdVentasPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasPorFecha.Location = new System.Drawing.Point(641, 222);
            this.cmdVentasPorFecha.Name = "cmdVentasPorFecha";
            this.cmdVentasPorFecha.Size = new System.Drawing.Size(123, 70);
            this.cmdVentasPorFecha.TabIndex = 121;
            this.cmdVentasPorFecha.Text = "Ventas por fecha";
            this.cmdVentasPorFecha.UseVisualStyleBackColor = false;
            this.cmdVentasPorFecha.Click += new System.EventHandler(this.cmdVentasPorFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 120;
            this.label2.Text = "Fecha fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 119;
            this.label1.Text = "Fecha inicio:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(559, 71);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(274, 27);
            this.dtpFin.TabIndex = 118;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(242, 71);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(274, 27);
            this.dtpInicio.TabIndex = 117;
            // 
            // cmdClientesGeneral
            // 
            this.cmdClientesGeneral.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdClientesGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientesGeneral.Location = new System.Drawing.Point(322, 146);
            this.cmdClientesGeneral.Name = "cmdClientesGeneral";
            this.cmdClientesGeneral.Size = new System.Drawing.Size(138, 70);
            this.cmdClientesGeneral.TabIndex = 116;
            this.cmdClientesGeneral.Text = "General Clientes";
            this.cmdClientesGeneral.UseVisualStyleBackColor = false;
            this.cmdClientesGeneral.Click += new System.EventHandler(this.cmdClientesGeneral_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 32);
            this.label5.TabIndex = 114;
            this.label5.Text = "Reportes";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(49, 300);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1392, 418);
            this.reportViewer1.TabIndex = 122;
            // 
            // cmdComprasPorFecha
            // 
            this.cmdComprasPorFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdComprasPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasPorFecha.Location = new System.Drawing.Point(477, 222);
            this.cmdComprasPorFecha.Name = "cmdComprasPorFecha";
            this.cmdComprasPorFecha.Size = new System.Drawing.Size(149, 70);
            this.cmdComprasPorFecha.TabIndex = 123;
            this.cmdComprasPorFecha.Text = "Compras por fecha";
            this.cmdComprasPorFecha.UseVisualStyleBackColor = false;
            this.cmdComprasPorFecha.Click += new System.EventHandler(this.cmdComprasPorFecha_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(1058, 73);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(189, 31);
            this.cboProveedor.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1053, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(856, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 128;
            this.label4.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(861, 73);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(189, 31);
            this.cboCliente.TabIndex = 127;
            // 
            // nudTop
            // 
            this.nudTop.Location = new System.Drawing.Point(623, 118);
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(64, 22);
            this.nudTop.TabIndex = 129;
            this.nudTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmdComprasPorProveedor
            // 
            this.cmdComprasPorProveedor.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdComprasPorProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasPorProveedor.Location = new System.Drawing.Point(322, 222);
            this.cmdComprasPorProveedor.Name = "cmdComprasPorProveedor";
            this.cmdComprasPorProveedor.Size = new System.Drawing.Size(149, 70);
            this.cmdComprasPorProveedor.TabIndex = 130;
            this.cmdComprasPorProveedor.Text = "Compras por proveedor";
            this.cmdComprasPorProveedor.UseVisualStyleBackColor = false;
            this.cmdComprasPorProveedor.Click += new System.EventHandler(this.cmdComprasPorProveedor_Click);
            // 
            // cmdDesperdiciosPorFecha
            // 
            this.cmdDesperdiciosPorFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdDesperdiciosPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesperdiciosPorFecha.Location = new System.Drawing.Point(946, 146);
            this.cmdDesperdiciosPorFecha.Name = "cmdDesperdiciosPorFecha";
            this.cmdDesperdiciosPorFecha.Size = new System.Drawing.Size(149, 73);
            this.cmdDesperdiciosPorFecha.TabIndex = 131;
            this.cmdDesperdiciosPorFecha.Text = "Desperdicios por fecha";
            this.cmdDesperdiciosPorFecha.UseVisualStyleBackColor = false;
            this.cmdDesperdiciosPorFecha.Click += new System.EventHandler(this.cmdDesperdiciosPorFecha_Click);
            // 
            // cmdLavadasPorFecha
            // 
            this.cmdLavadasPorFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdLavadasPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLavadasPorFecha.Location = new System.Drawing.Point(778, 146);
            this.cmdLavadasPorFecha.Name = "cmdLavadasPorFecha";
            this.cmdLavadasPorFecha.Size = new System.Drawing.Size(149, 73);
            this.cmdLavadasPorFecha.TabIndex = 132;
            this.cmdLavadasPorFecha.Text = "Lavadas por fecha";
            this.cmdLavadasPorFecha.UseVisualStyleBackColor = false;
            this.cmdLavadasPorFecha.Click += new System.EventHandler(this.cmdLavadasPorFecha_Click);
            // 
            // cmdProductosMasVendidos
            // 
            this.cmdProductosMasVendidos.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdProductosMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductosMasVendidos.Location = new System.Drawing.Point(623, 146);
            this.cmdProductosMasVendidos.Name = "cmdProductosMasVendidos";
            this.cmdProductosMasVendidos.Size = new System.Drawing.Size(149, 70);
            this.cmdProductosMasVendidos.TabIndex = 133;
            this.cmdProductosMasVendidos.Text = "Productos mas vendidos";
            this.cmdProductosMasVendidos.UseVisualStyleBackColor = false;
            this.cmdProductosMasVendidos.Click += new System.EventHandler(this.cmdProductosMasVendidos_Click);
            // 
            // cmdVentasPorCliente
            // 
            this.cmdVentasPorCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdVentasPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasPorCliente.Location = new System.Drawing.Point(468, 146);
            this.cmdVentasPorCliente.Name = "cmdVentasPorCliente";
            this.cmdVentasPorCliente.Size = new System.Drawing.Size(149, 70);
            this.cmdVentasPorCliente.TabIndex = 135;
            this.cmdVentasPorCliente.Text = "Ventas por cliente";
            this.cmdVentasPorCliente.UseVisualStyleBackColor = false;
            this.cmdVentasPorCliente.Click += new System.EventHandler(this.cmdVentasPorCliente_Click);
            // 
            // cmdProveedoresGeneral
            // 
            this.cmdProveedoresGeneral.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdProveedoresGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProveedoresGeneral.Location = new System.Drawing.Point(770, 222);
            this.cmdProveedoresGeneral.Name = "cmdProveedoresGeneral";
            this.cmdProveedoresGeneral.Size = new System.Drawing.Size(157, 70);
            this.cmdProveedoresGeneral.TabIndex = 136;
            this.cmdProveedoresGeneral.Text = "Proveedores General";
            this.cmdProveedoresGeneral.UseVisualStyleBackColor = false;
            this.cmdProveedoresGeneral.Click += new System.EventHandler(this.cmdProveedoresGeneral_Click);
            // 
            // cmdProductosGeneral
            // 
            this.cmdProductosGeneral.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdProductosGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductosGeneral.Location = new System.Drawing.Point(946, 222);
            this.cmdProductosGeneral.Name = "cmdProductosGeneral";
            this.cmdProductosGeneral.Size = new System.Drawing.Size(157, 70);
            this.cmdProductosGeneral.TabIndex = 137;
            this.cmdProductosGeneral.Text = "Productos General";
            this.cmdProductosGeneral.UseVisualStyleBackColor = false;
            this.cmdProductosGeneral.Click += new System.EventHandler(this.cmdProductosGeneral_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 751);
            this.Controls.Add(this.cmdProductosGeneral);
            this.Controls.Add(this.cmdProveedoresGeneral);
            this.Controls.Add(this.cmdVentasPorCliente);
            this.Controls.Add(this.cmdProductosMasVendidos);
            this.Controls.Add(this.cmdLavadasPorFecha);
            this.Controls.Add(this.cmdDesperdiciosPorFecha);
            this.Controls.Add(this.cmdComprasPorProveedor);
            this.Controls.Add(this.nudTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cmdComprasPorFecha);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmdVentasPorFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cmdClientesGeneral);
            this.Controls.Add(this.label5);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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