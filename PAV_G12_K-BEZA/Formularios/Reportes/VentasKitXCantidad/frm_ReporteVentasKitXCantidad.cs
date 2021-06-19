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

namespace PAV_G12_K_BEZA.Formularios.Reportes.VentasKitXCantidad
{
    public partial class frm_ReporteVentasKitXCantidad : Form
    {
        public frm_ReporteVentasKitXCantidad()
        {
            InitializeComponent();
        }

        private void frm_ReporteVentasKitXCantidad_Load(object sender, EventArgs e)
        {
            this.rpv_kit.RefreshReport();
        }

        private DataTable ReporteVentasKitXCantidad()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select tf.descripcion_tipo_factura, f.numero_factura, c.fecha, k.descripcion_kit, df.cantidad, f.total from Factura f join Detalle_Factura df on f.numero_factura = df.numero_factura join Tipo_Factura tf on f.id_tipo_factura = tf.id_tipo_factura
                            join Kit k on (df.id_kit = k.id_kit) join Compra c on (f.id_compra = c.id_compra)
                            where df.id_kit != 0 ";

            if (txt_Ini.Text == "")
            {
                MessageBox.Show("Debe Ingresar Cantidad Minima, se mostraran las ventas con cantidades menores a la Cantidad Maxima");
                sql = sql + "AND df.cantidad < '" + txt_Fin.Text + "'";
            }
            else if (txt_Fin.Text == "")
            {
                MessageBox.Show("Debe Ingresar Cantidad Maxima, se mostraran las ventas con cantidades mayores a la Cantidad Minima");
                sql = sql + "AND df.cantidad > '" + txt_Ini.Text + "'";
            }

            if (txt_Ini.Text != "" && txt_Fin.Text != "")
            {
                {
                    sql = sql + "AND df.cantidad between '" + txt_Ini.Text + "' AND '" + txt_Fin.Text + "'";
                }
            }
            return _BD.Ejecutar_Select(sql);
        }

        private void CalcularDatosKIT()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteVentasKitXCantidad();
            ArmarReporteVentas(tabla);
        }

        private void ArmarReporteVentas(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteVentasKitXCantidad", table);
            rpv_kit.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.VentasKitXCantidad.ReporteVentasKitXCantidad.rdlc";
            rpv_kit.LocalReport.DataSources.Clear();
            rpv_kit.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_kit.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            CalcularDatosKIT();
            txt_Fin.Clear();
            txt_Ini.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
