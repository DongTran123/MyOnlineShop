using MyOnlineShop.Web.Infrastructure.Core;
using System.Collections.Generic;
using System.Web.Http;
using MyOnlineShop.Service;

namespace MyOnlineShop.Web.Api
{
    public class TestController : ApiControllerBase
    {
        public TestController(IErrorService IErrorService) : base(IErrorService)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

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
        // POST api/<controller>
        public void Post([FromBody]string value)
        { 
        } 
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {

        }
    }
}
