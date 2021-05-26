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
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Stock.MovimientoStock
{
    public partial class frm_MovimientoStock : Form
    {
        public string Id_ProductoStock { get; set; }
        public string Id_UbicacionStock { get; set; }

        public frm_MovimientoStock()
        {
            InitializeComponent();
        }

        private void frm_MovimientoStock_Load(object sender, EventArgs e)
        {
            cmb_Producto.CargarCombo();
            cmb_Ubicacion.CargarCombo();
            Id_ProductoStock = "";
            Id_UbicacionStock = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            frm_AltaStock alta = new frm_AltaStock();
            alta.ShowDialog();
            cmb_Producto.SelectedIndex = -1;
            cmb_Ubicacion.SelectedIndex = -1;
            dgv_Stock.Rows.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            dgv_Stock.Rows.Clear();
            if (chkTodos.Checked == false && cmb_Producto.SelectedIndex == -1 && cmb_Ubicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chkTodos.Checked == true)
            {
                NE_Stock stock = new NE_Stock();
                DataTable tabla = new DataTable();
                tabla = stock.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (cmb_Producto.SelectedIndex != -1 && cmb_Ubicacion.SelectedIndex != -1 && chkTodos.Checked == false)
            {
                NE_Stock stock = new NE_Stock();
                DataTable tabla = new DataTable();
                stock.Pp_id_producto = cmb_Producto.SelectedValue.ToString();
                stock.Pp_id_ubicacion = cmb_Ubicacion.SelectedValue.ToString();
                tabla = stock.Recuperar_X_Producto_Ubicacion();
                CargarGrilla(tabla);
                return;
            }
            if (cmb_Ubicacion.SelectedIndex!=-1 && cmb_Producto.SelectedIndex==-1 && chkTodos.Checked==false) 
            {
                NE_Stock stock = new NE_Stock();
                DataTable tabla = new DataTable();
                stock.Pp_id_ubicacion = cmb_Ubicacion.SelectedValue.ToString();
                tabla = stock.Recuperar_X_Ubicacion();
                CargarGrilla(tabla);
                return;
            }
            if (cmb_Producto.SelectedIndex != -1 && cmb_Ubicacion.SelectedIndex == -1 && chkTodos.Checked == false)
            {
                NE_Stock stock = new NE_Stock();
                DataTable tabla = new DataTable();
                stock.Pp_id_producto = cmb_Producto.SelectedValue.ToString();
                tabla = stock.Recuperar_X_Producto();
                CargarGrilla(tabla);
                return;
            }
            

        }

        private void CargarGrilla(DataTable tabla)
        {
            dgv_Stock.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Stock.Rows.Add();
                dgv_Stock.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                dgv_Stock.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion_ubicacion"].ToString();
                dgv_Stock.Rows[i].Cells[2].Value = tabla.Rows[i]["cantidad"].ToString();
                dgv_Stock.Rows[i].Cells["id_producto"].Value = tabla.Rows[i]["id_producto"].ToString();
                dgv_Stock.Rows[i].Cells["id_ubicacion"].Value = tabla.Rows[i]["id_ubicacion"].ToString();
            }

        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Id_ProductoStock == "" & Id_UbicacionStock == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_ModificarStock modificar = new frm_ModificarStock();
            modificar.Id_productoStock = Id_ProductoStock;
            modificar.Id_ubicacionStock = Id_UbicacionStock;
            //MessageBox.Show(modificar.Id_ubicacionStock + " - " + modificar.Id_productoStock);
            //return;
            modificar.ShowDialog();
            cmb_Producto.SelectedIndex = -1;
            cmb_Ubicacion.SelectedIndex = -1;
            dgv_Stock.Rows.Clear();
            
        }

        private void dgv_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_ProductoStock = dgv_Stock.CurrentRow.Cells["id_producto"].Value.ToString();
            Id_UbicacionStock = dgv_Stock.CurrentRow.Cells["id_ubicacion"].Value.ToString();
            
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked==true)
            {
                cmb_Producto.SelectedIndex = -1;
                cmb_Ubicacion.SelectedIndex = -1;
                cmb_Ubicacion.Enabled = false;
                cmb_Producto.Enabled = false;
            }
            else
            {
                cmb_Ubicacion.Enabled = true;
                cmb_Producto.Enabled = true;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_Stock.Rows.Clear();
            cmb_Ubicacion.SelectedIndex = -1;
            cmb_Producto.SelectedIndex = -1;
            chkTodos.Checked = false;
        }
    }
}
