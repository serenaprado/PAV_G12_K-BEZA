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

namespace PAV_G12_K_BEZA.Formularios.Reportes.VentasXPeriodo
{
    public partial class frm_ReporteVentasXPeriodo : Form
    {
        public frm_ReporteVentasXPeriodo()
        {
            InitializeComponent();
        }

        private void frm_ReporteVentasXPeriodo_Load(object sender, EventArgs e)
        {
            this.rpv_ventasperiodo.RefreshReport();
        }

        private DataTable ReporteVentasXPeriodo()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select c.id_compra , c.id_cliente, c.fecha, f.numero_factura, tf.descripcion_tipo_factura, f.total
                            from Compra c join factura f on c.id_compra = f.id_compra join Tipo_Factura tf on f.id_tipo_factura = tf.id_tipo_factura Where ";

            if (txt_FechaIni.Text == "")
            {
                MessageBox.Show("Debe Ingresar Fecha Inicial, se mostraran las ventas anteriores a Fecha Final");
                sql = sql + "c.fecha < convert(datetime, '" + txt_FechaFin.Text + "', 103)";             
            }
            else if (txt_FechaFin.Text == "")
            {                
                MessageBox.Show("Debe Ingresar Fecha Final, se mostraran las ventas posteriores a Fecha Inicial");
                sql = sql + "c.fecha > convert(datetime, '" + txt_FechaIni.Text + "', 103)";
            }

            if (txt_FechaIni.Text != "" && txt_FechaFin.Text != "")
            {
                {
                    if (DateTime.ParseExact(txt_FechaFin.Text, "dd/MM/yyyy", null) < DateTime.ParseExact(txt_FechaIni.Text, "dd/MM/yyyy", null))
                    {
                        String fecha = txt_FechaFin.Text;
                        txt_FechaFin.Text = txt_FechaIni.Text;
                        txt_FechaIni.Text = fecha;
                    }
                    sql = sql + "c.fecha between convert(datetime, '" + txt_FechaIni.Text + "', 103) AND convert(datetime, '" + txt_FechaFin.Text + "',103)";
                }
            }             
            return _BD.Ejecutar_Select(sql);
        }

        private void CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteVentasXPeriodo();
            ArmarReporteVentas(tabla);
        }

        private void ArmarReporteVentas(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteVentasXPeriodo", table);
            rpv_ventasperiodo.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.VentasXPeriodo.ReporteVentasXPeriodo.rdlc";
            rpv_ventasperiodo.LocalReport.DataSources.Clear();
            rpv_ventasperiodo.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_ventasperiodo.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CalcularDatosUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
