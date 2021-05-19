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

namespace PAV_G12_K_BEZA.Formularios.Stock.Kit
{
    public partial class frm_BorrarKit : Form
    {

        public string Id_kit { get; set; }

        public frm_BorrarKit()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txt_Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Descripcion.Text = tabla.Rows[0][1].ToString();
            txt_Precio.Text = tabla.Rows[0][2].ToString();
            

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            NE_Kit borrar = new NE_Kit();
            DialogResult dialogResult = MessageBox.Show("¿Desea Borrar Este Kit?", "Confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                borrar.Pp_id_kit = Id_kit;
                borrar.Borrar();
                MessageBox.Show("Borrado de Kit Exitoso");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


            
        }

        private void frm_BorrarProducto_Load(object sender, EventArgs e)
        {
            NE_Kit Kit = new NE_Kit();
            MostrarDatos(Kit.Recuperar_x_Id(Id_kit));
        }
    }
}
