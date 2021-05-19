using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Clientes.Localidad;
using PAV_G12_K_BEZA.Formularios.Clientes.Cliente;
using PAV_G12_K_BEZA.Formularios.Clientes.Barrio;
using PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento;

namespace PAV_G12_K_BEZA.Formularios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnABMLocalidad_Click(object sender, EventArgs e)
        {
            frm_AMB_Localidad abmlocalidad = new frm_AMB_Localidad();
            abmlocalidad.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            Frm_ABM_Clientes abmcliente = new Frm_ABM_Clientes();
            abmcliente.ShowDialog();
        }

        private void btnABMBarrio_Click(object sender, EventArgs e)
        {
            frm_AMB_Barrio abmbarrio = new frm_AMB_Barrio();
            abmbarrio.ShowDialog();
        }

        private void btnABMTipoDoc_Click(object sender, EventArgs e)
        {
            frm_AMB_TipoDoc abmtipodoc = new frm_AMB_TipoDoc();
            abmtipodoc.ShowDialog();
        }
    }
}
