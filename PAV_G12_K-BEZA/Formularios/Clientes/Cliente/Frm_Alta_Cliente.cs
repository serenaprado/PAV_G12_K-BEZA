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
    public partial class Frm_Alta_Cliente : Form
    {
        public Frm_Alta_Cliente()
        {
            InitializeComponent();
        }

 

        private void Frm_Alta_Cliente_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo();
            cmb_tipo_doc.CargarCombo();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if(Tratamientos.Validar(this.Controls)==TratamientosEspeciales.Resultado.correcto)
            {
                NE_Cliente cliente = new NE_Cliente();

                //cliente.Pp_apellido = txt_apellido.Text;
                //cliente.Pp_nombre = txt_nombre.Text;
                //cliente.Pp_fecha_nacimiento = txt_fecha.Text;
                //cliente.Pp_sexo = txt_sexo.Text;
                //cliente.Pp_telefono = txt_telefono.Text;
                //cliente.Pp_mail = txt_mail.Text;
                //cliente.Pp_calle = txt_calle.Text;
                //cliente.Pp_n_tipocliente = cmb_tipo_doc.SelectedValue.ToString();
                //cliente.Pp_numero_documento = txt_nro_doc.Text;
                //cliente.Pp_nro_direccion = txt_nro_calle.Text;
                //cliente.Pp_id_barrio = cmb_barrio.SelectedValue.ToString();
                //cliente.Insertar_Cliente();

                cliente.Insertar_Cliente(this.Controls);
                this.Close();

            }
            else
            {
                return;
            }

        }
    }
}
