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
using PAV_G12_K_BEZA.Formularios.Stock.Productos;

namespace PAV_G12_K_BEZA.Formularios.Stock.Productos
{
    public partial class frm_ABM_Producto : Form
    {

        public string Id_Producto { get; set; }

        public frm_ABM_Producto()
        {
            InitializeComponent();
        }

        

        private void frm_ABM_Producto_Load(object sender, EventArgs e)
        {
            cmb_Tipos.CargarCombo();
            Id_Producto = "";
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            cmb_Tipos.SelectedIndex = -1;
            grid_Productos.Rows.Clear();
            
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            {
                NE_Productos productos = new NE_Productos();

                if (chk_Todos.Checked == false && txt_Nombre.Text == string.Empty && cmb_Tipos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar alguna opción", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (chk_Todos.Checked == true)
                {
                    DataTable tabla = new DataTable();
                    tabla = productos.RecuperarTodos();
                    CargarGrilla(tabla);
                    return;
                }
                if (chk_Todos.Checked == false
                    && cmb_Tipos.SelectedIndex != -1
                    && txt_Nombre.Text != "")
                {
                    CargarGrilla(productos.Recuperar_Mixto(txt_Nombre.Text, cmb_Tipos.SelectedValue.ToString()));
                    return;
                }
                if (cmb_Tipos.SelectedIndex != -1)
                {
                    CargarGrilla(productos.Recuperar_x_Perfiles(cmb_Tipos.SelectedValue.ToString()));
                    return;
                }
                if (txt_Nombre.Text != "")
                {
                    CargarGrilla(productos.Recuprar_x_Patron(txt_Nombre.Text));
                }
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_Productos.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Productos.Rows.Add();
                grid_Productos.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_Productos.Rows[i].Cells[1].Value = tabla.Rows[i]["precio"].ToString();
                grid_Productos.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion1"].ToString();
                grid_Productos.Rows[i].Cells["id_producto"].Value = tabla.Rows[i]["id_producto"].ToString();
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            frm_AltaProducto alta = new frm_AltaProducto();
            alta.ShowDialog();
            cmb_Tipos.SelectedIndex = -1;
            grid_Productos.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Producto == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_BorrarProducto borrar = new frm_BorrarProducto();
            borrar.Id_producto = Id_Producto;
            borrar.ShowDialog();
            cmb_Tipos.SelectedIndex = -1;
            grid_Productos.Rows.Clear();
            Id_Producto = "";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_Producto == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_ModiifcarProducto modificar = new frm_ModiifcarProducto();
            modificar.Id_producto = Id_Producto;
            modificar.ShowDialog();
            cmb_Tipos.SelectedIndex = -1;
            grid_Productos.Rows.Clear();
        }

        private void grid_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Producto = grid_Productos.CurrentRow.Cells["id_producto"].Value.ToString();
        }

        private void grid_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_MostrarProducto mostrar = new frm_MostrarProducto();
            mostrar.Id_producto = grid_Productos.CurrentRow.Cells["id_producto"].Value.ToString();
            mostrar.ShowDialog();
        }
    }
}
