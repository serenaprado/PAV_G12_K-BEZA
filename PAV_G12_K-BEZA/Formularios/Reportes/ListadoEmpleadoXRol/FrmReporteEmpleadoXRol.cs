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

namespace PAV_G12_K_BEZA.Formularios.Reportes.ListadoEmpleadoXRol
{
    public partial class FrmReporteEmpleadoXRol : Form
    {
        public FrmReporteEmpleadoXRol()
        {
            InitializeComponent();
        }

        private void ReporteEmpleadoXRol_Load(object sender, EventArgs e)
        {
            cb_Rol.CargarCombo();
            this.rv_empleadoRol.RefreshReport();
        }

        private DataTable ReporteEmpleado()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select e.legajo_empleado, e.apellido ,e.nombre, e.nro_direccion, e.calle
                        from empleado e join rol r on (e.id_rol = r.id_rol)
                        Where ";
            if (cb_Rol.SelectedIndex != -1 && check_Empleado.Checked== false)
            {
                sql = sql + "r.id_rol ='" + cb_Rol.SelectedValue.ToString() + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }


        private DataTable ReporteEmpleadoLimite()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select e.legajo_empleado, e.apellido ,e.nombre, e.nro_direccion, e.calle
                        from empleado e join rol r on (e.id_rol = r.id_rol)
                        Where ";
            if (cb_Rol.SelectedIndex != -1 && check_Empleado.Checked == false)
            {
                sql = sql + "r.id_rol ='" + cb_Rol.SelectedValue.ToString() + "'";
                sql = sql + "AND e.legajo_empleado BETWEEN '" + txt_Desde.Text + "' AND '" + txt_Hasta.Text + "'";
            }
            return _BD.Ejecutar_Select(sql);
        }

        //Empleado por Todos
        private DataTable ReporteEmpleadoTodos()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select e.legajo_empleado, e.apellido ,e.nombre ,e.nro_direccion, e.calle
                        from empleado e 
                         ";
            return _BD.Ejecutar_Select(sql);
        }

        private DataTable ReporteEmpleadoTodosLimite()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();

            String sql = @"select e.legajo_empleado, e.apellido ,e.nombre ,e.nro_direccion, e.calle
                        from empleado e 
                         Where ";
            if (cb_Limite.Checked == true)
            {
                sql = sql + "e.legajo_empleado BETWEEN '" + txt_Desde.Text +"' AND '" + txt_Hasta.Text + "'";
            }

            return _BD.Ejecutar_Select(sql);
        }

        private void CalcularDatosEmpleados()
        {
            DataTable tabla = new DataTable();
            if (check_Empleado.Checked == true)
            {
                if (cb_Limite.Checked == true && txt_Desde.Text != "" && txt_Hasta.Text != "")
                {
                    tabla = ReporteEmpleadoTodosLimite();
                }
                else
                {
                    tabla = ReporteEmpleadoTodos();
                }
            }
            else
            {
                if (cb_Limite.Checked == true && txt_Desde.Text != "" && txt_Hasta.Text != "")
                {
                    tabla = ReporteEmpleadoLimite();
                }
                else
                {
                    tabla = ReporteEmpleado();
                }
                
            }
            
            AcomodarReporteEmpleadoXRol(tabla);
        }

        private void AcomodarReporteEmpleadoXRol(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReporteEmpeladoXRol", tabla);
            rv_empleadoRol.LocalReport.ReportEmbeddedResource = "PAV_G12_K_BEZA.Formularios.Reportes.ListadoEmpleadoXRol.ReporteEmpeladoXRol.rdlc";
            rv_empleadoRol.LocalReport.DataSources.Clear();
            rv_empleadoRol.LocalReport.DataSources.Add(PaqueteDatos);
            rv_empleadoRol.RefreshReport();
        }

        private void bt_empleadoRol_Click(object sender, EventArgs e)
        {
            if (cb_Rol.SelectedIndex == -1 && check_Empleado.Checked ==  false )
            {
                MessageBox.Show("Selecciones un Rol");
            }
            else
            {
                CalcularDatosEmpleados();
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
