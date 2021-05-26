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

namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    public partial class frm_ConsultaKit : Form
    {
        public string Id_kit { get; set; }
        public string Id_producto { get; set; }
        public frm_ConsultaKit()
        {
            InitializeComponent();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0]["descripcion_kit"].ToString();
            txt_Precio.Text = tabla.Rows[0]["precio"].ToString();

        }

        private void frm_ConsultaKit_Load(object sender, EventArgs e)
        {
            NE_Kit productos = new NE_Kit();
            DataTable tabla = new DataTable();
            tabla = productos.RecuperarProductos_x_Id(Id_kit);
            CargarGrilla(tabla);
            NE_Kit producto = new NE_Kit();
            MostrarDatos(producto.Recuperar_x_Id(Id_kit));
            return;

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
    }
}
