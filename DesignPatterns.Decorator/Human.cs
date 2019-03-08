using System;

namespace DesignPatterns.Decorator
{
    public class Human : AnimalDecorator
    {
        public Human(IAnimal animal) : base(animal)
        {
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine("I can write");
            Console.WriteLine("I can walk");
        }
    }
}