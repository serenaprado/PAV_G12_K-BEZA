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
    public partial class frm_AltaKit : Form
    {

        public string Pp_id_usuario { get; set; }

        public frm_AltaKit()
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
                NE_Kit Kit = new NE_Kit();

                Kit.Pp_descripcion = txt_Descripcion.Text;
                Kit.Pp_precio = txt_Precio.Text;

                DialogResult dialogResult = MessageBox.Show("¿Desea Insertar Estos Datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Kit.Insertar();
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
        }

        private void txt_Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
