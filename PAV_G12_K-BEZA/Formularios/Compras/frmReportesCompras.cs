using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Reportes.VentasXPeriodo;
using PAV_G12_K_BEZA.Formularios.Reportes.VentasKitXCantidad;
using PAV_G12_K_BEZA.Formularios.Reportes.VentasXTipoFactura;
using PAV_G12_K_BEZA.Formularios.Reportes.CompraMayorA;
using PAV_G12_K_BEZA.Formularios.Reportes.ProductosXCantidad;
using PAV_G12_K_BEZA.Formularios.Reportes.ListadoVentaXBarrio;


namespace PAV_G12_K_BEZA.Formularios.Compras
{
    public partial class frmReportesCompras : Form
    {
        public frmReportesCompras()
        {
            InitializeComponent();
        }

        private void btnVentasXPeriodo_Click(object sender, EventArgs e)
        {
            frm_ReporteVentasXPeriodo ventasxperiodo = new frm_ReporteVentasXPeriodo();
            ventasxperiodo.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKitsVendidos_Click(object sender, EventArgs e)
        {
            frm_ReporteVentasKitXCantidad kitsvendidos = new frm_ReporteVentasKitXCantidad();
            kitsvendidos.ShowDialog();
        }

        private void btnVentasXTipoF_Click(object sender, EventArgs e)
        {
            ListadoDeVentasTipoFactura ventasxtipof = new ListadoDeVentasTipoFactura();
            ventasxtipof.ShowDialog();
        }

        private void btnVentasPorMonto_Click(object sender, EventArgs e)
        {
            ListadoVentasMayorA ventasxmonto = new ListadoVentasMayorA();
            ventasxmonto.ShowDialog();
        }

        private void btnVentasxcantidad_Click(object sender, EventArgs e)
        {
            frm_ReporteCantidadProductos ventasxcantidad = new frm_ReporteCantidadProductos();
            ventasxcantidad.ShowDialog();
        }

        private void btnVentasxbarrio_Click(object sender, EventArgs e)
        {
            FrmReporteVentasXBarrio ventaxbarrio = new FrmReporteVentasXBarrio();
            ventaxbarrio.ShowDialog();
        }
    }
}
