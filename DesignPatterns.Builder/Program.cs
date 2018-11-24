using System;

namespace DesignPatterns.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PluginBuilder builder = null;

            PluginDirector pluginDirector = new PluginDirector();
            
            builder = new ViewPluginBuilder();
            pluginDirector.Costruct(builder);

            builder = new EnginePluginBuilder();
            pluginDirector.Costruct(builder);

            Console.ReadLine();
        }
    }
}