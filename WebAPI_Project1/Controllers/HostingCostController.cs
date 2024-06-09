using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class HostingCostController : ApiController
    {
        [HttpGet]
        [Route("api/HostingCost/{id}")]

        public string HostingCost(int id) 
        {
            int fortnights = id / 14 + 1; // this calculates the number of fortnights
            double cost = fortnights * 5.50; // this calculates how much the client will be charged
            cost = Math.Round(cost, 2); // I got the idea from javaScript syntax
            double HST = cost * 0.13; // this calculates the HST
            HST = Math.Round(HST, 2);
            double total = cost + HST; // this gets the total
            total = Math.Round(total, 2);
            string result1 = fortnights + " fortnights at $5.50/FN = $" + cost + " CAD. ";
            string result2 = "HST 13% = $" + HST + "CAD. ";
            string result3 = "Total = $" + total + "CAD";
            return result1 + result2 + result3;

        }

    }
}
