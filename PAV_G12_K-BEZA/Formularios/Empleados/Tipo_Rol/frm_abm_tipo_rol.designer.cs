namespace PAV_G12_K_BEZA.Formularios.Empleados.Tipo_Rol
{
    partial class frm_abm_tipo_rol
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
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txtRol = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar_rol = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.dGV_Rol = new System.Windows.Forms.DataGridView();
            this.descripcion_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Rol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_borrar);
            this.groupBox1.Controls.Add(this.btn_agregar_rol);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_cargar);
            this.groupBox1.Controls.Add(this.dGV_Rol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Roles de Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Todos.Location = new System.Drawing.Point(121, 80);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 17;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(333, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.Location = new System.Drawing.Point(326, 296);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 40);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txtRol
            // 
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(121, 48);
            this.txtRol.Name = "txtRol";
            this.txtRol.Pp_MensajeError = "No debe ser vacio";
            this.txtRol.Pp_NombreCampo = null;
            this.txtRol.Pp_NombreTabla = null;
            this.txtRol.Pp_Validable = true;
            this.txtRol.Size = new System.Drawing.Size(124, 26);
            this.txtRol.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rol:";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(121, 296);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(43, 40);
            this.btn_borrar.TabIndex = 5;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_agregar_rol
            // 
            this.btn_agregar_rol.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_agregar_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_rol.Location = new System.Drawing.Point(23, 296);
            this.btn_agregar_rol.Name = "btn_agregar_rol";
            this.btn_agregar_rol.Size = new System.Drawing.Size(43, 40);
            this.btn_agregar_rol.TabIndex = 3;
            this.btn_agregar_rol.UseVisualStyleBackColor = true;
            this.btn_agregar_rol.Click += new System.EventHandler(this.btn_agregar_rol_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(72, 296);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(43, 40);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(251, 48);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(87, 26);
            this.btn_cargar.TabIndex = 1;
            this.btn_cargar.Text = "Consultar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_Rol
            // 
            this.dGV_Rol.AllowUserToAddRows = false;
            this.dGV_Rol.AllowUserToDeleteRows = false;
            this.dGV_Rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Rol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_rol,
            this.id_rol});
            this.dGV_Rol.Location = new System.Drawing.Point(23, 128);
            this.dGV_Rol.Name = "dGV_Rol";
            this.dGV_Rol.ReadOnly = true;
            this.dGV_Rol.Size = new System.Drawing.Size(352, 150);
            this.dGV_Rol.TabIndex = 2;
            this.dGV_Rol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Rol_CellContentClick);
            // 
            // descripcion_rol
            // 
            this.descripcion_rol.HeaderText = "Descripción";
            this.descripcion_rol.Name = "descripcion_rol";
            this.descripcion_rol.ReadOnly = true;
            this.descripcion_rol.Width = 200;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "id_rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            this.id_rol.Width = 80;
            // 
            // frm_abm_tipo_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_abm_tipo_rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Rol";
            this.Load += new System.EventHandler(this.frm_abm_tipo_rol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Rol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_Rol;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_agregar_rol;
        private Clases.TextBox01 txtRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
    }
}