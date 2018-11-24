using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public class Engine
    {
        public List<IEngine> Engines { get; set; }

        public Engine()
        {
            this.Engines = new List<IEngine>();
        }
    }
}