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
    public class FrequenciesController : ApiController
    {
        
        // GET: api/Class
        [Route("api/getAllFrequencies")]
        public List<common.Frequencies>  Get()
        {
            
           return ManegerFrequencies.GetFrequenciess(); 
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addFrequencies")]
        public void Post([FromBody]common.Frequencies value)
        {
            ManegerFrequencies.addFrequencies(value);
        }

        // PUT: api/Class/5
        [Route("api/updateFrequencies")]
        public void Put(int id, [FromBody]common.Frequencies value)
        {
            ManegerFrequencies.Update(value);
        }
        
        // DELETE: api/Class/5
        [Route("api/removeFrequencies/{id}")]
        public void Delete([FromUri]int id)
        {
              ManegerFrequencies.remove(id);
        }
    }
}
