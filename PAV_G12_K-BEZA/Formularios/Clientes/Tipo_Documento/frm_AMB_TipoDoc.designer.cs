namespace PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento
{
    partial class frm_AMB_TipoDoc
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
            this.lbl_Localidad = new System.Windows.Forms.Label();
            this.txt_tipodoc = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dgv_tipodoc = new System.Windows.Forms.DataGridView();
            this.descripcion_tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipodoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Localidad
            // 
            this.lbl_Localidad.AutoSize = true;
            this.lbl_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Localidad.Location = new System.Drawing.Point(25, 21);
            this.lbl_Localidad.Name = "lbl_Localidad";
            this.lbl_Localidad.Size = new System.Drawing.Size(126, 20);
            this.lbl_Localidad.TabIndex = 0;
            this.lbl_Localidad.Text = "Tipo Documento";
            this.lbl_Localidad.Click += new System.EventHandler(this.lbl_Localidad_Click);
            // 
            // txt_tipodoc
            // 
            this.txt_tipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_tipodoc.Location = new System.Drawing.Point(157, 18);
            this.txt_tipodoc.Name = "txt_tipodoc";
            this.txt_tipodoc.Size = new System.Drawing.Size(170, 26);
            this.txt_tipodoc.TabIndex = 1;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(333, 18);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(92, 26);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dgv_tipodoc
            // 
            this.dgv_tipodoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipodoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_tipodoc,
            this.id_tipodoc});
            this.dgv_tipodoc.Location = new System.Drawing.Point(78, 95);
            this.dgv_tipodoc.Name = "dgv_tipodoc";
            this.dgv_tipodoc.Size = new System.Drawing.Size(347, 144);
            this.dgv_tipodoc.TabIndex = 3;
            this.dgv_tipodoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // descripcion_tipodoc
            // 
            this.descripcion_tipodoc.HeaderText = "Tipo Documento";
            this.descripcion_tipodoc.Name = "descripcion_tipodoc";
            this.descripcion_tipodoc.Width = 200;
            // 
            // id_tipodoc
            // 
            this.id_tipodoc.HeaderText = "Id";
            this.id_tipodoc.Name = "id_tipodoc";
            this.id_tipodoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_tipodoc.Visible = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(454, 245);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Todos.Location = new System.Drawing.Point(157, 50);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 13;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(131, 245);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 44);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(78, 245);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(184, 244);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 44);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(383, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_AMB_TipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_Todos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_tipodoc);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.txt_tipodoc);
            this.Controls.Add(this.lbl_Localidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AMB_TipoDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Documento";
            this.Load += new System.EventHandler(this.frm_AMB_Localidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipodoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Localidad;
        private System.Windows.Forms.TextBox txt_tipodoc;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridView dgv_tipodoc;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipodoc;
    }
}

