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

namespace PAV_G12_K_BEZA.Formularios.Empleados.Empleado
{
    public partial class frm_ABM_Empleados : Form
    {

        public string Id_Empleado { get; set; }

        public frm_ABM_Empleados()
        {
            InitializeComponent();
        }

        

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            grid_Empleados.Rows.Clear();
            txt_Apellido.Text = "";
            txt_Nombre.Text = "";
            txt_nro_documento.Text = "";
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            {
                NE_Empleados empleados = new NE_Empleados();

                if (chk_Todos.Checked == false && txt_Apellido.Text == string.Empty &&
                                txt_Nombre.Text == string.Empty && txt_nro_documento.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar alguna opción", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (chk_Todos.Checked == true)
                {
                    DataTable tabla = new DataTable();
                    tabla = empleados.RecuperarTodos();
                    CargarGrilla(tabla);
                    return;
                }
                if (chk_Todos.Checked == false
                    && txt_Apellido.Text != "")
                {
                    CargarGrilla(empleados.Recuprar_x_Apellido(txt_Apellido.Text));
                    return;
                }
                if (chk_Todos.Checked == false && txt_Nombre.Text != "")
                {
                    CargarGrilla(empleados.Recuprar_x_Nombre(txt_Nombre.Text));
                }
                if (chk_Todos.Checked == false && txt_nro_documento.Text != "")
                {
                    CargarGrilla(empleados.Recuperar_x_DNI(txt_nro_documento.Text));
                }
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_Empleados.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Empleados.Rows.Add();
                grid_Empleados.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grid_Empleados.Rows[i].Cells[1].Value = tabla.Rows[i]["apellido"].ToString();
                grid_Empleados.Rows[i].Cells[2].Value = tabla.Rows[i]["tipo_documento"].ToString();
                grid_Empleados.Rows[i].Cells[3].Value = tabla.Rows[i]["Nro_Documento"].ToString();
                grid_Empleados.Rows[i].Cells["legajo_empleado"].Value = tabla.Rows[i]["legajo_empleado"].ToString();
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            frm_Alta_Empleados alta = new frm_Alta_Empleados();
            alta.ShowDialog();
            grid_Empleados.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Empleado == "")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            frm_Borrar_Empleados borrar = new frm_Borrar_Empleados();
            borrar.Id_Empleado = Id_Empleado;
            borrar.ShowDialog();
            grid_Empleados.Rows.Clear();
            Id_Empleado = "";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_Empleado=="")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            frm_Modificar_Empleados modificar = new frm_Modificar_Empleados();
            modificar.Legajo = Id_Empleado;
            modificar.ShowDialog();
            grid_Empleados.Rows.Clear();
            Id_Empleado = "";
        }

        private void grid_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Empleado = grid_Empleados.CurrentRow.Cells["legajo_empleado"].Value.ToString();
        }

        private void grid_Empleados_DoubleClick(object sender, EventArgs e)
        {
            frm_Mostrar_Empleados mostrar = new frm_Mostrar_Empleados();
            mostrar.Pp_legajo = grid_Empleados.CurrentRow.Cells["legajo_empleado"].Value.ToString();
            mostrar.ShowDialog();
        }

        private void frm_ABM_Empleados_Load(object sender, EventArgs e)
        {
            Id_Empleado = "";
        }
    }
}
