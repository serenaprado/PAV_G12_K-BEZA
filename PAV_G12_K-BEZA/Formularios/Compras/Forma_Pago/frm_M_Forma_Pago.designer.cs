namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
    partial class frm_M_Forma_Pago
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Forma_Pago = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Forma_Pago_Vieja = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nueva Forma de Pago:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(413, 95);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 24;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Modificar.Location = new System.Drawing.Point(25, 66);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(203, 20);
            this.lbl_Modificar.TabIndex = 21;
            this.lbl_Modificar.Text = "Forma de Pago a Modificar:";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(413, 45);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 44);
            this.btn_Modificar.TabIndex = 22;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Forma_Pago
            // 
            this.txt_Forma_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forma_Pago.Location = new System.Drawing.Point(234, 95);
            this.txt_Forma_Pago.Name = "txt_Forma_Pago";
            this.txt_Forma_Pago.Pp_MensajeError = null;
            this.txt_Forma_Pago.Pp_NombreCampo = null;
            this.txt_Forma_Pago.Pp_NombreTabla = null;
            this.txt_Forma_Pago.Pp_Validable = false;
            this.txt_Forma_Pago.Size = new System.Drawing.Size(173, 26);
            this.txt_Forma_Pago.TabIndex = 28;
            // 
            // txt_Forma_Pago_Vieja
            // 
            this.txt_Forma_Pago_Vieja.Enabled = false;
            this.txt_Forma_Pago_Vieja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forma_Pago_Vieja.Location = new System.Drawing.Point(234, 63);
            this.txt_Forma_Pago_Vieja.Name = "txt_Forma_Pago_Vieja";
            this.txt_Forma_Pago_Vieja.Pp_MensajeError = null;
            this.txt_Forma_Pago_Vieja.Pp_NombreCampo = null;
            this.txt_Forma_Pago_Vieja.Pp_NombreTabla = null;
            this.txt_Forma_Pago_Vieja.Pp_Validable = false;
            this.txt_Forma_Pago_Vieja.Size = new System.Drawing.Size(173, 26);
            this.txt_Forma_Pago_Vieja.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "MODIFICAR FORMA DE PAGO";
            // 
            // frm_M_Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 188);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Forma_Pago_Vieja);
            this.Controls.Add(this.txt_Forma_Pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_M_Forma_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Forma de Pago";
            this.Load += new System.EventHandler(this.frm_M_Forma_Pago_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Modificar;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_Forma_Pago;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_Forma_Pago_Vieja;
        private System.Windows.Forms.Label label5;
    }
}