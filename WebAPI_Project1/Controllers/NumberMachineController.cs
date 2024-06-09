using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/{id}")]


        /// <summary>
        /// This method receives a number and returns the result
        /// </summary>
        /// <param name="id"> The number to input</param>
        /// <returns>
        /// id + 10, id /2, id -5, id * 10
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/5 -> {"sum":10, "divide":2,"minus":2, "multiply":50}
        /// GET: localhost:xx/api/NumberMachine/-3 -> {"sum":2, "divide":-1,"minus":-6, "multiply":-30}
        /// GET: localhost:xx/api/NumberMachine/20 -> {"sum":25, "divide":10,"minus":17, "multiply":200}
        /// </example>

        public IHttpActionResult Method(int id)
        {
            int sum = id + 5;
            int divide = id / 2;
            int minus = id - 3;
            int multiply = id * 10;

            var result = new
            {
                sum,
                divide,
                minus,
                multiply
            };
            return Ok(result);

        }
    }
}
