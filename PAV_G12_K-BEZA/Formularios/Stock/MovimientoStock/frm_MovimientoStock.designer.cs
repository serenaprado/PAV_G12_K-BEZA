namespace PAV_G12_K_BEZA.Formularios.Stock.MovimientoStock
{
    partial class frm_MovimientoStock
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_Stock = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.cmb_Producto = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_Ubicacion = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.dgv_Stock);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Aceptar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Producto);
            this.groupBox1.Controls.Add(this.cmb_Ubicacion);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(429, 443);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Stock";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(237, 103);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(101, 28);
            this.btn_Consultar.TabIndex = 14;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(63, 338);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(50, 50);
            this.btn_modificar.TabIndex = 12;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_Stock
            // 
            this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.descripcion_ubicacion,
            this.Cantidad,
            this.Id_Producto,
            this.id_ubicacion});
            this.dgv_Stock.Location = new System.Drawing.Point(7, 182);
            this.dgv_Stock.Name = "dgv_Stock";
            this.dgv_Stock.Size = new System.Drawing.Size(415, 150);
            this.dgv_Stock.TabIndex = 9;
            this.dgv_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Stock_CellContentClick);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Producto";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 170;
            // 
            // descripcion_ubicacion
            // 
            this.descripcion_ubicacion.HeaderText = "Ubicacion";
            this.descripcion_ubicacion.Name = "descripcion_ubicacion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "id_producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Visible = false;
            // 
            // id_ubicacion
            // 
            this.id_ubicacion.HeaderText = "id_ubicacion";
            this.id_ubicacion.Name = "id_ubicacion";
            this.id_ubicacion.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(372, 385);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(50, 50);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(7, 338);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(50, 50);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(158, 107);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(72, 24);
            this.chkTodos.TabIndex = 15;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(158, 29);
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
            this.cmb_Producto.TabIndex = 1;
            // 
            // cmb_Ubicacion
            // 
            this.cmb_Ubicacion.FormattingEnabled = true;
            this.cmb_Ubicacion.Location = new System.Drawing.Point(158, 70);
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
            this.cmb_Ubicacion.TabIndex = 2;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(371, 127);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(51, 49);
            this.btn_Limpiar.TabIndex = 16;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_MovimientoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 474);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MovimientoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Productos";
            this.Load += new System.EventHandler(this.frm_MovimientoStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Clases.ComboBox01 cmb_Producto;
        private Clases.ComboBox01 cmb_Ubicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridView dgv_Stock;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ubicacion;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}