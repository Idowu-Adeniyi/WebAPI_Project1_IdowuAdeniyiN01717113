using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method receives a number as input and return the result of the square
        /// </summary>
        /// <param name="id"> The number to input</param>
        /// <return>id * id</return>
        /// <example>
        /// GET: localhost:xx/api/Square/5 --> 25
        /// GET: localhost:xx/api/Square/-5 --> 25
        /// GET: localhost:xx/api/Square/20 --> 400
        /// </example>

        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
