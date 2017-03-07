using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class BeDatosGenCip
    {
        public string XmlDesencriptado { get; set; }
        public List<BeMoneda> ListaModeneda { get; set; }
        public BeServicio Servicio { get; set; }
        public BeCliente UsuarioAnonimo { get; set; }
        public bool HabilitadoActualizacionCip { get; set; }
        public BeRespuesta Respuesta { get; set; }



    }
}
