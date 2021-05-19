namespace PAV_G12_K_BEZA.Formularios.Compras
{
    partial class frmCompras
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
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnABMTipoFactura = new System.Windows.Forms.Button();
            this.btnABMFormaPago = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Location = new System.Drawing.Point(572, 32);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(153, 47);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "COMPRA";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnABMTipoFactura
            // 
            this.btnABMTipoFactura.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMTipoFactura.Location = new System.Drawing.Point(572, 263);
            this.btnABMTipoFactura.Name = "btnABMTipoFactura";
            this.btnABMTipoFactura.Size = new System.Drawing.Size(153, 47);
            this.btnABMTipoFactura.TabIndex = 2;
            this.btnABMTipoFactura.Text = "TIPO DE FACTURA";
            this.btnABMTipoFactura.UseVisualStyleBackColor = true;
            this.btnABMTipoFactura.Click += new System.EventHandler(this.btnABMTipoFactura_Click);
            // 
            // btnABMFormaPago
            // 
            this.btnABMFormaPago.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMFormaPago.Location = new System.Drawing.Point(572, 316);
            this.btnABMFormaPago.Name = "btnABMFormaPago";
            this.btnABMFormaPago.Size = new System.Drawing.Size(153, 47);
            this.btnABMFormaPago.TabIndex = 3;
            this.btnABMFormaPago.Text = "FORMA DE PAGO";
            this.btnABMFormaPago.UseVisualStyleBackColor = true;
            this.btnABMFormaPago.Click += new System.EventHandler(this.btnABMFormaPago_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(690, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 52);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnABMFormaPago);
            this.Controls.Add(this.btnABMTipoFactura);
            this.Controls.Add(this.btnCompra);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnABMTipoFactura;
        private System.Windows.Forms.Button btnABMFormaPago;
        private System.Windows.Forms.Button btnSalir;
    }
}