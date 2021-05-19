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
    public partial class frm_A_Agregar : Form
    {
        public string Pp_id_ubicacion { get; set; }

        public frm_A_Agregar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_A_Agregar_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_UbicacionProducto UbicacionProducto = new NE_UbicacionProducto();

                UbicacionProducto.Pp_descripcion_ubicacion = txt_UbicacionProducto.Text;


                UbicacionProducto.Insertar();
                MessageBox.Show("Datos ingresados correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

