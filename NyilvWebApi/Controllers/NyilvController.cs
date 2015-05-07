using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using NyilvLib;
using NyilvLib.Entities;
using System.Data.Entity;

namespace Nyilv.Controllers
{
    public class NyilvController : ApiController
    {

        // GET api/Alapadatok/{id}
        [HttpGet]
        [Route(ControllerGetAlapadatById.ControllerFormat, Name = ControllerGetAlapadatById.ControllerName)]
        public IHttpActionResult GetAlapadatok(int id)
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
        // GET api/Cegadatok/{id}
        [HttpGet]
        [Route(ControllerGetCegadatokById.ControllerFormat, Name = ControllerGetCegadatokById.ControllerName)]
        public IHttpActionResult GetCegadatok(int id)
        {
            using (var ctx = new ModelNyilv())
            {
                var ceg = ctx.Cegadatok.SingleOrDefault(c => c.CegID == id);
                if (ceg == null)
                {
                    return NotFound();
                }
                return Ok(ceg);

            }
        }

        // GET api/Dokumentumok/{id}
        [HttpGet]
        [Route(ControllerGetDokumentumokById.ControllerFormat, Name = ControllerGetDokumentumokById.ControllerName)]
        public IHttpActionResult GetDokumentumok(int id)
        {
            using (var ctx = new ModelNyilv())
            {
                var doc = ctx.Dokumentumok.Where(c => c.CegID == id).ToList<Dokumentumok>();
                if (doc == null)
                {
                    return NotFound();
                }
                return Ok(doc);

            }
        }
        // GET api/Alapadatok/all
        [HttpGet]
        [Route(ControllerGetAlapadatAll.ControllerFormat)]
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
        [Route(ControllerFindAlapadat.ControllerFormat)]
        public IHttpActionResult Put([FromBody]MyQuery query)
        {
            using (var ctx = new ModelNyilv())
            {
                List<Alapadatok> result = null;
                switch (query.Condition)
	            {
                    case MyQuery.EqualsCondition :
                        result = ctx.Alapadatok.Where(c => query.Item2Find == query.Value).ToList();
                        break;
		            default:
                        break;
	            }

                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);

            }
        }

        [HttpPost]
        [Route(ControllerImport.ControllerFormat)]
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
