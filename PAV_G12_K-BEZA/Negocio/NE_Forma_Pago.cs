using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Forma_Pago
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_descripcion_forma_pago { get; set; }
        public string Pp_id_forma_pago { get; set; }

        public DataTable Consultar_Formas_Pago()
        {
            string sql = "SELECT id_forma_pago, descripcion_forma_pago FROM Forma_Pago";
            DataTable Resultado = new DataTable();
            Resultado = _BD.Ejecutar_Select(sql);
            return Resultado;
        }

        public DataTable Recuperar_X_Patron(string patron)
        {
            string sql = @"SELECT * FROM Forma_Pago WHERE descripcion_forma_pago like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_X_Id(string Id)
        {
            string sql = @"SELECT * FROM Forma_Pago WHERE id_forma_pago = " + Id;
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Forma_Pago(descripcion_forma_pago) VALUES('" + Pp_descripcion_forma_pago + "')";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Forma_Pago SET descripcion_forma_pago = '" + Pp_descripcion_forma_pago + "'WHERE id_forma_pago =" + Pp_id_forma_pago;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = @"DELETE FROM Forma_Pago WHERE id_forma_pago = " + Pp_id_forma_pago;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM Forma_Pago";
            return _BD.Ejecutar_Select(sql);
        }
    }
}