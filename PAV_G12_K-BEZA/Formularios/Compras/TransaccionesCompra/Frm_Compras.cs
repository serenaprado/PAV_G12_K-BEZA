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



namespace PAV_G12_K_BEZA.Formularios.Compras.TransaccionCompras
{
    public partial class Frm_Compras : Form
    {
        NE_Cliente cliente = new NE_Cliente();
        NE_Compras compras01 = new NE_Compras();
        NE_Empleados empleado = new NE_Empleados();
        TratamientosEspeciales tratamiento = new TratamientosEspeciales();
        NE_Factura Facturaa = new NE_Factura();

        public Frm_Compras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            cmb_ProductoVenta.CargarCombo();
            cmb_KitVenta.CargarCombo();
            cmb_empleado.CargarCombo();
            cmb_FormaDePago.CargarCombo();
            cmb_TipoDocumento.CargarCombo();
            cmb_FormaDePago.CargarCombo();
            cmb_tipoFactura.CargarCombo();
            txt_FechaCompra.Text = tratamiento.RecuperarFecha();
        }

        private void textBox012_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (txt_cantidadProd.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad");
                return;
            }
            if(cmb_ProductoVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el producto");
                return;
            }
            for (int i = 0; i < grid_productos.Rows.Count; i++)
            {
                if(grid_productos.Rows[i].Cells[0].Value.ToString() == cmb_ProductoVenta.SelectedValue.ToString())
                {
                    bandera = true;
                }
            }
            if (bandera == true)
            {
                MessageBox.Show("Ya se cargo el producto");
                return;
            }

            

            grid_productos.Rows.Add(
                cmb_ProductoVenta.SelectedValue.ToString()
                , cmb_ProductoVenta.Text
                , txt_cantidadProd.Text
                , compras01.RecuperarValorProducto(cmb_ProductoVenta.SelectedValue.ToString())
                , Convert.ToInt32(compras01.RecuperarValorProducto(cmb_ProductoVenta.SelectedValue.ToString())) * Convert.ToInt32(txt_cantidadProd.Text)                
                );

            txt_precioTotal.Text = PrecioTotal();
        }

        private void btn_productoKit_Click(object sender, EventArgs e)
        {

            bool bandera = false;
            if (txt_cantidadKit.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad");
                return;
            }
            if (cmb_KitVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el kit");
                return;
            }
            for (int i = 0; i < grid_Kit.Rows.Count; i++)
            {
                if (grid_Kit.Rows[i].Cells[0].Value.ToString() == cmb_KitVenta.SelectedValue.ToString())
                {
                    bandera = true;
                }
            }
            if (bandera == true)
            {
                MessageBox.Show("Ya se cargo el kit");
                return;
            }


            grid_Kit.Rows.Add(
                cmb_KitVenta.SelectedValue.ToString()
                , cmb_KitVenta.Text
                , txt_cantidadKit.Text
                , compras01.RecuperarValorKit(cmb_KitVenta.SelectedValue.ToString())
                , Convert.ToInt32(compras01.RecuperarValorKit(cmb_KitVenta.SelectedValue.ToString())) * Convert.ToInt32(txt_cantidadKit.Text)
                );
            txt_precioTotal.Text = PrecioTotal();
        }


        private string PrecioTotal()
        {
            double calculo = 0;
            for (int i = 0; i < grid_Kit.Rows.Count; i++)
            {
                calculo += double.Parse(grid_Kit.Rows[i].Cells[4].Value.ToString());
            }
            for (int i = 0; i < grid_productos.Rows.Count; i++)
            {
                calculo += double.Parse(grid_productos.Rows[i].Cells[4].Value.ToString());
            }
            return calculo.ToString();
        }

        private void cmb_ProductoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_ProdPrecioUnitario.Text = compras01.RecuperarValorProducto(cmb_ProductoVenta.SelectedValue.ToString());
        }

        private void cmb_KitVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_kitPrecioUnit.Text = compras01.RecuperarValorKit(cmb_KitVenta.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_DocCliente.Text != "" && cmb_TipoDocumento.SelectedValue.ToString() != "") { 
                    DataTable tabla = new DataTable();
                    tabla = cliente.Recuperacion_Mixta(txt_DocCliente.Text, cmb_TipoDocumento.SelectedValue.ToString());
                    if (tabla.Rows.Count != 0)
                { 
                    txt_nombreCliente.Text = tabla.Rows[0]["nombre"].ToString();
                    txt_apellidoCliente.Text = tabla.Rows[0]["apellido"].ToString();
                }
                else
                {
                    MessageBox.Show("El Documento cargado no se encuentra registrado");
                }
                return;
            }
            else {
                MessageBox.Show("Faltan cargar datos del tipo de documento/numero documento");
                    }

        }

        private void cmb_empleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = empleado.Recuperar_x_Id(cmb_empleado.SelectedValue.ToString());
            txt_apellidoEmpleado.Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombreEmpleado.Text = tabla.Rows[0]["nombre"].ToString();

        }

        private void btn_registarVenta_Click(object sender, EventArgs e)
        {
            Facturaa.Id_empleado = cmb_empleado.SelectedValue.ToString();
            Facturaa.Id_Cliente = txt_DocCliente.Text;
            Facturaa.Fecha_emision = txt_FechaCompra.Text;
            Facturaa.IdTipoFactura = cmb_tipoFactura.SelectedValue.ToString();
            Facturaa.Id_forma_pago = cmb_FormaDePago.SelectedValue.ToString();
            Facturaa.TotalCompra = txt_precioTotal.Text;
            Facturaa.Insertar(grid_productos, grid_Kit);
             
        }

        private void btn_CancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
