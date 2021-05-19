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

namespace PAV_G12_K_BEZA.Formularios.Empleados.Usuario
{
    public partial class frm_alta_usuario : Form
    {
        public frm_alta_usuario()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_alta_usuario_Load_1(object sender, EventArgs e)
        {
            BE_AccesoDatos _bd = new BE_AccesoDatos();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT id_perfil, descripcion_perfil FROM Perfil";
            tabla = _bd.Ejecutar_Select(sql);
            cmb_id_perfil.DisplayMember = "descripcion_perfil";
            cmb_id_perfil.ValueMember = "id_perfil";
            cmb_id_perfil.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (txt_clave.Text != txt_rep_clave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            else
            {
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
                {
                    ne_usuario usuario = new ne_usuario();

                    usuario.pp_usuario = txt_nombre_usuario.Text;
                    usuario.pp_clave = txt_clave.Text;
                    usuario.pp_id_empleado = txt_id_empleado.Text;
                    usuario.pp_id_perfil = cmb_id_perfil.SelectedValue.ToString();
                    usuario.insertar();
                }
                else
                {
                    return;
                }
            }
            this.Close();
        }
    }
}
