using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectoValidarClientes.Controllers
{
    public class ProccesController : Controller
    {
        //
        // GET: /Procces/

        //public ActionResult Index()
        //{
        //    return View();
        //}
           [ActionName("ProcesoAPP")]
        public string List()
        {
            return "Procceso controller list action"+GetString();
        }
  
        public ActionResult Index()
        {

            return RedirectToAction("Index", "Home");
        }
        [NonAction]
        public string GetString()
        {

            return "stringlaza";
        }
        public ActionResult SearchInformacion()
        {
           
            return Content("Searchinformation no selecto empty");
        }
        [HttpGet]
        public ActionResult SearchInformacion(string id)
        {
            var select = Server.HtmlEncode(id);
            return Content( "using getverb selector");
        }
        public ActionResult ViewClient()
        {

            return View();
        }
    }
}
