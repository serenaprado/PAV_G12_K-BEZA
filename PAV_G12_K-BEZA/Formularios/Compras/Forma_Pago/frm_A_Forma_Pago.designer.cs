namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
    partial class frm_A_Forma_Pago
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
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Forma_Pago = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Agregar.Location = new System.Drawing.Point(31, 66);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(183, 20);
            this.lbl_Agregar.TabIndex = 14;
            this.lbl_Agregar.Text = "Forma de Pago Agregar:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(392, 79);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 17;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Forma_Pago
            // 
            this.txt_Forma_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Forma_Pago.Location = new System.Drawing.Point(220, 63);
            this.txt_Forma_Pago.Name = "txt_Forma_Pago";
            this.txt_Forma_Pago.Pp_MensajeError = null;
            this.txt_Forma_Pago.Pp_NombreCampo = null;
            this.txt_Forma_Pago.Pp_NombreTabla = null;
            this.txt_Forma_Pago.Pp_Validable = false;
            this.txt_Forma_Pago.Size = new System.Drawing.Size(166, 26);
            this.txt_Forma_Pago.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 34);
            this.label5.TabIndex = 32;
            this.label5.Text = "NUEVA FORMA DE PAGO";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(392, 29);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 15;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // frm_A_Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 150);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Forma_Pago);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_Forma_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Forma de Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Agregar;
        private Clases.TextBox01 txt_Forma_Pago;
        private System.Windows.Forms.Label label5;
    }
}