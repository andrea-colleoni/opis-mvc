using Giorno1Oggetti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    public class ValuesController : ApiController
    {
        Giorno1Context db = new Giorno1Context();
        // GET api/values
        [HttpGet]
        public IEnumerable<Contact> Pippo()
        {
            return db.Contacts;
        }

        // GET api/values/5
        [Authorize]
        public Contact Get(int id)
        {
            return db.Contacts.Find(id);
        }

        // POST api/values
        public void Post([FromBody]Prova value)
        {
            Console.Out.WriteLine(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
