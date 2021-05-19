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
    public partial class frm_M_Forma_Pago : Form
    {
        public string Id_Forma_Pago { get; set; }

        public frm_M_Forma_Pago()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_M_Forma_Pago_Load(object sender, EventArgs e)
        {
            NE_Forma_Pago FormaPago = new NE_Forma_Pago();
            MostrarDatos(FormaPago.Recuperar_X_Id(Id_Forma_Pago));
        }

        private void MostrarDatos (DataTable Tabla)
        {
            txt_Forma_Pago.Text = Tabla.Rows[0]["descripcion_forma_pago"].ToString();
            txt_Forma_Pago_Vieja.Text = Tabla.Rows[0]["descripcion_forma_pago"].ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Forma_Pago Forma_Pago = new NE_Forma_Pago();
                Forma_Pago.Pp_id_forma_pago = Id_Forma_Pago;
                Forma_Pago.Pp_descripcion_forma_pago = txt_Forma_Pago.Text;
                Forma_Pago.Modificar();
                MessageBox.Show("La Forma de Pago se modificó correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void frm_M_Forma_Pago_Load_1(object sender, EventArgs e)
        {
            NE_Forma_Pago Forma_Pago = new NE_Forma_Pago();
            MostrarDatos(Forma_Pago.Recuperar_X_Id(Id_Forma_Pago));
        }
    }
}
