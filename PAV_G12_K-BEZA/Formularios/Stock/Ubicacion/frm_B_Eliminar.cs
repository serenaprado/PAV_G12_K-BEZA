using PAV_G12_K_BEZA.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV_G12_K_BEZA.Formularios.Stock.Ubicacion
{
    public partial class frm_B_Eliminar : Form
    {
        public string Pp_id_ubicacion { get; set; }
        public string Id_Ubicacion { get; set; }

        public frm_B_Eliminar()
        {
            InitializeComponent();
        }

        private void frm_B_Eliminar_Load(object sender, EventArgs e)
        {
            NE_UbicacionProducto UbicacionProducto = new NE_UbicacionProducto();
            MostrarDatos(UbicacionProducto.Recuperar_x_Id(Id_Ubicacion));

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            NE_UbicacionProducto borrar = new NE_UbicacionProducto();
            DialogResult dialogResult = MessageBox.Show("¿Desea borrar esta ubicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                borrar.Pp_id_ubicacion = Id_Ubicacion;
                borrar.Borrar();
                MessageBox.Show("Borrado de ubicacion exitoso");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_UbicacionProducto.Text = tabla.Rows[0]["descripcion_ubicacion"].ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
