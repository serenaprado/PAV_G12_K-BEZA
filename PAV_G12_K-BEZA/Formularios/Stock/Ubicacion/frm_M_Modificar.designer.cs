namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
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
            this.lbl_ubicacionanterior = new System.Windows.Forms.Label();
            this.txt_ubicacionanterior = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.txt_UbicacionProducto = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ubicacionanterior
            // 
            this.lbl_ubicacionanterior.AutoSize = true;
            this.lbl_ubicacionanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ubicacionanterior.Location = new System.Drawing.Point(35, 58);
            this.lbl_ubicacionanterior.Name = "lbl_ubicacionanterior";
            this.lbl_ubicacionanterior.Size = new System.Drawing.Size(128, 20);
            this.lbl_ubicacionanterior.TabIndex = 2;
            this.lbl_ubicacionanterior.Text = "Ubicacion Actual";
            // 
            // txt_ubicacionanterior
            // 
            this.txt_ubicacionanterior.Enabled = false;
            this.txt_ubicacionanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ubicacionanterior.Location = new System.Drawing.Point(169, 55);
            this.txt_ubicacionanterior.Name = "txt_ubicacionanterior";
            this.txt_ubicacionanterior.Pp_MensajeError = null;
            this.txt_ubicacionanterior.Pp_NombreCampo = null;
            this.txt_ubicacionanterior.Pp_NombreTabla = null;
            this.txt_ubicacionanterior.Pp_Validable = false;
            this.txt_ubicacionanterior.Size = new System.Drawing.Size(161, 26);
            this.txt_ubicacionanterior.TabIndex = 3;
            this.txt_ubicacionanterior.TextChanged += new System.EventHandler(this.txt_ubicacionanterior_TextChanged);
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_modificar.Location = new System.Drawing.Point(35, 90);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(128, 20);
            this.lbl_modificar.TabIndex = 5;
            this.lbl_modificar.Text = "Ubicacion Nueva";
            // 
            // txt_UbicacionProducto
            // 
            this.txt_UbicacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UbicacionProducto.Location = new System.Drawing.Point(169, 87);
            this.txt_UbicacionProducto.Name = "txt_UbicacionProducto";
            this.txt_UbicacionProducto.Pp_MensajeError = null;
            this.txt_UbicacionProducto.Pp_NombreCampo = null;
            this.txt_UbicacionProducto.Pp_NombreTabla = null;
            this.txt_UbicacionProducto.Pp_Validable = false;
            this.txt_UbicacionProducto.Size = new System.Drawing.Size(161, 26);
            this.txt_UbicacionProducto.TabIndex = 6;
            this.txt_UbicacionProducto.TextChanged += new System.EventHandler(this.txt_UbicacionProducto_TextChanged);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(336, 35);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 46);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "MODIFICAR UBICACIÓN";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.Location = new System.Drawing.Point(336, 87);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 46);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_M_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 161);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_UbicacionProducto);
            this.Controls.Add(this.lbl_modificar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_ubicacionanterior);
            this.Controls.Add(this.lbl_ubicacionanterior);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_M_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Ubicacion de Producto";
            this.Load += new System.EventHandler(this.frm_M_Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ubicacionanterior;
        private Clases.TextBox01 txt_ubicacionanterior;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_modificar;
        private Clases.TextBox01 txt_UbicacionProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
    }
}