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
    public partial class Frm_AltasProveedores : Form
    {
        public string Pp_id_proveedor { get; set; }

        public Frm_AltasProveedores()
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


                proveedor.Insertar();
                MessageBox.Show(" Se registrararon los datos correctamente!");
                this.Close();

            }
            else
            {
                return;
            }

        }
    }
}
