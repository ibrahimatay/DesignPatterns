using DesignPatterns.Adapter.LoggerSystem;
using DesignPatterns.Adapter.WeatherSystem;

namespace DesignPatterns.Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherForecast weatherForecast = new WeatherForecast()
            {
                ExceptionCode = "3000",
                ExceptionMessage = "county code is not found"
            };

            ILogger[] loggers =
            {
                new FileLogger()
                {
                    Message = "File not found", Code = "404", Priority = 5
                },
                new ServiceLogger()
                {
                    Message = "services failed", Code = "500", Priority = 4
                },
                new WeatherForecastLoggerAdapter(weatherForecast),
            };

            foreach (ILogger logger in loggers)
            {
                logger.Write();
            }
        }
    }
}