using System;

namespace DesignPatterns.Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();

            IEngine dataManagementEngine = new DataManagementEngine("Data Management Engine");
            
            engine.Engines.Add(dataManagementEngine);
            Console.WriteLine("second clone");
            engine.Engines.Add(dataManagementEngine.Clone() as DataManagementEngine);


            IEngine viewEngine = new ViewEngine("View Engine");

            engine.Engines.Add(viewEngine);
            Console.WriteLine("second clone");
            engine.Engines.Add(viewEngine.Clone() as ViewEngine);

            Console.ReadLine();
        }
    }
}