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

namespace PAV_G12_K_BEZA.Formularios.Clientes.Cliente
{
    public partial class Frm_ABM_Clientes : Form
    {
        public string Id_cliente { get; set; }
        public string Id_numero { get; set; }

        public Frm_ABM_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {
            cmb_Box_tipo_doc.CargarCombo();
            Id_cliente = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_Box_tipo_doc.SelectedIndex = -1;
            GridView_Client.Rows.Clear();
        }

        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {
            NE_Cliente cliente = new NE_Cliente();

            if (checkBox_CLiente.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = cliente.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (cmb_Box_tipo_doc.SelectedIndex != -1)
            {
                CargarGrilla(cliente.Recuperar_X_Tipo_Doc(cmb_Box_tipo_doc.SelectedValue.ToString()));
                return;
            }
            if (txt_num_doc.Text != "")
            {
                CargarGrilla(cliente.Recuperar_X_Num_Doc(txt_num_doc.Text));

            }
            if (checkBox_CLiente.Checked == true
                && cmb_Box_tipo_doc.SelectedIndex != -1
                && txt_num_doc.Text != "")
            {
                CargarGrilla(cliente.Recuperacion_Mixta(txt_num_doc.Text, cmb_Box_tipo_doc.SelectedValue.ToString()));
                return;
            }
            if (checkBox_CLiente.Checked != true
                && cmb_Box_tipo_doc.SelectedIndex == -1
                && txt_num_doc.Text == "")
            {
                GridView_Client.Rows.Clear();
                return;
            }

        }
        private void CargarGrilla(DataTable tabla)
        {
            GridView_Client.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridView_Client.Rows.Add();
                GridView_Client.Rows[i].Cells[0].Value = tabla.Rows[i]["tipo_documento"].ToString();
                GridView_Client.Rows[i].Cells[1].Value = tabla.Rows[i]["numero_documento"].ToString();
                GridView_Client.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();
                GridView_Client.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
                GridView_Client.Rows[i].Cells[4].Value = tabla.Rows[i]["fecha_nacimiento"].ToString();
                GridView_Client.Rows[i].Cells[5].Value = tabla.Rows[i]["sexo"].ToString();
                GridView_Client.Rows[i].Cells[6].Value = tabla.Rows[i]["telefono"].ToString();
                GridView_Client.Rows[i].Cells[7].Value = tabla.Rows[i]["mail"].ToString();
                GridView_Client.Rows[i].Cells[8].Value = tabla.Rows[i]["calle"].ToString();
                GridView_Client.Rows[i].Cells[9].Value = tabla.Rows[i]["nro_direccion"].ToString();
                GridView_Client.Rows[i].Cells[10].Value = tabla.Rows[i]["id_barrio"].ToString();

            }


        }

        private void btm_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Cliente alta = new Frm_Alta_Cliente();
            alta.ShowDialog();
            GridView_Client.Rows.Clear();
        }

        private void GridView_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_cliente = GridView_Client.CurrentRow.Cells["Column1"].Value.ToString();
            Id_numero = GridView_Client.CurrentRow.Cells["Column2"].Value.ToString();


        }

        private void btm_modificar_Click(object sender, EventArgs e)
        {
            if (Id_cliente == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            Frm_Modificar_Cliente modificar = new Frm_Modificar_Cliente();
            modificar.Id_cliente = Id_cliente;


            modificar.Id_numero = Id_numero;

            modificar.ShowDialog();
            GridView_Client.Rows.Clear();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GridView_Client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Mostrar_Cliente mostrar = new Frm_Mostrar_Cliente();
            mostrar.Id_cliente = Id_cliente;
            mostrar.Id_numero = Id_numero;
            mostrar.ShowDialog();
        }

        private void btm_eliminar_Click(object sender, EventArgs e)
        {
            if (PAV_G12_K_BEZA.Inicio.id_perfil_actual > 3)
            {
                MessageBox.Show("No posee permisos necesarios para borrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                if (Id_cliente == "")
                {
                    MessageBox.Show("Debe seleccionar un item de la grilla");
                    return;
                }
            }
            Frm_Borrado_Cliente borrar = new Frm_Borrado_Cliente();
            borrar.Id_cliente = Id_cliente;
            borrar.Id_numero = Id_numero;
            borrar.ShowDialog();
            GridView_Client.Rows.Clear();
            Id_cliente = "";
        }


    }
}

