using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Kit
    {

        public string Pp_descripcion { get; set; }
        public string Pp_precio { get; set; }
        public string Pp_id_kit { get; set; }
        public string pp_id_producto { get; set; }
        public int pp_cantidad { get; set; }

        public enum ResultadoValidacion { exite, no_existe }
        BE_AccesoDatos _BD = new BE_AccesoDatos();


        public DataTable RecuperarTodos()
        {
            string sql = @"Select * From Kit ";
            return _BD.Ejecutar_Select(sql);
        }


        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"Select * From Kit Where id_kit = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Id2(string id, string idp)
        {
            string sql = @"Select * From Kit_X_Producto x inner join Producto p on x.id_producto = p.id_producto
                            Where id_kit = " + id + "and x.id_producto =" + idp;
            return _BD.Ejecutar_Select(sql);
        }



        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"Select * From Kit"
                     + " WHERE descripcion_kit like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"Insert into Kit(descripcion_kit, precio)"
                                + " VALUES ("
                                + "'" + Pp_descripcion + "'"
                                + ", " + Pp_precio + ")";
            _BD.Insertar(sqlInsertar);
        }

        public void InsertarProducto()
        {
            string sqlInsertarProducto = @"Insert into Kit_X_Producto(id_kit,id_producto,cantidad)"
                                + " VALUES ("
                                + "'" + Pp_id_kit + "'"
                                + ", '" + pp_id_producto + "'" 
                                + "," + pp_cantidad + ")";
            _BD.Insertar(sqlInsertarProducto);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Kit SET "
                         + " descripcion_kit = '" + Pp_descripcion + "'"
                         + ", precio = " + Pp_precio
                         + " WHERE id_kit = " + Pp_id_kit;
            _BD.Modificar(sqlModificar);
        }

        public void ModificarProducto()
        {
            string sqlModificarProducto = @"UPDATE Kit_X_Producto SET "
                         + " cantidad = '" + pp_cantidad + "'"
                         + " WHERE id_kit = " + Pp_id_kit + "and id_producto =" + pp_id_producto;
            _BD.Modificar(sqlModificarProducto);
        }


        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Kit WHERE id_kit = " + Pp_id_kit;
            _BD.Borrar(sqlDelete);
        }
        public void Borrar2()
        {
            string sqlDelete = "DELETE FROM Kit_X_Producto WHERE id_kit = " + Pp_id_kit;
            _BD.Borrar(sqlDelete);
        }
        public void BorrarProducto()
        {
            string sqlDelete = "DELETE FROM Kit_X_Producto WHERE id_kit = " + Pp_id_kit + "and id_producto =" + pp_id_producto;
            _BD.Borrar(sqlDelete);
        }

        public DataTable RecuperarProductos_x_Id(string id)
        {
            string sql = @"Select x.id_kit,x.id_producto,x.cantidad,k.descripcion_kit,k.precio,p.descripcion,t.descripcion 
                                    From Kit_X_Producto x 
                                    inner join Kit k on x.id_kit = k.id_kit
                                    inner join Producto p on x.id_producto = p.id_producto
                                    inner join Tipo_Producto t on t.id_tipo_producto = p.id_tipo_producto
                                            Where x.id_kit = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarProductos_x_Id2(string id)
        {
            string sql = @"select * from Producto p JOIN Tipo_Producto tp ON (p.id_tipo_producto = tp.id_tipo_producto)
                            where id_producto not in (select id_producto 
                                                        from Kit_X_Producto where id_kit =" + id+")";
            return _BD.Ejecutar_Select(sql);
        }

    }
}
