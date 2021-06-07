using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Stock.Proveedor;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Stock.Proveedor
{
    public partial class Frm_ABM_Proveedores : Form

    {
        public string Id_proveedor { get; set; }


        public Frm_ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consulta_Click_Click(object sender, EventArgs e)
        {
            NE_Proveedores proveedores = new NE_Proveedores();
            if (chk_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = proveedores.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (txt_apellido.Text != "" && txt_razonSocial.Text != "")
            {
                CargarGrilla(proveedores.Recuperar_x_apellidoYRazon(txt_apellido.Text, txt_razonSocial.Text));
                return;
            }
            if (txt_apellido.Text != "")
            {
                CargarGrilla(proveedores.Recuperar_x_apellido(txt_apellido.Text));
                return;
            }
            if (txt_razonSocial.Text != "")
            {
                CargarGrilla(proveedores.Recuperar_X_Razon(txt_razonSocial.Text));
                return;
            }
            else
            {
                MessageBox.Show("Debe cargar/seleccionar algun campo");
            }

        }
        private void CargarGrilla(DataTable tabla)
        {

            grid_proveedores.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_proveedores.Rows.Add();
                grid_proveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["razon_social"].ToString();
                grid_proveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["telefono"].ToString();
                grid_proveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido_contacto"].ToString();
                grid_proveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre_contacto"].ToString();
                grid_proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["calle"].ToString();
                grid_proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["nro_direccion"].ToString();
                grid_proveedores.Rows[i].Cells[6].Value = tabla.Rows[i]["nom_barrio"].ToString();
                grid_proveedores.Rows[i].Cells["id_proveedor"].Value = tabla.Rows[i]["id_proveedor"].ToString();
            }

        }

        private void Frm_ABM_Proveedores_Load(object sender, EventArgs e)
        {
            Id_proveedor = "";
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            Frm_AltasProveedores alta = new Frm_AltasProveedores();
            alta.ShowDialog();
            grid_proveedores.Rows.Clear();
        }

        private void grid_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_proveedor = grid_proveedores.CurrentRow.Cells["id_proveedor"].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Id_proveedor == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            Frm_ModificacionProveedores modificar = new Frm_ModificacionProveedores();
            modificar.Id_proveedor = Id_proveedor;
            modificar.ShowDialog();
            grid_proveedores.Rows.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if ((PAV_G12_K_BEZA.Inicio.id_perfil_actual != 3) && (PAV_G12_K_BEZA.Inicio.id_perfil_actual != 2) && (PAV_G12_K_BEZA.Inicio.id_perfil_actual != 1))
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Id_proveedor == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                    return;
                }
                Frm_BorrarProveedores borrar = new Frm_BorrarProveedores();
                borrar.Id_proveedor = Id_proveedor;
                borrar.ShowDialog();
                grid_proveedores.Rows.Clear();
                Id_proveedor = "";
            }
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            grid_proveedores.Rows.Clear();
        }
    }
}
