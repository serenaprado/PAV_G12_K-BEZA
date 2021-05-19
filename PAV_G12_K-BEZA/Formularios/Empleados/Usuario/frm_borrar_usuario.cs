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
    public partial class frm_borrar_usuario : Form
    {

        public string ID_usuario { get; set; }

        public frm_borrar_usuario()
        {
            InitializeComponent();
        }

        private void mostrar_datos (DataTable tabla)
        {
            txt_nombre_usuario.Text = tabla.Rows[0]["usuario"].ToString();
            txt_clave.Text = tabla.Rows[0]["clave"].ToString();
            txt_id_usuario.Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_id_empleado.Text = tabla.Rows[0]["id_empleado"].ToString();
            cmb_id_perfil.SelectedValue = int.Parse(tabla.Rows[0]["id_perfil"].ToString());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            ne_usuario usuario = new ne_usuario() { pp_id_usuario = ID_usuario };
            if (MessageBox.Show("¿Está seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                usuario.borrar(ID_usuario);
            }
            this.Close();
        }

        private void frm_borrar_usuario_Load(object sender, EventArgs e)
        {
            BE_AccesoDatos _bd = new BE_AccesoDatos();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT id_perfil, descripcion_perfil FROM Perfil";
            tabla = _bd.Ejecutar_Select(sql);
            cmb_id_perfil.DisplayMember = "descripcion_perfil";
            cmb_id_perfil.ValueMember = "id_perfil";
            cmb_id_perfil.DataSource = tabla;

            ne_usuario usuario = new ne_usuario();
            mostrar_datos(usuario.recuperar_x_id(ID_usuario));
        }
    }
}
