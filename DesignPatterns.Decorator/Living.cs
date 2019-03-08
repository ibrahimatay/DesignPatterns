using System;

namespace DesignPatterns.Decorator
{
    public sealed class Living : IAnimal
    {
        public void Describe()
        {
            Console.WriteLine("I am animal");
        }
    }
}