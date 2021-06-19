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

namespace PAV_G12_K_BEZA.Formularios.Reportes.CompraMayorA
{
    public partial class ListadoVentasMayorA : Form
    {
        public ListadoVentasMayorA()
        {
            InitializeComponent();
        }

        private void ListadoVentasMayorA_Load(object sender, EventArgs e)
        {

            this.rpt_ventas.RefreshReport();
        }

        private void rpt_ventas_Load(object sender, EventArgs e)
        {
            
            
        }

        private DataTable ReporteVentasMayores()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();



            String sql = @"Select f.numero_factura as 'NumeroFactura', tf.descripcion_tipo_factura as 'Tipo',c.id_compra 'Compra', CONVERT(char(10),c.fecha,103) as 'Fecha', c.id_empleado as 'Legajo' ,f.total as Total
                            FROM Factura f JOIN Tipo_Factura tf  ON tf.id_tipo_factura = f.id_tipo_factura JOIN Compra c ON f.id_compra = c.id_compra
                            WHERE f.total ";


            if (rbt_Mayor.Checked == true)
            {
                sql = sql + ">" + txt_monto.Text;
            }
            else sql = sql + "<" + txt_monto.Text;

            if (txt_inicio.Text != "  /  /" && txt_fin.Text == "  /  /")
            {
                sql = sql + " and convert(datetime, f.fecha_emision, 103) > convert(datetime,'" + txt_inicio.Text + "',103)";

            }
            else if (txt_inicio.Text == "  /  /" && txt_fin.Text != "  /  /")
            {
                sql = sql + " and convert(datetime, f.fecha_emision,103) < convert(datetime,'" + txt_inicio.Text + "',103)";

            }
            else if (txt_inicio.Text != "  /  /" && txt_fin.Text != "  /  /")
            {
                if (DateTime.ParseExact(txt_fin.Text, "dd/MM/yyyy", null) < DateTime.ParseExact(txt_inicio.Text, "dd/MM/yyyy", null))
                {
                    String fecha = txt_fin.Text;
                    txt_fin.Text = txt_inicio.Text;
                    txt_inicio.Text = fecha;
                }
                sql = sql + " and convert(datetime, f.fecha_emision, 103) between convert(datetime,'" + txt_inicio.Text + "',103) AND convert(datetime,'" + txt_fin.Text + "',103)";
            }
            

            return _BD.Ejecutar_Select(sql);


        }


        private void ArmarReporteVentas(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("VentasMayoresA", table);
            rpt_ventas.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.CompraMayorA.ListadoVentasMayor.rdlc";
            rpt_ventas.LocalReport.DataSources.Clear();
            rpt_ventas.LocalReport.DataSources.Add(PaqueteDatos);
            rpt_ventas.RefreshReport();
        }


        private void CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteVentasMayores();
            ArmarReporteVentas(tabla);
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_monto.Text != "")
            {
                if (rbt_Mayor.Checked == true || rbt_Menor.Checked == true )
                    CalcularDatosUsuarios();
                else MessageBox.Show("Falta seleccionar si el munto va a ser mayor o menor");
            }
            else MessageBox.Show("Faltan cargar con el monto");
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
