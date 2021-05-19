using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago;
using PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura;

namespace PAV_G12_K_BEZA.Formularios.Compras
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMFormaPago_Click(object sender, EventArgs e)
        {
            frm_ABM_Forma_Pago abmformapago = new frm_ABM_Forma_Pago();
            abmformapago.ShowDialog();
        }

        private void btnABMTipoFactura_Click(object sender, EventArgs e)
        {
            frm_ABM_Tipo_Factura abmtipofactura = new frm_ABM_Tipo_Factura();
            abmtipofactura.ShowDialog();
        }
    }
}
