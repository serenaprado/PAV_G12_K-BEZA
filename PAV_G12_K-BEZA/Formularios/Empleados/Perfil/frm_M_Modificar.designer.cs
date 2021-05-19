namespace PAV_G12_K_BEZA.Formularios.Empleados.Perfil
{
    partial class frm_M_Modificar
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
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_perfilanterior = new System.Windows.Forms.Label();
            this.txt_perfilanterior = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Perfil = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_modificar.Location = new System.Drawing.Point(26, 100);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(142, 20);
            this.lbl_modificar.TabIndex = 0;
            this.lbl_modificar.Text = "Nueva descripción:";
            this.lbl_modificar.Click += new System.EventHandler(this.lbl_modificar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(341, 32);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(52, 50);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_perfilanterior
            // 
            this.lbl_perfilanterior.AutoSize = true;
            this.lbl_perfilanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_perfilanterior.Location = new System.Drawing.Point(120, 59);
            this.lbl_perfilanterior.Name = "lbl_perfilanterior";
            this.lbl_perfilanterior.Size = new System.Drawing.Size(48, 20);
            this.lbl_perfilanterior.TabIndex = 4;
            this.lbl_perfilanterior.Text = "Perfil:";
            // 
            // txt_perfilanterior
            // 
            this.txt_perfilanterior.Enabled = false;
            this.txt_perfilanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_perfilanterior.Location = new System.Drawing.Point(174, 56);
            this.txt_perfilanterior.Name = "txt_perfilanterior";
            this.txt_perfilanterior.Pp_MensajeError = null;
            this.txt_perfilanterior.Pp_NombreCampo = null;
            this.txt_perfilanterior.Pp_NombreTabla = null;
            this.txt_perfilanterior.Pp_Validable = false;
            this.txt_perfilanterior.Size = new System.Drawing.Size(161, 26);
            this.txt_perfilanterior.TabIndex = 5;
            this.txt_perfilanterior.TextChanged += new System.EventHandler(this.txt_perfilanterior_TextChanged);
            // 
            // txt_Perfil
            // 
            this.txt_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Perfil.Location = new System.Drawing.Point(174, 97);
            this.txt_Perfil.Name = "txt_Perfil";
            this.txt_Perfil.Pp_MensajeError = null;
            this.txt_Perfil.Pp_NombreCampo = null;
            this.txt_Perfil.Pp_NombreTabla = null;
            this.txt_Perfil.Pp_Validable = false;
            this.txt_Perfil.Size = new System.Drawing.Size(161, 26);
            this.txt_Perfil.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(341, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "MODIFICAR PERFIL";
            // 
            // frm_M_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txt_perfilanterior);
            this.Controls.Add(this.lbl_perfilanterior);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_Perfil);
            this.Controls.Add(this.lbl_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_M_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Perfil";
            this.Load += new System.EventHandler(this.frm_M_Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_modificar;
        private Clases.TextBox01 txt_Perfil;
        private System.Windows.Forms.Button btn_Modificar;
        private Clases.TextBox01 txt_perfilanterior;
        private System.Windows.Forms.Label lbl_perfilanterior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}