namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
{
    partial class frm_UbicacionProducto
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
            this.lbl_UbicacionProducto = new System.Windows.Forms.Label();
            this.txt_UbicacionProducto = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.dgv_UbicacionProducto = new System.Windows.Forms.DataGridView();
            this.descripcion_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UbicacionProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UbicacionProducto
            // 
            this.lbl_UbicacionProducto.AutoSize = true;
            this.lbl_UbicacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_UbicacionProducto.Location = new System.Drawing.Point(30, 39);
            this.lbl_UbicacionProducto.Name = "lbl_UbicacionProducto";
            this.lbl_UbicacionProducto.Size = new System.Drawing.Size(147, 20);
            this.lbl_UbicacionProducto.TabIndex = 1;
            this.lbl_UbicacionProducto.Text = "Ubicacion Producto";
            this.lbl_UbicacionProducto.Click += new System.EventHandler(this.lbl_UbicacionProducto_Click);
            // 
            // txt_UbicacionProducto
            // 
            this.txt_UbicacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_UbicacionProducto.Location = new System.Drawing.Point(183, 36);
            this.txt_UbicacionProducto.Name = "txt_UbicacionProducto";
            this.txt_UbicacionProducto.Size = new System.Drawing.Size(183, 26);
            this.txt_UbicacionProducto.TabIndex = 2;
            this.txt_UbicacionProducto.TextChanged += new System.EventHandler(this.txt_UbicacionProducto_TextChanged);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(372, 36);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(88, 26);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(183, 68);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 14;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            this.chk_Todos.CheckedChanged += new System.EventHandler(this.chk_Todos_CheckedChanged);
            // 
            // dgv_UbicacionProducto
            // 
            this.dgv_UbicacionProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UbicacionProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_ubicacion,
            this.id_ubicacion});
            this.dgv_UbicacionProducto.Location = new System.Drawing.Point(34, 117);
            this.dgv_UbicacionProducto.Name = "dgv_UbicacionProducto";
            this.dgv_UbicacionProducto.ReadOnly = true;
            this.dgv_UbicacionProducto.Size = new System.Drawing.Size(426, 150);
            this.dgv_UbicacionProducto.TabIndex = 15;
            this.dgv_UbicacionProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UbicacionProducto_CellContentClick_1);
            // 
            // descripcion_ubicacion
            // 
            this.descripcion_ubicacion.HeaderText = "Nombre";
            this.descripcion_ubicacion.Name = "descripcion_ubicacion";
            this.descripcion_ubicacion.ReadOnly = true;
            this.descripcion_ubicacion.Width = 200;
            // 
            // id_ubicacion
            // 
            this.id_ubicacion.HeaderText = "id_ubicacion";
            this.id_ubicacion.Name = "id_ubicacion";
            this.id_ubicacion.ReadOnly = true;
            this.id_ubicacion.Visible = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(34, 273);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 42);
            this.btn_Agregar.TabIndex = 16;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(87, 273);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 42);
            this.btn_Modificar.TabIndex = 17;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(140, 271);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 44);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(413, 271);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.lbl_UbicacionProducto);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.txt_UbicacionProducto);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.dgv_UbicacionProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 338);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Ubicaciones";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(410, 68);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(50, 43);
            this.btn_Limpiar.TabIndex = 24;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_UbicacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 362);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UbicacionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion Producto";
            this.Load += new System.EventHandler(this.frm_UbicacionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UbicacionProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_UbicacionProducto;
        private System.Windows.Forms.TextBox txt_UbicacionProducto;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.DataGridView dgv_UbicacionProducto;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ubicacion;
    }
}