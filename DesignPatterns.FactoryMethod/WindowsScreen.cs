using System;

namespace DesignPatterns.FactoryMethod
{
    public class WindowsScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Windows drawing");
        }
    }
}