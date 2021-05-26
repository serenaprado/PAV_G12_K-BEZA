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
    public partial class frm_BorrarProductoKit : Form
    {

        public string Id_kit { get; set; }
        public string Id_producto { get; set; }

        public frm_BorrarProductoKit()
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
            NE_Kit Kit = new NE_Kit();
            MostrarDatos(Kit.Recuperar_x_Id2(Id_kit,Id_producto));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_Cantidad.Text = tabla.Rows[0]["cantidad"].ToString();
            

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Kit Kit = new NE_Kit();

                Kit.Pp_id_kit = Id_kit;
                Kit.pp_id_producto = Id_producto;
                Kit.pp_cantidad = int.Parse(txt_Cantidad.Text);
                
                
                Kit.BorrarProducto();
                MessageBox.Show("Se eliminaron los datos correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
