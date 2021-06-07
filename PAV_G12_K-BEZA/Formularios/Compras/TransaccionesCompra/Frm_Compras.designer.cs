namespace PAV_G12_K_BEZA.Formularios.Compras.TransaccionCompras
{
    partial class Frm_Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.grid_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.btn_productoKit = new System.Windows.Forms.Button();
            this.btn_eleminar = new System.Windows.Forms.Button();
            this.btn_registarVenta = new System.Windows.Forms.Button();
            this.btn_CancelarVenta = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.grid_Kit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cantidadProd = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidadKit = new System.Windows.Forms.MaskedTextBox();
            this.txt_kitPrecioUnit = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_ProdPrecioUnitario = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_precioTotal = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_apellidoEmpleado = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_apellidoCliente = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_nombreEmpleado = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_nombreCliente = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_FechaCompra = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_DocCliente = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.cmb_FormaDePago = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_tipoFactura = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_TipoDocumento = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_empleado = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_KitVenta = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.cmb_ProductoVenta = new PAV_G12_K_BEZA.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRA ";
            // 
            // grid_productos
            // 
            this.grid_productos.AllowUserToAddRows = false;
            this.grid_productos.AllowUserToDeleteRows = false;
            this.grid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_productos.Location = new System.Drawing.Point(478, 99);
            this.grid_productos.Name = "grid_productos";
            this.grid_productos.ReadOnly = true;
            this.grid_productos.Size = new System.Drawing.Size(659, 178);
            this.grid_productos.TabIndex = 1;
            this.grid_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Unit.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Doc. Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Legajo empleado: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Doc. Cliente:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Forma de Pago:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kit:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(777, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio unit.";
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProducto.Location = new System.Drawing.Point(1011, 59);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(126, 26);
            this.btn_agregarProducto.TabIndex = 8;
            this.btn_agregarProducto.Text = "Agregar Prod.";
            this.btn_agregarProducto.UseVisualStyleBackColor = true;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // btn_productoKit
            // 
            this.btn_productoKit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productoKit.Location = new System.Drawing.Point(1011, 283);
            this.btn_productoKit.Name = "btn_productoKit";
            this.btn_productoKit.Size = new System.Drawing.Size(126, 26);
            this.btn_productoKit.TabIndex = 12;
            this.btn_productoKit.Text = "Agregar Kit";
            this.btn_productoKit.UseVisualStyleBackColor = true;
            this.btn_productoKit.Click += new System.EventHandler(this.btn_productoKit_Click);
            // 
            // btn_eleminar
            // 
            this.btn_eleminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eleminar.Location = new System.Drawing.Point(92, 460);
            this.btn_eleminar.Name = "btn_eleminar";
            this.btn_eleminar.Size = new System.Drawing.Size(126, 26);
            this.btn_eleminar.TabIndex = 13;
            this.btn_eleminar.Text = "Eliminar ";
            this.btn_eleminar.UseVisualStyleBackColor = true;
            // 
            // btn_registarVenta
            // 
            this.btn_registarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registarVenta.Location = new System.Drawing.Point(73, 539);
            this.btn_registarVenta.Name = "btn_registarVenta";
            this.btn_registarVenta.Size = new System.Drawing.Size(172, 26);
            this.btn_registarVenta.TabIndex = 15;
            this.btn_registarVenta.Text = "Registar Venta";
            this.btn_registarVenta.UseVisualStyleBackColor = true;
            this.btn_registarVenta.Click += new System.EventHandler(this.btn_registarVenta_Click);
            // 
            // btn_CancelarVenta
            // 
            this.btn_CancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarVenta.Location = new System.Drawing.Point(251, 539);
            this.btn_CancelarVenta.Name = "btn_CancelarVenta";
            this.btn_CancelarVenta.Size = new System.Drawing.Size(172, 26);
            this.btn_CancelarVenta.TabIndex = 16;
            this.btn_CancelarVenta.Text = "Cancelar Venta";
            this.btn_CancelarVenta.UseVisualStyleBackColor = true;
            this.btn_CancelarVenta.Click += new System.EventHandler(this.btn_CancelarVenta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(224, 460);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(126, 26);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // grid_Kit
            // 
            this.grid_Kit.AllowUserToAddRows = false;
            this.grid_Kit.AllowUserToDeleteRows = false;
            this.grid_Kit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Kit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grid_Kit.Location = new System.Drawing.Point(478, 329);
            this.grid_Kit.Name = "grid_Kit";
            this.grid_Kit.ReadOnly = true;
            this.grid_Kit.Size = new System.Drawing.Size(659, 178);
            this.grid_Kit.TabIndex = 1;
            this.grid_Kit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Unit.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Precio Total:";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nombre Cliente:";
            this.label12.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Fecha: ";
            this.label13.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Apellido Empleado:";
            this.label14.Click += new System.EventHandler(this.label2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nombre Empleado: ";
            this.label15.Click += new System.EventHandler(this.label2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(89, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tipo Factura:";
            // 
            // txt_cantidadProd
            // 
            this.txt_cantidadProd.Location = new System.Drawing.Point(781, 55);
            this.txt_cantidadProd.Mask = "9";
            this.txt_cantidadProd.Name = "txt_cantidadProd";
            this.txt_cantidadProd.Size = new System.Drawing.Size(34, 26);
            this.txt_cantidadProd.TabIndex = 17;
            this.txt_cantidadProd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_cantidadKit
            // 
            this.txt_cantidadKit.Location = new System.Drawing.Point(781, 283);
            this.txt_cantidadKit.Mask = "9";
            this.txt_cantidadKit.Name = "txt_cantidadKit";
            this.txt_cantidadKit.Size = new System.Drawing.Size(34, 26);
            this.txt_cantidadKit.TabIndex = 17;
            this.txt_cantidadKit.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_kitPrecioUnit
            // 
            this.txt_kitPrecioUnit.Enabled = false;
            this.txt_kitPrecioUnit.Location = new System.Drawing.Point(893, 283);
            this.txt_kitPrecioUnit.Name = "txt_kitPrecioUnit";
            this.txt_kitPrecioUnit.Pp_MensajeError = null;
            this.txt_kitPrecioUnit.Pp_NombreCampo = null;
            this.txt_kitPrecioUnit.Pp_NombreTabla = null;
            this.txt_kitPrecioUnit.Pp_Validable = false;
            this.txt_kitPrecioUnit.Size = new System.Drawing.Size(104, 26);
            this.txt_kitPrecioUnit.TabIndex = 11;
            // 
            // txt_ProdPrecioUnitario
            // 
            this.txt_ProdPrecioUnitario.Enabled = false;
            this.txt_ProdPrecioUnitario.Location = new System.Drawing.Point(893, 57);
            this.txt_ProdPrecioUnitario.Name = "txt_ProdPrecioUnitario";
            this.txt_ProdPrecioUnitario.Pp_MensajeError = null;
            this.txt_ProdPrecioUnitario.Pp_NombreCampo = null;
            this.txt_ProdPrecioUnitario.Pp_NombreTabla = null;
            this.txt_ProdPrecioUnitario.Pp_Validable = false;
            this.txt_ProdPrecioUnitario.Size = new System.Drawing.Size(104, 26);
            this.txt_ProdPrecioUnitario.TabIndex = 7;
            // 
            // txt_precioTotal
            // 
            this.txt_precioTotal.Enabled = false;
            this.txt_precioTotal.Location = new System.Drawing.Point(1011, 539);
            this.txt_precioTotal.Name = "txt_precioTotal";
            this.txt_precioTotal.Pp_MensajeError = null;
            this.txt_precioTotal.Pp_NombreCampo = null;
            this.txt_precioTotal.Pp_NombreTabla = null;
            this.txt_precioTotal.Pp_Validable = false;
            this.txt_precioTotal.Size = new System.Drawing.Size(126, 26);
            this.txt_precioTotal.TabIndex = 6;
            // 
            // txt_apellidoEmpleado
            // 
            this.txt_apellidoEmpleado.Enabled = false;
            this.txt_apellidoEmpleado.Location = new System.Drawing.Point(189, 318);
            this.txt_apellidoEmpleado.Name = "txt_apellidoEmpleado";
            this.txt_apellidoEmpleado.Pp_MensajeError = null;
            this.txt_apellidoEmpleado.Pp_NombreCampo = null;
            this.txt_apellidoEmpleado.Pp_NombreTabla = null;
            this.txt_apellidoEmpleado.Pp_Validable = false;
            this.txt_apellidoEmpleado.Size = new System.Drawing.Size(121, 26);
            this.txt_apellidoEmpleado.TabIndex = 6;
            // 
            // txt_apellidoCliente
            // 
            this.txt_apellidoCliente.Enabled = false;
            this.txt_apellidoCliente.Location = new System.Drawing.Point(189, 201);
            this.txt_apellidoCliente.Name = "txt_apellidoCliente";
            this.txt_apellidoCliente.Pp_MensajeError = null;
            this.txt_apellidoCliente.Pp_NombreCampo = null;
            this.txt_apellidoCliente.Pp_NombreTabla = null;
            this.txt_apellidoCliente.Pp_Validable = false;
            this.txt_apellidoCliente.Size = new System.Drawing.Size(121, 26);
            this.txt_apellidoCliente.TabIndex = 6;
            // 
            // txt_nombreEmpleado
            // 
            this.txt_nombreEmpleado.Enabled = false;
            this.txt_nombreEmpleado.Location = new System.Drawing.Point(189, 286);
            this.txt_nombreEmpleado.Name = "txt_nombreEmpleado";
            this.txt_nombreEmpleado.Pp_MensajeError = null;
            this.txt_nombreEmpleado.Pp_NombreCampo = null;
            this.txt_nombreEmpleado.Pp_NombreTabla = null;
            this.txt_nombreEmpleado.Pp_Validable = false;
            this.txt_nombreEmpleado.Size = new System.Drawing.Size(121, 26);
            this.txt_nombreEmpleado.TabIndex = 6;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Enabled = false;
            this.txt_nombreCliente.Location = new System.Drawing.Point(189, 169);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Pp_MensajeError = null;
            this.txt_nombreCliente.Pp_NombreCampo = null;
            this.txt_nombreCliente.Pp_NombreTabla = null;
            this.txt_nombreCliente.Pp_Validable = false;
            this.txt_nombreCliente.Size = new System.Drawing.Size(121, 26);
            this.txt_nombreCliente.TabIndex = 6;
            this.txt_nombreCliente.TextChanged += new System.EventHandler(this.textBox012_TextChanged);
            // 
            // txt_FechaCompra
            // 
            this.txt_FechaCompra.Enabled = false;
            this.txt_FechaCompra.Location = new System.Drawing.Point(189, 62);
            this.txt_FechaCompra.Name = "txt_FechaCompra";
            this.txt_FechaCompra.Pp_MensajeError = "Falta cargar documento del cliente";
            this.txt_FechaCompra.Pp_NombreCampo = null;
            this.txt_FechaCompra.Pp_NombreTabla = null;
            this.txt_FechaCompra.Pp_Validable = false;
            this.txt_FechaCompra.Size = new System.Drawing.Size(121, 26);
            this.txt_FechaCompra.TabIndex = 6;
            this.txt_FechaCompra.TextChanged += new System.EventHandler(this.textBox012_TextChanged);
            // 
            // txt_DocCliente
            // 
            this.txt_DocCliente.Location = new System.Drawing.Point(189, 138);
            this.txt_DocCliente.Name = "txt_DocCliente";
            this.txt_DocCliente.Pp_MensajeError = "Falta cargar documento del cliente";
            this.txt_DocCliente.Pp_NombreCampo = null;
            this.txt_DocCliente.Pp_NombreTabla = null;
            this.txt_DocCliente.Pp_Validable = false;
            this.txt_DocCliente.Size = new System.Drawing.Size(121, 26);
            this.txt_DocCliente.TabIndex = 6;
            this.txt_DocCliente.TextChanged += new System.EventHandler(this.textBox012_TextChanged);
            // 
            // cmb_FormaDePago
            // 
            this.cmb_FormaDePago.Location = new System.Drawing.Point(189, 401);
            this.cmb_FormaDePago.Name = "cmb_FormaDePago";
            this.cmb_FormaDePago.Pp_Coseleccion = false;
            this.cmb_FormaDePago.Pp_descripcion = "descripcion_forma_pago";
            this.cmb_FormaDePago.Pp_MensajeError = null;
            this.cmb_FormaDePago.Pp_NombreCampo = null;
            this.cmb_FormaDePago.Pp_NombreTabla = null;
            this.cmb_FormaDePago.Pp_Pk = "id_forma_pago";
            this.cmb_FormaDePago.Pp_tabla = "Forma_Pago";
            this.cmb_FormaDePago.Pp_Validable = false;
            this.cmb_FormaDePago.Size = new System.Drawing.Size(121, 28);
            this.cmb_FormaDePago.TabIndex = 4;
            // 
            // cmb_tipoFactura
            // 
            this.cmb_tipoFactura.Location = new System.Drawing.Point(189, 367);
            this.cmb_tipoFactura.Name = "cmb_tipoFactura";
            this.cmb_tipoFactura.Pp_Coseleccion = false;
            this.cmb_tipoFactura.Pp_descripcion = "descripcion_tipo_factura";
            this.cmb_tipoFactura.Pp_MensajeError = null;
            this.cmb_tipoFactura.Pp_NombreCampo = null;
            this.cmb_tipoFactura.Pp_NombreTabla = null;
            this.cmb_tipoFactura.Pp_Pk = "id_tipo_factura";
            this.cmb_tipoFactura.Pp_tabla = "Tipo_Factura";
            this.cmb_tipoFactura.Pp_Validable = false;
            this.cmb_tipoFactura.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipoFactura.TabIndex = 3;
            // 
            // cmb_TipoDocumento
            // 
            this.cmb_TipoDocumento.Location = new System.Drawing.Point(189, 104);
            this.cmb_TipoDocumento.Name = "cmb_TipoDocumento";
            this.cmb_TipoDocumento.Pp_Coseleccion = false;
            this.cmb_TipoDocumento.Pp_descripcion = "descripcion_tipo_doc";
            this.cmb_TipoDocumento.Pp_MensajeError = "Falta seleccionar el documento del cliente";
            this.cmb_TipoDocumento.Pp_NombreCampo = null;
            this.cmb_TipoDocumento.Pp_NombreTabla = null;
            this.cmb_TipoDocumento.Pp_Pk = "id_tipo_documento";
            this.cmb_TipoDocumento.Pp_tabla = "Tipo_Documento";
            this.cmb_TipoDocumento.Pp_Validable = false;
            this.cmb_TipoDocumento.Size = new System.Drawing.Size(121, 28);
            this.cmb_TipoDocumento.TabIndex = 3;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.Location = new System.Drawing.Point(189, 252);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Pp_Coseleccion = false;
            this.cmb_empleado.Pp_descripcion = "legajo_empleado";
            this.cmb_empleado.Pp_MensajeError = null;
            this.cmb_empleado.Pp_NombreCampo = null;
            this.cmb_empleado.Pp_NombreTabla = null;
            this.cmb_empleado.Pp_Pk = "legajo_empleado";
            this.cmb_empleado.Pp_tabla = "Empleado";
            this.cmb_empleado.Pp_Validable = false;
            this.cmb_empleado.Size = new System.Drawing.Size(121, 28);
            this.cmb_empleado.TabIndex = 2;
            this.cmb_empleado.SelectionChangeCommitted += new System.EventHandler(this.cmb_empleado_SelectionChangeCommitted);
            // 
            // cmb_KitVenta
            // 
            this.cmb_KitVenta.Location = new System.Drawing.Point(563, 283);
            this.cmb_KitVenta.Name = "cmb_KitVenta";
            this.cmb_KitVenta.Pp_Coseleccion = false;
            this.cmb_KitVenta.Pp_descripcion = "descripcion_kit";
            this.cmb_KitVenta.Pp_MensajeError = null;
            this.cmb_KitVenta.Pp_NombreCampo = null;
            this.cmb_KitVenta.Pp_NombreTabla = null;
            this.cmb_KitVenta.Pp_Pk = "id_kit";
            this.cmb_KitVenta.Pp_tabla = "Kit";
            this.cmb_KitVenta.Pp_Validable = false;
            this.cmb_KitVenta.Size = new System.Drawing.Size(189, 28);
            this.cmb_KitVenta.TabIndex = 9;
            this.cmb_KitVenta.SelectionChangeCommitted += new System.EventHandler(this.cmb_KitVenta_SelectionChangeCommitted);
            // 
            // cmb_ProductoVenta
            // 
            this.cmb_ProductoVenta.Location = new System.Drawing.Point(563, 55);
            this.cmb_ProductoVenta.Name = "cmb_ProductoVenta";
            this.cmb_ProductoVenta.Pp_Coseleccion = false;
            this.cmb_ProductoVenta.Pp_descripcion = "descripcion";
            this.cmb_ProductoVenta.Pp_MensajeError = null;
            this.cmb_ProductoVenta.Pp_NombreCampo = null;
            this.cmb_ProductoVenta.Pp_NombreTabla = null;
            this.cmb_ProductoVenta.Pp_Pk = "id_producto";
            this.cmb_ProductoVenta.Pp_tabla = "Producto";
            this.cmb_ProductoVenta.Pp_Validable = false;
            this.cmb_ProductoVenta.Size = new System.Drawing.Size(189, 28);
            this.cmb_ProductoVenta.TabIndex = 5;
            this.cmb_ProductoVenta.SelectionChangeCommitted += new System.EventHandler(this.cmb_ProductoVenta_SelectionChangeCommitted);
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 579);
            this.Controls.Add(this.txt_cantidadKit);
            this.Controls.Add(this.txt_cantidadProd);
            this.Controls.Add(this.btn_productoKit);
            this.Controls.Add(this.btn_CancelarVenta);
            this.Controls.Add(this.btn_registarVenta);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eleminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_kitPrecioUnit);
            this.Controls.Add(this.txt_ProdPrecioUnitario);
            this.Controls.Add(this.txt_precioTotal);
            this.Controls.Add(this.txt_apellidoEmpleado);
            this.Controls.Add(this.txt_apellidoCliente);
            this.Controls.Add(this.txt_nombreEmpleado);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_FechaCompra);
            this.Controls.Add(this.txt_DocCliente);
            this.Controls.Add(this.cmb_FormaDePago);
            this.Controls.Add(this.cmb_tipoFactura);
            this.Controls.Add(this.cmb_TipoDocumento);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.cmb_KitVenta);
            this.Controls.Add(this.cmb_ProductoVenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_Kit);
            this.Controls.Add(this.grid_productos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Compras";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_empleado;
        private Clases.ComboBox01 cmb_TipoDocumento;
        private Clases.ComboBox01 cmb_FormaDePago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 cmb_ProductoVenta;
        private Clases.ComboBox01 cmb_KitVenta;
        private Clases.TextBox01 txt_kitPrecioUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txt_ProdPrecioUnitario;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Button btn_productoKit;
        private System.Windows.Forms.Button btn_eleminar;
        private System.Windows.Forms.Button btn_registarVenta;
        private System.Windows.Forms.Button btn_CancelarVenta;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView grid_Kit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Clases.TextBox01 txt_precioTotal;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_DocCliente;
        private Clases.TextBox01 txt_apellidoCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Clases.TextBox01 txt_nombreEmpleado;
        private Clases.TextBox01 txt_apellidoEmpleado;
        private Clases.TextBox01 txt_nombreCliente;
        private System.Windows.Forms.Label label16;
        private Clases.ComboBox01 cmb_tipoFactura;
        private System.Windows.Forms.MaskedTextBox txt_cantidadProd;
        private System.Windows.Forms.MaskedTextBox txt_cantidadKit;
        private Clases.TextBox01 txt_FechaCompra;
    }
}