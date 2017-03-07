using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BeSolicitud
    {
        public BeTramaSolicitud.SolPago TramaSolicitud { get; set; }
        public BeRespuesta Respuesta { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int IdServicio { get; set; }
        public int IdEstado { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public string Moneda { get; set; }
        public string Trama { get; set; }
    }
}
