namespace PAV_G12_K_BEZA.Formularios.Empleados
{
    partial class frmEmpleados
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
            this.btnABMEmpleado = new System.Windows.Forms.Button();
            this.btnABMUsuario = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMEmpleado
            // 
            this.btnABMEmpleado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMEmpleado.Location = new System.Drawing.Point(574, 50);
            this.btnABMEmpleado.Name = "btnABMEmpleado";
            this.btnABMEmpleado.Size = new System.Drawing.Size(153, 47);
            this.btnABMEmpleado.TabIndex = 5;
            this.btnABMEmpleado.Text = "EMPLEADO";
            this.btnABMEmpleado.UseVisualStyleBackColor = true;
            this.btnABMEmpleado.Click += new System.EventHandler(this.btnABMEmpleado_Click);
            // 
            // btnABMUsuario
            // 
            this.btnABMUsuario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMUsuario.Location = new System.Drawing.Point(574, 103);
            this.btnABMUsuario.Name = "btnABMUsuario";
            this.btnABMUsuario.Size = new System.Drawing.Size(153, 47);
            this.btnABMUsuario.TabIndex = 6;
            this.btnABMUsuario.Text = "USUARIO";
            this.btnABMUsuario.UseVisualStyleBackColor = true;
            this.btnABMUsuario.Click += new System.EventHandler(this.btnABMUsuario_Click);
            // 
            // btnABMRol
            // 
            this.btnABMRol.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMRol.Location = new System.Drawing.Point(574, 176);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(153, 47);
            this.btnABMRol.TabIndex = 7;
            this.btnABMRol.Text = "ROL";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(574, 229);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(153, 47);
            this.btnPerfil.TabIndex = 8;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(689, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 52);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(574, 282);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(153, 47);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnABMRol);
            this.Controls.Add(this.btnABMUsuario);
            this.Controls.Add(this.btnABMEmpleado);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMEmpleado;
        private System.Windows.Forms.Button btnABMUsuario;
        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
    }
}