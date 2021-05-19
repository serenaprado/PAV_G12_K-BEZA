using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Localidad
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_localidad { get; set; }
        public string Pp_id_localidad { get; set; }

        public DataTable Consultar_Localidades()
        {
            string sql = "SELECT id_localidad, descripcion_localidad FROM Localidad";
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_X_Patron(string patron)
        {
            string sql = @"SELECT * FROM Localidad WHERE descripcion_localidad like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Id(string Id)
        {
            string sql = @"SELECT * FROM Localidad WHERE id_localidad = " + Id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Localidad(descripcion_localidad) VALUES('" + Pp_descripcion_localidad + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Localidad SET descripcion_localidad = '" + Pp_descripcion_localidad + "'WHERE id_localidad =" + Pp_id_localidad;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = @"DELETE FROM Localidad WHERE id_localidad = " + Pp_id_localidad;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Localidad";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
