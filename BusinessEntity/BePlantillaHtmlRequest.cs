using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BePlantillaHtmlRequest
    {
        public int IdServicio { get; set; }
        public string CodPlantillaTipo { get; set; }
        public Dictionary<string, string> valoresDinamicos { get; set; }
        public string CodPlantillaTipoVariacion { get; set; }
    }
}
