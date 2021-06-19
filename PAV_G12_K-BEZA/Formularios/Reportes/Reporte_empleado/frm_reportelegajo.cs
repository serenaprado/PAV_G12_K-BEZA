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

namespace PAV_G12_K_BEZA.Formularios.Reportes.Reporte_empleado
{
    public partial class frm_reportelegajo : Form
    {
        public frm_reportelegajo()
        {
            InitializeComponent();
        }

        private void frm_reportelegajo_Load(object sender, EventArgs e)
        {
            this.rpv_legajo.RefreshReport();
        }

        private DataTable ReporteCantidadProducto()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select e.legajo_empleado, e.nro_documento, e.apellido, e.nombre
                            from Empleado e Where ";

            if (txt_Minimo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Legajo Minimo, se mostraran los empleados con legajos menores al Legajo Maximo");
                sql = sql + "e.legajo_empleado < '" + txt_Maximo.Text + "'";
            }
            else if (txt_Maximo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Legajo Maximo, se mostraran los empleados con legajos mayores al Legajo Minimo");
                sql = sql + " e.legajo_empleado > '" + txt_Minimo.Text + "'";
            }

            if (txt_Minimo.Text != "" && txt_Maximo.Text != "")
            {
                sql = sql + " e.legajo_empleado between '" + txt_Minimo.Text + "' AND '" + txt_Maximo.Text + "'";
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
            ReportDataSource PaqueteDatos = new ReportDataSource("Reporte_empleado", table);
            rpv_legajo.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Reporte_empleado.Reporte_empleado.rdlc";
            rpv_legajo.LocalReport.DataSources.Clear();
            rpv_legajo.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_legajo.RefreshReport();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CalcularCantidad();
        }
    }
}
