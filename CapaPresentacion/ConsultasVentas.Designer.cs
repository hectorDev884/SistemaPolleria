namespace CapaPresentacion
{
    partial class ConsultasVentas
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdPorFecha = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPorCliente = new System.Windows.Forms.Button();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.cmdTopProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 32);
            this.label5.TabIndex = 61;
            this.label5.Text = "Consulta de ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 429);
            this.dataGridView1.TabIndex = 62;
            // 
            // cmdPorFecha
            // 
            this.cmdPorFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPorFecha.Location = new System.Drawing.Point(1176, 174);
            this.cmdPorFecha.Name = "cmdPorFecha";
            this.cmdPorFecha.Size = new System.Drawing.Size(138, 83);
            this.cmdPorFecha.TabIndex = 94;
            this.cmdPorFecha.Text = "Consultas por fechas";
            this.cmdPorFecha.UseVisualStyleBackColor = false;
            this.cmdPorFecha.Click += new System.EventHandler(this.cmdPorFecha_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(370, 56);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(274, 27);
            this.dtpInicio.TabIndex = 95;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(687, 56);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(274, 27);
            this.dtpFin.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Fecha fin:";
            // 
            // cboClientes
            // 
            this.cboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(1027, 50);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(169, 33);
            this.cboClientes.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 100;
            this.label3.Text = "Cliente:";
            // 
            // cmdPorCliente
            // 
            this.cmdPorCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPorCliente.Location = new System.Drawing.Point(1027, 174);
            this.cmdPorCliente.Name = "cmdPorCliente";
            this.cmdPorCliente.Size = new System.Drawing.Size(138, 83);
            this.cmdPorCliente.TabIndex = 101;
            this.cmdPorCliente.Text = "Consultas por cliente";
            this.cmdPorCliente.UseVisualStyleBackColor = false;
            this.cmdPorCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudTop
            // 
            this.nudTop.Location = new System.Drawing.Point(873, 146);
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(64, 22);
            this.nudTop.TabIndex = 102;
            this.nudTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmdTopProductos
            // 
            this.cmdTopProductos.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdTopProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTopProductos.Location = new System.Drawing.Point(873, 174);
            this.cmdTopProductos.Name = "cmdTopProductos";
            this.cmdTopProductos.Size = new System.Drawing.Size(138, 83);
            this.cmdTopProductos.TabIndex = 103;
            this.cmdTopProductos.Text = "Top productos";
            this.cmdTopProductos.UseVisualStyleBackColor = false;
            this.cmdTopProductos.Click += new System.EventHandler(this.cmdTopProductos_Click);
            // 
            // ConsultasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 738);
            this.Controls.Add(this.cmdTopProductos);
            this.Controls.Add(this.nudTop);
            this.Controls.Add(this.cmdPorCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cmdPorFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "ConsultasVentas";
            this.Text = "ConsultasVentas";
            this.Load += new System.EventHandler(this.ConsultasVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdPorFecha;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPorCliente;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.Button cmdTopProductos;
    }
}