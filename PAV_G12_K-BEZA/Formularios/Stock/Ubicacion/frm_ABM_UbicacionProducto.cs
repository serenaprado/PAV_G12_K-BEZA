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


namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
{
    public partial class frm_UbicacionProducto : Form
    {
        public string Id_Ubicacion { get; set; }

        public frm_UbicacionProducto()
        {
            InitializeComponent();
        }

        private void lbl_UbicacionProducto_Click(object sender, EventArgs e)
        {

        }



        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_UbicacionProducto UbicacionProducto = new NE_UbicacionProducto();
            if (chk_Todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = UbicacionProducto.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }



            if (txt_UbicacionProducto.Text != "")
            {
                CargarGrilla(UbicacionProducto.Recuperar_x_Patron(txt_UbicacionProducto.Text));
            }
        }

        private void chk_Todos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 4)
            {
                MessageBox.Show("No posee permisos necesarios para agregar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_A_Agregar Alta = new frm_A_Agregar();
                Alta.ShowDialog();
                dgv_UbicacionProducto.Rows.Clear();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 4)
            {
                MessageBox.Show("No posee permisos necesarios para modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Ubicacion == "")
                {
                    MessageBox.Show("Debe seleccionar un elemento de la grilla");
                    return;
                }
                frm_M_Modificar modificar = new frm_M_Modificar();
                modificar.Id_Ubicacion = Id_Ubicacion;
                modificar.ShowDialog();
                dgv_UbicacionProducto.Rows.Clear();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 4)
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Ubicacion == "")
                {
                    MessageBox.Show("Debe seleccionar un elemento de la grilla");
                    return;
                }
                frm_B_Eliminar Baja = new frm_B_Eliminar();
                Baja.Id_Ubicacion = Id_Ubicacion;
                Baja.ShowDialog();
                dgv_UbicacionProducto.Rows.Clear();
                Id_Ubicacion = "";
            }
        }



        private void CargarGrilla(DataTable tabla)
        {
            dgv_UbicacionProducto.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_UbicacionProducto.Rows.Add();
                dgv_UbicacionProducto.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_ubicacion"].ToString();
                dgv_UbicacionProducto.Rows[i].Cells["id_ubicacion"].Value = tabla.Rows[i]["id_ubicacion"].ToString();
            }
        }

        private void dgv_UbicacionProducto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            Id_Ubicacion = dgv_UbicacionProducto.CurrentRow.Cells["id_ubicacion"].Value.ToString();

        }

        private void txt_UbicacionProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_UbicacionProducto.Rows.Clear();
            txt_UbicacionProducto.Clear();

        }

        private void frm_UbicacionProducto_Load(object sender, EventArgs e)
        {
            Id_Ubicacion = "";
        }
    }
}
