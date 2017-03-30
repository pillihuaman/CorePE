using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectoValidarClientes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Employee", "Employee/{name}",
            //    defaults: new { Controller = "Employee", Action = "Index", name = UrlParameter.Optional }
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{NumeroDocumento}",
                defaults: new { controller = "Clientes", action = "Index", NumeroDocumento = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Procces",
                url: "{Procces}/{action}/{id}",
                defaults: new { Controller = "Procces", Action = "List", id = UrlParameter.Optional }
                );
            
        }
    }
}