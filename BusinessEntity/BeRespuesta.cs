using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
   public class BeRespuesta
    {
        public bool ExisteError { get; set; }
        public string Mensaje { get; set; }
        public bool ValidacionOk { get; set; }
        public string Estado { get; set; }
        public string MensajeLog { get; set; }
    }
}
