using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HW1.Models;

namespace HW1.Controllers
{
    public class FlightsController : ApiController
    {
        // GET api/<controller>
        public List<Flight> Get()
        {
            //return new string[] { "value1", "value2" };
            Flight flt1 = new Flight();
            return flt1.getFlight();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}