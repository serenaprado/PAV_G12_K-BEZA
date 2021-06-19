namespace PAV_G12_K_BEZA.Formularios.Reportes.VentasXTipoFactura
{
    partial class ListadoDeVentasTipoFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listado_de_ventas_tipo_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSListadoDeVentasTipoFactura = new PAV_G12_K_BEZA.Formularios.Reportes.VentasXTipoFactura.DSListadoDeVentasTipoFactura();
            this.rpt_ventas_tipo_factura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_fecha_desde = new System.Windows.Forms.MaskedTextBox();
            this.txt_fecha_hasta = new System.Windows.Forms.MaskedTextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_TipoFactura = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado_de_ventas_tipo_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListadoDeVentasTipoFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // listado_de_ventas_tipo_facturaBindingSource
            // 
            this.listado_de_ventas_tipo_facturaBindingSource.DataMember = "listado_de_ventas_tipo_factura";
            this.listado_de_ventas_tipo_facturaBindingSource.DataSource = this.DSListadoDeVentasTipoFactura;
            // 
            // DSListadoDeVentasTipoFactura
            // 
            this.DSListadoDeVentasTipoFactura.DataSetName = "DSListadoDeVentasTipoFactura";
            this.DSListadoDeVentasTipoFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpt_ventas_tipo_factura
            // 
            reportDataSource1.Name = "DSListadoDeVentasTipoFactura";
            reportDataSource1.Value = this.listado_de_ventas_tipo_facturaBindingSource;
            this.rpt_ventas_tipo_factura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_ventas_tipo_factura.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Listados.ListadoDeVentasTipoFactura.ListadoDeVentasTip" +
    "oFactura.rdlc";
            this.rpt_ventas_tipo_factura.Location = new System.Drawing.Point(12, 200);
            this.rpt_ventas_tipo_factura.Name = "rpt_ventas_tipo_factura";
            this.rpt_ventas_tipo_factura.ServerReport.BearerToken = null;
            this.rpt_ventas_tipo_factura.Size = new System.Drawing.Size(609, 353);
            this.rpt_ventas_tipo_factura.TabIndex = 0;
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_desde.Location = new System.Drawing.Point(157, 103);
            this.txt_fecha_desde.Mask = "00/00/0000";
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Size = new System.Drawing.Size(93, 26);
            this.txt_fecha_desde.TabIndex = 1;
            this.txt_fecha_desde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fecha_hasta
            // 
            this.txt_fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_hasta.Location = new System.Drawing.Point(399, 103);
            this.txt_fecha_hasta.Mask = "00/00/0000";
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(93, 26);
            this.txt_fecha_hasta.TabIndex = 2;
            this.txt_fecha_hasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(528, 106);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(93, 38);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "dd/mm/aaaaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "dd/mm/aaaaa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado de Ventas por Tipo de Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo de Factura:";
            // 
            // cbo_TipoFactura
            // 
            this.cbo_TipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TipoFactura.FormattingEnabled = true;
            this.cbo_TipoFactura.Location = new System.Drawing.Point(157, 64);
            this.cbo_TipoFactura.Name = "cbo_TipoFactura";
            this.cbo_TipoFactura.Pp_Coseleccion = false;
            this.cbo_TipoFactura.Pp_descripcion = "descripcion_tipo_factura";
            this.cbo_TipoFactura.Pp_MensajeError = "Debe seleccionar un tipo de factura";
            this.cbo_TipoFactura.Pp_NombreCampo = null;
            this.cbo_TipoFactura.Pp_NombreTabla = null;
            this.cbo_TipoFactura.Pp_Pk = "id_tipo_factura";
            this.cbo_TipoFactura.Pp_tabla = "Tipo_Factura";
            this.cbo_TipoFactura.Pp_Validable = true;
            this.cbo_TipoFactura.Size = new System.Drawing.Size(121, 28);
            this.cbo_TipoFactura.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(579, 563);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 501;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListadoDeVentasTipoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 614);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_TipoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.txt_fecha_hasta);
            this.Controls.Add(this.txt_fecha_desde);
            this.Controls.Add(this.rpt_ventas_tipo_factura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoDeVentasTipoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ventas por Tipo de Factura";
            this.Load += new System.EventHandler(this.ListadoDeVentasTipoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listado_de_ventas_tipo_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListadoDeVentasTipoFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listado_de_ventas_tipo_facturaBindingSource;
        private DSListadoDeVentasTipoFactura DSListadoDeVentasTipoFactura;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_ventas_tipo_factura;
        private System.Windows.Forms.MaskedTextBox txt_fecha_desde;
        private System.Windows.Forms.MaskedTextBox txt_fecha_hasta;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cbo_TipoFactura;
        private System.Windows.Forms.Button btnSalir;
    }
}