using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Reportes.ListadoEmpleadoXRol;
using PAV_G12_K_BEZA.Formularios.Reportes.Reporte_empleado;



namespace PAV_G12_K_BEZA.Formularios.Empleados
{
    public partial class frmReportesEmpleados : Form
    {
        public frmReportesEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleadoXRol_Click(object sender, EventArgs e)
        {
            FrmReporteEmpleadoXRol empleadoxrol = new FrmReporteEmpleadoXRol();
            empleadoxrol.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reportelegajo empleadoxrol = new frm_reportelegajo();
            empleadoxrol.ShowDialog();
        }
    }
}
