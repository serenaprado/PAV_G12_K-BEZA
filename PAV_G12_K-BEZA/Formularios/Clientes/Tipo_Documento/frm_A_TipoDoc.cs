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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento
{
    public partial class frm_A_TipoDoc : Form
    {
        public string Pp_id_tipo_doc { get; set; }

        public frm_A_TipoDoc()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_A_Localidad_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Tipo_doc TipoDoc = new NE_Tipo_doc();
                TipoDoc.Pp_descripcion_tipo_doc = txt_tipo_doc.Text;
                TipoDoc.Insertar();
                MessageBox.Show("El Tipo de Documento se registro correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
