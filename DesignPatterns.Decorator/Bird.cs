using System;

namespace DesignPatterns.Decorator
{
    public class Bird : AnimalDecorator
    {
        public Bird(IAnimal animal) : base(animal)
        {
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine("I can fly");
            Console.WriteLine("I can sing");
        }
    }
}