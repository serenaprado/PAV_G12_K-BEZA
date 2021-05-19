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


namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
    public partial class frm_A_Forma_Pago : Form
        {
            public string Pp_id_forma_pago { get; set; }
        public frm_A_Forma_Pago()
        {
            InitializeComponent();
        }

        private void frm_A_Forma_Pago_Load(object sender, EventArgs e)
        {
            Pp_id_forma_pago = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Forma_Pago Forma_Pago = new NE_Forma_Pago();
                Forma_Pago.Pp_descripcion_forma_pago = txt_Forma_Pago.Text;
                Forma_Pago.Insertar();
                MessageBox.Show("La Forma de Pago se registró correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
