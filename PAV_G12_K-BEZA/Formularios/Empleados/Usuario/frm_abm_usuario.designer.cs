namespace PAV_G12_K_BEZA.Formularios.Empleados.Usuario
{
    partial class frm_abm_usuario
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.cmb_perfiles = new System.Windows.Forms.ComboBox();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Controls.Add(this.btn_borrar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.grid_usuarios);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.cmb_perfiles);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(692, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Usuarios";
            // 
            // btn_alta
            // 
            this.btn_alta.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.Location = new System.Drawing.Point(7, 372);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(49, 46);
            this.btn_alta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_alta, "Dar de alta a un usuario.");
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(117, 372);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(49, 46);
            this.btn_borrar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_borrar, "Eliminar un usuario.");
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(62, 372);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(49, 46);
            this.btn_modificar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_modificar, "Modificar los datos de un usuario existente.");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(631, 374);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(54, 44);
            this.btn_salir.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_salir, "Salir.");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.num_usuario});
            this.grid_usuarios.Location = new System.Drawing.Point(7, 172);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.Size = new System.Drawing.Size(678, 194);
            this.grid_usuarios.TabIndex = 7;
            this.grid_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellClick);
            this.grid_usuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Usuario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Legajo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID Perfil";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 95;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre Perfil";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // num_usuario
            // 
            this.num_usuario.HeaderText = "num_usuario";
            this.num_usuario.Name = "num_usuario";
            this.num_usuario.ReadOnly = true;
            this.num_usuario.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(631, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 47);
            this.button1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button1, "Oprima para quitar la selección.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(451, 74);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(106, 28);
            this.btn_consultar.TabIndex = 4;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(217, 108);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(72, 24);
            this.chk_todos.TabIndex = 3;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(217, 74);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Size = new System.Drawing.Size(228, 28);
            this.cmb_perfiles.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmb_perfiles, "Seleccione el perfil del usuario.");
            // 
            // txt_patron
            // 
            this.txt_patron.Location = new System.Drawing.Point(217, 39);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(228, 26);
            this.txt_patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_patron, "Ingrese el nombre del usuario.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perfiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 350;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frm_abm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 470);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_abm_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.frm_abm_usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.ComboBox cmb_perfiles;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6
            ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_usuario;
    }
}