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

namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    public partial class frm_M_Modificar : Form
    {
        public string Id_Tipo_Factura { get; set; }

        public frm_M_Modificar()

        {
            InitializeComponent();
        }


        private void MostrarDatos(DataTable tabla)
        {
            txt_Tipo_Factura.Text = tabla.Rows[0]["descripcion_tipo_factura"].ToString();
            txt_tipo_factura_anterior.Text = tabla.Rows[0]["descripcion_tipo_factura"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Tipo_Factura TipoFactura = new NE_Tipo_Factura();
                TipoFactura.Pp_id_tipo_factura = Id_Tipo_Factura;
                TipoFactura.Pp_descripcion_tipo_factura = txt_Tipo_Factura.Text;


                TipoFactura.Modificar();
                MessageBox.Show("Datos modificados correctamente");
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void frm_M_Modificar_Load_1(object sender, EventArgs e)
        {

            NE_Tipo_Factura TipoFactura = new NE_Tipo_Factura();
            MostrarDatos(TipoFactura.Recuperar_x_Id(Id_Tipo_Factura));
        }
    }
}
