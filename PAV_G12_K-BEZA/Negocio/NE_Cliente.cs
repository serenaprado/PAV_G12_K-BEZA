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
    class NE_Cliente
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_n_tipocliente { get; set; }
        public string Pp_numero_documento { get; set; }
        public string Pp_apellido { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_fecha_nacimiento { get; set; }
        public string Pp_sexo { get; set; }
        public string Pp_telefono { get; set; }
        public string Pp_mail { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro_direccion { get; set; }
        public string Pp_id_barrio { get; set; }



        public DataTable RecuperarTodos()
        {
            string sql = "SELECT u.* , p.descripcion_tipo_doc as n_tipos " +
                "FROM cliente u join  tipo_documento p " +
                "on u.tipo_documento = p.id_tipo_documento ";
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.Ejecutar_Select(sql);

        }
        
        public DataTable Recuperar_X_Tipo_Doc(string tipo_documento)
        {
            string sql = "SELECT u.* , p.descripcion_tipo_doc as n_tipos " +
                "FROM cliente u join  tipo_documento p " +
                "on u.tipo_documento = p.id_tipo_documento "
                + " WHERE u.tipo_documento = " + tipo_documento;
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Num_Doc(string patron)
        {
            string sql = "SELECT u.* , p.descripcion_tipo_doc as n_tipos " +
                            "FROM cliente u join  tipo_documento p " +
                            "on u.tipo_documento = p.id_tipo_documento "
                            + " WHERE u.numero_documento  like '%" + patron.Trim() +"%'";
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperacion_Mixta(string patron, string tipo_documento)   
        {
        
            string sql = "SELECT u.* , p.descripcion_tipo_doc as n_tipos " +
                            "FROM cliente u join  tipo_documento p " +
                            "on u.tipo_documento = p.id_tipo_documento "
                            + " WHERE u.numero_documento  like '%" + patron.Trim() + "%'"
                            + " AND u.tipo_documento = " + tipo_documento;
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.Ejecutar_Select(sql);
        }
        public void Insertar_Cliente()
        {
                string sqlInsertar = "INSERT INTO Cliente (tipo_documento, numero_documento, apellido,nombre, fecha_nacimiento, sexo" +
                ", telefono, mail, calle, nro_direccion, id_barrio ) "
                + "VALUES ("
                + Pp_n_tipocliente
                + ", " + Pp_numero_documento

                + ", '" + Pp_apellido + "'"
                + ", '" + Pp_nombre + "'"
                + ", '" + Pp_fecha_nacimiento + "'"
                + ", '" + Pp_sexo + "'"
                + ", '" + Pp_telefono + "'"
                + ", '" + Pp_mail + "'"
                + ", '" + Pp_calle + "'"
                + ", " + Pp_nro_direccion
                + ", " + Pp_id_barrio + ")";

            _BD.Insertar(sqlInsertar);
            MessageBox.Show("La carga a finalizado correctamente");


        }
        public void Insertar_Cliente(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            _BD.Insertar(tratamientos.CostructorInsert("Cliente", controles));

        }
        public void Modificar_Cliente()
        {
            
            string sqlModificar = "UPDATE cliente SET "
                        
                        + "apellido = '" + Pp_apellido + "'"
                        + ", nombre = '" + Pp_nombre + "'"
                        + ", fecha_nacimiento = '" + Pp_fecha_nacimiento + "'"
                        + ", sexo = '" + Pp_sexo + "'"
                        + ", telefono = '" + Pp_telefono + "'"
                        + ", mail = '" + Pp_mail + "'"
                        + ", calle = '" + Pp_calle + "'"
                        + ", nro_direccion = " + Pp_nro_direccion
                        + ", id_barrio = " + Pp_id_barrio
                        + " WHERE tipo_documento = " + Pp_n_tipocliente + "AND numero_documento = "+ Pp_numero_documento;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar_Cliente()
        {
            string sqlDelete = "DELETE FROM cliente WHERE  tipo_documento = " + Pp_n_tipocliente + "AND numero_documento = " + Pp_numero_documento;
            _BD.Borrar(sqlDelete);
        }
        public void Borrar_Cliente(string id_tipo , string id_documento)
        {
            string sqlDelete = "DELETE FROM cliente WHERE  tipo_documento = " + id_tipo + "AND numero_documento = " + id_documento;
            _BD.Borrar(sqlDelete);
        }
    }
}
