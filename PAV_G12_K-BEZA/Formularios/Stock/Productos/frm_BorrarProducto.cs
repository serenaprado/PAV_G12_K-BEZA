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

namespace PAV_G12_K_BEZA.Formularios.Stock.Productos
{
    public partial class frm_BorrarProducto : Form
    {

        public string Id_producto { get; set; }

        public frm_BorrarProducto()
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

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_Precio.Text = tabla.Rows[0]["precio"].ToString();
            cmb_Tipos.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_producto"].ToString());
            txt_Color.Text = tabla.Rows[0]["color"].ToString();
            txt_MaterialPrincipal.Text = tabla.Rows[0]["material_principal"].ToString();
            txt_Peso.Text = tabla.Rows[0]["peso"].ToString();
            txt_Largo.Text = tabla.Rows[0]["largo"].ToString();
            txt_Ancho.Text = tabla.Rows[0]["ancho"].ToString();
            txt_Alto.Text = tabla.Rows[0]["alto"].ToString();
            txt_TiempoGarantia.Text = tabla.Rows[0]["tiempo_garantia"].ToString();
            cmbProveedor.SelectedValue = int.Parse(tabla.Rows[0]["id_proveedor"].ToString());

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            NE_Productos borrar = new NE_Productos();
            DialogResult dialogResult = MessageBox.Show("¿Desea Borrar Este Producto?", "Confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                borrar.Pp_id_producto = Id_producto;
                borrar.Borrar();
                MessageBox.Show("Borrado de Producto Exitoso");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


            
        }

        private void frm_BorrarProducto_Load(object sender, EventArgs e)
        {
            cmb_Tipos.CargarCombo();
            cmbProveedor.CargarCombo();
            NE_Productos producto = new NE_Productos();
            MostrarDatos(producto.Recuperar_x_Id(Id_producto));
        }
    }
}
