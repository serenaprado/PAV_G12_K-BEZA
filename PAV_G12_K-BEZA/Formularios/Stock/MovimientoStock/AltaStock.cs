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

namespace PAV_G12_K_BEZA.Formularios.Stock.MovimientoStock
{
    public partial class frm_AltaStock : Form
    {
        public string Id_productoStock { get; set; }
        public string Id_ubicacionStock { get; set; }
        public int bandera { get; set; }

        public frm_AltaStock()
        {
            InitializeComponent();
        }

        private void frm_ModificarStock_Load(object sender, EventArgs e)
        {
            bandera = 0;
            cmb_Ubicacion.CargarCombo();
            cmb_Producto.Enabled = false;
            txtCantidad.Enabled = false;
            bandera = 1;

        }
        

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Stock stock = new NE_Stock();

                stock.Pp_id_producto = cmb_Producto.SelectedValue.ToString();
                stock.Pp_id_ubicacion = cmb_Ubicacion.SelectedValue.ToString();
                stock.Pp_cantidad = txtCantidad.Text;

                DialogResult dialogResult = MessageBox.Show("¿Desea Insertar Estos Datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    stock.Insertar();
                    MessageBox.Show("Insercion de Datos Exitosa");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Cancelar?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void cmb_Ubicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Ubicacion.SelectedIndex!=-1 && bandera==1) 
            {
                cmb_Producto.Enabled = true;
                txtCantidad.Enabled = true;
                cmb_Producto.CargarCombo2(" WHERE id_producto not in (select id_producto from Stock where id_ubicacion ="+cmb_Ubicacion.SelectedValue.ToString()+")");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
