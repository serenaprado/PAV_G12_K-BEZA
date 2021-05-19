namespace PAV_G12_K_BEZA.Formularios.Empleados.Empleado
{
    partial class frm_Borrar_Empleados
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.cmb_Barrio = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_legajo_sup = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Rol = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_n_direccion = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Calle = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fecha = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sexo = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.cmb_Tipos = new PAV_G12_K_BEZA.Clases.ComboBox01();
            this.txt_nombre = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_legajo = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.txt_nro_documento = new PAV_G12_K_BEZA.Clases.TextBox01();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Cancelar;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(437, 258);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(50, 50);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = global::PAV_G12_K_BEZA.Properties.Resources.Aceptar;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(437, 174);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(50, 50);
            this.btn_Aceptar.TabIndex = 13;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // cmb_Barrio
            // 
            this.cmb_Barrio.Enabled = false;
            this.cmb_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Barrio.FormattingEnabled = true;
            this.cmb_Barrio.Location = new System.Drawing.Point(173, 398);
            this.cmb_Barrio.Name = "cmb_Barrio";
            this.cmb_Barrio.Pp_Coseleccion = false;
            this.cmb_Barrio.Pp_descripcion = "descripcion_barrio";
            this.cmb_Barrio.Pp_MensajeError = "";
            this.cmb_Barrio.Pp_NombreCampo = "id_barrio";
            this.cmb_Barrio.Pp_NombreTabla = null;
            this.cmb_Barrio.Pp_Pk = "id_barrio";
            this.cmb_Barrio.Pp_tabla = "Barrio";
            this.cmb_Barrio.Pp_Validable = true;
            this.cmb_Barrio.Size = new System.Drawing.Size(150, 28);
            this.cmb_Barrio.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Id Barrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Legajo:";
            // 
            // txt_legajo_sup
            // 
            this.txt_legajo_sup.Enabled = false;
            this.txt_legajo_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo_sup.Location = new System.Drawing.Point(173, 432);
            this.txt_legajo_sup.Name = "txt_legajo_sup";
            this.txt_legajo_sup.Pp_MensajeError = "";
            this.txt_legajo_sup.Pp_NombreCampo = "";
            this.txt_legajo_sup.Pp_NombreTabla = "";
            this.txt_legajo_sup.Pp_Validable = true;
            this.txt_legajo_sup.Size = new System.Drawing.Size(88, 26);
            this.txt_legajo_sup.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nº Documento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Legajo Supervisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo Documento:";
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.Enabled = false;
            this.cmb_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(173, 106);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Pp_Coseleccion = false;
            this.cmb_Rol.Pp_descripcion = "descripcion_rol";
            this.cmb_Rol.Pp_MensajeError = "";
            this.cmb_Rol.Pp_NombreCampo = "id_rol";
            this.cmb_Rol.Pp_NombreTabla = null;
            this.cmb_Rol.Pp_Pk = "id_rol";
            this.cmb_Rol.Pp_tabla = "Rol";
            this.cmb_Rol.Pp_Validable = true;
            this.cmb_Rol.Size = new System.Drawing.Size(150, 28);
            this.cmb_Rol.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Sexo:";
            // 
            // txt_n_direccion
            // 
            this.txt_n_direccion.Enabled = false;
            this.txt_n_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_direccion.Location = new System.Drawing.Point(173, 366);
            this.txt_n_direccion.Name = "txt_n_direccion";
            this.txt_n_direccion.Pp_MensajeError = "";
            this.txt_n_direccion.Pp_NombreCampo = "";
            this.txt_n_direccion.Pp_NombreTabla = "";
            this.txt_n_direccion.Pp_Validable = true;
            this.txt_n_direccion.Size = new System.Drawing.Size(78, 26);
            this.txt_n_direccion.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // txt_Calle
            // 
            this.txt_Calle.Enabled = false;
            this.txt_Calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Calle.Location = new System.Drawing.Point(173, 334);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Pp_MensajeError = "";
            this.txt_Calle.Pp_NombreCampo = "";
            this.txt_Calle.Pp_NombreTabla = "";
            this.txt_Calle.Pp_Validable = true;
            this.txt_Calle.Size = new System.Drawing.Size(232, 26);
            this.txt_Calle.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rol:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(173, 302);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Pp_MensajeError = "";
            this.txt_fecha.Pp_NombreCampo = "";
            this.txt_fecha.Pp_NombreTabla = "";
            this.txt_fecha.Pp_Validable = true;
            this.txt_fecha.Size = new System.Drawing.Size(88, 26);
            this.txt_fecha.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Calle";
            // 
            // txt_sexo
            // 
            this.txt_sexo.Enabled = false;
            this.txt_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sexo.Location = new System.Drawing.Point(173, 270);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Pp_MensajeError = "";
            this.txt_sexo.Pp_NombreCampo = "";
            this.txt_sexo.Pp_NombreTabla = "";
            this.txt_sexo.Pp_Validable = true;
            this.txt_sexo.Size = new System.Drawing.Size(113, 26);
            this.txt_sexo.TabIndex = 26;
            // 
            // cmb_Tipos
            // 
            this.cmb_Tipos.Enabled = false;
            this.cmb_Tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Tipos.FormattingEnabled = true;
            this.cmb_Tipos.Location = new System.Drawing.Point(173, 140);
            this.cmb_Tipos.Name = "cmb_Tipos";
            this.cmb_Tipos.Pp_Coseleccion = false;
            this.cmb_Tipos.Pp_descripcion = "descripcion_tipo_doc";
            this.cmb_Tipos.Pp_MensajeError = "";
            this.cmb_Tipos.Pp_NombreCampo = "id_tipo_documento";
            this.cmb_Tipos.Pp_NombreTabla = null;
            this.cmb_Tipos.Pp_Pk = "id_tipo_documento";
            this.cmb_Tipos.Pp_tabla = "Tipo_Documento";
            this.cmb_Tipos.Pp_Validable = true;
            this.cmb_Tipos.Size = new System.Drawing.Size(88, 28);
            this.cmb_Tipos.TabIndex = 25;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(173, 238);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_MensajeError = "";
            this.txt_nombre.Pp_NombreCampo = "";
            this.txt_nombre.Pp_NombreTabla = "";
            this.txt_nombre.Pp_Validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(195, 26);
            this.txt_nombre.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nº Direccion";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(173, 206);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_MensajeError = "";
            this.txt_apellido.Pp_NombreCampo = "";
            this.txt_apellido.Pp_NombreTabla = "";
            this.txt_apellido.Pp_Validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(195, 26);
            this.txt_apellido.TabIndex = 32;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(173, 74);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Pp_MensajeError = "";
            this.txt_legajo.Pp_NombreCampo = "";
            this.txt_legajo.Pp_NombreTabla = "";
            this.txt_legajo.Pp_Validable = true;
            this.txt_legajo.Size = new System.Drawing.Size(88, 26);
            this.txt_legajo.TabIndex = 23;
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Enabled = false;
            this.txt_nro_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_documento.Location = new System.Drawing.Point(173, 174);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Pp_MensajeError = "";
            this.txt_nro_documento.Pp_NombreCampo = "";
            this.txt_nro_documento.Pp_NombreTabla = "";
            this.txt_nro_documento.Pp_Validable = true;
            this.txt_nro_documento.Size = new System.Drawing.Size(150, 26);
            this.txt_nro_documento.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 34);
            this.label13.TabIndex = 44;
            this.label13.Text = "BORRAR EMPLEADO";
            // 
            // frm_Borrar_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 488);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_Barrio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_legajo_sup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_n_direccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Calle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.cmb_Tipos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_nro_documento);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Borrar_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Baja de Empleado";
            this.Load += new System.EventHandler(this.frm_Borrar_Empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private Clases.ComboBox01 cmb_Barrio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_legajo_sup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_Rol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_n_direccion;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_Calle;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txt_fecha;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txt_sexo;
        private Clases.ComboBox01 cmb_Tipos;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_apellido;
        private Clases.TextBox01 txt_legajo;
        private Clases.TextBox01 txt_nro_documento;
        private System.Windows.Forms.Label label13;
    }
}