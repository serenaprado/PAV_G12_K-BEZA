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
    public partial class frm_B_Eliminar : Form
    {
        public string Pp_id_perfil { get; set; }
        public string Id_Perfil { get; set; }
        
        public frm_B_Eliminar()
        {
            InitializeComponent();
        }

       

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Perfil borrar = new NE_Perfil();
            DialogResult dialogResult = MessageBox.Show("¿Desea borrar este perfil?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                borrar.Pp_id_perfil = Id_Perfil;
                borrar.Borrar();
                MessageBox.Show("Borrado de perfil exitoso");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void frm_B_Eliminar_Load(object sender, EventArgs e)
        {
            NE_Perfil Perfil = new NE_Perfil();
            MostrarDatos(Perfil.Recuperar_x_Id(Id_Perfil));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_Perfil.Text = tabla.Rows[0]["descripcion_perfil"].ToString();
        }

        private void txt_Perfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
