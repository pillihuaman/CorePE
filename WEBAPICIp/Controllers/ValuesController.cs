using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntity;
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

        public string Post([FromBody] Login Response)
        {
            Login log = new Login();
            log = Response;
          

         
            
            return "StreinLEn"+Response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Models.CIP PostData)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
    }
}