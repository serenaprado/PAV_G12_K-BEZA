using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PAV_G12_K_BEZA.Clases
{
    class BE_AccesoDatos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void conectar()
        {
            conexion.ConnectionString = @"Data Source=200.69.137.167,11333;Persist Security Info=True;User ID=BD3K6G12_2021;Initial Catalog=BD3K6G12_2021;password=BDG12_8214";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void Insertar(string SqlInsertar)
        {
            InsModBorr(SqlInsertar);
        }
        public void Modificar(string SqlModificar)
        {
            InsModBorr(SqlModificar);
        }
        public void Borrar(string SqlBorrar)
        {
            InsModBorr(SqlBorrar);
        }
        private void InsModBorr(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
    }
}
