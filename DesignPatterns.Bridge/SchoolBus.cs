using System;

namespace DesignPatterns.Bridge
{
    public class SchoolBus : IVehicle
    {
        public IEngine Engine { get; }

        public SchoolBus(IEngine engine)
        {
            Engine = engine;
        }
        
        
        public void Drive()
        {
            if (Engine == null)
            {
                throw new Exception("There is no engine in the car.");
            }

            Engine.Run();
            
            Console.WriteLine("SchoolBus driving");
        }
    }
}