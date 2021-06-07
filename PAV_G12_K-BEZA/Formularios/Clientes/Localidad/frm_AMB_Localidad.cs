using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Clientes.Localidad;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Clientes.Localidad
{
    public partial class frm_AMB_Localidad : Form
    {
        public string Id_Localidad { get; set; }

        public frm_AMB_Localidad()
        {
            InitializeComponent();
        }

        private void frm_AMB_Localidad_Load(object sender, EventArgs e)
        {
            Id_Localidad = "";
        }

        private void lbl_Localidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Localidad Localidad = new NE_Localidad();
            if (chk_Todos.Checked == true)
            {
                DataTable Tabla = new DataTable();
                Tabla = Localidad.Recuperar_Todos();
                CargarGrilla(Tabla);
                return;
            }
            if (txt_Localidad.Text != "")
            {
                CargarGrilla(Localidad.Recuperar_X_Patron(txt_Localidad.Text));
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            dgv_Localidad.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Localidad.Rows.Add();
                dgv_Localidad.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_localidad"].ToString();
                dgv_Localidad.Rows[i].Cells["id_localidad"].Value = tabla.Rows[i]["id_localidad"].ToString();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para agregar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_A_Localidad Alta = new frm_A_Localidad();
                Alta.ShowDialog();
                dgv_Localidad.Rows.Clear();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Localidad == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                    return;
                }
                frm_M_Localidad Modificar = new frm_M_Localidad();
                Modificar.Id_Localidad = Id_Localidad;
                Modificar.ShowDialog();
                dgv_Localidad.Rows.Clear();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Localidad == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                    return;
                }
                frm_B_Localidad Borrar = new frm_B_Localidad();
                Borrar.Id_Localidad = Id_Localidad;
                Borrar.ShowDialog();
                dgv_Localidad.Rows.Clear();
                Id_Localidad = "";
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_Localidad = dgv_Localidad.CurrentRow.Cells["id_localidad"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Localidad.Rows.Clear();
        }
    }
}
