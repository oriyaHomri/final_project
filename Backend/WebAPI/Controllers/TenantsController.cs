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
    public class TenantsController : ApiController
    {
        
        // GET: api/Class
        [Route("api/getAllTenants")]
        public List<common.Tenants>  Get()
        {
            return             ManegerTenants.GetTenantss(); 
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addTenants")]
        public void Post([FromBody]Tenants value)
        {
            ManegerTenants.addTenants(value);
        }

        // PUT: api/Class/5
        [Route("api/updateTenants")]
        public void Put([FromBody]common.Tenants value)
        {
            ManegerTenants.Update(value);   
        }
        [Route("api/sendEmailTenants")]
        public void Put([FromBody]SendEmail value)
        {

            ManegerSendEMail.sendEmail(value); 
        }
        // DELETE: api/Class/5
        [Route("api/removeTenants/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerTenants.remove(id);
        }
    }
}
