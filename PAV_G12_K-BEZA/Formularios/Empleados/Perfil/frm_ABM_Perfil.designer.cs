namespace PAV_G12_K_BEZA.Formularios.Empleados.Perfil
{
    partial class frm_ABM_Perfil
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
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.txt_Perfil = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dgv_Perfil = new System.Windows.Forms.DataGridView();
            this.descripcion_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Perfil.Location = new System.Drawing.Point(61, 25);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(44, 20);
            this.lbl_Perfil.TabIndex = 0;
            this.lbl_Perfil.Text = "Perfil";
            this.lbl_Perfil.Click += new System.EventHandler(this.lbl_Perfil_Click);
            // 
            // txt_Perfil
            // 
            this.txt_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Perfil.Location = new System.Drawing.Point(111, 25);
            this.txt_Perfil.Name = "txt_Perfil";
            this.txt_Perfil.Size = new System.Drawing.Size(252, 26);
            this.txt_Perfil.TabIndex = 1;
            this.txt_Perfil.TextChanged += new System.EventHandler(this.txt_Perfil_TextChanged);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(369, 25);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(85, 26);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dgv_Perfil
            // 
            this.dgv_Perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Perfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_perfil,
            this.id_perfil});
            this.dgv_Perfil.Location = new System.Drawing.Point(65, 101);
            this.dgv_Perfil.Name = "dgv_Perfil";
            this.dgv_Perfil.ReadOnly = true;
            this.dgv_Perfil.Size = new System.Drawing.Size(389, 150);
            this.dgv_Perfil.TabIndex = 3;
            this.dgv_Perfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Perfil_CellContentClick);
            // 
            // descripcion_perfil
            // 
            this.descripcion_perfil.HeaderText = "Nombre";
            this.descripcion_perfil.Name = "descripcion_perfil";
            this.descripcion_perfil.ReadOnly = true;
            // 
            // id_perfil
            // 
            this.id_perfil.HeaderText = "id_perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            this.id_perfil.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(171, 257);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 45);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(118, 257);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 45);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(65, 257);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 45);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(466, 257);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Todos.Location = new System.Drawing.Point(111, 61);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 13;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(412, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ABM_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_Todos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Perfil);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.txt_Perfil);
            this.Controls.Add(this.lbl_Perfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ABM_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Perfil;
        private System.Windows.Forms.TextBox txt_Perfil;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridView dgv_Perfil;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Button button1;
    }
}

