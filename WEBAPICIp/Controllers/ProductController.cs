using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BibliotecaDesarrollo;
namespace WEBAPICIp.Controllers
{
    public class ProductController : ApiController
    {
          [System.Web.Http.HttpPost]
         public string  APICentro(Product pro)
         {


             return "d";

         }


          [System.Web.Http.HttpGet]
          public string APICentroGet(Product pro)
          {


              return "d";

          }
    }
}
