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
    public partial class frm_AltaProducto : Form
    {

        public string Pp_id_usuario { get; set; }

        public frm_AltaProducto()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro Desea Cancelar?", "Atencion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            this.Close();

        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Productos producto = new NE_Productos();

                producto.Pp_descripcion = txt_Descripcion.Text;
                producto.Pp_precio = txt_Precio.Text;
                producto.Pp_id_tipo_producto = cmb_Tipos.SelectedValue.ToString();
                producto.Pp_color = txt_Color.Text;
                producto.Pp_material_principal = txt_MaterialPrincipal.Text;
                producto.Pp_peso = txt_Peso.Text;
                producto.Pp_largo = txt_Largo.Text;
                producto.Pp_ancho = txt_Ancho.Text;
                producto.Pp_alto = txt_Alto.Text;
                producto.Pp_tiempo_garantia = txt_TiempoGarantia.Text;

                DialogResult dialogResult = MessageBox.Show("¿Desea Insertar Estos Datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    producto.Insertar();
                    MessageBox.Show("Insercion de Datos Exitosa");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                this.Close();    

            }
            else
            {
                return;
            }
        }

        private void frm_AltaProducto_Load(object sender, EventArgs e)
        {
            cmb_Tipos.CargarCombo();
        }

        private void txt_Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
