using System;

namespace DesignPatterns.Visitor
{
    public class ExternalPowerVisitor : IVisitor
    {
        public void Visit(Computer computer)
        {
            if (computer is PcComputer)
            {
                Console.WriteLine("MAC have external power");
                return;
            }

            Console.WriteLine("Unsupported external power");
        }
    }
}