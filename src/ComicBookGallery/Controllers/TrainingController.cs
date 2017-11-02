using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComicBookGallery.Controllers
{
    public class TrainingController : ApiController
    {
        // GET: api/Training
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Training/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Training
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Training/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Training/5
        public void Delete(int id)
        {
        }
    }
}
