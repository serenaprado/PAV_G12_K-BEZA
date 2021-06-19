namespace PAV_G12_K_BEZA.Formularios.Reportes.ClientesXLocalidad
{
    partial class frm_clientesxlocalicad
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteClientesXlocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteClientesXLocalidad = new PAV_G12_K_BEZA.Formularios.Reportes.ClientesXLocalidad.ReporteClientesXLocalidad();
            this.cbo_localidades = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.rpv_clientes_x_localidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClientesXlocalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClientesXLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteClientesXlocalidadBindingSource
            // 
            this.ReporteClientesXlocalidadBindingSource.DataMember = "ReporteClientesXlocalidad";
            this.ReporteClientesXlocalidadBindingSource.DataSource = this.ReporteClientesXLocalidad;
            // 
            // ReporteClientesXLocalidad
            // 
            this.ReporteClientesXLocalidad.DataSetName = "ReporteClientesXLocalidad";
            this.ReporteClientesXLocalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_localidades
            // 
            this.cbo_localidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_localidades.FormattingEnabled = true;
            this.cbo_localidades.Location = new System.Drawing.Point(216, 76);
            this.cbo_localidades.Name = "cbo_localidades";
            this.cbo_localidades.Pp_Coseleccion = true;
            this.cbo_localidades.Pp_descripcion = "descripcion_localidad";
            this.cbo_localidades.Pp_MensajeError = "Debe seleccionar una localidad";
            this.cbo_localidades.Pp_NombreCampo = null;
            this.cbo_localidades.Pp_NombreTabla = null;
            this.cbo_localidades.Pp_Pk = "id_localidad";
            this.cbo_localidades.Pp_tabla = "Localidad";
            this.cbo_localidades.Pp_Validable = true;
            this.cbo_localidades.Size = new System.Drawing.Size(221, 28);
            this.cbo_localidades.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de Clientes por Localidad";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(443, 70);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(98, 34);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // rpv_clientes_x_localidad
            // 
            reportDataSource3.Name = "ReporteClientesXLocalidad";
            reportDataSource3.Value = this.ReporteClientesXlocalidadBindingSource;
            this.rpv_clientes_x_localidad.LocalReport.DataSources.Add(reportDataSource3);
            this.rpv_clientes_x_localidad.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Listados.ClientesXLocalidad.ReporteClientesXLocalidad." +
    "rdlc";
            this.rpv_clientes_x_localidad.Location = new System.Drawing.Point(18, 136);
            this.rpv_clientes_x_localidad.Name = "rpv_clientes_x_localidad";
            this.rpv_clientes_x_localidad.ServerReport.BearerToken = null;
            this.rpv_clientes_x_localidad.Size = new System.Drawing.Size(770, 266);
            this.rpv_clientes_x_localidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Localidad:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(746, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 503;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frm_clientesxlocalicad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpv_clientes_x_localidad);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_localidades);
            this.Name = "frm_clientesxlocalicad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_clientesxlocalicad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClientesXlocalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClientesXLocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBox01 cbo_localidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_clientes_x_localidad;
        private System.Windows.Forms.BindingSource ReporteClientesXlocalidadBindingSource;
        private ReporteClientesXLocalidad ReporteClientesXLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}