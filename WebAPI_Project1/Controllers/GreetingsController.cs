using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class GreetingsController : ApiController
    {
        /// <summary>
        /// This method receives a number and returns a message of number of people
        /// </summary>
        /// <param name="id">number to input</param>
        /// <returns>
        /// "Greetings to {id} people!"
        /// </returns>
        /// <example>
        /// Get: localhost:xx/api/greetings/{id} -> "Greetings to {id} people!"
        /// Get: localhost:xx/api/greetings/5 -> "Greetings to 5 people!"
        /// Get: localhost:xx/api/greetings/7 -> "Greetings to 7 people!"
        /// Get: localhost:xx/api/greetings/0 -> "Greetings to 0 people!"
        /// </example>

        public string Get(int id)
        {
            string message = $"Greetings to {id} people";
            return message;
        }
    }
}
