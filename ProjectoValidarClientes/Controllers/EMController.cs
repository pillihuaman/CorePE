using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectoValidarClientes.Controllers
{
    public class EMController : Controller
    {
        //
        // GET: /Employee/

        //public ActionResult Search(string name)
        //{

        //    var input = Server.HtmlEncode(name);

        //    return Content(input);
        //}

        //public ContentResult Search(string name)
        //{

        //    var input = Server.HtmlEncode("Nombre es :"+name);
        //    return  Content(input);
        //}
        ////public FileContentResult Search(string name)
        //{
        //    var filepath = "D://zarmir//asp.net_mvc_tutorial.pdf";
        //    return File(filepath, "application/pdf");
        
        
        //}
        //public FilePathResult Search(string name)
        //{
        //    var filepath = "D://zarmir//asp.net_mvc_tutorial.pdf";
        //   return File(filepath, "application/pdf",name+".pdf");
        
        //}
        public string Search()
        {
            return "<ul><li>1</li><li>2</li><li>3</li></ul>";
        }
      
    }
}
