namespace PAV_G12_K_BEZA.Formularios.Reportes.Reporte_empleado
{
    partial class frm_reportelegajo
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
            this.rpv_legajo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_Minimo = new System.Windows.Forms.TextBox();
            this.txt_Maximo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpv_legajo
            // 
            this.rpv_legajo.DocumentMapWidth = 40;
            this.rpv_legajo.Location = new System.Drawing.Point(36, 115);
            this.rpv_legajo.Name = "rpv_legajo";
            this.rpv_legajo.ServerReport.BearerToken = null;
            this.rpv_legajo.Size = new System.Drawing.Size(482, 244);
            this.rpv_legajo.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(410, 52);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(108, 35);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // txt_Minimo
            // 
            this.txt_Minimo.Location = new System.Drawing.Point(94, 56);
            this.txt_Minimo.Name = "txt_Minimo";
            this.txt_Minimo.Size = new System.Drawing.Size(73, 26);
            this.txt_Minimo.TabIndex = 2;
            // 
            // txt_Maximo
            // 
            this.txt_Maximo.Location = new System.Drawing.Point(272, 56);
            this.txt_Maximo.Name = "txt_Maximo";
            this.txt_Maximo.Size = new System.Drawing.Size(73, 26);
            this.txt_Maximo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Minimo);
            this.groupBox1.Controls.Add(this.rpv_legajo);
            this.groupBox1.Controls.Add(this.txt_Maximo);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Empleados según su legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // frm_reportelegajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_reportelegajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_reportelegajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_legajo;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox txt_Minimo;
        private System.Windows.Forms.TextBox txt_Maximo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}