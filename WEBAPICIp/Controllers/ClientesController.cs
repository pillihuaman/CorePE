using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using BibliotecaDesarrollo;
using Newtonsoft.Json;
using WEBAPICIp.Models;
namespace WEBAPICIp.Controllers
{
    public class ClientesController : Controller
    {
        //// GET api/clientes
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/clientes/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/clientes
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/clientes/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/clientes/5
        //public void Delete(int id)
        //{
        //}

        public String GetClientes( BIClientes Clientes)
        {
            var arrayclientes = BLProcesoCliente.GetClientes();

            return JsonConvert.SerializeObject(arrayclientes);        }
    }
}
