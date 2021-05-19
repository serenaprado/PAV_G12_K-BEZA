using PAV_G12_K_BEZA.Formularios;
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
    public partial class frm_ABM_Perfil : Form
    {
        public string Id_Perfil { get; set; }
        public frm_ABM_Perfil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Id_Perfil = "";
        }

        

        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Perfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Perfil = dgv_Perfil.CurrentRow.Cells["id_perfil"].Value.ToString();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Perfil Perfil = new NE_Perfil();
            if (chk_Todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = Perfil.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }
            
            
           
            if (txt_Perfil.Text != "")
            {
                CargarGrilla(Perfil.Recuperar_x_Patron(txt_Perfil.Text));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dgv_Perfil.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Perfil.Rows.Add();
                dgv_Perfil.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_perfil"].ToString();
                dgv_Perfil.Rows[i].Cells["id_perfil"].Value = tabla.Rows[i]["id_perfil"].ToString();
            }
        }

        private void txt_Perfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_Perfil == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_M_Modificar modificar = new frm_M_Modificar();
            modificar.Id_Perfil = Id_Perfil;
            modificar.ShowDialog();
            dgv_Perfil.Rows.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_A_Agregar Alta = new frm_A_Agregar();
            Alta.ShowDialog();
            dgv_Perfil.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Perfil == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_B_Eliminar Baja = new frm_B_Eliminar();
            Baja.Id_Perfil = Id_Perfil;
            Baja.ShowDialog();
            dgv_Perfil.Rows.Clear();
            Id_Perfil = "";
        }

        private void lbl_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Perfil.Rows.Clear();
        }
    }
}
