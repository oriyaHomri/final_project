﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using common;
using bll;
using System.Web.Http;

namespace myApi.Controllers
{
    public class TypeOfProfessionalsController : ApiController
    {

        // GET: api/Class
        [Route("api/getAllTypeOfProfessionals")]
        public List<common.TypeOfProfessionals> Get()
        {
            //return null;
            return ManegerTypeOfProfessionals.GetTypeOfProfessionalss();
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        [Route("api/addTypeOfProfessionals")]
        public void Post([FromBody]TypeOfProfessionals value)
        {
            ManegerTypeOfProfessionals.addTypeOfProfessionals(value);
        }

        // PUT: api/Class/5
        
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE: api/Class/5
        [Route("api/removeTypeOfProfessionals/{id}")]
        public void Delete([FromUri]int id)
        {
            ManegerTypeOfProfessionals.remove(id);
        }
    }
}
