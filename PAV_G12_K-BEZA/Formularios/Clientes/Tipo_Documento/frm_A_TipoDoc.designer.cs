namespace PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento
{
    partial class frm_A_TipoDoc
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
            this.txt_tipo_doc = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Agregar.Location = new System.Drawing.Point(16, 63);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(130, 20);
            this.lbl_Agregar.TabIndex = 0;
            this.lbl_Agregar.Text = "Tipo Documento:";
            // 
            // txt_tipo_doc
            // 
            this.txt_tipo_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_tipo_doc.Location = new System.Drawing.Point(152, 60);
            this.txt_tipo_doc.Name = "txt_tipo_doc";
            this.txt_tipo_doc.Pp_MensajeError = null;
            this.txt_tipo_doc.Pp_NombreCampo = null;
            this.txt_tipo_doc.Pp_NombreTabla = null;
            this.txt_tipo_doc.Pp_Validable = false;
            this.txt_tipo_doc.Size = new System.Drawing.Size(201, 26);
            this.txt_tipo_doc.TabIndex = 1;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(359, 76);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(359, 26);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "NUEVO TIPO DE DOCUMENTO";
            // 
            // frm_A_TipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_tipo_doc);
            this.Controls.Add(this.lbl_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_TipoDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Tipo de Documento";
            this.Load += new System.EventHandler(this.frm_A_Localidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Agregar;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_tipo_doc;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
    }
}