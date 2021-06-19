using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Reportes.ClientesXBarrio;
using PAV_G12_K_BEZA.Formularios.Reportes.ClientesXEdad;
using PAV_G12_K_BEZA.Formularios.Reportes.ClientesXLocalidad;


namespace PAV_G12_K_BEZA.Formularios.Clientes
{
    public partial class frmReportesClientes : Form
    {
        public frmReportesClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientesXBarrio_Click(object sender, EventArgs e)
        {
            frm_ReporteClientesXBarrio clientesxbarrio = new frm_ReporteClientesXBarrio();
            clientesxbarrio.ShowDialog();
        }

        private void btnClienteXEdad_Click(object sender, EventArgs e)
        {
            frm_ReporteClienteXEdad clientesxedad = new frm_ReporteClienteXEdad();
            clientesxedad.ShowDialog();
        }

        private void btnClienteXLocalidad_Click(object sender, EventArgs e)
        {
            frm_clientesxlocalicad clientexlocalidad = new frm_clientesxlocalicad();
            clientexlocalidad.ShowDialog();
        }
    }
}
