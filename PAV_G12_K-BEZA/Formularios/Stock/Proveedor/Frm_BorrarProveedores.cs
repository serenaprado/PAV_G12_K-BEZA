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

namespace PAV_G12_K_BEZA.Formularios.Stock.Proveedor
{
    public partial class Frm_BorrarProveedores : Form
    {   
        public string Id_proveedor { get; set; }

        public Frm_BorrarProveedores()
        {
            InitializeComponent();
        }

        private void MostrarDatos (DataTable tabla)
        {
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_apellido.Text = tabla.Rows[0]["apellido_contacto"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_razon.Text = tabla.Rows[0]["razon_social"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["nro_direccion"].ToString();
        }

        private void Frm_BorrarProveedores_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo();

            NE_Proveedores proveeodres = new NE_Proveedores();
            MostrarDatos(proveeodres.Recuperar_x_id(Id_proveedor));

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Proveedores provedores = new NE_Proveedores() { Pp_id_proveedor = Id_proveedor};

            if (MessageBox.Show("¿Estas seguiro de borrar?", "Importante",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                provedores.Borrar();
                MessageBox.Show("Se borro correctamente ");
                this.Close();
            }
                
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
