namespace PAV_G12_K_BEZA.Formularios.Stock.Tipo_Producto
{
    partial class frm_ABM_Tipo_Producto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_Tipo = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.grid_Tipos = new System.Windows.Forms.DataGridView();
            this.id_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Insertar = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_altaTipo = new System.Windows.Forms.Label();
            this.btn_Escape = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ModTipo = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_ModAceptar = new System.Windows.Forms.Button();
            this.lbl_ModTipo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tipos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.txt_Tipo);
            this.groupBox1.Controls.Add(this.btn_Insertar);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Editar);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.grid_Tipos);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(432, 449);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Tipo de Producto";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Location = new System.Drawing.Point(127, 388);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(52, 47);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(145, 47);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Pp_MensajeError = null;
            this.txt_Tipo.Pp_NombreCampo = "";
            this.txt_Tipo.Pp_NombreTabla = "";
            this.txt_Tipo.Pp_Validable = true;
            this.txt_Tipo.Size = new System.Drawing.Size(267, 26);
            this.txt_Tipo.TabIndex = 7;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Insertar.Location = new System.Drawing.Point(11, 388);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(52, 47);
            this.btn_Insertar.TabIndex = 9;
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(324, 79);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(88, 24);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Editar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Editar.Location = new System.Drawing.Point(69, 388);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(52, 47);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(362, 114);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(50, 47);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // grid_Tipos
            // 
            this.grid_Tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Tipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipo_producto,
            this.Column1});
            this.grid_Tipos.Location = new System.Drawing.Point(11, 174);
            this.grid_Tipos.Name = "grid_Tipos";
            this.grid_Tipos.Size = new System.Drawing.Size(401, 206);
            this.grid_Tipos.TabIndex = 6;
            this.grid_Tipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Tipos_CellClick);
            this.grid_Tipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Tipos_CellDoubleClick);
            // 
            // id_tipo_producto
            // 
            this.id_tipo_producto.HeaderText = "id_tipo_producto";
            this.id_tipo_producto.Name = "id_tipo_producto";
            this.id_tipo_producto.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo_Producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(145, 79);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 3;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Producto:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(987, 669);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 77);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = " ";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Insertar);
            this.groupBox2.Controls.Add(this.btn_Aceptar);
            this.groupBox2.Controls.Add(this.lbl_altaTipo);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(504, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(444, 179);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta Tipo Productos";
            this.groupBox2.Visible = false;
            // 
            // txt_Insertar
            // 
            this.txt_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Insertar.Location = new System.Drawing.Point(218, 60);
            this.txt_Insertar.Name = "txt_Insertar";
            this.txt_Insertar.Pp_MensajeError = "Debe Ingresar Descripcion";
            this.txt_Insertar.Pp_NombreCampo = "descripcion";
            this.txt_Insertar.Pp_NombreTabla = "";
            this.txt_Insertar.Pp_Validable = true;
            this.txt_Insertar.Size = new System.Drawing.Size(195, 26);
            this.txt_Insertar.TabIndex = 0;
            this.txt_Insertar.Visible = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(297, 96);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(50, 50);
            this.btn_Aceptar.TabIndex = 9;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Visible = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_altaTipo
            // 
            this.lbl_altaTipo.AutoSize = true;
            this.lbl_altaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altaTipo.Location = new System.Drawing.Point(26, 60);
            this.lbl_altaTipo.Name = "lbl_altaTipo";
            this.lbl_altaTipo.Size = new System.Drawing.Size(107, 20);
            this.lbl_altaTipo.TabIndex = 0;
            this.lbl_altaTipo.Text = "Tipo Producto";
            this.lbl_altaTipo.Visible = false;
            // 
            // btn_Escape
            // 
            this.btn_Escape.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Escape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Escape.Location = new System.Drawing.Point(898, 402);
            this.btn_Escape.Name = "btn_Escape";
            this.btn_Escape.Size = new System.Drawing.Size(50, 50);
            this.btn_Escape.TabIndex = 10;
            this.btn_Escape.UseVisualStyleBackColor = true;
            this.btn_Escape.Click += new System.EventHandler(this.btn_Escape_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txt_ModTipo);
            this.groupBox3.Controls.Add(this.btn_ModAceptar);
            this.groupBox3.Controls.Add(this.lbl_ModTipo);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(504, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(444, 179);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar Tipo Productos";
            this.groupBox3.Visible = false;
            // 
            // txt_ModTipo
            // 
            this.txt_ModTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModTipo.Location = new System.Drawing.Point(218, 60);
            this.txt_ModTipo.Name = "txt_ModTipo";
            this.txt_ModTipo.Pp_MensajeError = "Debe Ingresar Descripcion";
            this.txt_ModTipo.Pp_NombreCampo = "descripcion";
            this.txt_ModTipo.Pp_NombreTabla = "";
            this.txt_ModTipo.Pp_Validable = true;
            this.txt_ModTipo.Size = new System.Drawing.Size(195, 26);
            this.txt_ModTipo.TabIndex = 0;
            this.txt_ModTipo.Visible = false;
            // 
            // btn_ModAceptar
            // 
            this.btn_ModAceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_ModAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModAceptar.Location = new System.Drawing.Point(297, 96);
            this.btn_ModAceptar.Name = "btn_ModAceptar";
            this.btn_ModAceptar.Size = new System.Drawing.Size(50, 50);
            this.btn_ModAceptar.TabIndex = 9;
            this.btn_ModAceptar.UseVisualStyleBackColor = true;
            this.btn_ModAceptar.Visible = false;
            this.btn_ModAceptar.Click += new System.EventHandler(this.btn_ModAceptar_Click);
            // 
            // lbl_ModTipo
            // 
            this.lbl_ModTipo.AutoSize = true;
            this.lbl_ModTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModTipo.Location = new System.Drawing.Point(26, 60);
            this.lbl_ModTipo.Name = "lbl_ModTipo";
            this.lbl_ModTipo.Size = new System.Drawing.Size(107, 20);
            this.lbl_ModTipo.TabIndex = 0;
            this.lbl_ModTipo.Text = "Tipo Producto";
            this.lbl_ModTipo.Visible = false;
            // 
            // frm_ABM_Tipo_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Escape);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ABM_Tipo_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Productos";
            this.Load += new System.EventHandler(this.frm_ABM_Tipo_Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tipos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_Tipo;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DataGridView grid_Tipos;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.TextBox01 txt_Insertar;
        private System.Windows.Forms.Label lbl_altaTipo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_Escape;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.GroupBox groupBox3;
        private Clases.TextBox01 txt_ModTipo;
        private System.Windows.Forms.Button btn_ModAceptar;
        private System.Windows.Forms.Label lbl_ModTipo;
    }
}