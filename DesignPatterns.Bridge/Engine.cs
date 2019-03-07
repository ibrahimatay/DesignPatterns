using System;

namespace DesignPatterns.Bridge
{
    public class Engine : IEngine
    {
        public void Run()
        {
            Console.WriteLine("Runing");
        }
    }
}