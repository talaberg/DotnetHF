using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nyilv.Entities;
using System.Web;

namespace Nyilv.Controllers
{
    public class NyilvController : ApiController
    {

        // GET api/Alapadatok/{id}
        [HttpGet]
        [Route("api/Alapadatok/{id}", Name = "GetAlapadatokUrl")]
        public IHttpActionResult Get(int id)
        {
            using (var ctx = new  ModelNyilv())
            {
                var ceg = ctx.Alapadatok.SingleOrDefault(c => c.CegID == id);
                if (ceg == null)
                {
                    return NotFound();
                }
                return Ok(ceg);
                
            }
        }
        // GET api/Alapadatok/all
        [HttpGet]
        [Route("api/Alapadatok/all")]
        public IHttpActionResult GetAll()
        {
            using (var ctx = new ModelNyilv())
            {
                var cegek = new List<Alapadatok>();
                foreach (var ceg in ctx.Alapadatok)
                {
                    cegek.Add(ceg);
                    
                }
                if (cegek == null)
                {
                    return NotFound();
                }
                return Ok(cegek);

            }
        }

        // PUT: api/Alapadatok/find
        [HttpPut]
        [Route("api/Alapadatok/find")]
        public IHttpActionResult Put([FromBody]Alapadatok value)
        {
            using (var ctx = new ModelNyilv())
            {
                var ceg = ctx.Alapadatok.SingleOrDefault(c => c.Cegnev == value.Cegnev);
                if (ceg == null)
                {
                    return NotFound();
                }
                return Ok(ceg);

            }
        }

        [HttpPost]
        [Route("api/import")]
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/" + "Temp");
                    postedFile.SaveAs(filePath);
                    docfiles.Add(filePath);

                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return result;

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
