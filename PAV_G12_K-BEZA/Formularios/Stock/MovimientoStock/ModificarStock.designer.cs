namespace PAV_G12_K_BEZA.Formularios.Stock.MovimientoStock
{
    partial class frm_ModificarStock
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.cmb_Producto = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_Ubicacion = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(329, 121);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 50);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(329, 65);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(50, 50);
            this.btn_Aceptar.TabIndex = 21;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ubicacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 34);
            this.label11.TabIndex = 24;
            this.label11.Text = "MODIFICAR STOCK DE PRODUCTO";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(125, 141);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Pp_MensajeError = null;
            this.txtCantidad.Pp_NombreCampo = null;
            this.txtCantidad.Pp_NombreTabla = null;
            this.txtCantidad.Pp_Validable = false;
            this.txtCantidad.Size = new System.Drawing.Size(95, 26);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.Enabled = false;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(125, 103);
            this.cmb_Producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Pp_Coseleccion = false;
            this.cmb_Producto.Pp_descripcion = "descripcion";
            this.cmb_Producto.Pp_MensajeError = "Debe Ingresar un Producto";
            this.cmb_Producto.Pp_NombreCampo = "descripcion";
            this.cmb_Producto.Pp_NombreTabla = "";
            this.cmb_Producto.Pp_Pk = "id_producto";
            this.cmb_Producto.Pp_tabla = "Producto";
            this.cmb_Producto.Pp_Validable = false;
            this.cmb_Producto.Size = new System.Drawing.Size(180, 28);
            this.cmb_Producto.TabIndex = 16;
            // 
            // cmb_Ubicacion
            // 
            this.cmb_Ubicacion.Enabled = false;
            this.cmb_Ubicacion.FormattingEnabled = true;
            this.cmb_Ubicacion.Location = new System.Drawing.Point(125, 65);
            this.cmb_Ubicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Ubicacion.Name = "cmb_Ubicacion";
            this.cmb_Ubicacion.Pp_Coseleccion = false;
            this.cmb_Ubicacion.Pp_descripcion = "descripcion_ubicacion";
            this.cmb_Ubicacion.Pp_MensajeError = "Debe Ingresar una Ubicacion";
            this.cmb_Ubicacion.Pp_NombreCampo = "descripcion_ubicacion";
            this.cmb_Ubicacion.Pp_NombreTabla = null;
            this.cmb_Ubicacion.Pp_Pk = "id_ubicacion";
            this.cmb_Ubicacion.Pp_tabla = "Ubicacion_Producto";
            this.cmb_Ubicacion.Pp_Validable = false;
            this.cmb_Ubicacion.Size = new System.Drawing.Size(180, 28);
            this.cmb_Ubicacion.TabIndex = 17;
            // 
            // frm_ModificarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 211);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.cmb_Ubicacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ModificarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarStock";
            this.Load += new System.EventHandler(this.frm_ModificarStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txtCantidad;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_Producto;
        private Clases.ComboBox01 cmb_Ubicacion;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label11;
    }
}