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

namespace PAV_G12_K_BEZA.Formularios.Compras.Forma_Pago
{
        

    public partial class frm_B_Forma_Pago : Form
    {
        public string Pp_Id_Forma_Pago { get; set; }
        public string Id_Forma_Pago { get; set; }
        public frm_B_Forma_Pago()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_B_Forma_Pago_Load_1(object sender, EventArgs e)
        {
            NE_Forma_Pago Forma_Pago = new NE_Forma_Pago();
            MostrarDatos(Forma_Pago.Recuperar_X_Id(Id_Forma_Pago));

        }
 
        private void MostrarDatos(DataTable Tabla)
        {
            txt_Forma_Pago.Text = Tabla.Rows[0]["descripcion_forma_pago"].ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_Forma_Pago Borrar = new NE_Forma_Pago();
            DialogResult dialogResult = MessageBox.Show("Desea borrar esta Forma de Pago", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Borrar.Pp_id_forma_pago = Id_Forma_Pago;
                Borrar.Borrar();
                MessageBox.Show("La Forma de Pago se ha borrado exitosamente");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

      
    }
}

