namespace PAV_G12_K_BEZA.Formularios
{
    partial class frmClientes
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
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnABMTipoDoc = new System.Windows.Forms.Button();
            this.btnABMBarrio = new System.Windows.Forms.Button();
            this.btnABMLocalidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMCliente.Location = new System.Drawing.Point(574, 46);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(153, 47);
            this.btnABMCliente.TabIndex = 0;
            this.btnABMCliente.Text = "CLIENTE";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnABMTipoDoc
            // 
            this.btnABMTipoDoc.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMTipoDoc.Location = new System.Drawing.Point(574, 215);
            this.btnABMTipoDoc.Name = "btnABMTipoDoc";
            this.btnABMTipoDoc.Size = new System.Drawing.Size(153, 47);
            this.btnABMTipoDoc.TabIndex = 1;
            this.btnABMTipoDoc.Text = "TIPO DE DOCUMENTO";
            this.btnABMTipoDoc.UseVisualStyleBackColor = true;
            this.btnABMTipoDoc.Click += new System.EventHandler(this.btnABMTipoDoc_Click);
            // 
            // btnABMBarrio
            // 
            this.btnABMBarrio.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMBarrio.Location = new System.Drawing.Point(574, 268);
            this.btnABMBarrio.Name = "btnABMBarrio";
            this.btnABMBarrio.Size = new System.Drawing.Size(153, 47);
            this.btnABMBarrio.TabIndex = 2;
            this.btnABMBarrio.Text = "BARRIO";
            this.btnABMBarrio.UseVisualStyleBackColor = true;
            this.btnABMBarrio.Click += new System.EventHandler(this.btnABMBarrio_Click);
            // 
            // btnABMLocalidad
            // 
            this.btnABMLocalidad.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMLocalidad.Location = new System.Drawing.Point(574, 321);
            this.btnABMLocalidad.Name = "btnABMLocalidad";
            this.btnABMLocalidad.Size = new System.Drawing.Size(153, 47);
            this.btnABMLocalidad.TabIndex = 3;
            this.btnABMLocalidad.Text = "LOCALIDAD";
            this.btnABMLocalidad.UseVisualStyleBackColor = true;
            this.btnABMLocalidad.Click += new System.EventHandler(this.btnABMLocalidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(690, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 52);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnABMLocalidad);
            this.Controls.Add(this.btnABMBarrio);
            this.Controls.Add(this.btnABMTipoDoc);
            this.Controls.Add(this.btnABMCliente);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnABMTipoDoc;
        private System.Windows.Forms.Button btnABMBarrio;
        private System.Windows.Forms.Button btnABMLocalidad;
        private System.Windows.Forms.Button btnSalir;
    }
}