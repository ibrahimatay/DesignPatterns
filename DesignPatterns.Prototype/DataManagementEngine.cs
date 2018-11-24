using System;

namespace DesignPatterns.Prototype
{
    public class DataManagementEngine : IEngine
    {
        public DataManagementEngine(string name)
        {
            Console.WriteLine(name);
        }

        public IEngine Clone()
        {
            return this.MemberwiseClone() as IEngine;
        }
    }
}