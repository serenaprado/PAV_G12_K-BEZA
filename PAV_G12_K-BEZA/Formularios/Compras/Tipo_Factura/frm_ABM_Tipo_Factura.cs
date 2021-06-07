using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    public partial class frm_ABM_Tipo_Factura : Form
    {
        public string Id_Tipo_Factura { get; set; }

        public frm_ABM_Tipo_Factura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Id_Tipo_Factura = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgv_TipoFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Tipo_Factura = dgv_TipoFactura.CurrentRow.Cells["id_tipo_factura"].Value.ToString();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Tipo_Factura TipoFactura = new NE_Tipo_Factura();
            if (chk_Todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = TipoFactura.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }



            if (txt_Tipo_Factura.Text != "")
            {
                CargarGrilla(TipoFactura.Recuperar_x_Patron(txt_Tipo_Factura.Text));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            dgv_TipoFactura.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_TipoFactura.Rows.Add();
                dgv_TipoFactura.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_tipo_factura"].ToString();
                dgv_TipoFactura.Rows[i].Cells["id_tipo_factura"].Value = tabla.Rows[i]["id_tipo_factura"].ToString();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Tipo_Factura == "")
                {
                    MessageBox.Show("Debe seleccionar un tipo de factura de la grilla");
                    return;
                }
                frm_M_Modificar modificar = new frm_M_Modificar();
                modificar.Id_Tipo_Factura = Id_Tipo_Factura;
                modificar.ShowDialog();
                dgv_TipoFactura.Rows.Clear();
            }
        }


        private void frm_ABM_Tipo_Factura_Load(object sender, EventArgs e)
        {
            Id_Tipo_Factura = "";
        }

        private void dgv_TipoFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Tipo_Factura = dgv_TipoFactura.CurrentRow.Cells["id_tipo_factura"].Value.ToString();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para agregar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_A_Tipo_Factura Alta = new frm_A_Tipo_Factura();
                Alta.ShowDialog();
                dgv_TipoFactura.Rows.Clear();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_Tipo_Factura == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                }
                frm_B_Tipo_Factura Borrar = new frm_B_Tipo_Factura();
                Borrar.Id_Tipo_Factura = Id_Tipo_Factura;
                Borrar.ShowDialog();
                dgv_TipoFactura.Rows.Clear();
                Id_Tipo_Factura = "";
            }
        }
    }
}
