namespace PAV_G12_K_BEZA.Formularios.Reportes.ClientesXBarrio
{
    partial class frm_ReporteClientesXBarrio
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rpv_clienteXbarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbo_Barrios = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Barrios";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(390, 45);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(87, 28);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rpv_clienteXbarrio
            // 
            this.rpv_clienteXbarrio.Location = new System.Drawing.Point(7, 121);
            this.rpv_clienteXbarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpv_clienteXbarrio.Name = "rpv_clienteXbarrio";
            this.rpv_clienteXbarrio.ServerReport.BearerToken = null;
            this.rpv_clienteXbarrio.Size = new System.Drawing.Size(835, 295);
            this.rpv_clienteXbarrio.TabIndex = 6;
            // 
            // cbo_Barrios
            // 
            this.cbo_Barrios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Barrios.FormattingEnabled = true;
            this.cbo_Barrios.Location = new System.Drawing.Point(185, 45);
            this.cbo_Barrios.Name = "cbo_Barrios";
            this.cbo_Barrios.Pp_Coseleccion = false;
            this.cbo_Barrios.Pp_descripcion = "descripcion_barrio";
            this.cbo_Barrios.Pp_MensajeError = "Debe Seleccionar un Barrio";
            this.cbo_Barrios.Pp_NombreCampo = null;
            this.cbo_Barrios.Pp_NombreTabla = null;
            this.cbo_Barrios.Pp_Pk = "id_barrio";
            this.cbo_Barrios.Pp_tabla = "Barrio";
            this.cbo_Barrios.Pp_Validable = true;
            this.cbo_Barrios.Size = new System.Drawing.Size(198, 28);
            this.cbo_Barrios.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.rpv_clienteXbarrio);
            this.groupBox1.Controls.Add(this.cbo_Barrios);
            this.groupBox1.Controls.Add(this.btn_Calcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 464);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte de Clientes por Barrio";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(807, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 501;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frm_ReporteClientesXBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ReporteClientesXBarrio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ReporteClientesXBarrio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calcular;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_clienteXbarrio;
        private Clases.ComboBox01 cbo_Barrios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}