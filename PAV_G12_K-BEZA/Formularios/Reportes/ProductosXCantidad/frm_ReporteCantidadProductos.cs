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
using Microsoft.Reporting.WinForms;

namespace PAV_G12_K_BEZA.Formularios.Reportes.ProductosXCantidad
{
    public partial class frm_ReporteCantidadProductos : Form
    {
        public frm_ReporteCantidadProductos()
        {
            InitializeComponent();
        }

        private void frm_ReporteCantidadProductos_Load(object sender, EventArgs e)
        {
            this.rpv_cantidad.RefreshReport();
        }

        private DataTable ReporteCantidadProducto()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select df.numero_factura, p.descripcion, df.cantidad, df.precio_unitario
                            from Detalle_Factura df join Producto p ON(df.id_producto = p.id_producto)
                            Where ";

            if (txt_Minimo.Text == "")
            {
                MessageBox.Show("Debe Ingresar Cantidad Minima, se mostraran las ventas con cantidades menores a la Cantidad Maxima");
                sql = sql + "df.cantidad < '" + txt_Maximo.Text + "'";
            }
            else if (txt_Maximo.Text == "")
            {
                MessageBox.Show("Debe Ingresar Cantidad Maxima, se mostraran las ventas con cantidades mayores a la Cantidad Minima");
                sql = sql + " df.cantidad > '" + txt_Minimo.Text + "'";
            }

            if (txt_Minimo.Text != "" && txt_Maximo.Text != "")
            {
                sql = sql + " df.cantidad between '" + txt_Minimo.Text + "' AND '" + txt_Maximo.Text + "'";               
            }
            return _BD.Ejecutar_Select(sql);
        }

        private void CalcularCantidad()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteCantidadProducto();
            ArmarReporteVentas(tabla);
        }

        private void ArmarReporteVentas(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteCantidadProductos", table);
            rpv_cantidad.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ProductosXCantidad.ReporteCantidadProductos.rdlc";
            rpv_cantidad.LocalReport.DataSources.Clear();
            rpv_cantidad.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_cantidad.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            CalcularCantidad();
            txt_Maximo.Clear();
            txt_Minimo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
