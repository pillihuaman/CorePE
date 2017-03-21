using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntity;
using BibliotecaDesarrollo;
using Newtonsoft.Json;
namespace WEBAPICIp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

     
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //[System.Web.Http.HttpPost]
        [HttpPost]
        [AllowAnonymous]
        public string Post([FromBody]   Product pr)
        {
            ////Login log = new Login();
            ////log = Response;
            //pr.Category = "1";
            //pr.Id = "1";



            return "";
        }
       

        // PUT api/values/5
        public void Put(int id, [FromBody] Product pro)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        //public HttpResponseMessage PostAddNewEmploye(Product Pro)
        //{
        //    List<Employee> add= new List<Employee>();
        //    if (Pro == null)
        //    {
        //        throw new ArgumentException();
        
        //    }
        //    else
        //    {
        //        add.Add(Pro);
        //        var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, Pro);
        //        string URll = Url.Link("DefaultApi", new { id = Emplo.Uid });
        //        response.Headers.Location = new Uri(URll);
        //        return response;
                 
               
        //    }
        //}

       
 

        
        
    }
}