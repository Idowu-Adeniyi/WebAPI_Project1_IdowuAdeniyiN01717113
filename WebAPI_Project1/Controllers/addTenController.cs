using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class addTenController : ApiController
    {
        /// <summary>
        /// This method receives a number as input and return the result
        /// </summary>
        /// <param name="id"> The number to input</param>
        /// <return>{id} + 10</return>
        /// <example>
        /// GET: localhost:xx/api/AddTen/10 --> 20
        /// GET: localhost:xx/api/AddTen/-1 --> 9
        /// GET: localhost:xx/api/AddTen/15 --> 25
        /// </example>
        
        public int Get(int id)
        {
            int result = id + 10;
            return result;       
        }
    }
}
