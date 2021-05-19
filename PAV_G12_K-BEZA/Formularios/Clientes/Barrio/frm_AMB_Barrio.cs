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
using PAV_G12_K_BEZA.Formularios.Clientes.Barrio;

namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    public partial class frm_AMB_Barrio : Form
    {
        public string Id_Barrio { get; set; }
        public string Id_Localidad { get; set; }

        public frm_AMB_Barrio()
        {
            InitializeComponent();
        }

        private void frm_AMB_Barrio_Load(object sender, EventArgs e)
        {
            Id_Barrio = "";
        }

        private void lbl_Barrio_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Barrio Barrio = new NE_Barrio();
            if (chk_Todos.Checked == true)
            {
                DataTable Tabla = new DataTable();
                Tabla = Barrio.Recuperar_Todos();
                CargarGrilla(Tabla);
                return;
            }
            if (txt_Barrio.Text != "")
            {
                CargarGrilla(Barrio.Recuperar_X_Patron(txt_Barrio.Text));
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            dgv_Barrio.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Barrio.Rows.Add();
                dgv_Barrio.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_barrio"].ToString();
                dgv_Barrio.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion_localidad"].ToString();
                dgv_Barrio.Rows[i].Cells["id_barrio"].Value = tabla.Rows[i]["id_barrio"].ToString();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_A_Barrio Alta = new frm_A_Barrio();
            Alta.ShowDialog();
            dgv_Barrio.Rows.Clear();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_Barrio=="")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            frm_M_Barrio Modificar = new frm_M_Barrio();
            Modificar.Id_Barrio = Id_Barrio;
            Modificar.ShowDialog();
            dgv_Barrio.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Barrio == "")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            frm_B_Barrio Borrar = new frm_B_Barrio();
            Borrar.Id_Barrio = Id_Barrio;
            Borrar.ShowDialog();
            dgv_Barrio.Rows.Clear();
            Id_Barrio = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_Barrio = dgv_Barrio.CurrentRow.Cells["id_barrio"].Value.ToString();
            Id_Localidad = dgv_Barrio.CurrentRow.Cells["id_localidad"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Barrio.Rows.Clear();
            txt_Barrio.Clear();
        }
    }
}
