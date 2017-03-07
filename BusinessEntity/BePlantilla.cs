using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BePlantilla
    {
        public int IdPlantilla { get; set; }
        public int IdPlantillaTipo { get; set; }
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public string PlantillaHtml { get; set; }
        public int IdEstado { get; set; }
        public string CodigoPlantillaTipo { get; set; }
        public string CodigoPlantillaTipoVariacion { get; set; }
        public List<BePlantillaParametro> ListaParametros { get; set; }
        public BeRespuesta Respuesta { get; set; }
    }
}
