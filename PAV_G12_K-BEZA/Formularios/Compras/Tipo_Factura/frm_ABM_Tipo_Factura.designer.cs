namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    partial class frm_ABM_Tipo_Factura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.dgv_TipoFactura = new System.Windows.Forms.DataGridView();
            this.descripcion_tipo_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Tipo_Factura = new System.Windows.Forms.TextBox();
            this.lbl_Tipo_Factura = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(125, 78);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 22;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // dgv_TipoFactura
            // 
            this.dgv_TipoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TipoFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_tipo_factura,
            this.id_tipo_factura});
            this.dgv_TipoFactura.Location = new System.Drawing.Point(6, 138);
            this.dgv_TipoFactura.Name = "dgv_TipoFactura";
            this.dgv_TipoFactura.ReadOnly = true;
            this.dgv_TipoFactura.Size = new System.Drawing.Size(469, 150);
            this.dgv_TipoFactura.TabIndex = 17;
            this.dgv_TipoFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TipoFactura_CellClick);
            // 
            // descripcion_tipo_factura
            // 
            this.descripcion_tipo_factura.FillWeight = 200F;
            this.descripcion_tipo_factura.HeaderText = "Tipo Factura";
            this.descripcion_tipo_factura.Name = "descripcion_tipo_factura";
            this.descripcion_tipo_factura.ReadOnly = true;
            this.descripcion_tipo_factura.Width = 200;
            // 
            // id_tipo_factura
            // 
            this.id_tipo_factura.HeaderText = "id_tipo_factura";
            this.id_tipo_factura.Name = "id_tipo_factura";
            this.id_tipo_factura.ReadOnly = true;
            this.id_tipo_factura.Visible = false;
            // 
            // txt_Tipo_Factura
            // 
            this.txt_Tipo_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Tipo_Factura.Location = new System.Drawing.Point(125, 46);
            this.txt_Tipo_Factura.Name = "txt_Tipo_Factura";
            this.txt_Tipo_Factura.Size = new System.Drawing.Size(252, 26);
            this.txt_Tipo_Factura.TabIndex = 15;
            // 
            // lbl_Tipo_Factura
            // 
            this.lbl_Tipo_Factura.AutoSize = true;
            this.lbl_Tipo_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Tipo_Factura.Location = new System.Drawing.Point(21, 49);
            this.lbl_Tipo_Factura.Name = "lbl_Tipo_Factura";
            this.lbl_Tipo_Factura.Size = new System.Drawing.Size(98, 20);
            this.lbl_Tipo_Factura.TabIndex = 14;
            this.lbl_Tipo_Factura.Text = "Tipo Factura";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(428, 295);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(6, 294);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 45);
            this.btn_Agregar.TabIndex = 20;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(57, 294);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 45);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(110, 294);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 45);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(383, 46);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(85, 26);
            this.btn_Consultar.TabIndex = 16;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Tipo_Factura);
            this.groupBox1.Controls.Add(this.txt_Tipo_Factura);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.dgv_TipoFactura);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 352);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Tipos de Factura";
            // 
            // frm_ABM_Tipo_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ABM_Tipo_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo de Factura";
            this.Load += new System.EventHandler(this.frm_ABM_Tipo_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_TipoFactura;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.TextBox txt_Tipo_Factura;
        private System.Windows.Forms.Label lbl_Tipo_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_tipo_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_factura;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

