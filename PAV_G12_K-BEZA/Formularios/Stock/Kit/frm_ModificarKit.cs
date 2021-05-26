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

namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    public partial class frm_ModifcarKit : Form
    {

        public string Id_kit { get; set; }

        public frm_ModifcarKit()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txt_Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            NE_Kit productos = new NE_Kit();
            DataTable tabla = new DataTable();
            tabla = productos.RecuperarProductos_x_Id(Id_kit);
            CargarGrilla(tabla);
            NE_Kit Kit = new NE_Kit();
            MostrarDatos(Kit.Recuperar_x_Id(Id_kit));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0][1].ToString();
            txt_Precio.Text = tabla.Rows[0][2].ToString();
            

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Kit Kit = new NE_Kit();

                Kit.Pp_id_kit = Id_kit;
                Kit.Pp_descripcion = txt_Descripcion.Text;
                Kit.Pp_precio = txt_Precio.Text;
                
                
                Kit.Modificar();
                MessageBox.Show("Se cambiaron los datos correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dgvProducto.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvProducto.Rows.Add();
                dgvProducto.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                dgvProducto.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion1"].ToString();
                dgvProducto.Rows[i].Cells["idproducto"].Value = tabla.Rows[i]["id_producto"].ToString();
                dgvProducto.Rows[i].Cells["cantidad"].Value = tabla.Rows[i]["cantidad"].ToString();
            }

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ModifcarProductoKit modifica = new frm_ModifcarProductoKit();
            modifica.Id_producto = dgvProducto.CurrentRow.Cells["idproducto"].Value.ToString();
            modifica.Id_kit = Id_kit;
            modifica.ShowDialog();
            NE_Kit productos = new NE_Kit();
            DataTable tabla = new DataTable();
            tabla = productos.RecuperarProductos_x_Id(Id_kit);
            dgvProducto.Rows.Clear();
            CargarGrilla(tabla);
        }
    }
}
