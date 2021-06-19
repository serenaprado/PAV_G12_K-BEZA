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

namespace PAV_G12_K_BEZA.Formularios.Reportes.StockMenor
{
    public partial class Frm_stock : Form
    {
        public Frm_stock()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_stock_Load(object sender, EventArgs e)
        {

            this.rpv_stock.RefreshReport();
        }

        private void btn_reportar_Click(object sender, EventArgs e)
        {
            CalcularDatosUsuarios();

        }


        //private DataTable StockMenor()
        //{
        //    BE_AccesoDatos _BD = new BE_AccesoDatos();

        //    String sql = @"SELECT s.id_producto,  Producto.descripcion,s.cantidad, U.descripcion_ubicacion FROM Producto INNER JOIN Stock s ON Producto.id_producto = s.id_producto INNER JOIN Ubicacion_Producto U ON s.id_ubicacion = U.id_ubicacion where s.cantidad <= 5";
        //    return _BD.Ejecutar_Select(sql);
        //}
        //private DataTable StockMayor()

        //{
        //    BE_AccesoDatos _BD = new BE_AccesoDatos();
        //    String sql = @"SELECT s.id_producto,  Producto.descripcion,s.cantidad, U.descripcion_ubicacion FROM Producto INNER JOIN Stock s ON Producto.id_producto = s.id_producto INNER JOIN Ubicacion_Producto U ON s.id_ubicacion = U.id_ubicacion where s.cantidad >= 25";
        //    return _BD.Ejecutar_Select(sql);


        //}

        private DataTable ReporteVentasMayores()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();



            String sql = @"SELECT s.id_producto, p.descripcion,s.cantidad,
                u.descripcion_ubicacion FROM Producto p INNER JOIN Stock s 
                ON p.id_producto = s.id_producto INNER JOIN Ubicacion_Producto u 
                ON s.id_ubicacion = u.id_ubicacion Where ";


            if (txt_minimo.Text != "" && txt_maximo.Text == "")
            {
                sql = sql + "s.cantidad >'" + txt_minimo.Text + "'";

            }
            else if (txt_minimo.Text == "" && txt_maximo.Text != "")
            {
                sql = sql + "s.cantidad < '" + txt_maximo.Text + "'";

            }
            else if (txt_minimo.Text != "" && txt_maximo.Text != "")
            {
                //if (txt_minimo, null) < DateTime.ParseExact(txt_inicio.Text, "", null))
                //{
                //    String fecha = txt_fin.Text;
                //    txt_fin.Text = txt_inicio.Text;
                //    txt_inicio.Text = fecha;
                //}
                sql = sql + "s.cantidad between '" + txt_minimo.Text + "' AND '" + txt_maximo.Text + "'";
            }
            else if (txt_minimo.Text == "" && txt_maximo.Text == "")
            {
                sql = sql + "s.cantidad = s.cantidad";
            }
                return _BD.Ejecutar_Select(sql);
            }

            //    private void ArmarReporteMayor(DataTable table)
            //{
            //    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", table);
            //    rpv_stock.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Listados.StockMenor.rdlc";
            //    rpv_stock.LocalReport.DataSources.Clear();
            //    rpv_stock.LocalReport.DataSources.Add(PaqueteDatos);
            //    rpv_stock.RefreshReport();
            //}
            private void ArmarReporteStock(DataTable table)
            {
                ReportDataSource PaqueteDatos = new ReportDataSource("ReporteStockMenor", table);
                rpv_stock.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.StockMenor.ReporteStockMenor.rdlc";
                rpv_stock.LocalReport.DataSources.Clear();
                rpv_stock.LocalReport.DataSources.Add(PaqueteDatos);
                rpv_stock.RefreshReport();
            }
            private void CalcularDatosUsuarios()
            {
                DataTable tabla = new DataTable();
                tabla = ReporteVentasMayores();
                ArmarReporteStock(tabla);
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        //private void CalcularReporteMenor()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = StockMenor();
        //    ArmarReporteMenor(tabla);
        //}
        //private void CalcularReporteMayor()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = StockMenor();
        //    ArmarReporteMayor(tabla);
        //}
    }
