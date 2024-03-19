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
    public class TasksController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllTasks")]
        public List<common.Tasks> Get()
        {
            //return null;
            return ManegerTasks.GetTaskss();
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addTasks")]
        public void Post([FromBody]common.Tasks value)
        {
            ManegerTasks.addTasks(value);
        }

        // PUT: api/Class/5
        [Route("api/updateTasks")]
        public void Put(int id, [FromBody]common.Tasks value)
        {
            ManegerTasks.Update( value);
        }

        // DELETE: api/Class/5
        [Route("api/removeTasks/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerTasks.remove(id);
        }
    }
}
