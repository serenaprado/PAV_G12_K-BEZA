namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoProductosXDeposito
{
    partial class FrmReporteProducto
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
            this.rv_producto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox011 = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUbicacion = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desde = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_hasta = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.ch_limite = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rv_producto
            // 
            this.rv_producto.Location = new System.Drawing.Point(12, 159);
            this.rv_producto.Name = "rv_producto";
            this.rv_producto.ServerReport.BearerToken = null;
            this.rv_producto.Size = new System.Drawing.Size(639, 246);
            this.rv_producto.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // comboBox011
            // 
            this.comboBox011.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(118, 51);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Pp_Coseleccion = false;
            this.comboBox011.Pp_descripcion = "descripcion";
            this.comboBox011.Pp_MensajeError = "Falta Cargar";
            this.comboBox011.Pp_NombreCampo = "id_producto";
            this.comboBox011.Pp_NombreTabla = null;
            this.comboBox011.Pp_Pk = "id_producto";
            this.comboBox011.Pp_tabla = "Producto";
            this.comboBox011.Pp_Validable = true;
            this.comboBox011.Size = new System.Drawing.Size(121, 28);
            this.comboBox011.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ubicacion";
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Location = new System.Drawing.Point(118, 85);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Pp_Coseleccion = false;
            this.cbUbicacion.Pp_descripcion = "descripcion_ubicacion";
            this.cbUbicacion.Pp_MensajeError = "Falta Cargar";
            this.cbUbicacion.Pp_NombreCampo = "descripcion_ubicacion";
            this.cbUbicacion.Pp_NombreTabla = null;
            this.cbUbicacion.Pp_Pk = "id_ubicacion";
            this.cbUbicacion.Pp_tabla = "Ubicacion_Producto";
            this.cbUbicacion.Pp_Validable = false;
            this.cbUbicacion.Size = new System.Drawing.Size(121, 28);
            this.cbUbicacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(118, 122);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Pp_MensajeError = null;
            this.txt_desde.Pp_NombreCampo = null;
            this.txt_desde.Pp_NombreTabla = null;
            this.txt_desde.Pp_Validable = false;
            this.txt_desde.Size = new System.Drawing.Size(100, 26);
            this.txt_desde.TabIndex = 10;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta.Location = new System.Drawing.Point(298, 122);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Pp_MensajeError = null;
            this.txt_hasta.Pp_NombreCampo = null;
            this.txt_hasta.Pp_NombreTabla = null;
            this.txt_hasta.Pp_Validable = false;
            this.txt_hasta.Size = new System.Drawing.Size(100, 26);
            this.txt_hasta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reporte de Producto por Ubicación";
            // 
            // ch_limite
            // 
            this.ch_limite.AutoSize = true;
            this.ch_limite.BackColor = System.Drawing.Color.Transparent;
            this.ch_limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_limite.Location = new System.Drawing.Point(435, 124);
            this.ch_limite.Name = "ch_limite";
            this.ch_limite.Size = new System.Drawing.Size(106, 24);
            this.ch_limite.TabIndex = 13;
            this.ch_limite.Text = "Por Limites";
            this.ch_limite.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(609, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 505;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 452);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ch_limite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUbicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rv_producto);
            this.Name = "FrmReporteProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReporteProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_producto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 comboBox011;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cbUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_desde;
        private Clases.TextBox01 txt_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ch_limite;
        private System.Windows.Forms.Button btnSalir;
    }
}