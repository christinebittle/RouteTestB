using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteTest.Controllers
{
    public class ChallengeController : ApiController
    {
        //aa test 
        /// <summary>
        /// Calculates the volumne of a prism given the length, width, and height
        /// </summary>
        /// <param name="x">The width of the prism in cm</param>
        /// <param name="y">the length of  the prism in cm</param>
        /// <param name="z">The height of the prism in cm</param>
        /// <returns>"The volumne is {volumne}cm^3"</returns>
        //POST: api/challenge/compute/6/1/10 ->
        //The volumne is 60cm^3
        [HttpPost]
        [Route("api/challenge/compute/{x}/{y}/{z}")]
        public string Compute(int x, int y, int z)
        {
            int volumne = x * y * z;
            string message = "The volumne is " + volumne + "cm^3";
            return message;
        }

    }
}
