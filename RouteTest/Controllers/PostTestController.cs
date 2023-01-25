using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteTest.Controllers
{
    public class PostTestController : ApiController
    {
        //POST: api/posttest/10 -> 100
        public int Post(int id)
        {
            return id * 10;

        }
    }
}
