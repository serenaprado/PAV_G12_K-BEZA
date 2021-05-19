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
    class NE_Productos
    {

        public string Pp_descripcion { get; set; }
        public string Pp_precio { get; set; }
        public string Pp_id_tipo_producto { get; set; }
        public string Pp_color { get; set; }
        public string Pp_material_principal { get; set; }
        public string Pp_peso { get; set; }
        public string Pp_largo { get; set; }
        public string Pp_ancho { get; set; }
        public string Pp_alto { get; set; }
        public string Pp_tiempo_garantia { get; set; }
        public string Pp_id_producto { get; set; }


        public enum ResultadoValidacion { exite, no_existe }
        BE_AccesoDatos _BD = new BE_AccesoDatos();


        public DataTable RecuperarTodos()
        {
            string sql = @"Select * From Producto p JOIN Tipo_Producto tp ON (p.id_tipo_producto = tp.id_tipo_producto)";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarTodosTipos()
        {
            string sql = @"Select * From Tipo_Producto tp";
            return _BD.Ejecutar_Select(sql);
        }


        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"Select * From Producto Where id_producto = " + id;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Perfiles(string id_tipo_producto)
        {
            string sql = @"Select * From Producto p JOIN Tipo_Producto tp ON (p.id_tipo_producto = tp.id_tipo_producto)"
                + " WHERE tp.id_tipo_producto = " + id_tipo_producto;
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"Select * From Producto p JOIN Tipo_Producto tp ON (p.id_tipo_producto = tp.id_tipo_producto)"
                     + " WHERE p.descripcion like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron, string id_tipo_producto)
        {
            string sql = @"Select * From Producto p JOIN Tipo_Producto tp ON (p.id_tipo_producto = tp.id_tipo_producto)"
           + " WHERE p.descripcion like '%" + patron.Trim() + "%'"
           + "tp.id_tipo_producto = " + id_tipo_producto;
            return _BD.Ejecutar_Select(sql);
        }
        public void Insertar()
        {
            string sqlInsertar = @"Insert into Producto(descripcion, precio, id_tipo_producto, "
                                + "color, material_principal, peso, largo, ancho, alto, tiempo_garantia)"
                                + " VALUES ("
                                + "'" + Pp_descripcion + "'"
                                + ", " + Pp_precio
                                + ", " + Pp_id_tipo_producto
                                + ", '" + Pp_color + "'"
                                + ", '" + Pp_material_principal + "'"
                                + ", '" + Pp_peso + "'"
                                + ", '" + Pp_largo + "'"
                                + ", '" + Pp_ancho + "'"
                                + ", '" + Pp_alto + "'"
                                + ", '" + Pp_tiempo_garantia + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void InsertarTipo()
        {
            string sqlInsertar = @"Insert into Tipo_Producto(descripcion) VALUES (" + "'" + Pp_descripcion + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Producto SET "
                         + " descripcion = '" + Pp_descripcion + "'"
                         + ", precio = " + Pp_precio
                         + ", id_tipo_producto = " + Pp_id_tipo_producto
                         + ", color = '" + Pp_color + "'"
                         + ", material_principal = '" + Pp_material_principal + "'"
                         + ", peso = '" + Pp_peso + "'"
                         + ", largo = '" + Pp_largo + "'"
                         + ", ancho = '" + Pp_ancho + "'"
                         + ", alto = '" + Pp_alto + "'"
                         + ", tiempo_garantia = '" + Pp_tiempo_garantia + "'"
                        + " WHERE id_producto = " + Pp_id_producto;
            _BD.Modificar(sqlModificar);
        }

        public void ModTipo()
        {
            string sqlModTipo = @"UPDATE Tipo_Producto SET "
                         + " descripcion = '" + Pp_descripcion + "'"
                         + " WHERE id_tipo_producto = " + Pp_id_tipo_producto;
            _BD.Modificar(sqlModTipo);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Producto WHERE id_producto = " + Pp_id_producto;
            _BD.Borrar(sqlDelete);
        }

        public void BorrarTipo()
        {
            string sqlDeleteTipo = "DELETE FROM Tipo_Producto WHERE id_tipo_producto = " + Pp_id_tipo_producto;
            _BD.Borrar(sqlDeleteTipo);
        }
    }
}
