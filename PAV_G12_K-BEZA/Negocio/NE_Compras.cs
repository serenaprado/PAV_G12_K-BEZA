using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Compras
    {
        BE_AccesoDatos_T _BD = new BE_AccesoDatos_T();
        

        public string RecuperarValorProducto (string id)
        {
            
            return _BD.EjecutarSelect("SELECT precio FROM Producto where id_producto = " + id).Rows[0][0].ToString();
        }
        public string RecuperarValorKit(string id)
        {        
            return _BD.EjecutarSelect("SELECT precio FROM Kit where id_kit = " + id).Rows[0][0].ToString();
        }
    }
}
