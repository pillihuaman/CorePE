using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
 using System.Web.Routing;
namespace ProjectoValidarClientes.APPBack
{
    public class ActionFilterClassMain:ActionFilterAttribute
    {
       
            public override void OnActionExecuting(ActionExecutingContext filterContext)

 {
 Log("OnActionExecuting", filterContext.RouteData);
 }
 public override void OnActionExecuted(ActionExecutedContext
filterContext)
 {
 Log("OnActionExecuted", filterContext.RouteData);
 }
 public override void OnResultExecuting(ResultExecutingContext
filterContext)
 {
 Log("OnResultExecuting", filterContext.RouteData);
 }
 public override void OnResultExecuted(ResultExecutedContext
filterContext)
 {
 Log("OnResultExecuted", filterContext.RouteData);
 }

 public void Log(string MethodName, RouteData routedate)
 { 
            var controllername=routedate.Values["controller"];
            var ActionName = routedate.Values["action"];
            var message = string.Format("{0} controller :{1} action :{2}", MethodName,controllername, ActionName);
            Debug.WriteLine(message, "Message Filter");
        
        }
    }
}