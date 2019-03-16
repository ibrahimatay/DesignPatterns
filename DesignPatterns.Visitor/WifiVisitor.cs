using System;

namespace DesignPatterns.Visitor
{
    public class WifiVisitor : IVisitor
    {
        public void Visit(Computer computer)
        {
            if (computer is MacComputer)
            {
                Console.WriteLine("Mac have wi-fi");
                return;
            }
            
            if (computer is PcComputer)
            {
                Console.WriteLine("PC have wi-fi");
                return;
            }

            Console.WriteLine("Unsupported wifi");
        }
    }
}