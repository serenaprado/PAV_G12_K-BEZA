using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Barrio
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_barrio { get; set; }
        public string Pp_id_barrio { get; set; }
        public string Pp_id_localidad { get; set; }

        public DataTable Consultar_Barrios()
        {
            string sql = "SELECT id_barrio, descripcion_barrio, b.id_localidad, l.descripcion_localidad FROM Barrio b left join Localidad l on b.id_localidad = l.id_localidad";
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_X_Patron(string patron)
        {
            string sql = @"SELECT * FROM Barrio b left join Localidad l on b.id_localidad = l.id_localidad WHERE descripcion_barrio like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Id(string Id)
        {
            string sql = @"SELECT * FROM Barrio b left join Localidad l on b.id_localidad = l.id_localidad WHERE id_barrio = " + Id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Barrio(descripcion_barrio, id_localidad) VALUES('" + Pp_descripcion_barrio + "'" + ", '" + Pp_id_localidad + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Barrio SET descripcion_barrio = '" + Pp_descripcion_barrio + "'WHERE id_barrio =" + Pp_id_barrio;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = @"DELETE FROM Barrio WHERE id_barrio = " + Pp_id_barrio;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Barrio b left join Localidad l on b.id_localidad = l.id_localidad";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
