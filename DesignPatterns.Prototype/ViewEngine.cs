using System;

namespace DesignPatterns.Prototype
{
    public class ViewEngine : IEngine
    {
        public ViewEngine(string name)
        {
            Console.WriteLine(name);
        }

        public IEngine Clone()
        {
            return this.MemberwiseClone() as IEngine;
        }
    }
}