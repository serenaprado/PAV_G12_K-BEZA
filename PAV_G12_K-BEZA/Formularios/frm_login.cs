using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Negocio;
using PAV_G12_K_BEZA.Formularios;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Formularios
{
    public partial class frm_login : Form
    {
        public string Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }
        
        public string Pp_contraseña
        {
            get { return txt_contraseña.Text; }
            set { txt_contraseña.Text = value; }
        }


        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("El Ususario está vacío");
                txt_usuario.Focus();
                return;
            }
            if (txt_contraseña.Text == "")
            {
                MessageBox.Show("La Contraseña está vacía");
                txt_contraseña.Focus();
                return;
            }

            ne_usuario usuario = new ne_usuario();
            if (usuario.validar_usuario(txt_usuario.Text, txt_contraseña.Text) == ne_usuario.resultado_validacion.existe)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y contraseña no existen");
            }
        }
    }
}
