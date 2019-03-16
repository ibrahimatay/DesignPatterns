using System;

namespace DesignPatterns.Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Computer mac = new MacComputer();
            Computer pc = new PcComputer();

            Console.WriteLine(mac.ToString());
            mac.Accept(new WifiVisitor());
            mac.Accept(new ExternalPowerVisitor());

            Console.WriteLine(pc.ToString());
            pc.Accept(new WifiVisitor());
            pc.Accept(new ExternalPowerVisitor());
        }
    }
}