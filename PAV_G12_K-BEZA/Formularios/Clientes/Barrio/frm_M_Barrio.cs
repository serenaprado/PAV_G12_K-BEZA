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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    public partial class frm_M_Barrio : Form
    {
        public string Id_Barrio { get; set; }

        public frm_M_Barrio()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarDatos(DataTable Tabla)
        {
            txt_Barrio.Text = Tabla.Rows[0]["descripcion_barrio"].ToString();
            txt_Barrio_Vieja.Text = Tabla.Rows[0]["descripcion_barrio"].ToString();
        }


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Barrio Barrio = new NE_Barrio();
                Barrio.Pp_id_barrio = Id_Barrio;
                Barrio.Pp_descripcion_barrio = txt_Barrio.Text;
                Barrio.Modificar();
                MessageBox.Show("El Barrio se modificó correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void frm_M_Barrio_Load(object sender, EventArgs e)
        {
            NE_Barrio Barrio = new NE_Barrio();
            MostrarDatos(Barrio.Recuperar_X_Id(Id_Barrio));
        }
    }
}
