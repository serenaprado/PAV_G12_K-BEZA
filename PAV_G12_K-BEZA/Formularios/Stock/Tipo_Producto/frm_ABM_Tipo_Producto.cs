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
using PAV_G12_K_BEZA.Formularios.Stock.Productos;

namespace PAV_G12_K_BEZA.Formularios.Stock.Tipo_Producto
{
    public partial class frm_ABM_Tipo_Producto : Form
    {

        public string Id_Tipo_Producto { get; set; }
        public frm_ABM_Tipo_Producto()
        {
            InitializeComponent();
        }

        private void frm_ABM_Tipo_Producto_Load(object sender, EventArgs e)
        {
            Id_Tipo_Producto = "";
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Productos productos = new NE_Productos();

            if (chk_Todos.Checked == false && txt_Tipo.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar alguna opción", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (chk_Todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = productos.RecuperarTodosTipos();
                CargarGrilla(tabla);
                return;
            }
            if (txt_Tipo.Text != "")
            {
                CargarGrilla(productos.Recuprar_x_Patron(txt_Tipo.Text));
            }
            groupBox2.Visible = false;
            lbl_altaTipo.Visible = false;
            txt_Insertar.Visible = false;
            btn_Aceptar.Visible = false;
            groupBox3.Visible = false;
            lbl_ModTipo.Visible = false;
            txt_ModTipo.Visible = false;
            btn_ModAceptar.Visible = false;
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_Tipos.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Tipos.Rows.Add();
                grid_Tipos.Rows[i].Cells[0].Value = tabla.Rows[i]["id_tipo_producto"].ToString();
                grid_Tipos.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_Tipos.Rows[i].Cells["id_tipo_producto"].Value = tabla.Rows[i]["id_tipo_producto"].ToString();
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            grid_Tipos.Rows.Clear();
        }

        private void grid_Tipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Tipo_Producto = grid_Tipos.CurrentRow.Cells["id_tipo_producto"].Value.ToString();
        }

        private void grid_Tipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Productos producto = new NE_Productos();

                producto.Pp_descripcion = txt_Insertar.Text;

                DialogResult dialogResult = MessageBox.Show("¿Desea Insertar Estos Datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    producto.InsertarTipo();
                    MessageBox.Show("Insercion de Datos Exitosa");
                    txt_Insertar.Clear();
                    grid_Tipos.Rows.Clear();
                    return;
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (Id_Tipo_Producto == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            groupBox3.Visible = true;
            lbl_ModTipo.Visible = true;
            txt_ModTipo.Visible = true;
            btn_ModAceptar.Visible = true;
            groupBox2.Visible = false;
            lbl_altaTipo.Visible = false;
            txt_Insertar.Visible = false;
            btn_Aceptar.Visible = false;
            grid_Tipos.Rows.Clear();


        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            lbl_altaTipo.Visible = true;
            txt_Insertar.Visible = true;
            btn_Aceptar.Visible = true;
            grid_Tipos.Rows.Clear();
        }

        private void btn_ModAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Productos producto = new NE_Productos();

                producto.Pp_id_tipo_producto = Id_Tipo_Producto;
                producto.Pp_descripcion = txt_ModTipo.Text;
                producto.ModTipo();
                MessageBox.Show("Se cambiaron los datos correctamente");
                groupBox3.Visible = false;
                lbl_ModTipo.Visible = false;
                txt_ModTipo.Visible = false;
                btn_ModAceptar.Visible = false;
                grid_Tipos.Rows.Clear();
                return;
            }
            else
            {
                return;
            }
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_Tipo_Producto == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            NE_Productos borrar = new NE_Productos();
            DialogResult dialogResult = MessageBox.Show("¿Desea Borrar Este Producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                borrar.Pp_id_tipo_producto = Id_Tipo_Producto;
                borrar.BorrarTipo();
                MessageBox.Show("Borrado de Datos Exitoso");
                grid_Tipos.Rows.Clear();
                return;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            grid_Tipos.Rows.Clear();
            Id_Tipo_Producto = "";
        }
    }
}
