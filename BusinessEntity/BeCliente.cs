using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
  public  class BeCliente
    {
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Alias { get; set; }
        public string EmailAlternativo { get; set; }
        public bool TieneInfoCompleta { get; set; }
        public bool HabilitarMonedero { get; set; }
        public DateTime FechaInfoCompleta { get; set; }
        public DateTime FechaHabilitarMonedero { get; set; }
        public DateTime FechaInhabilitarMonedero { get; set; }
        public string Observaciones { get; set; }

    }
}
