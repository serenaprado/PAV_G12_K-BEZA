namespace PAV_G12_K_BEZA.Formularios.Clientes.Cliente
{
    partial class Frm_ABM_Clientes
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
            this.GridView_Client = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_consultar_cliente = new System.Windows.Forms.Button();
            this.checkBox_CLiente = new System.Windows.Forms.CheckBox();
            this.cmb_Box_tipo_doc = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.txt_num_doc = new System.Windows.Forms.TextBox();
            this.n_doc = new System.Windows.Forms.Label();
            this.t_doc = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btm_salida = new System.Windows.Forms.Button();
            this.btm_eliminar = new System.Windows.Forms.Button();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_alta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.GridView_Client);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_consultar_cliente);
            this.groupBox1.Controls.Add(this.checkBox_CLiente);
            this.groupBox1.Controls.Add(this.cmb_Box_tipo_doc);
            this.groupBox1.Controls.Add(this.txt_num_doc);
            this.groupBox1.Controls.Add(this.n_doc);
            this.groupBox1.Controls.Add(this.t_doc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GridView_Client
            // 
            this.GridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.GridView_Client.Location = new System.Drawing.Point(6, 186);
            this.GridView_Client.Name = "GridView_Client";
            this.GridView_Client.ReadOnly = true;
            this.GridView_Client.Size = new System.Drawing.Size(631, 185);
            this.GridView_Client.TabIndex = 7;
            this.GridView_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Client_CellClick);
            this.GridView_Client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Client_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Doc.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Documento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Nacimiento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sexo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Telefono";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mail";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Calle";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nro. Calle";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Id Barrio";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Limpiar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(595, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultar_cliente
            // 
            this.btn_consultar_cliente.Location = new System.Drawing.Point(453, 94);
            this.btn_consultar_cliente.Name = "btn_consultar_cliente";
            this.btn_consultar_cliente.Size = new System.Drawing.Size(80, 24);
            this.btn_consultar_cliente.TabIndex = 6;
            this.btn_consultar_cliente.Text = "Consultar";
            this.btn_consultar_cliente.UseVisualStyleBackColor = true;
            this.btn_consultar_cliente.Click += new System.EventHandler(this.btn_consultar_cliente_Click);
            // 
            // checkBox_CLiente
            // 
            this.checkBox_CLiente.AutoSize = true;
            this.checkBox_CLiente.Location = new System.Drawing.Point(237, 124);
            this.checkBox_CLiente.Name = "checkBox_CLiente";
            this.checkBox_CLiente.Size = new System.Drawing.Size(70, 22);
            this.checkBox_CLiente.TabIndex = 4;
            this.checkBox_CLiente.Text = "Todos";
            this.toolTip1.SetToolTip(this.checkBox_CLiente, "Mostrar todos los Clientes");
            this.checkBox_CLiente.UseVisualStyleBackColor = true;
            // 
            // cmb_Box_tipo_doc
            // 
            this.cmb_Box_tipo_doc.FormattingEnabled = true;
            this.cmb_Box_tipo_doc.Location = new System.Drawing.Point(237, 49);
            this.cmb_Box_tipo_doc.Name = "cmb_Box_tipo_doc";
            this.cmb_Box_tipo_doc.Pp_Coseleccion = false;
            this.cmb_Box_tipo_doc.Pp_descripcion = "descripcion_tipo_doc";
            this.cmb_Box_tipo_doc.Pp_MensajeError = null;
            this.cmb_Box_tipo_doc.Pp_NombreCampo = null;
            this.cmb_Box_tipo_doc.Pp_NombreTabla = null;
            this.cmb_Box_tipo_doc.Pp_Pk = "id_tipo_documento";
            this.cmb_Box_tipo_doc.Pp_tabla = "Tipo_Documento";
            this.cmb_Box_tipo_doc.Pp_Validable = false;
            this.cmb_Box_tipo_doc.Size = new System.Drawing.Size(210, 26);
            this.cmb_Box_tipo_doc.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmb_Box_tipo_doc, "Seleccionar un tipo de documento");
            // 
            // txt_num_doc
            // 
            this.txt_num_doc.Location = new System.Drawing.Point(237, 94);
            this.txt_num_doc.Name = "txt_num_doc";
            this.txt_num_doc.Size = new System.Drawing.Size(210, 24);
            this.txt_num_doc.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_num_doc, "Ingresar el numero de documento del cliente ");
            // 
            // n_doc
            // 
            this.n_doc.AutoSize = true;
            this.n_doc.Location = new System.Drawing.Point(79, 97);
            this.n_doc.Name = "n_doc";
            this.n_doc.Size = new System.Drawing.Size(144, 18);
            this.n_doc.TabIndex = 1;
            this.n_doc.Text = "Numero Documento";
            // 
            // t_doc
            // 
            this.t_doc.AutoSize = true;
            this.t_doc.Location = new System.Drawing.Point(105, 57);
            this.t_doc.Name = "t_doc";
            this.t_doc.Size = new System.Drawing.Size(119, 18);
            this.t_doc.TabIndex = 0;
            this.t_doc.Text = "Tipo Documento";
            // 
            // btm_salida
            // 
            this.btm_salida.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Salir;
            this.btm_salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_salida.Location = new System.Drawing.Point(605, 409);
            this.btm_salida.Name = "btm_salida";
            this.btm_salida.Size = new System.Drawing.Size(50, 45);
            this.btm_salida.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btm_salida, "Salir");
            this.btm_salida.UseVisualStyleBackColor = true;
            this.btm_salida.Click += new System.EventHandler(this.btm_salida_Click);
            // 
            // btm_eliminar
            // 
            this.btm_eliminar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Baja;
            this.btm_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_eliminar.Location = new System.Drawing.Point(146, 409);
            this.btm_eliminar.Name = "btm_eliminar";
            this.btm_eliminar.Size = new System.Drawing.Size(50, 46);
            this.btm_eliminar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btm_eliminar, "Eliminar un cliente seleccionado");
            this.btm_eliminar.UseVisualStyleBackColor = true;
            this.btm_eliminar.Click += new System.EventHandler(this.btm_eliminar_Click);
            // 
            // btm_modificar
            // 
            this.btm_modificar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Modifica;
            this.btm_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_modificar.Location = new System.Drawing.Point(90, 409);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(50, 46);
            this.btm_modificar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btm_modificar, "Modificar un cliente seleccionado");
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.btm_modificar_Click);
            // 
            // btm_alta
            // 
            this.btm_alta.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Alta;
            this.btm_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_alta.Location = new System.Drawing.Point(34, 409);
            this.btm_alta.Name = "btm_alta";
            this.btm_alta.Size = new System.Drawing.Size(50, 47);
            this.btm_alta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btm_alta, "Añadir un nuevo Cliente");
            this.btm_alta.UseVisualStyleBackColor = true;
            this.btm_alta.Click += new System.EventHandler(this.btm_alta_Click);
            // 
            // Frm_ABM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 470);
            this.Controls.Add(this.btm_salida);
            this.Controls.Add(this.btm_eliminar);
            this.Controls.Add(this.btm_modificar);
            this.Controls.Add(this.btm_alta);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ABM_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_ABM_Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_num_doc;
        private System.Windows.Forms.Label n_doc;
        private System.Windows.Forms.Label t_doc;
        private Clases.ComboBox01 cmb_Box_tipo_doc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_consultar_cliente;
        private System.Windows.Forms.CheckBox checkBox_CLiente;
        private System.Windows.Forms.DataGridView GridView_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btm_alta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_eliminar;
        private System.Windows.Forms.Button btm_salida;
    }
}