using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV_G12_K_BEZA.Clases;
using System.Windows.Forms;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Empleados
    {
        public string Pp_legajo { get; set; }
        public string Pp_tipo_documento { get; set; }
        public string Pp_nro_documento { get; set; }
        public string Pp_id_rol { get; set; }
        public string Pp_apellido { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_sexo { get; set; }
        public string Pp_fecha_nacimiento { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro_direccion { get; set; }
        public string Pp_id_barrio { get; set; }
        public string Pp_legajo_supervisor { get; set; }


        public enum ResultadoValidacion { exite, no_existe }
        BE_AccesoDatos _BD = new BE_AccesoDatos();


        public DataTable RecuperarTodos()
        {
            string sql = @"select * from Empleado e JOIN Tipo_Documento td ON (e.tipo_documento = td.id_tipo_documento) " +
                                    "JOIN Barrio b ON (e.id_barrio = b.id_barrio) JOIN Rol r ON (e.id_rol = r.id_rol)";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"Select * From Empleado Where legajo_empleado = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_DNI(string documento)
        {
            string sql = @"Select * from Empleado e JOIN Tipo_Documento td ON (e.tipo_documento = td.id_tipo_documento)"
                + " WHERE e.nro_documento LIKE '%" + documento.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuprar_x_Nombre(string nombre)
        {
            string sql = @"select * from Empleado e JOIN Tipo_Documento td ON (e.tipo_documento = td.id_tipo_documento) "
                        + " JOIN Barrio b ON (e.id_barrio = b.id_barrio) JOIN Rol r ON (e.id_rol = r.id_rol)"
                        + " WHERE e.nombre like '%" + nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuprar_x_Apellido(string apellido)
        {
            string sql = @"select * from Empleado e JOIN Tipo_Documento td ON (e.tipo_documento = td.id_tipo_documento) "
                        + " JOIN Barrio b ON (e.id_barrio = b.id_barrio) JOIN Rol r ON (e.id_rol = r.id_rol)"
                        + " WHERE e.apellido like '%" + apellido.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"Insert into Empleado (legajo_empleado, tipo_documento, nro_documento, id_rol, apellido, nombre, sexo, " +
                    " fecha_nacimiento, calle, nro_direccion, id_barrio, legajo_supervisor) VALUES("
                                + "'" + Pp_legajo + "'"
                                + ", " + Pp_tipo_documento
                                + ", " + Pp_nro_documento
                                + ", '" + Pp_id_rol + "'"
                                + ", '" + Pp_apellido + "'"
                                + ", '" + Pp_nombre + "'"
                                + ", '" + Pp_sexo + "'"
                                + ", '" + Pp_fecha_nacimiento + "'"
                                + ", '" + Pp_calle + "'"
                                + ", '" + Pp_nro_direccion + "'"
                                + ", '" + Pp_id_barrio + "'"
                                + ", '" + Pp_legajo_supervisor + "')";
                                                                                               
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Empleado SET "
                         + " legajo_empleado = '" + Pp_legajo + "'"
                         + ", tipo_documento = " + Pp_tipo_documento
                         +", nro_documento = " + Pp_nro_documento
                         +", id_rol = '" + Pp_id_rol + "'"
                         + ", apellido = '" + Pp_apellido + "'"
                         + ", nombre = '" + Pp_nombre + "'"
                         + ", sexo = '" + Pp_sexo + "'"
                         + ", fecha_nacimiento = '" + Pp_fecha_nacimiento + "'"
                         + ", calle = '" + Pp_calle + "'"
                         + ", nro_direccion = '" + Pp_nro_direccion + "'"
                         + ", id_barrio = '" + Pp_id_barrio + "'"
                         + ", legajo_supervisor = '" + Pp_legajo_supervisor + "'"
                        + " WHERE legajo_empleado = " + Pp_legajo;
            _BD.Modificar(sqlModificar);
        }


        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Empleado WHERE legajo_empleado = " + Pp_legajo;
            _BD.Borrar(sqlDelete);
        }
    }
}
