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
    public partial class frm_Mostrar_Empleados : Form
    {
        public string Pp_legajo { get; set; }

        public frm_Mostrar_Empleados()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarDatos(DataTable tabla)
        {
            txt_legajo.Text = tabla.Rows[0]["legajo_empleado"].ToString();
            cmb_Tipos.SelectedValue = int.Parse(tabla.Rows[0]["tipo_documento"].ToString());
            txt_nro_documento.Text = tabla.Rows[0]["nro_documento"].ToString();
            cmb_Rol.SelectedValue = int.Parse(tabla.Rows[0]["id_rol"].ToString());
            txt_apellido.Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_sexo.Text = tabla.Rows[0]["sexo"].ToString();
            txt_fecha.Text = tabla.Rows[0]["fecha_nacimiento"].ToString();
            txt_Calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_n_direccion.Text = tabla.Rows[0]["nro_direccion"].ToString();
            cmb_Barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_legajo_sup.Text = tabla.Rows[0]["legajo_supervisor"].ToString();

        }

        private void frm_Mostrar_Empleados_Load(object sender, EventArgs e)
        {
            cmb_Tipos.CargarCombo();
            cmb_Barrio.CargarCombo();
            cmb_Rol.CargarCombo();

            NE_Empleados empleados = new NE_Empleados();
            MostrarDatos(empleados.Recuperar_x_Id(Pp_legajo));
        }
    }
}
