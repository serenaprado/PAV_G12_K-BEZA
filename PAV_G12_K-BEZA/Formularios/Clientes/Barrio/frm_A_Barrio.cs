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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Barrio
{
    public partial class frm_A_Barrio : Form
    {
        public frm_A_Barrio()
        {
            InitializeComponent();
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
                NE_Barrio Barrio = new NE_Barrio();
                Barrio.Pp_descripcion_barrio = txt_Barrio.Text;
                Barrio.Pp_id_localidad = cmbLocalidad.SelectedValue.ToString();
                Barrio.Insertar();
                MessageBox.Show("El Barrio se registro correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void frm_A_Barrio_Load(object sender, EventArgs e)
        {
            cmbLocalidad.CargarCombo();
        }
    }

 
}
