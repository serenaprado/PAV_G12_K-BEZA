using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Kit
    {

        public string Pp_descripcion { get; set; }
        public string Pp_precio { get; set; }
        public string Pp_id_kit { get; set; }

        public enum ResultadoValidacion { exite, no_existe }
        BE_AccesoDatos _BD = new BE_AccesoDatos();


        public DataTable RecuperarTodos()
        {
            string sql = @"Select * From Kit ";
            return _BD.Ejecutar_Select(sql);
        }


        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"Select * From Kit Where id_kit = " + id;
            return _BD.Ejecutar_Select(sql);
        }


        
        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"Select * From Kit"
                     + " WHERE descripcion_kit like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"Insert into Kit(descripcion_kit, precio)"
                                + " VALUES ("
                                + "'" + Pp_descripcion + "'"
                                + ", " + Pp_precio + ")";
            _BD.Insertar(sqlInsertar);
        }


        public void Modificar()
        {
            string sqlModificar = @"UPDATE Kit SET "
                         + " descripcion_kit = '" + Pp_descripcion + "'"
                         + ", precio = " + Pp_precio
                         + " WHERE id_kit = " + Pp_id_kit;
            _BD.Modificar(sqlModificar);
        }


        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Kit WHERE id_kit = " + Pp_id_kit;
            _BD.Borrar(sqlDelete);
        }

    }
}
