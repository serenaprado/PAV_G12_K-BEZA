using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Stock
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_id_ubicacion { get; set; }
        public string Pp_descripcion_ubicacion { get; set; }
        public string Pp_id_producto { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_cantidad { get; set; }
        public enum ResultadoValidacion { exite, no_existe }


        public DataTable Recuperar_x_Id(string id_p, string id_u)
        {
            string sql = @"select s.id_producto, p.descripcion, s.id_ubicacion, u.descripcion_ubicacion, s.cantidad FROM
		                Stock s JOIN Producto p ON(s.id_producto=p.id_producto) JOIN Ubicacion_Producto u ON
		                (s.id_ubicacion=u.id_ubicacion) Where s.id_producto = " + id_p + "AND s.id_ubicacion = " +id_u ;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Stock (id_producto, id_ubicacion, cantidad)"
                                + " VALUES ("
                                + "'" + Pp_id_producto + "'"
                                + ", '" + Pp_id_ubicacion + "'"
                                + ", '" + Pp_cantidad + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Stock SET "
                         +" cantidad = '" + Pp_cantidad + "'"
                        + " WHERE id_producto = " + Pp_id_producto+ "AND id_ubicacion=" + Pp_id_ubicacion;
            _BD.Modificar(sqlModificar);
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"select p.id_producto, p.descripcion, u.id_ubicacion, u.descripcion_ubicacion, s.cantidad FROM Stock s "
                        + "JOIN Producto p ON(s.id_producto=p.id_producto) "
                        + "JOIN Ubicacion_Producto u ON (s.id_ubicacion=u.id_ubicacion)";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Ubicacion()
        {
            string sql = @"select p.id_producto, p.descripcion, u.id_ubicacion, u.descripcion_ubicacion, s.cantidad FROM Stock s "
                        + "JOIN Producto p ON(s.id_producto=p.id_producto) "
                        + "JOIN Ubicacion_Producto u ON (s.id_ubicacion=u.id_ubicacion)"
                        + "WHERE u.id_ubicacion =" + Pp_id_ubicacion;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Producto()
        {
            string sql = @"select p.id_producto, p.descripcion, u.id_ubicacion, u.descripcion_ubicacion, s.cantidad FROM Stock s "
                        + "JOIN Producto p ON(s.id_producto=p.id_producto) "
                        + "JOIN Ubicacion_Producto u ON (s.id_ubicacion=u.id_ubicacion)"
                        + "WHERE s.id_producto =" + Pp_id_producto;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Producto_Ubicacion()
        {
            string sql = @"select p.id_producto, p.descripcion, u.id_ubicacion, u.descripcion_ubicacion, s.cantidad FROM Stock s "
                        + "JOIN Producto p ON(s.id_producto=p.id_producto) "
                        + "JOIN Ubicacion_Producto u ON (s.id_ubicacion=u.id_ubicacion)"
                        + "WHERE s.id_producto =" + Pp_id_producto + "and u.id_ubbicacion="+ Pp_id_ubicacion;
            return _BD.Ejecutar_Select(sql);
        }

    }
}
