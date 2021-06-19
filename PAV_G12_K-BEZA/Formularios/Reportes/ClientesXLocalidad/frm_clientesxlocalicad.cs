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

namespace PAV_G12_K_BEZA.Formularios.Reportes.ClientesXLocalidad
{
    public partial class frm_clientesxlocalicad : Form
    {
        public frm_clientesxlocalicad()
        {
            InitializeComponent();
        }

        private void frm_clientesxlocalicad_Load(object sender, EventArgs e)
        {
            cbo_localidades.CargarCombo();
            this.rpv_clientes_x_localidad.RefreshReport();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (cbo_localidades.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Barrio");
            }
            else
            {
                CalcularDatosClientes();
            }

        }


        private DataTable ReporteClientesXBarrio()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select l.descripcion_localidad, c.numero_documento ,
                        c.apellido , c.nombre , c.fecha_nacimiento , c.sexo , 
                        c.telefono ,c.mail , c.calle  ,c.nro_direccion , b.descripcion_barrio

                        from cliente c join Tipo_Documento td on (c.tipo_documento = td.id_tipo_documento)
                        join Barrio b on (c.id_barrio = b.id_barrio)
						join Localidad l on b.id_localidad = l.id_localidad
                        where ";

            if (cbo_localidades.SelectedIndex != -1)
            {
                sql = sql + "l.id_localidad = '" + cbo_localidades.SelectedValue.ToString() + "'";
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
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteClientesXLocalidad", table);
            rpv_clientes_x_localidad.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ClientesXLocalidad.ReporteClientesXLocalidad.rdlc";
            rpv_clientes_x_localidad.LocalReport.DataSources.Clear();
            rpv_clientes_x_localidad.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_clientes_x_localidad.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
