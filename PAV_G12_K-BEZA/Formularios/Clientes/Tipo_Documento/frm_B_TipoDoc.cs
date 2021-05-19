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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento
{
    public partial class frm_B_TipoDoc : Form
    {
        public string Pp_Id_TipoDoc { get; set; }
        public string Id_TipoDoc { get; set; }

        public frm_B_TipoDoc()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_B_Localidad_Load(object sender, EventArgs e)
        {
            NE_Tipo_doc TipoDoc = new NE_Tipo_doc();
            MostrarDatos(TipoDoc.Recuperar_X_Id(Id_TipoDoc));
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_TipoDoc.Text = Tabla.Rows[0]["descripcion_tipo_doc"].ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_Tipo_doc Borrar = new NE_Tipo_doc();
            DialogResult dialogResult = MessageBox.Show("Desea borrar esta Tipo de Documento", "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Borrar.Pp_id_tipo_doc = Id_TipoDoc;
                Borrar.Borrar();
                MessageBox.Show("El Tipo de Documento se ha borrado exitosamente");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
