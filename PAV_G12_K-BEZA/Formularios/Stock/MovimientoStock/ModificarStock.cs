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
    public partial class frm_ModificarStock : Form
    {
        public string Id_productoStock { get; set; }
        public string Id_ubicacionStock { get; set; }

        public frm_ModificarStock()
        {
            InitializeComponent();
        }

        private void frm_ModificarStock_Load(object sender, EventArgs e)
        {
            cmb_Producto.CargarCombo();
            cmb_Ubicacion.CargarCombo();
            NE_Stock stock = new NE_Stock();
            MostrarDatos(stock.Recuperar_x_Id(Id_productoStock, Id_ubicacionStock));
        }
        private void MostrarDatos(DataTable tabla)
        {
            cmb_Producto.SelectedValue = int.Parse(tabla.Rows[0]["id_producto"].ToString());
            cmb_Ubicacion.SelectedValue = int.Parse(tabla.Rows[0]["id_ubicacion"].ToString());
            txtCantidad.Text = tabla.Rows[0]["cantidad"].ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Stock stock = new NE_Stock();

                stock.Pp_id_producto = Id_productoStock;
                stock.Pp_id_ubicacion = Id_ubicacionStock;
                stock.Pp_cantidad = txtCantidad.Text;

                stock.Modificar();
                MessageBox.Show("Se cambiaron los datos correctamente");
                this.Close();
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
