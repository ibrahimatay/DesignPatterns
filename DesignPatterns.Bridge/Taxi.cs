using System;

namespace DesignPatterns.Bridge
{
    public class Taxi : IVehicle
    {
        public IEngine Engine { get; }

        public Taxi(IEngine engine)
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
            
            Console.WriteLine("Taxi driving");
        }
    }
}