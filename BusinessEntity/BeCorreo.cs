using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
  public  class BeCorreo
    {
        public string UsuarioNombre { get; set; }
        public Int64 Cip { get; set; }
        public string CipEncriptado { get; set; }
        public int IdEmpresaContratante { get; set; }
        public string EmpresaContratante { get; set; }
        public int IdServicio { get; set; }
        public string ServicioNombre { get; set; }
        public string ConceptoPago { get; set; }
        public string Moneda { get; set; }
        public string Monto { get; set; }
        public string CodigoBarra { get; set; }
        public string FechaEmision { get; set; }
        public string HoraEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Cuenta { get; set; }
        public string CodigoRegistro { get; set; }
        public string Contrasenia { get; set; }
        public string SeccionValidacion { get; set; }
        public string NombreRemitente { get; set; }
        public BeOrdenPago OrdenPago { get; set; }
        public BeServicio Servicio { get; set; }
    }
}
