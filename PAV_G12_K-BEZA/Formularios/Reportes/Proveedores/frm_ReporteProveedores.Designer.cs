namespace PAV_G12_K_BEZA.Formularios.Reportes.Proveedores
{
    partial class frm_ReporteProveedores
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
            this.rpv_proveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_todos = new System.Windows.Forms.RadioButton();
            this.chk_Razon_social = new System.Windows.Forms.RadioButton();
            this.chk_Id = new System.Windows.Forms.RadioButton();
            this.txt_razon_social = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_razon_social = new System.Windows.Forms.Label();
            this.txt_id = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rpv_clienteXbarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbo_Barrios = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_calcular4 = new System.Windows.Forms.Button();
            this.rpv_proveedoresXLocalidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbo_Localidades = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_Proveedores = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.rpv_proveedores_productos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_consultar3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_calcular5 = new System.Windows.Forms.Button();
            this.rpv_fp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbo_FormaPago = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxMaster = new System.Windows.Forms.PictureBox();
            this.pictureBoxEfectivo = new System.Windows.Forms.PictureBox();
            this.pictureBoxNaranja = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisa = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_proveedores
            // 
            this.rpv_proveedores.Location = new System.Drawing.Point(15, 160);
            this.rpv_proveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpv_proveedores.Name = "rpv_proveedores";
            this.rpv_proveedores.ServerReport.BearerToken = null;
            this.rpv_proveedores.Size = new System.Drawing.Size(1001, 295);
            this.rpv_proveedores.TabIndex = 499;
            this.rpv_proveedores.Load += new System.EventHandler(this.rpv_proveedores_Load);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(904, 56);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(112, 26);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 510);
            this.tabControl1.TabIndex = 500;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Controls.Add(this.rpv_proveedores);
            this.tabPage1.Controls.Add(this.txt_razon_social);
            this.tabPage1.Controls.Add(this.lbl_razon_social);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.lbl_id);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.chk_Razon_social);
            this.groupBox1.Controls.Add(this.chk_Id);
            this.groupBox1.Location = new System.Drawing.Point(667, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(6, 84);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(71, 24);
            this.chk_todos.TabIndex = 2;
            this.chk_todos.TabStop = true;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // chk_Razon_social
            // 
            this.chk_Razon_social.AutoSize = true;
            this.chk_Razon_social.Location = new System.Drawing.Point(6, 50);
            this.chk_Razon_social.Name = "chk_Razon_social";
            this.chk_Razon_social.Size = new System.Drawing.Size(121, 24);
            this.chk_Razon_social.TabIndex = 1;
            this.chk_Razon_social.TabStop = true;
            this.chk_Razon_social.Text = "Razon Social";
            this.chk_Razon_social.UseVisualStyleBackColor = true;
            this.chk_Razon_social.CheckedChanged += new System.EventHandler(this.chk_Razon_social_CheckedChanged);
            // 
            // chk_Id
            // 
            this.chk_Id.AutoSize = true;
            this.chk_Id.Location = new System.Drawing.Point(6, 20);
            this.chk_Id.Name = "chk_Id";
            this.chk_Id.Size = new System.Drawing.Size(44, 24);
            this.chk_Id.TabIndex = 0;
            this.chk_Id.TabStop = true;
            this.chk_Id.Text = "ID";
            this.chk_Id.UseVisualStyleBackColor = true;
            this.chk_Id.CheckedChanged += new System.EventHandler(this.chk_Id_CheckedChanged);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_razon_social.Location = new System.Drawing.Point(360, 56);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Pp_MensajeError = null;
            this.txt_razon_social.Pp_NombreCampo = null;
            this.txt_razon_social.Pp_NombreTabla = null;
            this.txt_razon_social.Pp_Validable = false;
            this.txt_razon_social.Size = new System.Drawing.Size(243, 26);
            this.txt_razon_social.TabIndex = 6;
            // 
            // lbl_razon_social
            // 
            this.lbl_razon_social.AutoSize = true;
            this.lbl_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_razon_social.Location = new System.Drawing.Point(255, 59);
            this.lbl_razon_social.Name = "lbl_razon_social";
            this.lbl_razon_social.Size = new System.Drawing.Size(103, 20);
            this.lbl_razon_social.TabIndex = 5;
            this.lbl_razon_social.Text = "Razon Social";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id.Location = new System.Drawing.Point(116, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Pp_MensajeError = null;
            this.txt_id.Pp_NombreCampo = null;
            this.txt_id.Pp_NombreTabla = null;
            this.txt_id.Pp_Validable = false;
            this.txt_id.Size = new System.Drawing.Size(100, 26);
            this.txt_id.TabIndex = 2;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_id.Location = new System.Drawing.Point(11, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(99, 20);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Id Proveedor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedores por Barrio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rpv_clienteXbarrio);
            this.groupBox2.Controls.Add(this.cbo_Barrios);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 471);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte Proveedores por Barrio";
            // 
            // rpv_clienteXbarrio
            // 
            this.rpv_clienteXbarrio.Location = new System.Drawing.Point(7, 85);
            this.rpv_clienteXbarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpv_clienteXbarrio.Name = "rpv_clienteXbarrio";
            this.rpv_clienteXbarrio.ServerReport.BearerToken = null;
            this.rpv_clienteXbarrio.Size = new System.Drawing.Size(1161, 408);
            this.rpv_clienteXbarrio.TabIndex = 6;
            // 
            // cbo_Barrios
            // 
            this.cbo_Barrios.FormattingEnabled = true;
            this.cbo_Barrios.Location = new System.Drawing.Point(228, 32);
            this.cbo_Barrios.Name = "cbo_Barrios";
            this.cbo_Barrios.Pp_Coseleccion = false;
            this.cbo_Barrios.Pp_descripcion = "descripcion_barrio";
            this.cbo_Barrios.Pp_MensajeError = "Debe Seleccionar un Barrio";
            this.cbo_Barrios.Pp_NombreCampo = null;
            this.cbo_Barrios.Pp_NombreTabla = null;
            this.cbo_Barrios.Pp_Pk = "id_barrio";
            this.cbo_Barrios.Pp_tabla = "Barrio";
            this.cbo_Barrios.Pp_Validable = true;
            this.cbo_Barrios.Size = new System.Drawing.Size(236, 28);
            this.cbo_Barrios.TabIndex = 0;
            this.cbo_Barrios.SelectedIndexChanged += new System.EventHandler(this.cbo_Barrios_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Barrios";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1142, 477);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Proveedores por Localidad";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_calcular4);
            this.groupBox4.Controls.Add(this.rpv_proveedoresXLocalidad);
            this.groupBox4.Controls.Add(this.cbo_Localidades);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1136, 471);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reporte Proveedores por Localidad";
            // 
            // btn_calcular4
            // 
            this.btn_calcular4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular4.Location = new System.Drawing.Point(471, 29);
            this.btn_calcular4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calcular4.Name = "btn_calcular4";
            this.btn_calcular4.Size = new System.Drawing.Size(112, 31);
            this.btn_calcular4.TabIndex = 12;
            this.btn_calcular4.Text = "Calcular";
            this.btn_calcular4.UseVisualStyleBackColor = true;
            this.btn_calcular4.Click += new System.EventHandler(this.btn_calcular4_Click);
            // 
            // rpv_proveedoresXLocalidad
            // 
            this.rpv_proveedoresXLocalidad.Location = new System.Drawing.Point(7, 85);
            this.rpv_proveedoresXLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpv_proveedoresXLocalidad.Name = "rpv_proveedoresXLocalidad";
            this.rpv_proveedoresXLocalidad.ServerReport.BearerToken = null;
            this.rpv_proveedoresXLocalidad.Size = new System.Drawing.Size(1161, 408);
            this.rpv_proveedoresXLocalidad.TabIndex = 6;
            // 
            // cbo_Localidades
            // 
            this.cbo_Localidades.FormattingEnabled = true;
            this.cbo_Localidades.Location = new System.Drawing.Point(228, 32);
            this.cbo_Localidades.Name = "cbo_Localidades";
            this.cbo_Localidades.Pp_Coseleccion = false;
            this.cbo_Localidades.Pp_descripcion = "descripcion_localidad";
            this.cbo_Localidades.Pp_MensajeError = "Debe Seleccionar una Localidad";
            this.cbo_Localidades.Pp_NombreCampo = null;
            this.cbo_Localidades.Pp_NombreTabla = null;
            this.cbo_Localidades.Pp_Pk = "id_localidad";
            this.cbo_Localidades.Pp_tabla = "Localidad";
            this.cbo_Localidades.Pp_Validable = true;
            this.cbo_Localidades.Size = new System.Drawing.Size(236, 28);
            this.cbo_Localidades.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Listado de Localidades";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1142, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto por Proveedor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_Proveedores);
            this.groupBox3.Controls.Add(this.rpv_proveedores_productos);
            this.groupBox3.Controls.Add(this.btn_consultar3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1129, 464);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte productos por Proveedor";
            // 
            // cbo_Proveedores
            // 
            this.cbo_Proveedores.FormattingEnabled = true;
            this.cbo_Proveedores.Location = new System.Drawing.Point(224, 34);
            this.cbo_Proveedores.Name = "cbo_Proveedores";
            this.cbo_Proveedores.Pp_Coseleccion = false;
            this.cbo_Proveedores.Pp_descripcion = "razon_social";
            this.cbo_Proveedores.Pp_MensajeError = null;
            this.cbo_Proveedores.Pp_NombreCampo = null;
            this.cbo_Proveedores.Pp_NombreTabla = null;
            this.cbo_Proveedores.Pp_Pk = "id_proveedor";
            this.cbo_Proveedores.Pp_tabla = "Proveedor";
            this.cbo_Proveedores.Pp_Validable = true;
            this.cbo_Proveedores.Size = new System.Drawing.Size(260, 28);
            this.cbo_Proveedores.TabIndex = 14;
            // 
            // rpv_proveedores_productos
            // 
            this.rpv_proveedores_productos.Location = new System.Drawing.Point(6, 96);
            this.rpv_proveedores_productos.Name = "rpv_proveedores_productos";
            this.rpv_proveedores_productos.ServerReport.BearerToken = null;
            this.rpv_proveedores_productos.Size = new System.Drawing.Size(1117, 362);
            this.rpv_proveedores_productos.TabIndex = 0;
            // 
            // btn_consultar3
            // 
            this.btn_consultar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar3.Location = new System.Drawing.Point(490, 33);
            this.btn_consultar3.Name = "btn_consultar3";
            this.btn_consultar3.Size = new System.Drawing.Size(104, 28);
            this.btn_consultar3.TabIndex = 1;
            this.btn_consultar3.Text = "Consultar";
            this.btn_consultar3.UseVisualStyleBackColor = true;
            this.btn_consultar3.Click += new System.EventHandler(this.btn_consultar3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Listado de Proveedores";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1142, 477);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ventas por Forma de Pago";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_calcular5);
            this.groupBox5.Controls.Add(this.rpv_fp);
            this.groupBox5.Controls.Add(this.pictureBoxMaster);
            this.groupBox5.Controls.Add(this.pictureBoxEfectivo);
            this.groupBox5.Controls.Add(this.pictureBoxNaranja);
            this.groupBox5.Controls.Add(this.pictureBoxVisa);
            this.groupBox5.Controls.Add(this.cbo_FormaPago);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1136, 471);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reporte ventas por Forma de pago";
            // 
            // btn_calcular5
            // 
            this.btn_calcular5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular5.Location = new System.Drawing.Point(482, 32);
            this.btn_calcular5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calcular5.Name = "btn_calcular5";
            this.btn_calcular5.Size = new System.Drawing.Size(112, 31);
            this.btn_calcular5.TabIndex = 1;
            this.btn_calcular5.Text = "Calcular";
            this.btn_calcular5.UseVisualStyleBackColor = true;
            this.btn_calcular5.Click += new System.EventHandler(this.btn_calcular5_Click);
            // 
            // rpv_fp
            // 
            this.rpv_fp.Location = new System.Drawing.Point(7, 85);
            this.rpv_fp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpv_fp.Name = "rpv_fp";
            this.rpv_fp.ServerReport.BearerToken = null;
            this.rpv_fp.Size = new System.Drawing.Size(1125, 408);
            this.rpv_fp.TabIndex = 6;
            // 
            // cbo_FormaPago
            // 
            this.cbo_FormaPago.FormattingEnabled = true;
            this.cbo_FormaPago.Location = new System.Drawing.Point(228, 32);
            this.cbo_FormaPago.Name = "cbo_FormaPago";
            this.cbo_FormaPago.Pp_Coseleccion = false;
            this.cbo_FormaPago.Pp_descripcion = "descripcion_forma_pago";
            this.cbo_FormaPago.Pp_MensajeError = "Debe seleccionar una Forma de Pago";
            this.cbo_FormaPago.Pp_NombreCampo = null;
            this.cbo_FormaPago.Pp_NombreTabla = null;
            this.cbo_FormaPago.Pp_Pk = "id_forma_pago";
            this.cbo_FormaPago.Pp_tabla = "Forma_Pago";
            this.cbo_FormaPago.Pp_Validable = true;
            this.cbo_FormaPago.Size = new System.Drawing.Size(236, 28);
            this.cbo_FormaPago.TabIndex = 0;
            this.cbo_FormaPago.SelectedIndexChanged += new System.EventHandler(this.cbo_FormaPago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Formas de pago";
            // 
            // pictureBoxMaster
            // 
            this.pictureBoxMaster.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.iconfinder_70593_mastercard_curved_icon_128px;
            this.pictureBoxMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMaster.Enabled = false;
            this.pictureBoxMaster.Location = new System.Drawing.Point(651, 25);
            this.pictureBoxMaster.Name = "pictureBoxMaster";
            this.pictureBoxMaster.Size = new System.Drawing.Size(106, 52);
            this.pictureBoxMaster.TabIndex = 15;
            this.pictureBoxMaster.TabStop = false;
            this.pictureBoxMaster.Visible = false;
            // 
            // pictureBoxEfectivo
            // 
            this.pictureBoxEfectivo.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.iconfinder_4781825_cash_credit_currency_dollar_finance_icon_128px;
            this.pictureBoxEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEfectivo.Enabled = false;
            this.pictureBoxEfectivo.InitialImage = null;
            this.pictureBoxEfectivo.Location = new System.Drawing.Point(638, 14);
            this.pictureBoxEfectivo.Name = "pictureBoxEfectivo";
            this.pictureBoxEfectivo.Size = new System.Drawing.Size(119, 74);
            this.pictureBoxEfectivo.TabIndex = 14;
            this.pictureBoxEfectivo.TabStop = false;
            this.pictureBoxEfectivo.Visible = false;
            // 
            // pictureBoxNaranja
            // 
            this.pictureBoxNaranja.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources._13;
            this.pictureBoxNaranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNaranja.Location = new System.Drawing.Point(554, -63);
            this.pictureBoxNaranja.Name = "pictureBoxNaranja";
            this.pictureBoxNaranja.Size = new System.Drawing.Size(272, 232);
            this.pictureBoxNaranja.TabIndex = 13;
            this.pictureBoxNaranja.TabStop = false;
            this.pictureBoxNaranja.Visible = false;
            // 
            // pictureBoxVisa
            // 
            this.pictureBoxVisa.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.iconfinder_206684_visa_method_card_payment_icon_128px;
            this.pictureBoxVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVisa.Enabled = false;
            this.pictureBoxVisa.Location = new System.Drawing.Point(612, 25);
            this.pictureBoxVisa.Name = "pictureBoxVisa";
            this.pictureBoxVisa.Size = new System.Drawing.Size(106, 52);
            this.pictureBoxVisa.TabIndex = 12;
            this.pictureBoxVisa.TabStop = false;
            this.pictureBoxVisa.Visible = false;
            // 
            // frm_ReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_ReporteProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frm_ReporteProveedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpv_proveedores;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chk_todos;
        private System.Windows.Forms.RadioButton chk_Razon_social;
        private System.Windows.Forms.RadioButton chk_Id;
        private Clases.TextBox01 txt_razon_social;
        private System.Windows.Forms.Label lbl_razon_social;
        private Clases.TextBox01 txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_clienteXbarrio;
        private Clases.ComboBox01 cbo_Barrios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_proveedores_productos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_consultar3;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cbo_Proveedores;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_proveedoresXLocalidad;
        private Clases.ComboBox01 cbo_Localidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calcular4;
        private System.Windows.Forms.GroupBox groupBox5;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_fp;
        private Clases.ComboBox01 cbo_FormaPago;
        private System.Windows.Forms.Button btn_calcular5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxMaster;
        private System.Windows.Forms.PictureBox pictureBoxEfectivo;
        private System.Windows.Forms.PictureBox pictureBoxNaranja;
        private System.Windows.Forms.PictureBox pictureBoxVisa;
    }
}