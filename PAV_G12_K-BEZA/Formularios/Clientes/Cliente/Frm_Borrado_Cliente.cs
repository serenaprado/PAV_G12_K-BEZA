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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Cliente
{
    public partial class Frm_Borrado_Cliente : Form
    {
        public string Id_cliente { get; set; }
        public string Id_numero { get; set; }
        

        public Frm_Borrado_Cliente()
        {
            InitializeComponent();
            
        }



    private void MostrarDatos(DataTable tabla)
    {
        cmb_tipo_doc.SelectedValue = int.Parse(tabla.Rows[0]["tipo_documento"].ToString());
        txt_nro_doc.Text = tabla.Rows[0]["numero_documento"].ToString();
        txt_apellido.Text = tabla.Rows[0]["apellido"].ToString();
        txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
        txt_fecha.Text = tabla.Rows[0]["fecha_nacimiento"].ToString();
        txt_sexo.Text = tabla.Rows[0]["sexo"].ToString();
        txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
        txt_mail.Text = tabla.Rows[0]["mail"].ToString();
        txt_calle.Text = tabla.Rows[0]["calle"].ToString();
        txt_nro_calle.Text = tabla.Rows[0]["nro_direccion"].ToString();
        cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
    }



        private void Frm_Borrado_Cliente_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo();
            cmb_tipo_doc.CargarCombo();

            NE_Cliente cliente = new NE_Cliente();
            MostrarDatos(cliente.Recuperacion_Mixta(Id_numero, Id_cliente));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Cliente cliente = new NE_Cliente();
            if (MessageBox.Show("¿Estas seguro de querer Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                cliente.Borrar_Cliente(Id_cliente,Id_numero);
                this.Close();
            }            
            

        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
