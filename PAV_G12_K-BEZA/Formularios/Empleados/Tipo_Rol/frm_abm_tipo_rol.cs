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
using PAV_G12_K_BEZA.Formularios.Empleados.Tipo_Rol;

namespace PAV_G12_K_BEZA.Formularios.Empleados.Tipo_Rol
{
    public partial class frm_abm_tipo_rol : Form
    {
        public string Id_Rol { get; set; }


        public frm_abm_tipo_rol()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_abm_tipo_rol_Load(object sender, EventArgs e)
        {
            Id_Rol = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Rol_Empleado Rol = new NE_Rol_Empleado();
            if (chk_Todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = Rol.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }



            if (txtRol.Text != "")
            {
                CargarGrilla(Rol.Recuperar_X_Patron(txtRol.Text));
            }

        }
        private void CargarGrilla(DataTable tabla)

        {
              
            dGV_Rol.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dGV_Rol.Rows.Add();
                
                dGV_Rol.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_rol"].ToString();
                dGV_Rol.Rows[i].Cells["id_rol"].Value = tabla.Rows[i]["id_rol"].ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btn_agregar_rol_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Rol Alta = new Frm_Agregar_Rol();
            Alta.ShowDialog();
            dGV_Rol.Rows.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Id_Rol=="")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            Frm_Modificar_Rol modificar = new Frm_Modificar_Rol();
            modificar.Id_Rol = Id_Rol;
            modificar.ShowDialog();
            dGV_Rol.Rows.Clear();


        }

        private void dGV_Rol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Rol = dGV_Rol.CurrentRow.Cells["id_rol"].Value.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (Id_Rol == "")
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla");
                return;
            }
            Frm_Borrar_Rol Borrar = new Frm_Borrar_Rol();
            Borrar.Id_Rol = Id_Rol;
            Borrar.ShowDialog();
            dGV_Rol.Rows.Clear();
            Id_Rol = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dGV_Rol.Rows.Clear();
        }
    }

} 