using System;

namespace DesignPatterns.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Human Skills:");
            Human human = new Human(new Living());
            human.Describe();

            Console.WriteLine();
            Console.WriteLine("Bird Skills:");
            Bird bird = new Bird(new Living());
            bird.Describe();
        }
    }
}