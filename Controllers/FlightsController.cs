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
        
        Flight flightToFlilter = new Flight();

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

        [HttpGet]
        [Route("../api/Flights/{city}")]
        
    public List<Flight> getFilteredRoutes(string city)
        {
            return flightToFlilter.getFiltered_C(city);

        }
        // POST api/<controller>
        public void Post([FromBody]Flight flt1)
        {
            Flight.flightList.Add(flt1);
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