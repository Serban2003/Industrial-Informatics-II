using System;
using System.Collections.Generic;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Name = "WebService", Namespace = "WebService", Description="Web Service for Exercise 1 and 2")]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Double ConvertTemperature(Double temperature, String conversion)
        {
            Double result = 0;
            if(conversion == "CToF")
            {
                result = temperature * 9 / 5 + 32;
            }
            else if(conversion == "FToC")
            {
                result = (temperature - 32) * 5 / 9;
            }
            return Math.Round(result, 2);
        }

        [WebMethod]
        public Double ConvertRonToEuro(Double ronCurrency)
        {
            return Math.Round(ronCurrency / 4.95, 2);
        }

        [WebMethod]
        public List<String> GetListItems()
        {
            List<String> list = new List<String>
            {
                "Dog",
                "Cat",
                "Monkey",
                "Bird"
            };

            return list;
        }

        [WebMethod]
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
