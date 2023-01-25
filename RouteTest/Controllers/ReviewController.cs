using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteTest.Controllers
{
    public class ReviewController : ApiController
    {

        //api/Review -> "Hello"
        public string Get()
        {
            return "Hello";
        }
    }
}
