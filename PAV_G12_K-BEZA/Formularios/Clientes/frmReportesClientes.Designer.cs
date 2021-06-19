namespace PAV_G12_K_BEZA.Formularios.Clientes
{
    partial class frmReportesClientes
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
            this.btnClientesXBarrio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClienteXEdad = new System.Windows.Forms.Button();
            this.btnClienteXLocalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientesXBarrio
            // 
            this.btnClientesXBarrio.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesXBarrio.Location = new System.Drawing.Point(400, 12);
            this.btnClientesXBarrio.Name = "btnClientesXBarrio";
            this.btnClientesXBarrio.Size = new System.Drawing.Size(128, 30);
            this.btnClientesXBarrio.TabIndex = 0;
            this.btnClientesXBarrio.Text = "Clientes por Barrio";
            this.btnClientesXBarrio.UseVisualStyleBackColor = true;
            this.btnClientesXBarrio.Click += new System.EventHandler(this.btnClientesXBarrio_Click);
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
            // btnClienteXEdad
            // 
            this.btnClienteXEdad.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteXEdad.Location = new System.Drawing.Point(400, 48);
            this.btnClienteXEdad.Name = "btnClienteXEdad";
            this.btnClienteXEdad.Size = new System.Drawing.Size(128, 30);
            this.btnClienteXEdad.TabIndex = 7;
            this.btnClienteXEdad.Text = "Clientes por Edad";
            this.btnClienteXEdad.UseVisualStyleBackColor = true;
            this.btnClienteXEdad.Click += new System.EventHandler(this.btnClienteXEdad_Click);
            // 
            // btnClienteXLocalidad
            // 
            this.btnClienteXLocalidad.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteXLocalidad.Location = new System.Drawing.Point(400, 84);
            this.btnClienteXLocalidad.Name = "btnClienteXLocalidad";
            this.btnClienteXLocalidad.Size = new System.Drawing.Size(128, 30);
            this.btnClienteXLocalidad.TabIndex = 8;
            this.btnClienteXLocalidad.Text = "Clientes por Localidad";
            this.btnClienteXLocalidad.UseVisualStyleBackColor = true;
            this.btnClienteXLocalidad.Click += new System.EventHandler(this.btnClienteXLocalidad_Click);
            // 
            // frmReportesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnClienteXLocalidad);
            this.Controls.Add(this.btnClienteXEdad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClientesXBarrio);
            this.Name = "frmReportesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientesXBarrio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClienteXEdad;
        private System.Windows.Forms.Button btnClienteXLocalidad;
    }
}