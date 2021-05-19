using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Clientes.Localidad
{
    public partial class frm_B_Localidad : Form
    {
        public string Pp_Id_Localidad { get; set; }
        public string Id_Localidad { get; set; }

        public frm_B_Localidad()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_B_Localidad_Load(object sender, EventArgs e)
        {
            NE_Localidad Localidad = new NE_Localidad();
            MostrarDatos(Localidad.Recuperar_X_Id(Id_Localidad));
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_Localidad.Text = Tabla.Rows[0]["descripcion_localidad"].ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_Localidad Borrar = new NE_Localidad();
            DialogResult dialogResult = MessageBox.Show("Desea borrar esta Localidad", "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Borrar.Pp_id_localidad = Id_Localidad;
                Borrar.Borrar();
                MessageBox.Show("La Localidad se ha borrado exitosamente");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
