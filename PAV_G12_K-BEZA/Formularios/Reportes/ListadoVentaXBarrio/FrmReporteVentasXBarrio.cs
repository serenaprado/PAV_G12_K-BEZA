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

namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoVentaXBarrio
{
    public partial class FrmReporteVentasXBarrio : Form
    {
        public FrmReporteVentasXBarrio()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasXBarrio_Load(object sender, EventArgs e)
        {
            cb_barrio.CargarCombo();
            cb_localidad.CargarCombo();
            this.rv_ventaBarrio.RefreshReport();
        }

        private DataTable ReportesVentaXBarrio()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            //from factura f join compra c on (f.id_compra = c.id_compra) join barrio b on (c.id_barrio = b.id_barrio)
            //            join localidad l on (c.id_localidad = l.id_localidad)

            String sql = @"select c.id_compra, c.id_cliente, c.id_empleado, c.fecha, f.total
                         from factura f join compra c on (f.id_compra = c.id_compra) join cliente cl on (c.id_cliente = cl.numero_documento) 
                        join barrio b on (cl.id_barrio = b.id_barrio)
                        join localidad l on (b.id_localidad = l.id_localidad)
                        Where ";

            if (cb_barrio.SelectedIndex != -1 )
            {
               
                sql = sql + "b.id_barrio = '" + cb_barrio.SelectedValue.ToString() + "'";
                sql = sql + "AND l.id_localidad = '" + cb_localidad.SelectedValue.ToString() + "'";
            }

                return _BD.Ejecutar_Select(sql);
        }


        private DataTable ReportesVentaXBarrioLimite()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            String sql = @"select c.id_compra, c.id_cliente, c.id_empleado, c.fecha, f.total
                         from factura f join compra c on (f.id_compra = c.id_compra) join cliente cl on (c.id_cliente = cl.numero_documento) 
                        join barrio b on (cl.id_barrio = b.id_barrio)
                        join localidad l on (b.id_localidad = l.id_localidad)
                        Where ";

            if (cb_barrio.SelectedIndex != -1)
            {

                sql = sql + "b.id_barrio = '" + cb_barrio.SelectedValue.ToString() + "'";
                sql = sql + "AND l.id_localidad = '" + cb_localidad.SelectedValue.ToString() + "'";
                sql = sql + "AND f.total BETWEEN '" + txt_desde.Text + "' AND '" + txt_hasta.Text + "'";
            }

            return _BD.Ejecutar_Select(sql);
        }


        private void ArmarReporteVentaXBarrio(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteVentasXBarrio", tabla);
            rv_ventaBarrio.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ListadoVentaXBarrio.ReporteVentasXBarrio.rdlc";
            rv_ventaBarrio.LocalReport.DataSources.Clear();
            rv_ventaBarrio.LocalReport.DataSources.Add(PaqueteDatos);
            rv_ventaBarrio.RefreshReport();
        }

        private void CalcularDatosVenta()
        {
            DataTable tabla = new DataTable();

            if (cb_total.Checked == false)
            {
                
                tabla = ReportesVentaXBarrio();
            }
            else
            {
                if (txt_desde.Text != "" && txt_hasta.Text != "")
                {
                    tabla = ReportesVentaXBarrioLimite();
                }
                else
                {
                    MessageBox.Show("No ingreso los Limites");
                }
                
            }

            ArmarReporteVentaXBarrio(tabla);
        }

        private void btm_VentasBarrio_Click(object sender, EventArgs e)
        {
            if (cb_localidad.SelectedIndex == -1 || cb_barrio.SelectedIndex == -1 )
            {
                MessageBox.Show("No selecciono las opciones necesarias para buscar");
            }
            else
            { 
                CalcularDatosVenta();
                
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
