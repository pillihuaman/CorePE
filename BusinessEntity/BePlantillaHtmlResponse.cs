using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BePlantillaHtmlResponse
    {
        public BePlantilla Plantilla { get; set; }
        public IDictionary<string, string> Parametrovalores { get; set; }
        public string Html { get; set; }
        public int State { get; set; }
        public string Message { get; set; }
    }
}
