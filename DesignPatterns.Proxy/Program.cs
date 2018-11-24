namespace DesignPatterns.Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WSWeatherForecastClientProxy proxy = new WSWeatherForecastClientProxy("username", "userpassword");
            proxy.WeathersByCountyCode("90");
            proxy.WeathersByCountyCode("90");
            proxy.WeathersByCountyCode("90");
        }
    }
}