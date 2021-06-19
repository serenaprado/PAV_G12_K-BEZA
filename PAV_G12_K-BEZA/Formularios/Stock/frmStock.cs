using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Stock.Productos;
using PAV_G12_K_BEZA.Formularios.Stock.Tipo_Producto;
using PAV_G12_K_BEZA.Formularios.Stock.Kit;
using PAV_G12_K_BEZA.Formularios.Stock.Proveedor;
using PAV_G12_K_BEZA.Formularios.Stock.Ubicacion;
using PAV_G12_K_BEZA.Formularios.Stock.MovimientoStock;
namespace PAV_G12_K_BEZA.Formularios.Stock
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnABMProducto_Click(object sender, EventArgs e)
        {
            frm_ABM_Producto abmproductos = new frm_ABM_Producto();
            abmproductos.ShowDialog();
        }

        private void btnABMTipoProducto_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_ABM_Tipo_Producto abmtipoproducto = new frm_ABM_Tipo_Producto();
                abmtipoproducto.ShowDialog();
            }
        }

        private void btnABMKit_Click(object sender, EventArgs e)
        {
            frm_ABM_Kit abmkit = new frm_ABM_Kit();
            abmkit.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual == 4)
            {
                MessageBox.Show("No posee permisos necesarios para ingresar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Frm_ABM_Proveedores abmproveedor = new Frm_ABM_Proveedores();
                abmproveedor.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMUbicacion_Click(object sender, EventArgs e)
        {
            frm_UbicacionProducto abmubicacion = new frm_UbicacionProducto();
            abmubicacion.ShowDialog();
        }

        private void btnMovStock_Click(object sender, EventArgs e)
        {
            frm_MovimientoStock mover = new frm_MovimientoStock();
            mover.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportesStock reportes = new frmReportesStock();
            reportes.ShowDialog();
        }
    }

}
