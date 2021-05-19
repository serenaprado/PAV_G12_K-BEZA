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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    public partial class frm_B_Barrio : Form
    {
        public string Pp_Id_Barrio { get; set; }
        public string Id_Barrio { get; set; }

        public frm_B_Barrio()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_B_Barrio_Load(object sender, EventArgs e)
        {
            NE_Barrio Barrio = new NE_Barrio();
            MostrarDatos(Barrio.Recuperar_X_Id(Id_Barrio));
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_Barrio.Text = Tabla.Rows[0]["descripcion_barrio"].ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_Barrio Borrar = new NE_Barrio();
            DialogResult dialogResult = MessageBox.Show("¿Desea borrar este Barrio?", "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Borrar.Pp_id_barrio = Id_Barrio;
                Borrar.Borrar();
                MessageBox.Show("El barrio se ha borrado exitosamente");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
