namespace PAV_G12_K_BEZA.Formularios.Stock
{
    partial class frmReportesStock
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
            this.btnStockXCantidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProdxub = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockXCantidad
            // 
            this.btnStockXCantidad.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockXCantidad.Location = new System.Drawing.Point(380, 12);
            this.btnStockXCantidad.Name = "btnStockXCantidad";
            this.btnStockXCantidad.Size = new System.Drawing.Size(148, 30);
            this.btnStockXCantidad.TabIndex = 0;
            this.btnStockXCantidad.Text = "Stock por Cantidad";
            this.btnStockXCantidad.UseVisualStyleBackColor = true;
            this.btnStockXCantidad.Click += new System.EventHandler(this.btnStockXCantidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(486, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProdxub
            // 
            this.btnProdxub.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdxub.Location = new System.Drawing.Point(380, 48);
            this.btnProdxub.Name = "btnProdxub";
            this.btnProdxub.Size = new System.Drawing.Size(148, 30);
            this.btnProdxub.TabIndex = 7;
            this.btnProdxub.Text = "Productos por Ubicación";
            this.btnProdxub.UseVisualStyleBackColor = true;
            this.btnProdxub.Click += new System.EventHandler(this.btnProdxub_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(380, 84);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(148, 30);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // frmReportesStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProdxub);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnStockXCantidad);
            this.Name = "frmReportesStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Empleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockXCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProdxub;
        private System.Windows.Forms.Button btnProveedores;
    }
}