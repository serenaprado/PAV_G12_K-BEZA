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
    public partial class frm_M_Modificar : Form
    {
        public string Id_Perfil { get; set; }

        
        public frm_M_Modificar()
        {
            InitializeComponent();
        }

        private void frm_M_Modificar_Load(object sender, EventArgs e)
        {
            NE_Perfil Perfil = new NE_Perfil();
            MostrarDatos(Perfil.Recuperar_x_Id(Id_Perfil));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_Perfil.Text = tabla.Rows[0]["descripcion_perfil"].ToString();
            txt_perfilanterior.Text = tabla.Rows[0]["descripcion_perfil"].ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Perfil Perfil = new NE_Perfil();
                Perfil.Pp_id_perfil = Id_Perfil;
                Perfil.Pp_descripcion_perfil = txt_Perfil.Text;


                Perfil.Modificar();
                MessageBox.Show("Datos modificados correctamente");
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void lbl_modificar_Click(object sender, EventArgs e)
        {

        }

        private void txt_perfilanterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
