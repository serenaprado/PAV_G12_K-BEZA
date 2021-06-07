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
    public partial class frm_abm_usuario : Form
    {

        public string ID_usuario { get; set; }

        public frm_abm_usuario()
        {
            InitializeComponent();
        }

        private void frm_abm_usuario_Load(object sender, EventArgs e)
        {
            BE_AccesoDatos _bd = new BE_AccesoDatos();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT id_perfil, descripcion_perfil FROM Perfil";
            tabla = _bd.Ejecutar_Select(sql);
            cmb_perfiles.DisplayMember = "descripcion_perfil";
            cmb_perfiles.ValueMember = "id_perfil";
            cmb_perfiles.DataSource = tabla;
            ID_usuario = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_perfiles.SelectedIndex = -1;
            grid_usuarios.Rows.Clear();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ne_usuario usuario = new ne_usuario();

            if (chk_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = usuario.recuperar_todo();
                cargar_grilla(tabla);
                return;
            }

            if (cmb_perfiles.SelectedIndex != -1)
            {
                cargar_grilla(usuario.recuperar_x_perfiles(cmb_perfiles.SelectedValue.ToString()));
                return;
            }

            if (txt_patron.Text != "")
            {
                cargar_grilla(usuario.recuperar_x_patron(txt_patron.Text));
            }
        }

        private void cargar_grilla(DataTable tabla)
        {

            grid_usuarios.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_usuarios.Rows.Add();
                grid_usuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["id_usuario"].ToString();
                grid_usuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["usuario"].ToString();
                grid_usuarios.Rows[i].Cells[2].Value = tabla.Rows[i]["id_empleado"].ToString();
                grid_usuarios.Rows[i].Cells[3].Value = tabla.Rows[i]["id_perfil"].ToString();
                grid_usuarios.Rows[i].Cells[4].Value = tabla.Rows[i]["descripcion_perfil"].ToString();
                grid_usuarios.Rows[i].Cells["num_usuario"].Value = tabla.Rows[i]["id_usuario"].ToString();
            }
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 3)
            {
                MessageBox.Show("No posee permisos necesarios para agregar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_alta_usuario alta = new frm_alta_usuario();
                alta.ShowDialog();
                grid_usuarios.Rows.Clear();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_usuario = grid_usuarios.CurrentRow.Cells["num_usuario"].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 3)
            {
                MessageBox.Show("No posee permisos necesarios para modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ID_usuario == "")
                {
                    MessageBox.Show("Debe seleccionar un elemento de la grilla");
                    return;
                }
                frm_modif_usuario modificar = new frm_modif_usuario();
                modificar.ID_usuario = ID_usuario;
                modificar.ShowDialog();
                grid_usuarios.Rows.Clear();
            }
        }

        private void grid_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_consultar_usuario consulta = new frm_consultar_usuario();
            consulta.ID_usuario = grid_usuarios.CurrentRow.Cells["num_usuario"].Value.ToString();
            consulta.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 3)
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ID_usuario == "")
                {
                    MessageBox.Show("Debe seleccionar un elemento de la grilla");
                    return;
                }
                frm_borrar_usuario borrar = new frm_borrar_usuario();
                borrar.ID_usuario = ID_usuario;
                borrar.ShowDialog();
                grid_usuarios.Rows.Clear();
                ID_usuario = "";
            }
        }
    }
}

