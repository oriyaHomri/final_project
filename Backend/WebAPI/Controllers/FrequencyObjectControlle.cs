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
    public class FrequencyObjectController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllFrequencyObject")]
        public List<common.FrequencyObject> Get()
        {
            //return null;
            return ManegerFrequencyObject.GetFrequencyObjects();
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addFrequencyObject")]
        public void Post([FromBody]FrequencyObject value)
        {
            ManegerFrequencyObject.addFrequencyObject(value);
        }

        // PUT: api/Class/5
        
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE: api/Class/5
        [Route("api/removeFrequencyObject/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerFrequencyObject.remove(id);
        }
    }
}
