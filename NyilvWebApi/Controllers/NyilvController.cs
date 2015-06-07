using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

using NyilvLib;
using NyilvLib.Entities;

using System.Reflection;

using Nyilv.Auth;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Nyilv.Controllers
{
    public class NyilvController : ApiController
    {

        // GET api/Alapadatok/{id}
        [HttpGet]
        [Route(ControllerFormats.GetAlapadatById.ControllerFormat, Name = ControllerFormats.GetAlapadatById.ControllerName)]
        public IHttpActionResult GetAlapadatok(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    var ceg = ctx.Alapadatok.SingleOrDefault(c => c.CegID == id);
                    if (ceg == null)
                    {
                        return NotFound();
                    }
                    return Ok(ceg);

                }
            }
            else
            {
                return NotFound();
            }
        }
        // GET api/Cegadatok/{id}
        [HttpGet]
        [Route(ControllerFormats.GetCegadatokById.ControllerFormat, Name = ControllerFormats.GetCegadatokById.ControllerName)]
        public IHttpActionResult GetCegadatok(int id)
        {
            if (User.Identity.IsAuthenticated)
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
            else
            {
                return NotFound();
            }

        }

        // GET api/Dokumentumok/{id}
        [HttpGet]
        [Route(ControllerFormats.GetDokumentumokById.ControllerFormat, Name = ControllerFormats.GetDokumentumokById.ControllerName)]
        public IHttpActionResult GetDokumentumok(int id)
        {
            if (User.Identity.IsAuthenticated)
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
            else
            {
                return NotFound();
            }

        }
        // GET api/Alapadatok/all
        [HttpGet]
        [Route(ControllerFormats.GetAlapadatAll.ControllerFormat)]
        public IHttpActionResult GetAll()
        {
            if (User.Identity.IsAuthenticated)
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
            else
            {
                return NotFound();
            }
        }
        
        // PUT: api/Alapadatok/find
        [HttpPut]
        [Route(ControllerFormats.FindAlapadat.ControllerFormat)]
        public IHttpActionResult PutFind([FromBody]MyQuery query)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    List<Alapadatok> result = null;
                    switch (query.Item2Find)
                    {
                        case "CegID":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                int val = (int)Int32.Parse(query.Value);
                                result = ctx.Alapadatok.Where(c => c.CegID == val).ToList<Alapadatok>();
                            }
                            break;

                        case "Szamlazas":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Szamlazas == query.Value).ToList<Alapadatok>();
                            }
                            else if (query.Condition == MyQuery.ContainsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Szamlazas.Contains(query.Value)).ToList<Alapadatok>();
                            }
                            break;

                        case "Felelos":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Felelos == query.Value).ToList<Alapadatok>();
                            }
                            else if (query.Condition == MyQuery.ContainsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Felelos.Contains(query.Value)).ToList<Alapadatok>();
                            }
                            break;

                        case "Cegnev":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Cegnev == query.Value).ToList<Alapadatok>();
                            }
                            else if (query.Condition == MyQuery.ContainsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Cegnev.Contains(query.Value)).ToList<Alapadatok>();
                            }
                            break;

                        case "Ceg_forma":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Ceg_forma == query.Value).ToList<Alapadatok>();
                            }
                            else if (query.Condition == MyQuery.ContainsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Ceg_forma.Contains(query.Value)).ToList<Alapadatok>();
                            }
                            break;

                        case "Hivatkozas":
                            if (query.Condition == MyQuery.EqualsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Hivatkozas == query.Value).ToList<Alapadatok>();
                            }
                            else if (query.Condition == MyQuery.ContainsCondition)
                            {
                                result = ctx.Alapadatok.Where(c => c.Hivatkozas.Contains(query.Value)).ToList<Alapadatok>();
                            }
                            break;

                        case "Felfuggesztett":
                            if (query.Condition == MyQuery.EqualsCondition)
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
            else
            {
                return NotFound();
            }

        }

        //Modify Alapadatok element
        [HttpPost]
        [Route(ControllerFormats.UpdateAlapadat.ControllerFormat)]
        public IHttpActionResult PostAlapadat([FromBody]Alapadatok adat)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Alapadatok Item2Modify = ctx.Alapadatok
                            .Where(c => c.CegID == adat.CegID).FirstOrDefault<Alapadatok>();
                    if (Item2Modify == null)
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
            else
            {
                return NotFound();
            }
        }
        //Modify Cegadatok element
        [HttpPost]
        [Route(ControllerFormats.UpdateCegadatok.ControllerFormat)]
        public IHttpActionResult PostCegadat([FromBody]Cegadatok adat)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Cegadatok Item2Modify = ctx.Cegadatok
                            .Where(c => c.CegID == adat.CegID).FirstOrDefault<Cegadatok>();
                    if (Item2Modify == null)
                    {
                        ctx.Cegadatok.Add(adat);
                    }
                    else
                    {
                        ctx.Entry(Item2Modify).CurrentValues.SetValues(adat);
                    }
                    ctx.SaveChanges();

                    return Ok();
                }
            }
            else
            {
                return NotFound();
            }
        }
        //Modify Dokumentumok element
        [HttpPost]
        [Route(ControllerFormats.UpdateDokumentumok.ControllerFormat)]
        public IHttpActionResult PostCegadat([FromBody]Dokumentumok adat)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Dokumentumok Item2Modify = ctx.Dokumentumok
                            .Where(c => c.DokumentumID == adat.DokumentumID).FirstOrDefault<Dokumentumok>();
                    if (Item2Modify == null)
                    {
                        ctx.Dokumentumok.Add(adat);
                    }
                    else
                    {
                        ctx.Entry(Item2Modify).CurrentValues.SetValues(adat);
                    }
                    ctx.SaveChanges();

                    return Ok();
                }
            }
            else
            {
                return NotFound();
            }
        }
        // api/Alapadatok/remove/{id}
        [HttpGet]
        [Route(ControllerFormats.DeleteAlapadatById.ControllerFormat, Name = ControllerFormats.DeleteAlapadatById.ControllerName)]
        public IHttpActionResult DeleteAlapadatok(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Alapadatok ceg = ctx.Alapadatok.Where(c => c.CegID == id).FirstOrDefault<Alapadatok>();
                    if (ceg == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ctx.Alapadatok.Remove(ceg);
                        ctx.SaveChanges();
                        return Ok();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }
        // api/Cegadatok/remove/{id}
        [HttpGet]
        [Route(ControllerFormats.DeleteCegadatokById.ControllerFormat, Name = ControllerFormats.DeleteCegadatokById.ControllerName)]
        public IHttpActionResult DeleteCegadatok(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Cegadatok ceg = ctx.Cegadatok.Where(c => c.CegID == id).FirstOrDefault<Cegadatok>();
                    if (ceg == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ctx.Cegadatok.Remove(ceg);
                        ctx.SaveChanges();
                        return Ok();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }
        // api/Dokumentumok/remove/{id}
        [HttpGet]
        [Route(ControllerFormats.DeleteDokumentumokById.ControllerFormat, Name = ControllerFormats.DeleteDokumentumokById.ControllerName)]
        public IHttpActionResult DeleteDokumentumok(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    Dokumentumok doc = ctx.Dokumentumok.Where(c => c.DokumentumID == id).FirstOrDefault<Dokumentumok>();
                    if (doc == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ctx.Dokumentumok.Remove(doc);
                        ctx.SaveChanges();
                        return Ok();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }

        // api/aremeles/{ar}
        [HttpPost]
        [Route(ControllerFormats.Aremeles.ControllerFormat)]
        public IHttpActionResult Aremeles([FromBody]double ar)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var ctx = new ModelNyilv())
                {
                    foreach (var ceg in ctx.Cegadatok)
                    {
                        if (ceg.Tarifa != null)
                        {
                            ceg.Tarifa = (int)((double)ceg.Tarifa * ar);
                        }
                    }
                    ctx.SaveChanges();
                    return Ok();
                }
            }
            else
            {
                return NotFound();
            }
        }

        //Import Ceg XLS file
        [HttpPost]
        [Route(ControllerFormats.ImportCeg.ControllerFormat)]
        public HttpResponseMessage PostImportCeg()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                int i = 0;
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/" + file + (i++).ToString() + ".xlsx");
                    postedFile.SaveAs(filePath);
                    docfiles.Add(filePath);
                }
                MyXlsImporter.ImportCeg(docfiles);

                List<Alapadatok> importedItems = MyXlsImporter.ImportAlapadatokResult;
                List<Cegadatok> importedCegadatokItems = MyXlsImporter.ImportCegadatokResult;

                using (var ctx = new ModelNyilv())
                {
                    foreach (Alapadatok item in importedItems)
                    {
                        Alapadatok Item2Modify = ctx.Alapadatok
                                .Where(c => c.CegID == item.CegID).FirstOrDefault<Alapadatok>();
                        if (Item2Modify == null)
                        {
                            ctx.Alapadatok.Add(item);
                        }
                        else
                        {
                           // ctx.Entry(Item2Modify).CurrentValues.SetValues(item);
                        }                        
                    }
                    foreach (Cegadatok item in importedCegadatokItems)
                    {
                        Cegadatok Item2Modify = ctx.Cegadatok
                                .Where(c => c.CegID == item.CegID).FirstOrDefault<Cegadatok>();
                        if (Item2Modify == null)
                        {
                            ctx.Cegadatok.Add(item);
                        }
                        else
                        {
                            // ctx.Entry(Item2Modify).CurrentValues.SetValues(item);
                        }
                    }
                    ctx.SaveChanges();
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }
        //Import Dokumentum XLS file
        [HttpPost]
        [Route(ControllerFormats.ImportDokumentum.ControllerFormat)]
        public HttpResponseMessage PostImportDokumentum()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                int i = 0;
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/" + file + (i++).ToString() + ".xlsx");
                    postedFile.SaveAs(filePath);
                    docfiles.Add(filePath);
                }
                MyXlsImporter.ImportDokumentum(docfiles);

                List<Dokumentumok> importedItems = MyXlsImporter.ImportDokumentumokResult;

                using (var ctx = new ModelNyilv())
                {
                    foreach (Dokumentumok item in importedItems)
                    {
                        Dokumentumok Item2Modify = ctx.Dokumentumok
                                .Where(c => c.DokumentumID == item.DokumentumID).FirstOrDefault<Dokumentumok>();
                        if (Item2Modify == null)
                        {
                            ctx.Dokumentumok.Add(item);
                        }
                        else
                        {
                            // ctx.Entry(Item2Modify).CurrentValues.SetValues(item);
                        }
                    }

                    ctx.SaveChanges();
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }

        //Authentication
        [HttpPost]
        [Route(ControllerFormats.Authenticate.ControllerFormat)]
        public IHttpActionResult PostAuth([FromBody]UserData data)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            string userPassword = Decryption.Decyrpt(data.EncryptedPassword);

            var user = userManager.Find(data.Username, userPassword);

            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                return Ok();
            }
            else
            {
                return NotFound();
            }

        }

    }
}
