namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    partial class frm_AMB_Barrio
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
            this.lbl_Barrio = new System.Windows.Forms.Label();
            this.txt_Barrio = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dgv_Barrio = new System.Windows.Forms.DataGridView();
            this.descripcion_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Barrio
            // 
            this.lbl_Barrio.AutoSize = true;
            this.lbl_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Barrio.Location = new System.Drawing.Point(6, 32);
            this.lbl_Barrio.Name = "lbl_Barrio";
            this.lbl_Barrio.Size = new System.Drawing.Size(55, 20);
            this.lbl_Barrio.TabIndex = 0;
            this.lbl_Barrio.Text = "Barrio:";
            this.lbl_Barrio.Click += new System.EventHandler(this.lbl_Barrio_Click);
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Barrio.Location = new System.Drawing.Point(63, 29);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.Size = new System.Drawing.Size(244, 26);
            this.txt_Barrio.TabIndex = 1;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(313, 29);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(93, 26);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dgv_Barrio
            // 
            this.dgv_Barrio.AllowUserToAddRows = false;
            this.dgv_Barrio.AllowUserToDeleteRows = false;
            this.dgv_Barrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Barrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_barrio,
            this.id_barrio,
            this.id_localidad});
            this.dgv_Barrio.Location = new System.Drawing.Point(10, 109);
            this.dgv_Barrio.Name = "dgv_Barrio";
            this.dgv_Barrio.ReadOnly = true;
            this.dgv_Barrio.Size = new System.Drawing.Size(396, 144);
            this.dgv_Barrio.TabIndex = 3;
            this.dgv_Barrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // descripcion_barrio
            // 
            this.descripcion_barrio.HeaderText = "Barrio";
            this.descripcion_barrio.Name = "descripcion_barrio";
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "Id";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_barrio.Visible = false;
            // 
            // id_localidad
            // 
            this.id_localidad.HeaderText = "Localidad";
            this.id_localidad.Name = "id_localidad";
            this.id_localidad.Width = 200;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(116, 259);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 44);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(10, 259);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(63, 259);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 44);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(359, 259);
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
            this.chk_Todos.Location = new System.Drawing.Point(63, 61);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 13;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_Barrio);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.txt_Barrio);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.dgv_Barrio);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 309);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Barrios";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(364, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_AMB_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 333);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AMB_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrios";
            this.Load += new System.EventHandler(this.frm_AMB_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Barrio;
        private System.Windows.Forms.TextBox txt_Barrio;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridView dgv_Barrio;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad;
    }
}

