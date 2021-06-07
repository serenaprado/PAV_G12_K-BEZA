using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Empleados.Perfil;
using PAV_G12_K_BEZA.Formularios.Empleados.Usuario;
using PAV_G12_K_BEZA.Formularios.Empleados.Tipo_Rol;
using PAV_G12_K_BEZA.Formularios.Empleados.Empleado;

namespace PAV_G12_K_BEZA.Formularios.Empleados
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 3)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_ABM_Perfil abmperfil = new frm_ABM_Perfil();
                abmperfil.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            frm_abm_usuario abmusuario = new frm_abm_usuario();
            abmusuario.ShowDialog();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            frm_abm_tipo_rol abmrol = new frm_abm_tipo_rol();
            abmrol.ShowDialog();
        }

        private void btnABMEmpleado_Click(object sender, EventArgs e)
        {
            frm_ABM_Empleados abmempleado = new frm_ABM_Empleados();
            abmempleado.ShowDialog();
        }
    }
}

