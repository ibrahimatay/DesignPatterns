using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public abstract class WSWeatherForecastClient
    {
        public abstract List<Weather> WeathersByCountyCode(string countyCode);
    }
}