namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    partial class frm_M_Modificar
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
            this.lbl_tipo_factura_anterior = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txt_Tipo_Factura = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_tipo_factura_anterior = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tipo_factura_anterior
            // 
            this.lbl_tipo_factura_anterior.AutoSize = true;
            this.lbl_tipo_factura_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_tipo_factura_anterior.Location = new System.Drawing.Point(14, 64);
            this.lbl_tipo_factura_anterior.Name = "lbl_tipo_factura_anterior";
            this.lbl_tipo_factura_anterior.Size = new System.Drawing.Size(169, 20);
            this.lbl_tipo_factura_anterior.TabIndex = 7;
            this.lbl_tipo_factura_anterior.Text = "Tipo de Factura Actual";
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_modificar.Location = new System.Drawing.Point(12, 96);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(169, 20);
            this.lbl_modificar.TabIndex = 5;
            this.lbl_modificar.Text = "Tipo de Factura Nueva";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(423, 93);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 50);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txt_Tipo_Factura
            // 
            this.txt_Tipo_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tipo_Factura.Location = new System.Drawing.Point(187, 93);
            this.txt_Tipo_Factura.Name = "txt_Tipo_Factura";
            this.txt_Tipo_Factura.Pp_MensajeError = null;
            this.txt_Tipo_Factura.Pp_NombreCampo = null;
            this.txt_Tipo_Factura.Pp_NombreTabla = null;
            this.txt_Tipo_Factura.Pp_Validable = false;
            this.txt_Tipo_Factura.Size = new System.Drawing.Size(230, 26);
            this.txt_Tipo_Factura.TabIndex = 8;
            // 
            // txt_tipo_factura_anterior
            // 
            this.txt_tipo_factura_anterior.Enabled = false;
            this.txt_tipo_factura_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_factura_anterior.Location = new System.Drawing.Point(187, 61);
            this.txt_tipo_factura_anterior.Name = "txt_tipo_factura_anterior";
            this.txt_tipo_factura_anterior.Pp_MensajeError = null;
            this.txt_tipo_factura_anterior.Pp_NombreCampo = null;
            this.txt_tipo_factura_anterior.Pp_NombreTabla = null;
            this.txt_tipo_factura_anterior.Pp_Validable = false;
            this.txt_tipo_factura_anterior.Size = new System.Drawing.Size(230, 26);
            this.txt_tipo_factura_anterior.TabIndex = 0;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(423, 37);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(52, 50);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "MODIFICAR TIPO DE FACTURA";
            // 
            // frm_M_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 181);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txt_Tipo_Factura);
            this.Controls.Add(this.lbl_tipo_factura_anterior);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_modificar);
            this.Controls.Add(this.txt_tipo_factura_anterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_M_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Tipo de Factura";
            this.Load += new System.EventHandler(this.frm_M_Modificar_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_tipo_factura_anterior;
        private System.Windows.Forms.Label lbl_tipo_factura_anterior;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_modificar;
        private Clases.TextBox01 txt_Tipo_Factura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
    }
}