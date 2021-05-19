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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Localidad
{
    public partial class frm_M_Localidad : Form
    {
        public string Id_Localidad { get; set; }

        public frm_M_Localidad()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_M_Localidad_Load(object sender, EventArgs e)
        {
            NE_Localidad Localidad = new NE_Localidad();
            MostrarDatos(Localidad.Recuperar_X_Id(Id_Localidad));
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_Localidad.Text = Tabla.Rows[0]["descripcion_localidad"].ToString();
            txt_Localidad_Vieja.Text = Tabla.Rows[0]["descripcion_localidad"].ToString();
        }


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Localidad Localidad = new NE_Localidad();
                Localidad.Pp_id_localidad = Id_Localidad;
                Localidad.Pp_descripcion_localidad = txt_Localidad.Text;
                Localidad.Modificar();
                MessageBox.Show("La Localidad se modificó correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
