namespace PAV_G12_K_BEZA.Formularios.Empleados.Usuario
{
    partial class frm_borrar_usuario
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_id_perfil = new System.Windows.Forms.ComboBox();
            this.txt_id_empleado = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_id_usuario = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_clave = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_nombre_usuario = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_aceptar.Location = new System.Drawing.Point(383, 91);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(53, 43);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.Location = new System.Drawing.Point(383, 156);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(53, 43);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID de Perfil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Legajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre de Usuario";
            // 
            // cmb_id_perfil
            // 
            this.cmb_id_perfil.Enabled = false;
            this.cmb_id_perfil.FormattingEnabled = true;
            this.cmb_id_perfil.Location = new System.Drawing.Point(187, 209);
            this.cmb_id_perfil.Name = "cmb_id_perfil";
            this.cmb_id_perfil.Size = new System.Drawing.Size(168, 28);
            this.cmb_id_perfil.TabIndex = 4;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Enabled = false;
            this.txt_id_empleado.Location = new System.Drawing.Point(187, 176);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Pp_MensajeError = "Ingrese el legajo del Usuario.";
            this.txt_id_empleado.Pp_NombreCampo = null;
            this.txt_id_empleado.Pp_NombreTabla = null;
            this.txt_id_empleado.Pp_Validable = true;
            this.txt_id_empleado.Size = new System.Drawing.Size(168, 26);
            this.txt_id_empleado.TabIndex = 3;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Location = new System.Drawing.Point(187, 142);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Pp_MensajeError = "Repita su contraseña.";
            this.txt_id_usuario.Pp_NombreCampo = null;
            this.txt_id_usuario.Pp_NombreTabla = null;
            this.txt_id_usuario.Pp_Validable = true;
            this.txt_id_usuario.Size = new System.Drawing.Size(168, 26);
            this.txt_id_usuario.TabIndex = 2;
            // 
            // txt_clave
            // 
            this.txt_clave.Enabled = false;
            this.txt_clave.Location = new System.Drawing.Point(187, 108);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Pp_MensajeError = "Ingrese una contraseña.";
            this.txt_clave.Pp_NombreCampo = null;
            this.txt_clave.Pp_NombreTabla = null;
            this.txt_clave.Pp_Validable = true;
            this.txt_clave.Size = new System.Drawing.Size(168, 26);
            this.txt_clave.TabIndex = 1;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Enabled = false;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(187, 74);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Pp_MensajeError = "Ingrese nombre de Usuario.";
            this.txt_nombre_usuario.Pp_NombreCampo = null;
            this.txt_nombre_usuario.Pp_NombreTabla = null;
            this.txt_nombre_usuario.Pp_Validable = true;
            this.txt_nombre_usuario.Size = new System.Drawing.Size(168, 26);
            this.txt_nombre_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "BORRAR USUARIO";
            // 
            // frm_borrar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_id_perfil);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_borrar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Usuario";
            this.Load += new System.EventHandler(this.frm_borrar_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_id_empleado;
        private Clases.TextBox01 txt_id_usuario;
        private Clases.TextBox01 txt_clave;
        private Clases.TextBox01 txt_nombre_usuario;
        private System.Windows.Forms.ComboBox cmb_id_perfil;
        private System.Windows.Forms.Label label1;
    }
}