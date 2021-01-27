using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantRater.Controllers
{
    public class ValuesController : ApiController
        // : ApiController allows access to properties and methods of API
    {
        // GET api/values
        // route follows the base url, every requst will havea base url when this is run it it will have a localhost url, e.g. "localhost:Port(this is assigned automatically)/Api/Value
        public IEnumerable<string> Get() // <-- This is a controller method or Endpoint, Get method returns array of value strings
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id) // <-- This Get method takes in an int and returns a value
        {
            return "value";
        }

        // POST api/values // <-- An action parameter comes only from the entity body of the incoming HttpRequestMessage 
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
