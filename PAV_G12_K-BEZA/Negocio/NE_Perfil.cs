using PAV_G12_K_BEZA.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Perfil
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_perfil { get; set; }
        public string Pp_id_perfil { get; set; }

        public DataTable consultar_perfiles()
        {
            string sql = "SELECT id_perfil, descripcion_perfil FROM Perfil";
            
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }
        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM Perfil "
                     + " WHERE descripcion_perfil like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM Perfil WHERE id_perfil = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Perfil (descripcion_perfil)"
                                + " VALUES ("
                                + " '" + Pp_descripcion_perfil + "')";

            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlmodificar = @"UPDATE Perfil SET descripcion_perfil = '" + Pp_descripcion_perfil + "' WHERE id_perfil = " + Pp_id_perfil;

            _BD.Modificar(sqlmodificar);
        }

        public void Borrar()
        {
            string sqlborrar = @"DELETE FROM Perfil WHERE id_perfil = " + Pp_id_perfil;
            _BD.Borrar(sqlborrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Perfil";
            return _BD.Ejecutar_Select(sql);
        }
        
    }
}
