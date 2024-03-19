using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using common;
using bll;
using System.Web.Http;

namespace myApi.Controllers
{
    public class ProfessionalsController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllProfessionals")]
        public List<Professionals> Get()
        {
            //return null;
            return ManegerProfessionals.GetProfessionalss();
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addProfessionals")]
        public void Post([FromBody]common.Professionals value)
        {
            ManegerProfessionals.addProfessionals(value);
        }

        // PUT: api/Class/5
        [Route("api/updateProfessionals")]
        public void Put(common.Professionals p)
        {
            ManegerProfessionals.Update(p);
        }

        // DELETE: api/Class/5
        [Route("api/removeProfessionals/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerProfessionals.remove(id);
        }
    }
}
