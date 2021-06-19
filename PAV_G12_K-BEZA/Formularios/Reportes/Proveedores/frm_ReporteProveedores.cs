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
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Reportes.Proveedores
{
    public partial class frm_ReporteProveedores : Form
    {
        NE_Proveedores proveedores = new NE_Proveedores();
        public frm_ReporteProveedores()
        {
            InitializeComponent();
        }
        
        private void frm_ReporteProveedores_Load(object sender, EventArgs e)
        {
            cbo_Barrios.CargarCombo();
            cbo_Proveedores.CargarCombo();
            cbo_Localidades.CargarCombo();
            cbo_FormaPago.CargarCombo();
            this.rpv_proveedores.RefreshReport();
            this.rpv_proveedores_productos.RefreshReport();
        }

        //SQL

        private DataTable ReporteProveedores()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select id_proveedor, razon_social, telefono, apellido_contacto, nombre_contacto, calle, 
                            nro_direccion, id_barrio From Proveedor";
                        
            return _BD.Ejecutar_Select(sql);
        }
        
        private DataTable ReporteProveedoresXBarrio()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select p.id_proveedor, p.razon_social, p.telefono , p.apellido_contacto, p.nombre_contacto, p.calle  ,p.nro_direccion , p.id_barrio, b.descripcion_barrio 
                        from Proveedor p  
                        join Barrio b on (p.id_barrio = b.id_barrio)
                        where ";

            if (cbo_Barrios.SelectedIndex != -1)
            {
                sql = sql + "p.id_barrio = '" + cbo_Barrios.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        private DataTable ReporteProveedoresXLocalidad()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select p.razon_social, p.telefono , p.apellido_contacto, p.nombre_contacto, p.calle  ,p.nro_direccion , p.id_barrio, b.id_localidad, l.descripcion_localidad 
                        from Proveedor p  
                        join Barrio b on (p.id_barrio = b.id_barrio)
                        join Localidad l on (b.id_localidad = l.id_localidad)
                        where ";

            if (cbo_Localidades.SelectedIndex != -1)
            {
                sql = sql + "l.id_localidad = '" + cbo_Localidades.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        private DataTable ReporteProductosXProveedor()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select p.id_producto, p.descripcion, p.precio , p.color, p.material_principal, p.tiempo_garantia, p.id_proveedor, pp.razon_social
                        from Producto p  
                        join Proveedor pp on (p.id_proveedor = pp.id_proveedor)
                        where ";

            if (cbo_Proveedores.SelectedIndex != -1)
            {
                sql = sql + "p.id_proveedor = '" + cbo_Proveedores.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        private DataTable ReporteVentasPorFormaPago()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select f.numero_factura, f.id_compra , f.fecha_emision, f.total, f.id_forma_pago, fp.descripcion_forma_pago
                        from Factura f  
                        join Forma_Pago fp on (f.id_forma_pago = fp.id_forma_pago)
                        where ";

            if (cbo_FormaPago.SelectedIndex != -1)
            {
                sql = sql + "f.id_forma_pago = '" + cbo_FormaPago.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        //LISTADO PROVEEDORES

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            CalcularDatosProveedores();
        }

        private void CalcularDatosProveedores()
        {
            DataTable tabla = new DataTable();
            
            if (chk_Id.Checked == true)
            {

                ArmarReporteProveedores(proveedores.ReporteProveedores_id(txt_id.Text));
            }
            if (chk_Razon_social.Checked == true)
            {
                ArmarReporteProveedores(proveedores.ReporteProveedores_Razon_social(txt_razon_social.Text));
            }
            if (chk_todos.Checked == true)
            {
                tabla = ReporteProveedores();
                ArmarReporteProveedores(tabla);
            }
        }
        
        private void ArmarReporteProveedores(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteProveedores", table);
            rpv_proveedores.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Proveedores.ReporteProveedores.rdlc";
            rpv_proveedores.LocalReport.DataSources.Clear();
            rpv_proveedores.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_proveedores.RefreshReport();
        }
        
        private void rpv_proveedores_Load(object sender, EventArgs e)
        {

        }

        private void chk_Id_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            txt_razon_social.Enabled = false;
            txt_razon_social.Clear();
        }

        private void chk_Razon_social_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_razon_social.Enabled = true;
            txt_id.Clear();
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_razon_social.Enabled = false;
            txt_id.Clear();
            txt_razon_social.Clear();
        }

        //REPORTE PROVEEDORES POR BARRIO

        private void ArmarReporteProveedores2(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteProveedores2", table);
            rpv_clienteXbarrio.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Proveedores.ReporteProveedores2.rdlc";
            rpv_clienteXbarrio.LocalReport.DataSources.Clear();
            rpv_clienteXbarrio.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_clienteXbarrio.RefreshReport();
        }

        private void CalcularDatosProveedoresXBarrio()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteProveedoresXBarrio();
            ArmarReporteProveedores2(tabla);
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbo_Barrios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Barrio");
            }
            else
            {
                CalcularDatosProveedoresXBarrio();
            }
        }

        private void cbo_Barrios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //REPORTE PRODUCTOS POR PROVEEDOR

        private void btn_consultar3_Click(object sender, EventArgs e)
        {
            if (cbo_Proveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Proveedor");
            }
            else
            {
                CalcularDatosProductosXProveedor();
            }
        }

        private void ArmarReporteProveedores3(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteProveedores3", table);
            rpv_proveedores_productos.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Proveedores.ReporteProveedores3.rdlc";
            rpv_proveedores_productos.LocalReport.DataSources.Clear();
            rpv_proveedores_productos.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_proveedores_productos.RefreshReport();
        }

        private void CalcularDatosProductosXProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteProductosXProveedor();
            ArmarReporteProveedores3(tabla);
        }

        //REPORTE PROVEEDORES POR LOCALIDAD

        private void btn_calcular4_Click(object sender, EventArgs e)
        {
            if (cbo_Localidades.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una Localidad");
            }
            else
            {
                CalcularDatosProveedoresXLocalidad();
            }
        }

        private void ArmarReporteProveedores4(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteProveedores4", table);
            rpv_proveedoresXLocalidad.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Proveedores.ReporteProveedores4.rdlc";
            rpv_proveedoresXLocalidad.LocalReport.DataSources.Clear();
            rpv_proveedoresXLocalidad.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_proveedoresXLocalidad.RefreshReport();
        }

        private void CalcularDatosProveedoresXLocalidad()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteProveedoresXLocalidad();
            ArmarReporteProveedores4(tabla);
        }

        //REPORTE VENTAS POR FORMA DE PAGO

        private void btn_calcular5_Click(object sender, EventArgs e)
        {
            if (cbo_FormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una Forma de pago");
            }
            else
            {
                CalcularDatosVentasPorFPago(); 
            }
        }

        private void ArmarReporteFormaPago(DataTable table)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteVentasPorFormaPago", table);
            rpv_fp.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.Proveedores.ReporteVentasPorFormaPago.rdlc";
            rpv_fp.LocalReport.DataSources.Clear();
            rpv_fp.LocalReport.DataSources.Add(PaqueteDatos);
            rpv_fp.RefreshReport();
        }

        private void CalcularDatosVentasPorFPago()
        {
            DataTable tabla = new DataTable();
            tabla = ReporteVentasPorFormaPago();
            ArmarReporteFormaPago(tabla);
        }

        private void cbo_FormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            pictureBoxEfectivo.Visible = false;

            if (cbo_FormaPago.SelectedIndex == 0)
            {
                pictureBoxVisa.Visible = false;
                pictureBoxMaster.Visible = false;
                pictureBoxEfectivo.Visible = true;
                pictureBoxNaranja.Visible = false;
            }
            if (cbo_FormaPago.SelectedIndex == 1)
            {
                pictureBoxVisa.Visible = true;
                pictureBoxMaster.Visible = false;
                pictureBoxEfectivo.Visible = false;
                pictureBoxNaranja.Visible = false;
            }
            if (cbo_FormaPago.SelectedIndex == 2)
            {
                pictureBoxVisa.Visible = false;
                pictureBoxMaster.Visible = true;
                pictureBoxEfectivo.Visible = false;
                pictureBoxNaranja.Visible = false;
            }
            if (cbo_FormaPago.SelectedIndex == 3)
            {
                pictureBoxVisa.Visible = false;
                pictureBoxMaster.Visible = false;
                pictureBoxEfectivo.Visible = false;
                pictureBoxNaranja.Visible = true;
            }
        }
    }
}
