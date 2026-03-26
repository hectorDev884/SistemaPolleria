namespace CapaPresentacion
{
    partial class Main
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
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdProveedores = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.cmdCategorias = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClientes
            // 
            this.cmdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.Location = new System.Drawing.Point(368, 65);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(148, 82);
            this.cmdClientes.TabIndex = 4;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = true;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdProveedores
            // 
            this.cmdProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProveedores.Location = new System.Drawing.Point(549, 65);
            this.cmdProveedores.Name = "cmdProveedores";
            this.cmdProveedores.Size = new System.Drawing.Size(148, 82);
            this.cmdProveedores.TabIndex = 3;
            this.cmdProveedores.Text = "Proveedores";
            this.cmdProveedores.UseVisualStyleBackColor = true;
            this.cmdProveedores.Click += new System.EventHandler(this.cmdProveedores_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.Location = new System.Drawing.Point(214, 65);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(148, 82);
            this.cmdProductos.TabIndex = 5;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = true;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // cmdCategorias
            // 
            this.cmdCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategorias.Location = new System.Drawing.Point(38, 65);
            this.cmdCategorias.Name = "cmdCategorias";
            this.cmdCategorias.Size = new System.Drawing.Size(148, 82);
            this.cmdCategorias.TabIndex = 6;
            this.cmdCategorias.Text = "Categoria";
            this.cmdCategorias.UseVisualStyleBackColor = true;
            this.cmdCategorias.Click += new System.EventHandler(this.cmdCategorias_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.Location = new System.Drawing.Point(112, 275);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(148, 82);
            this.cmdVentas.TabIndex = 7;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdCompras
            // 
            this.cmdCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCompras.Location = new System.Drawing.Point(298, 275);
            this.cmdCompras.Name = "cmdCompras";
            this.cmdCompras.Size = new System.Drawing.Size(148, 82);
            this.cmdCompras.TabIndex = 8;
            this.cmdCompras.Text = "Compras";
            this.cmdCompras.UseVisualStyleBackColor = true;
            this.cmdCompras.Click += new System.EventHandler(this.cmdCompras_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCompras);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdCategorias);
            this.Controls.Add(this.cmdProductos);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.cmdProveedores);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdProveedores;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdCategorias;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdCompras;
    }
}

