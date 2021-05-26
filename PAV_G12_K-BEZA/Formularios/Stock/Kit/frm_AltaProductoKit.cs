using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Negocio;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    public partial class frm_AltaProductoKit : Form
    {
        public string Id_kit { get; set; }
        public string Id_producto { get; set; }
        public frm_AltaProductoKit()
        {
            InitializeComponent();
        }

        private void frm_AltaProductoKit_Load(object sender, EventArgs e)
        {
            NE_Kit productos = new NE_Kit();
            DataTable tabla = new DataTable();
            tabla = productos.RecuperarProductos_x_Id2(Id_kit);
            CargarGrilla(tabla);
            return;
        }

        private void CargarGrilla(DataTable tabla)
        {
            dgvProducto.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvProducto.Rows.Add();
                dgvProducto.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                dgvProducto.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion1"].ToString();
                dgvProducto.Rows[i].Cells["idproducto"].Value = tabla.Rows[i]["id_producto"].ToString();
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_producto = dgvProducto.CurrentRow.Cells["idproducto"].Value.ToString();
            NE_Productos producto = new NE_Productos();
            MostrarDatos(producto.Recuperar_x_Id(Id_producto));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Id_producto=="")
            {
                MessageBox.Show("Debe seleccionar un Producto de la Grilla");
                return;
            }
            else
            {
                if (txtCantidad.Text=="")
                {
                    MessageBox.Show("Debe ingresar una cantidad valida");
                    return;
                }
                else
                {
                    TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
                    if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
                    {
                        NE_Kit Kit = new NE_Kit();

                        Kit.Pp_id_kit = Id_kit;
                        Kit.pp_id_producto = Id_producto;
                        Kit.pp_cantidad = int.Parse(txtCantidad.Text);

                        DialogResult dialogResult = MessageBox.Show("¿Desea Agregar el Producto?", "Confirmacion", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Kit.InsertarProducto();
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
