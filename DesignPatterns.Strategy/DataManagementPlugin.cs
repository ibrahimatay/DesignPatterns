using System;

namespace DesignPatterns.Strategy
{
    public class DataManagementPlugin : IPlugin
    {
        public string PluginName { get { return "DataManagement"; } }
        public string Version { get { return "1.0"; }}
        public void Call()
        {
            Console.WriteLine("Data Management Plugin Called");
        }
    }
}