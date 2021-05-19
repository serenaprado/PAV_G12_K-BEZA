using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Tipo_Factura
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_tipo_factura { get; set; }
        public string Pp_id_tipo_factura { get; set; }

        public DataTable consultar_tipo_factura()
        {
            string sql = "SELECT id_tipo_factura, descripcion_tipo_factura FROM Tipo_Factura";

            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM Tipo_Factura "
                     + " WHERE descripcion_tipo_factura like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM Tipo_Factura WHERE id_tipo_factura = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Tipo_Factura (descripcion_tipo_factura)"
                                + " VALUES ("
                                + " '" + Pp_descripcion_tipo_factura + "')";

            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlmodificar = @"UPDATE Tipo_Factura SET descripcion_tipo_factura = '" + Pp_descripcion_tipo_factura + "' WHERE id_tipo_factura = " + Pp_id_tipo_factura;

            _BD.Modificar(sqlmodificar);
        }

        public void Borrar()
        {
            string sqlborrar = @"DELETE FROM Tipo_Factura WHERE id_tipo_factura = " + Pp_id_tipo_factura;
            _BD.Borrar(sqlborrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Tipo_Factura";
            return _BD.Ejecutar_Select(sql);
        }

    }
}