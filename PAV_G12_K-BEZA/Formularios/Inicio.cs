using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Compras;
using PAV_G12_K_BEZA.Formularios.Empleados;
using PAV_G12_K_BEZA.Formularios.Stock;
using PAV_G12_K_BEZA.Formularios;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA
{
    public partial class Inicio : Form
    {
        public static int id_perfil_actual = 0;
        int id_usuario = 0;
        int id_empleado = 0;
        int id_perfil = 0;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (id_perfil_actual > 4)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                frmClientes clientes = new frmClientes();
                clientes.ShowDialog();
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (id_perfil_actual > 4)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                frmCompras compras = new frmCompras();
                compras.ShowDialog();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                frmEmpleados empleados = new frmEmpleados();
                empleados.ShowDialog();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();

            ne_usuario usuario = new ne_usuario();
            id_usuario = usuario.recuperar_id_usuario(login.Pp_usuario, login.Pp_contraseña);
            login.Dispose();

            ne_usuario perfil_usuario = new ne_usuario();
            id_perfil_actual = perfil_usuario.recuperar_id_perfil(login.Pp_usuario, login.Pp_contraseña);
        }
    }
}
