namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    partial class frm_A_Barrio
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
            this.lbl_Des_Agregar = new System.Windows.Forms.Label();
            this.txt_Barrio = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_Barrio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.cmbLocalidad = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(385, 82);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 24;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Des_Agregar
            // 
            this.lbl_Des_Agregar.AutoSize = true;
            this.lbl_Des_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Des_Agregar.Location = new System.Drawing.Point(73, 85);
            this.lbl_Des_Agregar.Name = "lbl_Des_Agregar";
            this.lbl_Des_Agregar.Size = new System.Drawing.Size(81, 20);
            this.lbl_Des_Agregar.TabIndex = 23;
            this.lbl_Des_Agregar.Text = "Localidad:";
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Barrio.Location = new System.Drawing.Point(160, 50);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.Pp_MensajeError = null;
            this.txt_Barrio.Pp_NombreCampo = null;
            this.txt_Barrio.Pp_NombreTabla = null;
            this.txt_Barrio.Pp_Validable = false;
            this.txt_Barrio.Size = new System.Drawing.Size(201, 26);
            this.txt_Barrio.TabIndex = 21;
            // 
            // lbl_Barrio
            // 
            this.lbl_Barrio.AutoSize = true;
            this.lbl_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Barrio.Location = new System.Drawing.Point(99, 53);
            this.lbl_Barrio.Name = "lbl_Barrio";
            this.lbl_Barrio.Size = new System.Drawing.Size(55, 20);
            this.lbl_Barrio.TabIndex = 20;
            this.lbl_Barrio.Text = "Barrio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "NUEVO BARRIO";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(385, 32);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 22;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(160, 82);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Pp_Coseleccion = false;
            this.cmbLocalidad.Pp_descripcion = "descripcion_localidad";
            this.cmbLocalidad.Pp_MensajeError = "Debe Ingresar Localidad";
            this.cmbLocalidad.Pp_NombreCampo = "id_localidad";
            this.cmbLocalidad.Pp_NombreTabla = "";
            this.cmbLocalidad.Pp_Pk = "id_localidad";
            this.cmbLocalidad.Pp_tabla = "Localidad";
            this.cmbLocalidad.Pp_Validable = false;
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 30;
            // 
            // frm_A_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 154);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Des_Agregar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Barrio);
            this.Controls.Add(this.lbl_Barrio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Barrio";
            this.Load += new System.EventHandler(this.frm_A_Barrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Des_Agregar;
        private System.Windows.Forms.Button btn_Agregar;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_Barrio;
        private System.Windows.Forms.Label lbl_Barrio;
        private System.Windows.Forms.Label label2;
        private PAV_G12_K_BEZA.Clases.ComboBox01 cmbLocalidad;
    }
}