using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
  public  class BeOrdenPago
    {

        public Int64 IdOrdenPago { get; set; }
        public Int64 IdSolicitudPago { get; set; }
        public string NumeroCip { get; set; }
        public string ClienteEmail { get; set; }
        public string EmailComercio { get; set; }
        public System.Xml.XmlDocument Xml { get; set; }
        public DateTime FechaEmision { get; set; }
        public string UsuarioNombre { get; set; }
        public string DescripcionCliente { get; set; }
        public string DescripcionEmpresa { get; set; }
        public string DescripcionServicio { get; set; }
        public string ConceptoPago { get; set; }
        public string SimboloMoneda { get; set; }
        public decimal Total { get; set; }
        public string NumeroOrdenPago { get; set; }
        public string ClaveAPI { get; set; }
        public string ClaveSecreta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdEmpresa { get; set; }
        public int IdServicio { get; set; }
        public bool OcultarEmpresa { get; set; }
        public string CodPlantillaTipoVariacion { get; set; }
        public int IdMoneda { get; set; }
        public bool UsaUsuariosAnonimos { get; set; }
        public BeRespuesta Respuesta { get; set; }
    }
}
