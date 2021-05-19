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

namespace PAV_G12_K_BEZA.Formularios.Compras.Tipo_Factura

{
    public partial class frm_A_Tipo_Factura : Form
    {
        public string Pp_id_tipo_factura { get; set; }
        public frm_A_Tipo_Factura()
        {
            InitializeComponent();
        }
        private void frm_A_Tipo_Factura_Load(object sender, EventArgs e)
        {
            Pp_id_tipo_factura = "";
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
                NE_Tipo_Factura Tipo_Factura = new NE_Tipo_Factura();
                Tipo_Factura.Pp_descripcion_tipo_factura = txt_Tipo_Factura.Text;
                Tipo_Factura.Insertar();
                MessageBox.Show("El tipo de Factura se registró correctamente");
                this.Close();
            }
            else
            {
                return;
            }
        }     
    }
}