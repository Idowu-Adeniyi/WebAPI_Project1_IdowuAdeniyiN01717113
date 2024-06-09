using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method listens to a post request and output a string
        /// </summary>
        /// <returns>
        /// "Hello World!"
        /// </returns> 
        /// <example>
        /// Post: localhost:xx/api/greeting -> "Hello World!"
        /// curl -d "" http://localhost:51764/api/greeting
        /// </example>

        public string Post()
        {
            string response = "Hello World!";
            return response;
        }
    }
}
