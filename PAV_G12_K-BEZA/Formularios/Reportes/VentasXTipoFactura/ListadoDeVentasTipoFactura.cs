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


namespace PAV_G12_K_BEZA.Formularios.Reportes.VentasXTipoFactura
{
    public partial class ListadoDeVentasTipoFactura : Form
    {
        public ListadoDeVentasTipoFactura()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ListadoDeVentasTipoFactura_Load(object sender, EventArgs e)
        {
            cbo_TipoFactura.CargarCombo();
            
            
            this.rpt_ventas_tipo_factura.RefreshReport();
        }

        private void ArmarReporteVentas(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DSListadoDeVentasTipoFactura", table);
            rpt_ventas_tipo_factura.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.VentasXTipoFactura.ListadoDeVentasTipoFactura.rdlc";
            rpt_ventas_tipo_factura.LocalReport.DataSources.Clear();
            rpt_ventas_tipo_factura.LocalReport.DataSources.Add(PaqueteDatos);
            rpt_ventas_tipo_factura.RefreshReport();
        }

        private DataTable ReporteVentasTipoFactura()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            
            String sql = @"SELECT  c.id_compra, convert(char(10), c.fecha, 103) as 'fecha_emision', c.id_empleado, d.numero_factura , d.total, t.descripcion_tipo_factura 
                            FROM Compra c JOIN Factura d ON c.fecha = d.fecha_emision JOIN Tipo_Factura t ON d.id_tipo_factura = t.id_tipo_factura 
                            WHERE ";
            if (cbo_TipoFactura.SelectedIndex != -1)
            {
                sql = sql + "d.id_tipo_factura = '" + cbo_TipoFactura.SelectedValue.ToString() + "'";
            }
            
            if (txt_fecha_desde.Text != "  /  /" && txt_fecha_hasta.Text == "  /  /")
            {
                sql = sql + " and convert(datetime,d.fecha_emision,103) > convert (datetime, '"+ txt_fecha_desde.Text + "',103)";

            }
            else if (txt_fecha_desde.Text == "  /  /" && txt_fecha_hasta.Text != "  /  /")
            {
                sql = sql + " and convert(datetime,d.fecha_emision,103) < convert (datetime, '"+ txt_fecha_desde.Text + "',103)";

            }
            else if (txt_fecha_desde.Text != "  /  /" && txt_fecha_hasta.Text != "  /  /")
            {
                if (DateTime.ParseExact(txt_fecha_hasta.Text, "dd/MM/yyyy", null) < DateTime.ParseExact(txt_fecha_desde.Text, "dd/MM/yyyy", null))
                {
                    String fecha = txt_fecha_hasta.Text;
                    txt_fecha_hasta.Text = txt_fecha_desde.Text;
                    txt_fecha_desde.Text = fecha;
                }
                sql = sql + " and convert(datetime, d.fecha_emision, 103) between convert(datetime, '"+txt_fecha_desde.Text + "',103) AND convert (datetime, '"+txt_fecha_hasta.Text + "',103)";
            }            
            return _BD.Ejecutar_Select(sql);
        }


        private void CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteVentasTipoFactura();
            ArmarReporteVentas(tabla);
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
            if (cbo_TipoFactura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo Factura");
            }
            else
            {
                CalcularDatosUsuarios();
            }                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
