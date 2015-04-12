using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nyilv.Controllers
{
    public class NyilvController : ApiController
    {
        // GET api/nyilv
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/nyilv/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/nyilv
        public void Post([FromBody]string value)
        {
        }

        // PUT api/nyilv/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/nyilv/5
        public void Delete(int id)
        {
        }
    }
}
