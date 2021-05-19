using PAV_G12_K_BEZA.Clases;
using PAV_G12_K_BEZA.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV_G12_K_BEZA.Formularios.Empleados.Perfil
{
    public partial class frm_A_Agregar : Form
    {
        public string Pp_id_perfil { get; set; }

        
        public frm_A_Agregar()
        {
            InitializeComponent();
        }

        private void frm_A_Agregar_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Perfil Perfil = new NE_Perfil();

                Perfil.Pp_descripcion_perfil = txt_Perfil.Text;
                

                Perfil.Insertar();
                MessageBox.Show("Datos ingresados correctamente");
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
