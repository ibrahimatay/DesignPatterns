using System;
using DesignPatterns.Adapter.LoggerSystem;

namespace DesignPatterns.Adapter.WeatherSystem
{
    public class WeatherForecastLoggerAdapter : ILogger
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public int Priority { get; set; }

        private WeatherForecast _weatherForecast;

        public WeatherForecastLoggerAdapter(WeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        public void Write()
        {
            Console.WriteLine(
                $"Message:{Message} \n " +
                $"Code:{Code} \n " +
                $"Priority:{Priority} \n " +
                $"ExceptionMessage:{_weatherForecast.ExceptionMessage} \n " +
                $"ExceptionCode:{_weatherForecast.ExceptionCode}");
        }
    }
}