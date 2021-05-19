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
    public partial class Frm_Agregar_Rol : Form
    {
        public Frm_Agregar_Rol()
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
                NE_Rol_Empleado Rol = new NE_Rol_Empleado();
                Rol.Pp_descripcion_rol = txt_agregar_rol.Text;
                Rol.Insertar();
                MessageBox.Show("El rol se registro correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Frm_Agregar_Rol_Load(object sender, EventArgs e)
        {

        }
    }
}
