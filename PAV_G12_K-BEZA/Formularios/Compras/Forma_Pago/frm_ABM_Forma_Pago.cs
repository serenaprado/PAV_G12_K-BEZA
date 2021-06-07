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

namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
    public partial class frm_ABM_Forma_Pago : Form
    {
        public frm_ABM_Forma_Pago()
        {
            InitializeComponent();
        }

        public string Id_Forma_Pago { get; set; }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Forma_Pago Forma_Pago = new NE_Forma_Pago();
            if (chk_Todos.Checked == true)
            {
                DataTable Tabla = new DataTable();
                Tabla = Forma_Pago.Recuperar_Todos();
                CargarGrilla(Tabla);
                return;
            }
            if (txt_Forma_Pago.Text != "")
            {
                CargarGrilla(Forma_Pago.Recuperar_X_Patron(txt_Forma_Pago.Text));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dgv_Forma_Pago.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Forma_Pago.Rows.Add();
                dgv_Forma_Pago.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_forma_pago"].ToString();
                dgv_Forma_Pago.Rows[i].Cells["id_forma_pago"].Value = tabla.Rows[i]["id_forma_pago"].ToString();
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_Forma_Pago = dgv_Forma_Pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para agregar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_A_Forma_Pago Alta = new frm_A_Forma_Pago();
                Alta.ShowDialog();
                dgv_Forma_Pago.Rows.Clear();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Forma_Pago == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                }
                frm_M_Forma_Pago Modificar = new frm_M_Forma_Pago();
                Modificar.Id_Forma_Pago = Id_Forma_Pago;
                Modificar.ShowDialog();
                dgv_Forma_Pago.Rows.Clear();
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
                if (Id_Forma_Pago == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                }
                frm_B_Forma_Pago Borrar = new frm_B_Forma_Pago();
                Borrar.Id_Forma_Pago = Id_Forma_Pago;
                Borrar.ShowDialog();
                dgv_Forma_Pago.Rows.Clear();
                Id_Forma_Pago = "";
            }
        }
        private void frm_ABM_Forma_Pago_Load(object sender, EventArgs e)
        {
            Id_Forma_Pago = "";
        }

        private void dgv_Forma_Pago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Forma_Pago = dgv_Forma_Pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();

        }

        private void dgv_Forma_Pago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Forma_Pago = dgv_Forma_Pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_Forma_Pago.Rows.Clear();
            txt_Forma_Pago.Clear();
        }
    }
}
