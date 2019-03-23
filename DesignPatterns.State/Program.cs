using System;

namespace DesignPatterns.State
{
    public interface IEmotion
    {
        void SayHello();
        void SayGoodbye();
    }

    public class Happy : IEmotion
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, friend!");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Bye, friend!");
        }
    }

    public class Sad : IEmotion
    {
        public void SayHello()
        {
            Console.WriteLine("Hello. Sniff, sniff.");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Bye. Sniff, sniff.");
        }
    }

    public class Human : IEmotion
    {
        private readonly IEmotion _emotion;

        public Human(IEmotion emotion)
        {
            _emotion = emotion;
        }
        
        public void SayHello()
        {
            _emotion.SayHello();
        }

        public void SayGoodbye()
        {
            _emotion.SayGoodbye();
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Human me = new Human(new Happy());
            me.SayHello();
            me.SayGoodbye();

            Console.WriteLine("--------");
            
            Human smith = new Human(new Sad());
            smith.SayHello();
            smith.SayGoodbye(); 
        }
    }
}