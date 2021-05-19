namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    partial class frm_A_Tipo_Factura
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
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.txt_Tipo_Factura = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Agregar.Location = new System.Drawing.Point(51, 60);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(124, 20);
            this.lbl_Agregar.TabIndex = 19;
            this.lbl_Agregar.Text = "Tipo de Factura:";
            // 
            // txt_Tipo_Factura
            // 
            this.txt_Tipo_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tipo_Factura.Location = new System.Drawing.Point(181, 57);
            this.txt_Tipo_Factura.Name = "txt_Tipo_Factura";
            this.txt_Tipo_Factura.Pp_MensajeError = "No se ingresó forma de pago a agregar.";
            this.txt_Tipo_Factura.Pp_NombreCampo = null;
            this.txt_Tipo_Factura.Pp_NombreTabla = null;
            this.txt_Tipo_Factura.Pp_Validable = false;
            this.txt_Tipo_Factura.Size = new System.Drawing.Size(160, 26);
            this.txt_Tipo_Factura.TabIndex = 24;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(347, 73);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(347, 23);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 20;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 34);
            this.label5.TabIndex = 33;
            this.label5.Text = "NUEVO TIPO DE FACTURA";
            // 
            // frm_A_Tipo_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 151);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Tipo_Factura);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Agregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_Tipo_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Tipo de Factura";
            this.Load += new System.EventHandler(this.frm_A_Tipo_Factura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Agregar;
        private Clases.TextBox01 txt_Tipo_Factura;
        private System.Windows.Forms.Label label5;
    }
}