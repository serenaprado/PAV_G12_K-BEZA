using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Clases;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Empleados.Tipo_Rol
{
    public partial class Frm_Modificar_Rol : Form
    {
        public string Id_Rol { get; set; }


        public Frm_Modificar_Rol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                
                NE_Rol_Empleado rol = new NE_Rol_Empleado();

                
                rol.Pp_id_rol = Id_Rol;
                rol.Pp_descripcion_rol = txt_modificar_rol.Text;
                rol.Modificar();
                MessageBox.Show("El rol se modificó correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Frm_Modificar_Rol_Load(object sender, EventArgs e)
        {
            NE_Rol_Empleado rol = new NE_Rol_Empleado();
            MostrarDatos(rol.Recuperar_X_Id(Id_Rol));

        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_modificar_rol.Text = tabla.Rows[0]["descripcion_rol"].ToString();

       }
    }
}
