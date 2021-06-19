namespace PAV_G12_K_BEZA.Formularios.Reportes.CompraMayorA
{
    partial class ListadoVentasMayorA
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
            this.rpt_ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_monto = new System.Windows.Forms.MaskedTextBox();
            this.txt_fin = new System.Windows.Forms.MaskedTextBox();
            this.txt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbt_Menor = new System.Windows.Forms.RadioButton();
            this.rbt_Mayor = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpt_ventas
            // 
            this.rpt_ventas.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Listados.ListadoVentasMayor.rdlc";
            this.rpt_ventas.Location = new System.Drawing.Point(18, 229);
            this.rpt_ventas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpt_ventas.Name = "rpt_ventas";
            this.rpt_ventas.ServerReport.BearerToken = null;
            this.rpt_ventas.Size = new System.Drawing.Size(818, 330);
            this.rpt_ventas.TabIndex = 0;
            this.rpt_ventas.Load += new System.EventHandler(this.rpt_ventas_Load);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(724, 184);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(112, 35);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "Calcular";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(69, 66);
            this.txt_monto.Mask = "999999";
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 26);
            this.txt_monto.TabIndex = 2;
            // 
            // txt_fin
            // 
            this.txt_fin.Location = new System.Drawing.Point(578, 66);
            this.txt_fin.Mask = "00/00/0000";
            this.txt_fin.Name = "txt_fin";
            this.txt_fin.Size = new System.Drawing.Size(100, 26);
            this.txt_fin.TabIndex = 2;
            this.txt_fin.ValidatingType = typeof(System.DateTime);
            // 
            // txt_inicio
            // 
            this.txt_inicio.Location = new System.Drawing.Point(347, 66);
            this.txt_inicio.Mask = "00/00/0000";
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(100, 26);
            this.txt_inicio.TabIndex = 2;
            this.txt_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(476, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(343, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "dd/mm/aaaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(581, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "dd/mm/aaaa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 34);
            this.label8.TabIndex = 3;
            this.label8.Text = "Reporte de totales mayores o menores";
            // 
            // rbt_Menor
            // 
            this.rbt_Menor.AutoSize = true;
            this.rbt_Menor.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Menor.Location = new System.Drawing.Point(69, 117);
            this.rbt_Menor.Name = "rbt_Menor";
            this.rbt_Menor.Size = new System.Drawing.Size(121, 24);
            this.rbt_Menor.TabIndex = 4;
            this.rbt_Menor.TabStop = true;
            this.rbt_Menor.Text = "Monto Menor";
            this.rbt_Menor.UseVisualStyleBackColor = false;
            // 
            // rbt_Mayor
            // 
            this.rbt_Mayor.AutoSize = true;
            this.rbt_Mayor.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Mayor.Location = new System.Drawing.Point(69, 145);
            this.rbt_Mayor.Name = "rbt_Mayor";
            this.rbt_Mayor.Size = new System.Drawing.Size(119, 24);
            this.rbt_Mayor.TabIndex = 4;
            this.rbt_Mayor.TabStop = true;
            this.rbt_Mayor.Text = "Monto Mayor";
            this.rbt_Mayor.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(794, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 504;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListadoVentasMayorA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 611);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbt_Mayor);
            this.Controls.Add(this.rbt_Menor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inicio);
            this.Controls.Add(this.txt_fin);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.rpt_ventas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListadoVentasMayorA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ventas Mayor o Menor";
            this.Load += new System.EventHandler(this.ListadoVentasMayorA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_ventas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.MaskedTextBox txt_monto;
        private System.Windows.Forms.MaskedTextBox txt_fin;
        private System.Windows.Forms.MaskedTextBox txt_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbt_Menor;
        private System.Windows.Forms.RadioButton rbt_Mayor;
        private System.Windows.Forms.Button btnSalir;
    }
}