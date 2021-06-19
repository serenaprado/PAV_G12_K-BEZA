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
using Microsoft.Reporting.WinForms;

namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoProductosXDeposito
{
    public partial class FrmReporteProducto : Form
    {

        public FrmReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            comboBox011.CargarCombo();
            cbUbicacion.CargarCombo();
            this.rv_producto.RefreshReport();
        }

        private DataTable ReporteProductoXUbicacion()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select p.id_producto ,p.descripcion, p.precio , p.id_proveedor
                        from producto p join stock s on (p.id_producto = s.id_producto)
                        join ubicacion_producto up on (s.id_ubicacion = up.id_ubicacion)
                        Where ";

            if (comboBox011.SelectedIndex != -1 && cbUbicacion.SelectedIndex != -1)
            {

                sql = sql + "p.id_producto = '" + comboBox011.SelectedValue.ToString() + "'";
                sql = sql + "AND up.id_ubicacion = '" + cbUbicacion.SelectedValue.ToString() + "'";
            }
            
            return _BD.Ejecutar_Select(sql);
        }


        private DataTable ReporteProductoXUbicacionLimite()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select p.id_producto ,p.descripcion, p.precio , p.id_proveedor
                        from producto p join stock s on (p.id_producto = s.id_producto)
                        join ubicacion_producto up on (s.id_ubicacion = up.id_ubicacion)
                        Where ";

            if (comboBox011.SelectedIndex != -1 && cbUbicacion.SelectedIndex != -1)
            {

                sql = sql + "p.id_producto = '" + comboBox011.SelectedValue.ToString() + "'";
                sql = sql + "AND up.id_ubicacion = '" + cbUbicacion.SelectedValue.ToString() + "'";
                sql = sql + " AND p.precio BETWEEN '" + Convert.ToInt32(txt_desde.Text) + "' AND '" + Convert.ToInt32(txt_hasta.Text) + "'";
            }
            //
            return _BD.Ejecutar_Select(sql);
        }



        private void CalcularDatosProducto()
        {
            DataTable tabla = new DataTable();
            if (ch_limite.Checked == true)
            {
                if (txt_desde.Text != "" && txt_hasta.Text != "")
                {
                    tabla = ReporteProductoXUbicacionLimite();
                }
                else
                {
                    MessageBox.Show("No ingreso los Limites");
                }
            }
            else
            {
                tabla = ReporteProductoXUbicacion();
            }

            
            ArmarReporteProducto(tabla);
        }

        private void ArmarReporteProducto(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteProductoXDeposito", tabla);
            rv_producto.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ListadoProductosXDeposito.ReporteProductoXDeposito.rdlc";
            rv_producto.LocalReport.DataSources.Clear();
            rv_producto.LocalReport.DataSources.Add(PaqueteDatos);
            rv_producto.RefreshReport();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox011.SelectedIndex == -1 || cbUbicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Producto y Ubicacion");
            }
            else
            {
                CalcularDatosProducto();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
