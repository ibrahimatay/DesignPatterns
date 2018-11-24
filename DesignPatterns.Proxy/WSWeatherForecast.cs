using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class WSWeatherForecast : WSWeatherForecastClient
    {
        public string ExceptionMessage { get; set; }
        public string ExceptionCode { get; set; }
        public List<Weather> Weathers { get; set; }

        public string WSUserName { get; set; }
        public string WSUserPassword { get; set; }

        public override List<Weather> WeathersByCountyCode(string countyCode)
        {
            Console.WriteLine("Return of County of Weather");
            return Weathers;
        }
    }
}