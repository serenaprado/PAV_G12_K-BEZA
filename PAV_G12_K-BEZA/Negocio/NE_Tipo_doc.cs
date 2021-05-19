using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Tipo_doc
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_tipo_doc { get; set; }
        public string Pp_id_tipo_doc { get; set; }

        public DataTable Consultar_Tipo_Doc()
        {
            string sql = "SELECT id_tipo_documento, descripcion_tipo_doc FROM Tipo_Documento";
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_X_Patron(string patron)
        {
            string sql = @"SELECT * FROM Tipo_Documento WHERE descripcion_tipo_doc like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Id(string Id)
        {
            string sql = @"SELECT * FROM Tipo_Documento WHERE id_tipo_documento = " + Id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Tipo_Documento(descripcion_tipo_doc) VALUES('" + Pp_descripcion_tipo_doc + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Tipo_Documento SET descripcion_tipo_doc = '" + Pp_descripcion_tipo_doc + "'WHERE id_tipo_documento =" + Pp_id_tipo_doc;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = @"DELETE FROM Tipo_Documento WHERE id_tipo_documento = " + Pp_id_tipo_doc;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Tipo_Documento";
            return _BD.Ejecutar_Select(sql);
        }
    }
}

