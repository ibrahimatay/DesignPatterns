using System;

namespace DesignPatterns.Strategy
{
    public class EnginePlugin : IPlugin
    {
        public string PluginName { get { return "Engine"; } }
        public string Version { get { return "1.0"; } }
        public void Call()
        {
            Console.WriteLine("Engine Plugin Called");
        }
    }
}