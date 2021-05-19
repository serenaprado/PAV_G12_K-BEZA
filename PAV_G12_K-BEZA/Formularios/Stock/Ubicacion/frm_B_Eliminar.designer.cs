namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
{
    partial class frm_B_Eliminar
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
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.txt_UbicacionProducto = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Eliminar.Location = new System.Drawing.Point(18, 69);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(152, 20);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Ubicacion a Eliminar";
            // 
            // txt_UbicacionProducto
            // 
            this.txt_UbicacionProducto.Enabled = false;
            this.txt_UbicacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UbicacionProducto.Location = new System.Drawing.Point(177, 66);
            this.txt_UbicacionProducto.Name = "txt_UbicacionProducto";
            this.txt_UbicacionProducto.Pp_MensajeError = null;
            this.txt_UbicacionProducto.Pp_NombreCampo = null;
            this.txt_UbicacionProducto.Pp_NombreTabla = null;
            this.txt_UbicacionProducto.Pp_Validable = false;
            this.txt_UbicacionProducto.Size = new System.Drawing.Size(161, 26);
            this.txt_UbicacionProducto.TabIndex = 3;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(344, 33);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 46);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.Location = new System.Drawing.Point(344, 85);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 46);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "BORRAR UBICACIÓN";
            // 
            // frm_B_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 143);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_UbicacionProducto);
            this.Controls.Add(this.lbl_Eliminar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_B_Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Ubicacion de Producto";
            this.Load += new System.EventHandler(this.frm_B_Eliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Eliminar;
        private Clases.TextBox01 txt_UbicacionProducto;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
    }
}