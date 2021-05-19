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
    class ne_usuario
    {
        public string pp_usuario { get; set; }
        public string pp_clave { get; set; }
        public string pp_id_empleado { get; set; }
        public string pp_id_perfil { get; set; }
        public string pp_id_usuario { get; set; }

        public enum resultado_validacion { existe, no_existe }
        BE_AccesoDatos _bd = new BE_AccesoDatos();

        public resultado_validacion validar_usuario(string usuario, string contraseña)
        {
            string sql = @"SELECT * FROM Usuario WHERE usuario = '" + usuario + "'"
                                + "AND clave = '" + contraseña + "'";

            DataTable tabla = new DataTable();
            tabla = _bd.Ejecutar_Select(sql);

            if (tabla.Rows.Count == 1)
            {
                return resultado_validacion.existe;
            }
            else
            {
                return resultado_validacion.no_existe;
            }
        }

        public int recuperar_id_usuario(string usuario, string contraseña)
        {
            string sql = @"SELECT id_usuario FROM Usuario WHERE usuario = '" + usuario + "'"
                                + "AND clave = '" + contraseña + "'";

            DataTable tabla = new DataTable();
            tabla = _bd.Ejecutar_Select(sql);

            return int.Parse(tabla.Rows[0][0].ToString());
        }

        public int recuperar_id_empleado(string usuario, string contraseña)
        {
            string sql = @"SELECT id_empleado FROM Usuario WHERE usuario = '" + usuario + "'"
                                + "AND clave = '" + contraseña + "'";

            DataTable tabla = new DataTable();
            tabla = _bd.Ejecutar_Select(sql);

            return int.Parse(tabla.Rows[0][0].ToString());
        }

        public int recuperar_id_perfil(string usuario, string contraseña)
        {
            string sql = @"SELECT id_perfil FROM Usuario WHERE usuario = '" + usuario + "'"
                                + "AND clave = '" + contraseña + "'";

            DataTable tabla = new DataTable();
            tabla = _bd.Ejecutar_Select(sql);

            return int.Parse(tabla.Rows[0][0].ToString());
        }

        public DataTable recuperar_x_id(string id_usuario)
        {
            string sql = "SELECT * FROM usuario WHERE id_usuario =" + id_usuario;
            return _bd.Ejecutar_Select(sql);
        }

        public DataTable recuperar_todo()
        {
            string sql = "SELECT * FROM usuario u JOIN perfil p ON u.id_perfil = p.id_perfil";
            return _bd.Ejecutar_Select(sql);
        }

        public DataTable recuperar_x_perfiles(string id_perfil)
        {
            string sql = @"SELECT * FROM usuario u JOIN perfil p ON u.id_perfil = p.id_perfil "
                            +" WHERE u.id_perfil = " + id_perfil;
            return _bd.Ejecutar_Select(sql);
        }

        public DataTable recuperar_x_patron(string patron)
        {
            string sql = @"SELECT * FROM usuario u JOIN perfil p ON u.id_perfil = p.id_perfil "
                            + " WHERE u.usuario like '%" + patron.Trim()+"%'";
            return _bd.Ejecutar_Select(sql);
        }

        public void insertar()
        {
            string sql_insertar = @"INSERT INTO usuario (usuario, clave, id_empleado, id_perfil)"
                                    + " VALUES ("
                                    +"'"+pp_usuario+"'"
                                    +", '"+pp_clave+"'"
                                    +", '"+pp_id_empleado+"'"
                                    +", "+pp_id_perfil+")";
            _bd.Insertar(sql_insertar);
        }

        public void modificar()
        {
            string sql_modificar = @"UPDATE usuario SET "
                            + " usuario = '" + pp_usuario + "'"
                            + ", clave = '" + pp_clave + "'"
                            + ", id_empleado = '" + pp_id_empleado + "'"
                            + ", id_perfil = " + pp_id_perfil
                            + " WHERE id_usuario = " + pp_id_usuario;

            _bd.Modificar(sql_modificar);
        }

        public void borrar(string id_usuario)
        {
             string sql_delete = "DELETE  FROM usuario WHERE id_usuario= " + id_usuario;
            _bd.Borrar(sql_delete);
        }
    }
}
