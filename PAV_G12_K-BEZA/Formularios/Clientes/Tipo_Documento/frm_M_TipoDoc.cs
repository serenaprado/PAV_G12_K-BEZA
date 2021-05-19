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
    public partial class frm_M_TipoDoc : Form
    {
        public string Id_tipodoc { get; set; }

        public frm_M_TipoDoc()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_M_Localidad_Load(object sender, EventArgs e)
        {
            NE_Tipo_doc Tipodoc = new NE_Tipo_doc();
            MostrarDatos(Tipodoc.Recuperar_X_Id(Id_tipodoc));
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_tipodoc.Text = Tabla.Rows[0]["descripcion_tipo_doc"].ToString();
            txt_tipodoc_Viejo.Text = Tabla.Rows[0]["descripcion_tipo_doc"].ToString();
        }


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Tipo_doc Tipodoc = new NE_Tipo_doc();
                Tipodoc.Pp_id_tipo_doc = Id_tipodoc;
                Tipodoc.Pp_descripcion_tipo_doc = txt_tipodoc.Text;
                Tipodoc.Modificar();
                MessageBox.Show("El Tipo de Documento se modificó correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
