namespace PAV_G12_K_BEZA.Formularios.Reportes.StockMenor
{
    partial class Frm_stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maximo = new System.Windows.Forms.MaskedTextBox();
            this.txt_minimo = new System.Windows.Forms.MaskedTextBox();
            this.rpv_stock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_maximo);
            this.groupBox1.Controls.Add(this.txt_minimo);
            this.groupBox1.Controls.Add(this.rpv_stock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_reportar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(718, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 504;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(356, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad mayor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad menor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_maximo
            // 
            this.txt_maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maximo.Location = new System.Drawing.Point(486, 64);
            this.txt_maximo.Mask = "99999";
            this.txt_maximo.Name = "txt_maximo";
            this.txt_maximo.Size = new System.Drawing.Size(100, 26);
            this.txt_maximo.TabIndex = 5;
            this.txt_maximo.ValidatingType = typeof(int);
            // 
            // txt_minimo
            // 
            this.txt_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minimo.Location = new System.Drawing.Point(244, 64);
            this.txt_minimo.Mask = "99999";
            this.txt_minimo.Name = "txt_minimo";
            this.txt_minimo.Size = new System.Drawing.Size(100, 26);
            this.txt_minimo.TabIndex = 4;
            this.txt_minimo.ValidatingType = typeof(int);
            // 
            // rpv_stock
            // 
            this.rpv_stock.ForeColor = System.Drawing.Color.Black;
            this.rpv_stock.Location = new System.Drawing.Point(12, 140);
            this.rpv_stock.Name = "rpv_stock";
            this.rpv_stock.ServerReport.BearerToken = null;
            this.rpv_stock.Size = new System.Drawing.Size(748, 298);
            this.rpv_stock.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de stock";
            // 
            // btn_reportar
            // 
            this.btn_reportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportar.ForeColor = System.Drawing.Color.Black;
            this.btn_reportar.Location = new System.Drawing.Point(624, 55);
            this.btn_reportar.Name = "btn_reportar";
            this.btn_reportar.Size = new System.Drawing.Size(103, 35);
            this.btn_reportar.TabIndex = 1;
            this.btn_reportar.Text = "Consultar";
            this.btn_reportar.UseVisualStyleBackColor = true;
            this.btn_reportar.Click += new System.EventHandler(this.btn_reportar_Click);
            // 
            // Frm_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Frm_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte stock";
            this.Load += new System.EventHandler(this.Frm_stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reportar;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_maximo;
        private System.Windows.Forms.MaskedTextBox txt_minimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}