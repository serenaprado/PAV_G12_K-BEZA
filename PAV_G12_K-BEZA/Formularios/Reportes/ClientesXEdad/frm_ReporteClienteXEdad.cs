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

namespace PAV_G12_K_BEZA.Formularios.Reportes.ClientesXEdad
{
    public partial class frm_ReporteClienteXEdad : Form
    {
        public frm_ReporteClienteXEdad()
        {
            InitializeComponent();
        }

        private void frm_ReporteClienteXEdad_Load(object sender, EventArgs e)
        {
            this.rpv_clientesedades.RefreshReport();
        }

        private DataTable ReporteVentasXPeriodo()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select td.descripcion_tipo_doc, c.numero_documento, c.apellido, c.nombre, c.fecha_nacimiento, 
                        c.sexo from Cliente c join Tipo_Documento td on (c.tipo_documento = td.id_tipo_documento)
                        where ";

            if (txt_FechaIni.Text == "")
            {
                MessageBox.Show("Debe Ingresar Fecha Inicial, se mostraran los clientes con nacimiento anterior a Fecha Final");
                sql = sql + "c.fecha_nacimiento < convert(datetime, '" + txt_FechaFin.Text + "', 103)";                
            }
            else if (txt_FechaFin.Text == "")
            {
                MessageBox.Show("Debe Ingresar Fecha Final, se mostraran los clientes con nacimiento posterior a Fecha Inicial");
                sql = sql + "c.fecha_nacimiento > convert(datetime, '" + txt_FechaIni.Text + "', 103)";
            }

            if (txt_FechaIni.Text != "" && txt_FechaFin.Text != "")
            {
                {                    
                    sql = sql + "c.fecha_nacimiento between '" + txt_FechaIni.Text + "' AND '" + txt_FechaFin.Text + "'";
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
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteClienteXEdad", table);
            rpv_clientesedades.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ClientesXEdad.ReporteClienteXEdad.rdlc";
            rpv_clientesedades.LocalReport.DataSources.Clear();
            rpv_clientesedades.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_clientesedades.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            CalcularDatosUsuarios();
            txt_FechaFin.Clear();
            txt_FechaIni.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
