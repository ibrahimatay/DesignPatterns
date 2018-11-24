using System;

namespace DesignPatterns.FactoryMethod
{
    public class WebScreem : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Web page is drawing");
        }
    }
}