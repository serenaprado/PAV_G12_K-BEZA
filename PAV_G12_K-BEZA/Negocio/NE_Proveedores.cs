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
    class NE_Proveedores
    {
        public string Pp_razonSocial { get; set; }
        public string Pp_telefono { get; set; }
        public string Pp_nombreContacto { get; set; }
        public string Pp_apellidoContacto { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro { get; set; }
        public string Pp_barrio { get; set; }
        public string Pp_id_proveedor { get; set; }

        BE_AccesoDatos _BD = new BE_AccesoDatos();

        public DataTable RecuperarTodos()
        {
            string sql = "Select p.*, b.descripcion_barrio as 'nom_barrio' FROM Proveedor p join barrio b on p.id_barrio = b.id_barrio";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable ReporteProveedores_id(string id)
        {
            string sql = "Select id_proveedor, razon_social, telefono,apellido_contacto,nombre_contacto,calle,nro_direccion,id_barrio FROM Proveedor WHERE id_proveedor like '" + id.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable ReporteProveedores_Razon_social(string razon_social)
        {
            string sql = "Select id_proveedor, razon_social, telefono,apellido_contacto,nombre_contacto,calle,nro_direccion,id_barrio FROM Proveedor WHERE razon_social like '" + razon_social.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_apellido(string apellido)
        {
            string sql = @"Select p.*, b.descripcion_barrio as 'nom_barrio' FROM Proveedor p join"
                        + " barrio b on p.id_barrio = b.id_barrio where apellido_contacto like '%" + apellido.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_apellidoYRazon(string apellido, string razon)
        {
            string sql = @"Select p.*, b.descripcion_barrio as 'nom_barrio' FROM Proveedor p join barrio b on p.id_barrio ="
                        + " b.id_barrio where apellido_contacto like '%" + apellido.Trim() + "%' and razon_social like '%" + razon.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_X_Razon(string razon)
        {
            string sql = "Select p.*, b.descripcion_barrio as 'nom_barrio' FROM Proveedor p join barrio b on p.id_barrio = b.id_barrio where razon_social like '%" + razon.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Proveedor(razon_social, telefono, apellido_contacto, nombre_contacto, calle, nro_direccion, id_barrio)"
                            + "VALUES ("
                            + "'" + Pp_razonSocial + "' "
                            + ", '" + Pp_telefono + "' "
                            + ", '" + Pp_apellidoContacto + "' "
                            + ", '" + Pp_nombreContacto + "' "
                            + ", '" + Pp_calle + "' "
                            + "," + Pp_nro
                            + "," + Pp_barrio + ")";



            _BD.Insertar(sqlInsertar);


        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Proveedor SET "
                        + "razon_social = '" + Pp_razonSocial
                        + "', telefono = '" + Pp_telefono
                        + "' , apellido_contacto = '" + Pp_apellidoContacto
                        + "' , nombre_contacto = '" + Pp_nombreContacto
                        + "' , calle = '" + Pp_calle
                        + "' , nro_direccion = " + Pp_nro
                        + " , id_barrio = " + Pp_barrio
                        + " WHERE id_proveedor = " + Pp_id_proveedor;

            _BD.Modificar(sqlModificar);
        }

        public DataTable Recuperar_x_id(string id)
        {
            string sql = "SELECT * FROM Proveedor WHERE id_proveedor =" + id;
            return _BD.Ejecutar_Select(sql);
        }


        public void Borrar()
        {
            string sqlDelete = "DELETE FROM proveedor WHERE id_proveedor = " + Pp_id_proveedor;
            _BD.Borrar(sqlDelete);
        }


        //public void Insertar(Control.ControlCollection controles)
        //{
        //    TratamientoEspeciale tratamiento = new TratamientoEspeciale();
        //    _BD.Insertar(tratamiento.CostructorInsert("Proveedor", controles));
        //}
    }
}