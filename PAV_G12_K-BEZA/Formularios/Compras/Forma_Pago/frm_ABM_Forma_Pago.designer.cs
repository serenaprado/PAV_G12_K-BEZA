namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
    partial class frm_ABM_Forma_Pago
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
            this.dgv_Forma_Pago = new System.Windows.Forms.DataGridView();
            this.descripcion_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Forma_Pago = new System.Windows.Forms.TextBox();
            this.lbl_Forma_Pago = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forma_Pago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Todos.Location = new System.Drawing.Point(130, 82);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 27;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // dgv_Forma_Pago
            // 
            this.dgv_Forma_Pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Forma_Pago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion_forma_pago,
            this.id_forma_pago});
            this.dgv_Forma_Pago.Location = new System.Drawing.Point(6, 148);
            this.dgv_Forma_Pago.Name = "dgv_Forma_Pago";
            this.dgv_Forma_Pago.ReadOnly = true;
            this.dgv_Forma_Pago.Size = new System.Drawing.Size(394, 144);
            this.dgv_Forma_Pago.TabIndex = 17;
            this.dgv_Forma_Pago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Forma_Pago_CellClick);
            // 
            // descripcion_forma_pago
            // 
            this.descripcion_forma_pago.HeaderText = "Forma de Pago";
            this.descripcion_forma_pago.Name = "descripcion_forma_pago";
            this.descripcion_forma_pago.ReadOnly = true;
            this.descripcion_forma_pago.Width = 150;
            // 
            // id_forma_pago
            // 
            this.id_forma_pago.HeaderText = "id_forma_pago";
            this.id_forma_pago.Name = "id_forma_pago";
            this.id_forma_pago.ReadOnly = true;
            this.id_forma_pago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_forma_pago.Visible = false;
            // 
            // txt_Forma_Pago
            // 
            this.txt_Forma_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Forma_Pago.Location = new System.Drawing.Point(130, 50);
            this.txt_Forma_Pago.Name = "txt_Forma_Pago";
            this.txt_Forma_Pago.Size = new System.Drawing.Size(170, 26);
            this.txt_Forma_Pago.TabIndex = 15;
            // 
            // lbl_Forma_Pago
            // 
            this.lbl_Forma_Pago.AutoSize = true;
            this.lbl_Forma_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Forma_Pago.Location = new System.Drawing.Point(6, 53);
            this.lbl_Forma_Pago.Name = "lbl_Forma_Pago";
            this.lbl_Forma_Pago.Size = new System.Drawing.Size(118, 20);
            this.lbl_Forma_Pago.TabIndex = 14;
            this.lbl_Forma_Pago.Text = "Forma de Pago";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Salir.Location = new System.Drawing.Point(353, 298);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 44);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Modificar.Location = new System.Drawing.Point(59, 298);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(47, 44);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Agregar.Location = new System.Drawing.Point(6, 298);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(47, 44);
            this.btn_Agregar.TabIndex = 19;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.Location = new System.Drawing.Point(112, 298);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(47, 44);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Consultar.Location = new System.Drawing.Point(309, 50);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(91, 26);
            this.btn_Consultar.TabIndex = 16;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.lbl_Forma_Pago);
            this.groupBox1.Controls.Add(this.chk_Todos);
            this.groupBox1.Controls.Add(this.txt_Forma_Pago);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.dgv_Forma_Pago);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 348);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Formas de Pago";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(346, 93);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(54, 49);
            this.btn_Limpiar.TabIndex = 29;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_ABM_Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 372);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ABM_Forma_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forma de Pago";
            this.Load += new System.EventHandler(this.frm_ABM_Forma_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forma_Pago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Forma_Pago;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.TextBox txt_Forma_Pago;
        private System.Windows.Forms.Label lbl_Forma_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma_pago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

