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

namespace PAV_G12_K_BEZA.Formularios.Empleados.Empleado
{
    public partial class frm_Alta_Empleados : Form
    {

        public string Pp_legajo_empleado { get; set; }

        public frm_Alta_Empleados()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro Desea Cancelar?", "Atencion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            this.Close();

        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Empleados empleados = new NE_Empleados();

                empleados.Pp_legajo = txt_legajo.Text;
                empleados.Pp_tipo_documento = cmb_Tipos.SelectedValue.ToString();
                empleados.Pp_nro_documento = txt_nro_documento.Text;
                empleados.Pp_id_rol = cmb_Rol.SelectedValue.ToString();
                empleados.Pp_apellido = txt_apellido.Text;
                empleados.Pp_nombre = txt_nombre.Text;
                empleados.Pp_sexo = txt_sexo.Text;
                empleados.Pp_fecha_nacimiento = txt_fecha.Text;
                empleados.Pp_calle = txt_Calle.Text;
                empleados.Pp_nro_direccion = txt_n_direccion.Text;
                empleados.Pp_id_barrio = cmb_Barrio.SelectedValue.ToString();
                empleados.Pp_legajo_supervisor = txt_legajo_sup.Text;

                DialogResult dialogResult = MessageBox.Show("¿Desea Insertar Estos Datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    empleados.Insertar();
                    MessageBox.Show("Insercion de Datos Exitosa");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void frm_Alta_Empleados_Load(object sender, EventArgs e)
        {
            cmb_Tipos.CargarCombo();
            cmb_Barrio.CargarCombo();
            cmb_Rol.CargarCombo();
        }
    }
}
