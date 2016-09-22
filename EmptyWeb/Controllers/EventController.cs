using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmptyWeb.Controllers
{
    public class EventController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        public Dog GetDog(int id)
        {
            return new Dog { Id = id, Name = "杨贵妃", Address = "A good convention to follow when creating bundles is to include \"bundle\" as a prefix in the bundle name. This will prevent a possible routing conflict.", BirthDay = DateTime.Now };
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

    public class Dog
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public DateTime BirthDay
        {
            get;
            set;
        }
    }
}