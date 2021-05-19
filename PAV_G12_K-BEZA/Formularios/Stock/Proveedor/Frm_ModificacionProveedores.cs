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
    public partial class Frm_ModificacionProveedores : Form
    {   
        public string Id_proveedor { get; set; }

        public Frm_ModificacionProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AltasProveedores_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo();
            NE_Proveedores proveedor = new NE_Proveedores();
            MostrarDatos(proveedor.Recuperar_x_id(Id_proveedor));
        }

        private void btn_AltaProvedoor_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Proveedores proveedor = new NE_Proveedores();

                proveedor.Pp_razonSocial = txt_razon.Text;
                proveedor.Pp_telefono = txt_telefono.Text;
                proveedor.Pp_apellidoContacto = txt_apellido.Text;
                proveedor.Pp_nombreContacto = txt_nombre.Text;
                proveedor.Pp_calle = txt_calle.Text;
                proveedor.Pp_nro = txt_numero.Text;
                proveedor.Pp_barrio = cmb_barrio.SelectedValue.ToString();
                proveedor.Pp_id_proveedor = Id_proveedor;

                proveedor.Modificar();
                MessageBox.Show(" Se cambiaron los datos correctamente!");
                this.Close();
                

            }
            else
            {
                return;
            }

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
    }
}
