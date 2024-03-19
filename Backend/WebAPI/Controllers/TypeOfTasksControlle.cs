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
    public class TypeOfTasksController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllTypeOfTasks")]
        public List<common.TypeOfTasks> Get()
        {
            //return null;
            return ManegerTypeOfTasks.GetTypeOfTaskss();
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addTypeOfTasks")]
        public void Post([FromBody]TypeOfTasks value)
        {
            ManegerTypeOfTasks.addTypeOfTasks(value);
        }

        // PUT: api/Class/5
        
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE: api/Class/5
        [Route("api/removeTypeOfTasks/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerTypeOfTasks.remove(id);
        }
    }
}
