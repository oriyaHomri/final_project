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
    public class InsertionsController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllInsertions")]
        public List<common.Insertions> Get()
        {
            //return null;
            return ManegerInsertions.GetInsertionss();
        }
        [Route("api/getAllI")]
        public List<common.Insertions> GetInsertionss()
        {
            //return null;
            return ManegerInsertions.GetInsertionss();
        }
        // GET: api/Class/5
        [Route("api/getInsertionsByYearOrderTenants/{year}")]
        public List<common.Insertions> Get([FromUri]int year)
        {
            return ManegerInsertions.getInsertionsByYearOrderTenants(year);
        }
        [Route("api/getInsertionsByTenants/{id}")]
        public List<common.Insertions> Get1([FromUri]int id)
        {
            return ManegerInsertions.getInsertionsByTenants(id);
        }
        // POST: api/Class
        [Route("api/addInsertions")]
        public void Post([FromBody]Insertions value)
        {

            ManegerInsertions.addInsertions(value);
        }

        // PUT: api/Class/5
        [Route("api/updateInsertions")]
        public void Put(common.Insertions i)
        {
            ManegerInsertions.Update(i);
        }

        // DELETE: api/Class/5
        [Route("api/removeInsertions/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerInsertions.remove(id);
        }
    }
}
