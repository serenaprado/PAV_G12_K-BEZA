namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoEmpleadoXRol
{
    partial class FrmReporteEmpleadoXRol
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
            this.rv_empleadoRol = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cb_Rol = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_empleadoRol = new System.Windows.Forms.Button();
            this.check_Empleado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Desde = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Hasta = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.cb_Limite = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rv_empleadoRol
            // 
            this.rv_empleadoRol.Location = new System.Drawing.Point(29, 137);
            this.rv_empleadoRol.Name = "rv_empleadoRol";
            this.rv_empleadoRol.ServerReport.BearerToken = null;
            this.rv_empleadoRol.Size = new System.Drawing.Size(586, 246);
            this.rv_empleadoRol.TabIndex = 0;
            // 
            // cb_Rol
            // 
            this.cb_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Rol.FormattingEnabled = true;
            this.cb_Rol.Location = new System.Drawing.Point(67, 60);
            this.cb_Rol.Name = "cb_Rol";
            this.cb_Rol.Pp_Coseleccion = false;
            this.cb_Rol.Pp_descripcion = "descripcion_rol";
            this.cb_Rol.Pp_MensajeError = null;
            this.cb_Rol.Pp_NombreCampo = null;
            this.cb_Rol.Pp_NombreTabla = null;
            this.cb_Rol.Pp_Pk = "id_rol";
            this.cb_Rol.Pp_tabla = "Rol";
            this.cb_Rol.Pp_Validable = false;
            this.cb_Rol.Size = new System.Drawing.Size(121, 28);
            this.cb_Rol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rol";
            // 
            // bt_empleadoRol
            // 
            this.bt_empleadoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_empleadoRol.Location = new System.Drawing.Point(540, 90);
            this.bt_empleadoRol.Name = "bt_empleadoRol";
            this.bt_empleadoRol.Size = new System.Drawing.Size(75, 35);
            this.bt_empleadoRol.TabIndex = 3;
            this.bt_empleadoRol.Text = "Calcular";
            this.bt_empleadoRol.UseVisualStyleBackColor = true;
            this.bt_empleadoRol.Click += new System.EventHandler(this.bt_empleadoRol_Click);
            // 
            // check_Empleado
            // 
            this.check_Empleado.AutoSize = true;
            this.check_Empleado.BackColor = System.Drawing.Color.Transparent;
            this.check_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Empleado.Location = new System.Drawing.Point(424, 77);
            this.check_Empleado.Name = "check_Empleado";
            this.check_Empleado.Size = new System.Drawing.Size(72, 24);
            this.check_Empleado.TabIndex = 4;
            this.check_Empleado.Text = "Todos";
            this.check_Empleado.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Legajo Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // txt_Desde
            // 
            this.txt_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desde.Location = new System.Drawing.Point(142, 103);
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Pp_MensajeError = null;
            this.txt_Desde.Pp_NombreCampo = null;
            this.txt_Desde.Pp_NombreTabla = null;
            this.txt_Desde.Pp_Validable = false;
            this.txt_Desde.Size = new System.Drawing.Size(100, 26);
            this.txt_Desde.TabIndex = 7;
            // 
            // txt_Hasta
            // 
            this.txt_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hasta.Location = new System.Drawing.Point(306, 102);
            this.txt_Hasta.Name = "txt_Hasta";
            this.txt_Hasta.Pp_MensajeError = null;
            this.txt_Hasta.Pp_NombreCampo = null;
            this.txt_Hasta.Pp_NombreTabla = null;
            this.txt_Hasta.Pp_Validable = false;
            this.txt_Hasta.Size = new System.Drawing.Size(100, 26);
            this.txt_Hasta.TabIndex = 8;
            // 
            // cb_Limite
            // 
            this.cb_Limite.AutoSize = true;
            this.cb_Limite.BackColor = System.Drawing.Color.Transparent;
            this.cb_Limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Limite.Location = new System.Drawing.Point(424, 108);
            this.cb_Limite.Name = "cb_Limite";
            this.cb_Limite.Size = new System.Drawing.Size(110, 24);
            this.cb_Limite.TabIndex = 9;
            this.cb_Limite.Text = "Por Limites ";
            this.cb_Limite.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reporte de Empleados por Rol";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(573, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 504;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmReporteEmpleadoXRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 445);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Limite);
            this.Controls.Add(this.txt_Hasta);
            this.Controls.Add(this.txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_Empleado);
            this.Controls.Add(this.bt_empleadoRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Rol);
            this.Controls.Add(this.rv_empleadoRol);
            this.Name = "FrmReporteEmpleadoXRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEmpleadoXRol";
            this.Load += new System.EventHandler(this.ReporteEmpleadoXRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_empleadoRol;
        private Clases.ComboBox01 cb_Rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_empleadoRol;
        private System.Windows.Forms.CheckBox check_Empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_Desde;
        private Clases.TextBox01 txt_Hasta;
        private System.Windows.Forms.CheckBox cb_Limite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}