using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV_G12_K_BEZA.Clases;
using System.Windows.Forms;
using System.Data;

namespace PAV_G12_K_BEZA.Negocio
{
    class NE_Factura
    {
        //COMPRA
        public int Id_compra { get; set; }
        public string Id_empleado { get;set; }
        public string Id_Cliente { get; set; }
        public string Fecha_emision { get; set; }



        //FACTURA
        public string IdTipoFactura { get; set; }
        public int Numero_facutra { get; set; }
        //Comparte empleado
        // Comparte fecha
        public string Id_forma_pago { get; set; }
        public string Total { get; set; }

        public string TotalCompra { get; set; }

        BE_AccesoDatos_T _BD = new BE_AccesoDatos_T();
        


        public void Insertar(DataGridView producto, DataGridView kit)
        {
            Id_compra = BuscarNumeroIdCompra();

            string SqlInsertar = @"Insert INTO Compra(id_cliente, id_empleado, fecha)
                                    VALUES("                                    
                                    + Id_Cliente.Trim() 
                                    + " , " + Id_empleado.Trim() 
                                    + " , CONVERT(DATE,'" + Fecha_emision + "', 103)"+
                                    " )";
            _BD.InicioTransaccion();
            _BD.Insertar(SqlInsertar);

            Numero_facutra = BuscarNumeroFactura();

            //Los kit van a tener lineas_factura par, y los productos impar
            InsertarProducto(producto);
            InsertarKit(kit);
            FacturaTotal();

            if(_BD.FinalTransaccion() == BE_AccesoDatos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabo correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo grabar nada hubo un error");
            }

        }

        private int BuscarNumeroFactura()
        {
            DataTable numeroFactura1 = _BD.EjecutarSelect("SELECT MAX(numero_factura) FROM Factura where id_tipo_factura = " + IdTipoFactura);
            string numeroFactura = numeroFactura1.Rows[0][0].ToString();


            if (numeroFactura == "NULL")
            {
                numeroFactura = "0";
            }
            return Convert.ToInt32(numeroFactura + 1);

        }

        private int BuscarNumeroIdCompra()

        {
            
            DataTable numeroCompra1 = _BD.EjecutarSelect("SELECT MAX(id_compra) FROM Compra");
            string numeroCompra = numeroCompra1.Rows[0][0].ToString();
            if (numeroCompra == "NULL")
            {
                numeroCompra = "0";
            }
            return Convert.ToInt32(numeroCompra + 1);

        }

        private void FacturaTotal()
        {
            
            string SqlInsertar = @"Insert INTO Factura(id_tipo_factura, numero_factura, id_compra, fecha_emision, id_forma_pago, total) 
                            VALUES("
                            + IdTipoFactura 
                            + ", " + Numero_facutra  
                            + ", " + Id_compra 
                            + " , CONVERT(DATE,'" + Fecha_emision + "', 103), "
                            + Id_forma_pago +
                            "," + TotalCompra +")";

            _BD.Insertar(SqlInsertar);


        }



        //Falta numero_factura
        private void InsertarProducto (DataGridView producto)
        {
            int linea = 0;
            string SqlInsertarProd = @"INSERT INTO Detalle_Factura(id_tipo_factura, numero_factura, linea_factura, id_producto, cantidad, precio_unitario) VALUES("
                                    + IdTipoFactura
                                    + ", " + Numero_facutra 
                                    + ", ";
            for (int i = 0; i < producto.Rows.Count; i++)
            {
                linea = (i + 1) * 2 + 1;
                string ValoresMoviles = "";
                ValoresMoviles = linea + ", " + producto.Rows[i].Cells[0].Value.ToString()
                                + "," + producto.Rows[i].Cells[2].Value.ToString()
                                + "," + producto.Rows[i].Cells[3].Value.ToString() + ")";
                _BD.Insertar(SqlInsertarProd + ValoresMoviles);
                
            }
        }
        private void InsertarKit(DataGridView kit)
        {
            int linea = 0;
            string SqlInsertarProd = @"INSERT INTO Detalle_Factura(id_tipo_factura, numero_factura, linea_factura, id_kit, cantidad, precio_unitario) VALUES("
                                    + IdTipoFactura
                                    + ", " + Numero_facutra
                                    + ", ";
            for (int i = 0; i < kit.Rows.Count; i++)
            {
                string ValoresMoviles = "";
                linea = (i + 1)*2;
                ValoresMoviles = linea + ", " + kit.Rows[i].Cells[0].Value.ToString()
                                + "," + kit.Rows[i].Cells[2].Value.ToString()
                                + "," + kit.Rows[i].Cells[3].Value.ToString() + ")";
                _BD.Insertar(SqlInsertarProd + ValoresMoviles);

            }
        }

    }
}
