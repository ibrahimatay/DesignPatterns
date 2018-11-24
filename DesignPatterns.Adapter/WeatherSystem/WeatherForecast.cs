using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter.WeatherSystem
{
    public class WeatherForecast
    {
        public string ExceptionMessage { get; set; }
        public string ExceptionCode { get; set; }

        public List<Weather> WeathersByCountyCode(string countyCode)
        {
            Console.WriteLine("Return of County of Weather");
            return new List<Weather>();
        }
    }
}