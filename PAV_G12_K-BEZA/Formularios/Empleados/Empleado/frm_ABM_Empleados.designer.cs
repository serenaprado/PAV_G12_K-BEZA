namespace PAV_G12_K_BEZA.Formularios.Empleados.Empleado
{
    partial class frm_ABM_Empleados
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nro_documento = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Nombre = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_Apellido = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.grid_Empleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Insertar);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nro_documento);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.grid_Empleados);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(616, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Empleados";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Location = new System.Drawing.Point(78, 439);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(50, 50);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = " ";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Location = new System.Drawing.Point(134, 439);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(50, 50);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = " ";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Insertar.Location = new System.Drawing.Point(22, 439);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(50, 50);
            this.btn_Insertar.TabIndex = 1;
            this.btn_Insertar.Text = " ";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(559, 460);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(50, 46);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = " ";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nº Documento";
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(197, 111);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Pp_MensajeError = null;
            this.txt_nro_documento.Pp_NombreCampo = "nro_documento";
            this.txt_nro_documento.Pp_NombreTabla = "Empleado";
            this.txt_nro_documento.Pp_Validable = true;
            this.txt_nro_documento.Size = new System.Drawing.Size(255, 26);
            this.txt_nro_documento.TabIndex = 10;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(197, 35);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_MensajeError = null;
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = "Empleado";
            this.txt_Nombre.Pp_Validable = true;
            this.txt_Nombre.Size = new System.Drawing.Size(255, 26);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(197, 71);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Pp_MensajeError = null;
            this.txt_Apellido.Pp_NombreCampo = "Apellido";
            this.txt_Apellido.Pp_NombreTabla = "Empleado";
            this.txt_Apellido.Pp_Validable = true;
            this.txt_Apellido.Size = new System.Drawing.Size(255, 26);
            this.txt_Apellido.TabIndex = 7;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(467, 111);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(89, 26);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(536, 161);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(54, 49);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // grid_Empleados
            // 
            this.grid_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.tipo_documento,
            this.Nro_Documento,
            this.legajo_empleado});
            this.grid_Empleados.Location = new System.Drawing.Point(22, 216);
            this.grid_Empleados.Name = "grid_Empleados";
            this.grid_Empleados.Size = new System.Drawing.Size(568, 217);
            this.grid_Empleados.TabIndex = 6;
            this.grid_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Empleados_CellContentClick);
            this.grid_Empleados.DoubleClick += new System.EventHandler(this.grid_Empleados_DoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // tipo_documento
            // 
            this.tipo_documento.HeaderText = "Tipo_Dni";
            this.tipo_documento.Name = "tipo_documento";
            // 
            // Nro_Documento
            // 
            this.Nro_Documento.FillWeight = 200F;
            this.Nro_Documento.HeaderText = "Nro_Documento";
            this.Nro_Documento.Name = "Nro_Documento";
            this.Nro_Documento.Width = 200;
            // 
            // legajo_empleado
            // 
            this.legajo_empleado.HeaderText = "legajo_empleado";
            this.legajo_empleado.Name = "legajo_empleado";
            this.legajo_empleado.ReadOnly = true;
            this.legajo_empleado.Visible = false;
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(197, 143);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 3;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // frm_ABM_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 550);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ABM_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_ABM_Empleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_Empleados;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private Clases.TextBox01 txt_Apellido;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_nro_documento;
        private Clases.TextBox01 txt_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_empleado;
    }
}