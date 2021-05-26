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
using PAV_G12_K_BEZA.Formularios.Stock.Kit;

namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    public partial class frm_ABM_Kit : Form
    {

        public string Id_Kit { get; set; }

        public frm_ABM_Kit()
        {
            InitializeComponent();
        }

        

        private void frm_ABM_Producto_Load(object sender, EventArgs e)
        {
            Id_Kit = "";
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            grid_kit.Rows.Clear();
            txt_Nombre.Clear();
            
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            {
                NE_Kit Kit = new NE_Kit();

                if (chk_Todos.Checked == false && txt_Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar alguna opción", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (chk_Todos.Checked == true)
                {
                    DataTable tabla = new DataTable();
                    tabla = Kit.RecuperarTodos();
                    CargarGrilla(tabla);
                    return;
                }
                
                
                if (txt_Nombre.Text != "")
                {
                    CargarGrilla(Kit.Recuprar_x_Patron(txt_Nombre.Text));
                }
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_kit.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_kit.Rows.Add();
                grid_kit.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_kit"].ToString();
                grid_kit.Rows[i].Cells[1].Value = tabla.Rows[i]["precio"].ToString();
                grid_kit.Rows[i].Cells[2].Value = tabla.Rows[i]["id_kit"].ToString();
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            frm_AltaKit alta = new frm_AltaKit();
            alta.ShowDialog();
            grid_kit.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Kit == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_BorrarKit borrar = new frm_BorrarKit();
            borrar.Id_kit = Id_Kit;
            borrar.ShowDialog();
            grid_kit.Rows.Clear();
            Id_Kit = "";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_Kit == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_ModifcarKit modificar = new frm_ModifcarKit();
            modificar.Id_kit = Id_Kit;
            modificar.ShowDialog();
            grid_kit.Rows.Clear();
        }

        private void grid_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Kit = grid_kit.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Id_Kit == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_AltaProductoKit altaprodkit = new frm_AltaProductoKit();
            altaprodkit.Id_kit = Id_Kit;
            altaprodkit.ShowDialog();
            grid_kit.Rows.Clear();
            Id_Kit = "";
        }

        private void grid_kit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ConsultaKit mostrar = new frm_ConsultaKit();
            mostrar.Id_kit = grid_kit.CurrentRow.Cells[2].Value.ToString();
            mostrar.ShowDialog();
        }
    }
}
