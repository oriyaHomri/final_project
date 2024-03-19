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
    public class ExpensesController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllExpenses")]
        public IEnumerable<common.Expenses> Get()
        {
            //return null;
            return ManegerExpenses.GetExpensess();
        }
        [Route("api/getId")]
        // GET: api/Class/5
        public int Get(int i)
        {
            return ManegerExpenses.getId();
        }

        // POST: api/Class
        [Route("api/addExpenses")]
        public void Post([FromBody]Expenses value)
        {
            ManegerExpenses.addExpenses(value);
        }

        // PUT: api/Class/5
        [Route("api/updateExpenses")]
        public void Put(common.Expenses e)
        {
            ManegerExpenses.Update(e);
        }

        // DELETE: api/Class/5
        [Route("api/removeExpenses/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerExpenses.remove(id);
        }
    }
}
