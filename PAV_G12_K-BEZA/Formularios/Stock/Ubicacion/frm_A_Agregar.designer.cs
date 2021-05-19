namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
{
    partial class frm_A_Agregar
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
            this.txt_UbicacionProducto = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_UbicacionProducto
            // 
            this.txt_UbicacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UbicacionProducto.Location = new System.Drawing.Point(171, 63);
            this.txt_UbicacionProducto.Name = "txt_UbicacionProducto";
            this.txt_UbicacionProducto.Pp_MensajeError = null;
            this.txt_UbicacionProducto.Pp_NombreCampo = null;
            this.txt_UbicacionProducto.Pp_NombreTabla = null;
            this.txt_UbicacionProducto.Pp_Validable = false;
            this.txt_UbicacionProducto.Size = new System.Drawing.Size(161, 26);
            this.txt_UbicacionProducto.TabIndex = 0;
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Agregar.Location = new System.Drawing.Point(14, 66);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(153, 20);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Ubicacion a Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "NUEVA UBICACIÓN";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.Location = new System.Drawing.Point(338, 77);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 46);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(338, 25);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 46);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // frm_A_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 149);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Agregar);
            this.Controls.Add(this.txt_UbicacionProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A_Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Ubicacion de Producto";
            this.Load += new System.EventHandler(this.frm_A_Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_UbicacionProducto;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
    }
}