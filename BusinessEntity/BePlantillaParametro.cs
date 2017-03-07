using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BePlantillaParametro
    {
        public int IdPlantillaParametro { get; set; }
        public int IdPlantilla { get; set; }
        public int IdPlantillaFuenteParametro { get; set; }
        public int IdTipoParametro { get; set; }
        public string Etiqueta { get; set; }
        public string Valor { get; set; }
        public string FuenteCodigo { get; set; }
        public string FuenteEtiqueta { get; set; }
        public string FuenteDescripcion { get; set; }
        public string FuenteOrigen { get; set; }
        public string TipoDescripcion { get; set; }
        public BeRespuesta Respuesta { get; set; }
    }
}
