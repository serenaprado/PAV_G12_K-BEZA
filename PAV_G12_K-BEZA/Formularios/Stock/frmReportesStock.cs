using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Reportes.StockMenor;
using PAV_G12_K_BEZA.Formularios.Reportes.ListadoProductosXDeposito;
using PAV_G12_K_BEZA.Formularios.Reportes.Proveedores;



namespace PAV_G12_K_BEZA.Formularios.Stock
{
    public partial class frmReportesStock : Form
    {
        public frmReportesStock()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockXCantidad_Click(object sender, EventArgs e)
        {
            Frm_stock stockxcantidad = new Frm_stock();
            stockxcantidad.ShowDialog();
        }

        private void btnProdxub_Click(object sender, EventArgs e)
        {
            FrmReporteProducto prodxub = new FrmReporteProducto();
            prodxub.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frm_ReporteProveedores prov = new frm_ReporteProveedores();
            prov.ShowDialog();
        }
    }
}
