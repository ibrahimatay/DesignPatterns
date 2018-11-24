using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class WSWeatherForecastClientProxy : WSWeatherForecastClient
    {
        public string WSUserName { get; set; }
        public string WSUserPassword { get; set; }

        private WSWeatherForecast weatherForecast;
        public WSWeatherForecastClientProxy(string userName, string userPassword)
        {
            this.WSUserName = userName;
            this.WSUserPassword = userPassword;
        }

        public override List<Weather> WeathersByCountyCode(string countyCode)
        {
            if (this.weatherForecast == null)
            {
                Console.WriteLine("Connecting");
                this.weatherForecast = new WSWeatherForecast();
            }

            return weatherForecast.WeathersByCountyCode(countyCode);
        }
    }
}