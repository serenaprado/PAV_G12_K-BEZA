namespace PAV_G12_K_BEZA.Formularios.Clientes.Localidad
{
    partial class frm_M_Localidad
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Localidad = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Localidad_Vieja = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(388, 108);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(388, 49);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 44);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Localidad
            // 
            this.txt_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Localidad.Location = new System.Drawing.Point(171, 104);
            this.txt_Localidad.Name = "txt_Localidad";
            this.txt_Localidad.Pp_MensajeError = null;
            this.txt_Localidad.Pp_NombreCampo = null;
            this.txt_Localidad.Pp_NombreTabla = null;
            this.txt_Localidad.Pp_Validable = false;
            this.txt_Localidad.Size = new System.Drawing.Size(201, 26);
            this.txt_Localidad.TabIndex = 15;
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Modificar.Location = new System.Drawing.Point(84, 70);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(81, 20);
            this.lbl_Modificar.TabIndex = 14;
            this.lbl_Modificar.Text = "Localidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nueva Descripción:";
            // 
            // txt_Localidad_Vieja
            // 
            this.txt_Localidad_Vieja.Enabled = false;
            this.txt_Localidad_Vieja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Localidad_Vieja.Location = new System.Drawing.Point(171, 67);
            this.txt_Localidad_Vieja.Name = "txt_Localidad_Vieja";
            this.txt_Localidad_Vieja.Pp_MensajeError = null;
            this.txt_Localidad_Vieja.Pp_NombreCampo = null;
            this.txt_Localidad_Vieja.Pp_NombreTabla = null;
            this.txt_Localidad_Vieja.Pp_Validable = false;
            this.txt_Localidad_Vieja.Size = new System.Drawing.Size(201, 26);
            this.txt_Localidad_Vieja.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "MODIFICAR LOCALIDAD";
            // 
            // frm_M_Localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Localidad_Vieja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_Localidad);
            this.Controls.Add(this.lbl_Modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_M_Localidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Localidad";
            this.Load += new System.EventHandler(this.frm_M_Localidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Modificar;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_Localidad;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Label label1;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_Localidad_Vieja;
        private System.Windows.Forms.Label label2;
    }
}