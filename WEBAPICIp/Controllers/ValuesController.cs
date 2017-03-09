using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntity;
using BibliotecaDesarrollo;
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
        [System.Web.Http.HttpPost]

        public string Post([FromBody]  byte[] bytes)
        {
            //Login log = new Login();
            //log = Response;
          

         
            
            return "StreinLEn";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string PostData)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        public HttpResponseMessage PostAddNewEmploye(Employee Emplo)
        {
            List<Employee> add= new List<Employee>();
            if (Emplo == null)
            {
                throw new ArgumentException();

            }
            else
            {
                add.Add(Emplo);
                var response = Request.CreateResponse<Employee>(HttpStatusCode.Created,Emplo);
                string URll = Url.Link("DefaultApi", new { id = Emplo.Uid });
                response.Headers.Location = new Uri(URll);
                return response;
            }
        }
 

        
        
    }
}