using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteTest.Controllers
{
    public class InputsController : ApiController
    {

        //GET: api/inputs/multiply/a/b -> a*b
        [HttpGet]
        [Route("api/inputs/multiply/{a}/{b}")]
        public int Multiply(int a, int b)
        {

            return a*b;
        }

    }
}
