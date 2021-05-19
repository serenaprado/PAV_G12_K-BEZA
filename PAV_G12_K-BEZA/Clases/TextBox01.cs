using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV_G12_K_BEZA.Clases
{
    class TextBox01 : TextBox
    {
        public string Pp_NombreCampo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreTabla { get; set; }
    }
}