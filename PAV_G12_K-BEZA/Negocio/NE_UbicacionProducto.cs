using PAV_G12_K_BEZA.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_UbicacionProducto
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_ubicacion { get; set; }
        public string Pp_id_ubicacion { get; set; }

        public DataTable consultar_ubicaciones()
        {
            string sql = "SELECT id_ubicacion, descripcion_ubicacion FROM Ubicacion_Producto";

            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }
        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM Ubicacion_Producto "
                     + " WHERE descripcion_ubicacion like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM Ubicacion_Producto WHERE id_ubicacion = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Ubicacion_Producto (descripcion_ubicacion)"
                                + " VALUES ("
                                + " '" + Pp_descripcion_ubicacion + "')";

            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlmodificar = @"UPDATE Ubicacion_Producto SET descripcion_ubicacion = '" + Pp_descripcion_ubicacion + "' WHERE id_ubicacion = " + Pp_id_ubicacion;

            _BD.Modificar(sqlmodificar);
        }

        public void Borrar()
        {
            string sqlborrar = @"DELETE FROM Ubicacion_Producto WHERE id_ubicacion = " + Pp_id_ubicacion;
            _BD.Borrar(sqlborrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Ubicacion_Producto";
            return _BD.Ejecutar_Select(sql);
        }

    }
}
