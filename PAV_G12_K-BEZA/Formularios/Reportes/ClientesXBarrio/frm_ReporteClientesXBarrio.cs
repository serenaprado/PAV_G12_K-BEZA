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

namespace PAV_G12_K_BEZA.Formularios.Reportes.ClientesXBarrio
{
    public partial class frm_ReporteClientesXBarrio : Form
    {
        public frm_ReporteClientesXBarrio()
        {
            InitializeComponent();
        }

        private void frm_ReporteClientesXBarrio_Load(object sender, EventArgs e)
        {          
            cbo_Barrios.CargarCombo();
            this.rpv_clienteXbarrio.RefreshReport();
        }

        private DataTable ReporteClientesXBarrio()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            
            String sql = @"select td.descripcion_tipo_doc,c.numero_documento ,
                        c.apellido , c.nombre , c.fecha_nacimiento , c.sexo , 
                        c.telefono ,c.mail , c.calle  ,c.nro_direccion , b.descripcion_barrio 
                        from cliente c join Tipo_Documento td on (c.tipo_documento = td.id_tipo_documento)
                        join Barrio b on (c.id_barrio = b.id_barrio)
                        where ";

            if (cbo_Barrios.SelectedIndex != -1)
            {
                sql = sql + "b.id_barrio = '" + cbo_Barrios.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        private void CalcularDatosClientes()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteClientesXBarrio();
            ArmarReporteClientes(tabla);
        }

        private void ArmarReporteClientes(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteClientesXBarrio", table);
            rpv_clienteXbarrio.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ClientesXBarrio.ReporteClientesXBarrio.rdlc";
            rpv_clienteXbarrio.LocalReport.DataSources.Clear();
            rpv_clienteXbarrio.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_clienteXbarrio.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (cbo_Barrios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Barrio");
            }
            else
            {
                CalcularDatosClientes();
            }
                       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
