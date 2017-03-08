using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using WEBAPICIp.BackEnd;
namespace WEBAPICIp.Controllers
{
    public class FeedControllerController : Controller
    {
        //
        // GET: /FeedController/

        public ActionResult Index()
        {
            return View();
        }
        public HttpResponseMessage Post([FromBody] Feedback Feed)
        {HttpResponseMessage response= new HttpResponseMessage();
            try
            {
            
            return ModelState.IsValid? this.Request.CreateResponse();
            }

            catch (HttpException ex)
            {
                throw ex;
            }
        }

    }
}
