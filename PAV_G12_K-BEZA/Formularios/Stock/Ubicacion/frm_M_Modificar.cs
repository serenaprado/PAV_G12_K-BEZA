using PAV_G12_K_BEZA.Clases;
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
    public partial class frm_M_Modificar : Form
    {
        
        public string Id_Ubicacion { get; set; }

        public frm_M_Modificar()
        {
            InitializeComponent();
        }

        private void frm_M_Modificar_Load(object sender, EventArgs e)
        {
            NE_UbicacionProducto UbicacionProducto = new NE_UbicacionProducto();
            MostrarDatos(UbicacionProducto.Recuperar_x_Id(Id_Ubicacion));

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_UbicacionProducto UbicacionProducto = new NE_UbicacionProducto();
                UbicacionProducto.Pp_id_ubicacion = Id_Ubicacion;
                UbicacionProducto.Pp_descripcion_ubicacion = txt_UbicacionProducto.Text;


                UbicacionProducto.Modificar();
                MessageBox.Show("Datos modificados correctamente");
                this.Close();

            }
            else
            {
                return;
            }
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_UbicacionProducto.Text = tabla.Rows[0]["descripcion_ubicacion"].ToString();
            txt_ubicacionanterior.Text = tabla.Rows[0]["descripcion_ubicacion"].ToString();
        }

        private void txt_ubicacionanterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_UbicacionProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
