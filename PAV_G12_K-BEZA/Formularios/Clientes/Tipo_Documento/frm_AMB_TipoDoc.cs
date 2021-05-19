using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento;
using PAV_G12_K_BEZA.Negocio;

namespace PAV_G12_K_BEZA.Formularios.Clientes.Tipo_Documento
{
    public partial class frm_AMB_TipoDoc : Form
    {
        public string Id_tipodoc { get; set; }
        
        public frm_AMB_TipoDoc()
        {
            InitializeComponent();
        }

        private void frm_AMB_Localidad_Load(object sender, EventArgs e)
        {
            Id_tipodoc = "";
        }

        private void lbl_Localidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Tipo_doc Tipodoc = new NE_Tipo_doc();
            if (chk_Todos.Checked == true)
            {
                DataTable Tabla = new DataTable();
                Tabla = Tipodoc.Recuperar_Todos();
                CargarGrilla(Tabla);
                return;
            }
            if (txt_tipodoc.Text != "")
            {
                CargarGrilla(Tipodoc.Recuperar_X_Patron(txt_tipodoc.Text));
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            dgv_tipodoc.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_tipodoc.Rows.Add();
                dgv_tipodoc.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion_tipo_doc"].ToString();
                dgv_tipodoc.Rows[i].Cells["id_tipodoc"].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_A_TipoDoc Alta = new frm_A_TipoDoc();
            Alta.ShowDialog();
            dgv_tipodoc.Rows.Clear();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Id_tipodoc == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_M_TipoDoc Modificar = new frm_M_TipoDoc();
            Modificar.Id_tipodoc = Id_tipodoc;
            Modificar.ShowDialog();
            dgv_tipodoc.Rows.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Id_tipodoc == "")
            {
                MessageBox.Show("Debe seleccionar un item de la grilla");
                return;
            }
            frm_B_TipoDoc Borrar = new frm_B_TipoDoc();
            Borrar.Id_TipoDoc = Id_tipodoc;
            Borrar.ShowDialog();
            dgv_tipodoc.Rows.Clear();
            Id_tipodoc = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_tipodoc = dgv_tipodoc.CurrentRow.Cells["id_tipodoc"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_tipodoc.Rows.Clear();
        }
    }
}
