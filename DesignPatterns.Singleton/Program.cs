using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManagement configuration1 = ConfigurationManagement.GetConfigurationManagementInstance();

            Console.WriteLine(configuration1.Id);

            ConfigurationManagement configuration2 = ConfigurationManagement.GetConfigurationManagementInstance();

            Console.WriteLine(configuration2.Id);

            Console.ReadLine();
        }
    }
}