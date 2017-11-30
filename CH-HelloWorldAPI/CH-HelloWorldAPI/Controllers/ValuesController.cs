using System.Web.Http;

namespace CH_HelloWorldAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Hello World";
        }

        // GET api/values/5
        public string Get(int id)
        {
            return string.Format("Hello World");
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
