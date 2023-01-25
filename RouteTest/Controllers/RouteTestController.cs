using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteTest.Controllers
{
    public class RouteTestController : ApiController
    {
        //GET: api/RouteTest/Greeting1
        [HttpGet]
        [Route("api/RouteTest/Greeting1")]
        public string PurplePenguin()
        {

            return "hello";
        }

        //POST: api/RouteTest/Greeting2
        [HttpPost]
        public string Greeting2()
        {

            return "Howdy";
        }

        //GET: api/RouteTest/Greeting3
        [HttpGet]
        public string Greeting3()
        {

            return "hola";
        }

        //POST: api/RouteTest/Greeting4
        [HttpPost]
        public string Greeting4()
        {
            return "Heya";
        }

    }
}
