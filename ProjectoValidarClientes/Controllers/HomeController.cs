using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectoValidarClientes.APPBack;

namespace ProjectoValidarClientes.Controllers
{

    [ActionFilterClassMain]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        [OutputCache(Duration=15)]
     
        public string Index()
        {
            return "Welcome to mi MVC aplication metoh return a String "+ DateTime.Now.ToString("T");
        }

    }
}
