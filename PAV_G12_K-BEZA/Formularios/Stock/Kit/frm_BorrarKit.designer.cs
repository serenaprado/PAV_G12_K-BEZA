namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    partial class frm_BorrarKit
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
            this.txt_Precio = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Descripcion = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Precio
            // 
            this.txt_Precio.Enabled = false;
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(164, 92);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Pp_MensajeError = "Debe Ingresar Precio";
            this.txt_Precio.Pp_NombreCampo = "precio";
            this.txt_Precio.Pp_NombreTabla = "Producto";
            this.txt_Precio.Pp_Validable = true;
            this.txt_Precio.Size = new System.Drawing.Size(195, 26);
            this.txt_Precio.TabIndex = 1;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(164, 57);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Pp_MensajeError = "Debe Ingresar Descripcion";
            this.txt_Descripcion.Pp_NombreCampo = "descripcion";
            this.txt_Descripcion.Pp_NombreTabla = "Producto";
            this.txt_Descripcion.Pp_Validable = true;
            this.txt_Descripcion.Size = new System.Drawing.Size(195, 26);
            this.txt_Descripcion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(365, 86);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(50, 50);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Location = new System.Drawing.Point(365, 30);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(50, 50);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 34);
            this.label11.TabIndex = 21;
            this.label11.Text = "BORRAR KIT";
            // 
            // frm_BorrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 165);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Descripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BorrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Baja de Kit";
            this.Load += new System.EventHandler(this.frm_BorrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_Precio;
        private Clases.TextBox01 txt_Descripcion;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label11;
    }
}