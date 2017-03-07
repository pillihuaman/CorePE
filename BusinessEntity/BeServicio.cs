using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class BeServicio
    {
        public int IdServicio { get; set; }
        public string Codigo { get; set; }
        public bool UsaUsuariosAnonimos { get; set; }
        public string RutaClaPub { get; set; }
        public string RutaClaPriv { get; set; }
        public string ContratoXML { get; set; }
        public bool FlgEmailGenCIP { get; set; }
        public bool FlgEmailCCAdmin { get; set; }
        public decimal TiempoExpiracion { get; set; }
    }
}
