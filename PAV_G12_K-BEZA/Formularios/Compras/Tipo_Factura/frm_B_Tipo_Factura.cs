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

namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura
{
    public partial class frm_B_Tipo_Factura : Form
    {
        public string Pp_Id_Tipo_Factura { get; set; }
        public string Id_Tipo_Factura { get; set; }

        public frm_B_Tipo_Factura()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable Tabla)
        {
            txt_tipo_factura.Text = Tabla.Rows[0]["descripcion_tipo_factura"].ToString();
        }


        private void frm_B_Tipo_Factura_Load(object sender, EventArgs e)
        {
            NE_Tipo_Factura Tipo_Factura = new NE_Tipo_Factura();
            MostrarDatos(Tipo_Factura.Recuperar_x_Id(Id_Tipo_Factura));
           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_Tipo_Factura Borrar = new NE_Tipo_Factura();
            DialogResult dialogResult = MessageBox.Show("Desea borrar este Tipo de Factura", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Borrar.Pp_id_tipo_factura = Id_Tipo_Factura;
                Borrar.Borrar();
                MessageBox.Show("El tipo de Factura se ha borrado exitosamente");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

    }
}

