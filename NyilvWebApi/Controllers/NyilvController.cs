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
using System.Reflection;

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
        public IHttpActionResult PutFind([FromBody]MyQuery query)
        {
            using (var ctx = new ModelNyilv())
            {
                List<Alapadatok> result = null;
                switch (query.Item2Find)
	            {
                    case "CegID" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                                int val = (int)Int32.Parse(query.Value);
                                result = ctx.Alapadatok.Where(c => c.CegID == val).ToList<Alapadatok>();
                        }
                        break;

                    case "Szamlazas" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Szamlazas == query.Value).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.ContainsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Szamlazas.Contains(query.Value)).ToList<Alapadatok>();
                        }
                        break;

                    case "Felelos" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Felelos == query.Value).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.ContainsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Felelos.Contains(query.Value)).ToList<Alapadatok>();
                        }
                        break;

                    case "Cegnev" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Cegnev == query.Value).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.ContainsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Cegnev.Contains(query.Value)).ToList<Alapadatok>();
                        }
                        break;

                    case "Ceg_forma" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Ceg_forma == query.Value).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.ContainsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Ceg_forma.Contains(query.Value)).ToList<Alapadatok>();
                        }
                        break;

                    case "Hivatkozas" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Hivatkozas == query.Value).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.ContainsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Hivatkozas.Contains(query.Value)).ToList<Alapadatok>();
                        }
                        break;

                    case "Felfuggesztett" :
                        if(query.Condition == MyQuery.EqualsCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Felfuggesztett == bool.Parse(query.Value)).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.TrueCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Felfuggesztett == true).ToList<Alapadatok>();
                        }
                        else if (query.Condition == MyQuery.FalseCondition)
                        {
                            result = ctx.Alapadatok.Where(c => c.Felfuggesztett != true).ToList<Alapadatok>();
                        }
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

        //Modify Alapadatok element
        [HttpPost]
        [Route(ControllerUpdateAlapadat.ControllerFormat)]
        public IHttpActionResult PutAlapadat([FromBody]Alapadatok adat)
        {
            using (var ctx = new ModelNyilv())
            {
                Alapadatok Item2Modify = ctx.Alapadatok
                        .Where(c => c.CegID == adat.CegID).FirstOrDefault<Alapadatok>();
                if(Item2Modify == null)
                {
                    ctx.Alapadatok.Add(adat);
                }
                else
                {
                    ctx.Entry(Item2Modify).CurrentValues.SetValues(adat);
                }
                ctx.SaveChanges();

                return Ok();
            }

        }

        //Import XLS file
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
