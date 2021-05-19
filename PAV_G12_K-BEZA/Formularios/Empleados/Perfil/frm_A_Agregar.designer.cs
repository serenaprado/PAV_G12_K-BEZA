namespace PAV_G12_K_BEZA.Formularios.Empleados.Perfil
{
    partial class frm_A_Agregar
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
            this.txt_Perfil = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Agregar.Location = new System.Drawing.Point(62, 68);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(48, 20);
            this.lbl_Agregar.TabIndex = 0;
            this.lbl_Agregar.Text = "Perfil:";
            // 
            // txt_Perfil
            // 
            this.txt_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Perfil.Location = new System.Drawing.Point(116, 65);
            this.txt_Perfil.Name = "txt_Perfil";
            this.txt_Perfil.Pp_MensajeError = null;
            this.txt_Perfil.Pp_NombreCampo = null;
            this.txt_Perfil.Pp_NombreTabla = null;
            this.txt_Perfil.Pp_Validable = false;
            this.txt_Perfil.Size = new System.Drawing.Size(161, 26);
            this.txt_Perfil.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(283, 29);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(51, 45);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(283, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 45);
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
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "NUEVO PERFIL";
            // 
            // frm_A_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Perfil);
            this.Controls.Add(this.lbl_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Perfil";
            this.Load += new System.EventHandler(this.frm_A_Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Agregar;
        private Clases.TextBox01 txt_Perfil;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}