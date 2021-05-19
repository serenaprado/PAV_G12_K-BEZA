using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;
using System.Data;
using System.Windows.Forms;


namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Rol_Empleado
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_rol { get; set; }
        public string Pp_id_rol { get; set; }

        public DataTable Consultar_Roles()
        {
            string sql = "SELECT id_rol, descripcion_rol FROM Rol";
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_X_Patron(string patron)
        {
            string sql = @"SELECT * FROM Rol WHERE descripcion_rol like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Id(string Id)
        {
            string sql = @"SELECT * FROM Rol WHERE id_rol = " + Id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Rol(descripcion_rol) VALUES('" + Pp_descripcion_rol + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Rol SET descripcion_rol = '" + Pp_descripcion_rol + "'WHERE id_rol =" + Pp_id_rol;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlDelete = @"DELETE FROM Rol WHERE id_rol = " + Pp_id_rol;
            _BD.Borrar(sqlDelete);
        }
        public void Borrar(string id_rol)
        {
            string sqlDelete = @"DELETE FROM Rol WHERE id_rol = " + id_rol;
            _BD.Borrar(sqlDelete);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Rol";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
