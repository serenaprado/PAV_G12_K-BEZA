using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PAV_G12_K_BEZA.Clases
{
    class TratamientosEspeciales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Text == "")
                    {
                        MessageBox.Show(((TextBox01)item).Pp_MensajeError);
                        ((TextBox01)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox01)item).Pp_MensajeError);
                        ((ComboBox01)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }

        public string CostructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }

            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            //MessageBox.Show(sql);
            return sql;
        }
        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.Ejecutar_Select("SELECT TOP 1 * FROM " + NombreTabla);
        }
        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_NombreCampo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";

        }
        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                case "DateTime":
                    return "'" + valorColumna + "'";
                default:
                    return valorColumna;
            }
        }

        public string RecuperarFecha()
        {
            BE_AccesoDatos_T _BD = new BE_AccesoDatos_T();
            return _BD.EjecutarSelect("select convert(char(10),getdate(),103)").Rows[0][0].ToString();
        }

    }
}