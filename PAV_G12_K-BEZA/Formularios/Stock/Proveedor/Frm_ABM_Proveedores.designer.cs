namespace PAV_G12_K_BEZA.Formularios.Stock.Proveedor
{
    partial class Frm_ABM_Proveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_razonSocial = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grid_proveedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.btn_consulta_Click = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(300, 89);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_MensajeError = null;
            this.txt_apellido.Pp_NombreCampo = null;
            this.txt_apellido.Pp_NombreTabla = null;
            this.txt_apellido.Pp_Validable = false;
            this.txt_apellido.Size = new System.Drawing.Size(278, 26);
            this.txt_apellido.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_apellido, "Puede ingresar el apellido completo del contacto o solo una parte del mismo para " +
        "poder buscarlo");
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Location = new System.Drawing.Point(300, 53);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Pp_MensajeError = null;
            this.txt_razonSocial.Pp_NombreCampo = null;
            this.txt_razonSocial.Pp_NombreTabla = null;
            this.txt_razonSocial.Pp_Validable = false;
            this.txt_razonSocial.Size = new System.Drawing.Size(278, 26);
            this.txt_razonSocial.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_razonSocial, "Puede ingresar la razon social completa o una fraccion de la misma para poder bus" +
        "carla");
            // 
            // grid_proveedores
            // 
            this.grid_proveedores.AllowUserToAddRows = false;
            this.grid_proveedores.AllowUserToDeleteRows = false;
            this.grid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Barrio,
            this.id_proveedor});
            this.grid_proveedores.Location = new System.Drawing.Point(29, 165);
            this.grid_proveedores.Name = "grid_proveedores";
            this.grid_proveedores.ReadOnly = true;
            this.grid_proveedores.Size = new System.Drawing.Size(794, 182);
            this.grid_proveedores.TabIndex = 4;
            this.grid_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_proveedores_CellClick);
            this.grid_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Razon Social";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Calle";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nro";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "id_proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(300, 121);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(72, 24);
            this.chk_todos.TabIndex = 5;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // btn_consulta_Click
            // 
            this.btn_consulta_Click.Location = new System.Drawing.Point(584, 89);
            this.btn_consulta_Click.Name = "btn_consulta_Click";
            this.btn_consulta_Click.Size = new System.Drawing.Size(93, 26);
            this.btn_consulta_Click.TabIndex = 6;
            this.btn_consulta_Click.Text = "Consultar";
            this.btn_consulta_Click.UseVisualStyleBackColor = true;
            this.btn_consulta_Click.Click += new System.EventHandler(this.btn_consulta_Click_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(29, 369);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(54, 49);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(89, 369);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(54, 49);
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(149, 369);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(55, 49);
            this.btn_borrar.TabIndex = 8;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(772, 369);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(51, 49);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_borrar);
            this.groupBox1.Controls.Add(this.txt_razonSocial);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.grid_proveedores);
            this.groupBox1.Controls.Add(this.btn_consulta_Click);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 439);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Proveedores";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(772, 109);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(50, 47);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = " ";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Frm_ABM_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 463);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ABM_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Frm_ABM_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_razonSocial;
        private PAV_G12_K_BEZA.Clases.TextBox01 txt_apellido;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView grid_proveedores;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Button btn_consulta_Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}