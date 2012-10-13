using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _003_ConsumidorWebService.Proxy;

namespace _003_ConsumidorWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new GlobalWeatherSoapClient("GlobalWeatherSoap");

            Console.WriteLine(c.GetCitiesByCountry("Brazil"));

            Console.ReadKey();
        }
    }
}
