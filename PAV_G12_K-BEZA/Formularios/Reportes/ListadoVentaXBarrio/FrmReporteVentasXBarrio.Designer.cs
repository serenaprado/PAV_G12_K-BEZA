namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoVentaXBarrio
{
    partial class FrmReporteVentasXBarrio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btm_VentasBarrio = new System.Windows.Forms.Button();
            this.rv_ventaBarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cb_total = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hasta = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_desde = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.cb_barrio = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cb_localidad = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barrio";
            // 
            // btm_VentasBarrio
            // 
            this.btm_VentasBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_VentasBarrio.Location = new System.Drawing.Point(553, 139);
            this.btm_VentasBarrio.Name = "btm_VentasBarrio";
            this.btm_VentasBarrio.Size = new System.Drawing.Size(75, 36);
            this.btm_VentasBarrio.TabIndex = 4;
            this.btm_VentasBarrio.Text = "Calcular";
            this.btm_VentasBarrio.UseVisualStyleBackColor = true;
            this.btm_VentasBarrio.Click += new System.EventHandler(this.btm_VentasBarrio_Click);
            // 
            // rv_ventaBarrio
            // 
            this.rv_ventaBarrio.Location = new System.Drawing.Point(11, 181);
            this.rv_ventaBarrio.Name = "rv_ventaBarrio";
            this.rv_ventaBarrio.ServerReport.BearerToken = null;
            this.rv_ventaBarrio.Size = new System.Drawing.Size(616, 228);
            this.rv_ventaBarrio.TabIndex = 5;
            // 
            // cb_total
            // 
            this.cb_total.AutoSize = true;
            this.cb_total.BackColor = System.Drawing.Color.Transparent;
            this.cb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_total.Location = new System.Drawing.Point(378, 144);
            this.cb_total.Name = "cb_total";
            this.cb_total.Size = new System.Drawing.Size(159, 24);
            this.cb_total.TabIndex = 8;
            this.cb_total.Text = "Buscar por Limites";
            this.cb_total.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta.Location = new System.Drawing.Point(272, 144);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Pp_MensajeError = null;
            this.txt_hasta.Pp_NombreCampo = null;
            this.txt_hasta.Pp_NombreTabla = null;
            this.txt_hasta.Pp_Validable = false;
            this.txt_hasta.Size = new System.Drawing.Size(100, 26);
            this.txt_hasta.TabIndex = 7;
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(108, 144);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Pp_MensajeError = null;
            this.txt_desde.Pp_NombreCampo = null;
            this.txt_desde.Pp_NombreTabla = null;
            this.txt_desde.Pp_Validable = false;
            this.txt_desde.Size = new System.Drawing.Size(100, 26);
            this.txt_desde.TabIndex = 6;
            // 
            // cb_barrio
            // 
            this.cb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_barrio.FormattingEnabled = true;
            this.cb_barrio.Location = new System.Drawing.Point(108, 100);
            this.cb_barrio.Name = "cb_barrio";
            this.cb_barrio.Pp_Coseleccion = false;
            this.cb_barrio.Pp_descripcion = "descripcion_barrio";
            this.cb_barrio.Pp_MensajeError = null;
            this.cb_barrio.Pp_NombreCampo = null;
            this.cb_barrio.Pp_NombreTabla = null;
            this.cb_barrio.Pp_Pk = "id_barrio";
            this.cb_barrio.Pp_tabla = "Barrio";
            this.cb_barrio.Pp_Validable = false;
            this.cb_barrio.Size = new System.Drawing.Size(121, 28);
            this.cb_barrio.TabIndex = 3;
            // 
            // cb_localidad
            // 
            this.cb_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_localidad.FormattingEnabled = true;
            this.cb_localidad.Location = new System.Drawing.Point(108, 66);
            this.cb_localidad.Name = "cb_localidad";
            this.cb_localidad.Pp_Coseleccion = false;
            this.cb_localidad.Pp_descripcion = "descripcion_localidad";
            this.cb_localidad.Pp_MensajeError = null;
            this.cb_localidad.Pp_NombreCampo = null;
            this.cb_localidad.Pp_NombreTabla = null;
            this.cb_localidad.Pp_Pk = "id_localidad";
            this.cb_localidad.Pp_tabla = "localidad";
            this.cb_localidad.Pp_Validable = false;
            this.cb_localidad.Size = new System.Drawing.Size(121, 28);
            this.cb_localidad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reporte de Ventas por Barrio";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(592, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 506;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmReporteVentasXBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 457);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_total);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.rv_ventaBarrio);
            this.Controls.Add(this.btm_VentasBarrio);
            this.Controls.Add(this.cb_barrio);
            this.Controls.Add(this.cb_localidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporteVentasXBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReporteVentasXBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cb_localidad;
        private Clases.ComboBox01 cb_barrio;
        private System.Windows.Forms.Button btm_VentasBarrio;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ventaBarrio;
        private Clases.TextBox01 txt_desde;
        private Clases.TextBox01 txt_hasta;
        private System.Windows.Forms.CheckBox cb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
    }
}