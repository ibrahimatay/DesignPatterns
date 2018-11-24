using System;

namespace DesignPatterns.Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator<int> originator =new Originator<int>();
            originator.State = 1;
            CareTaker<int> careTaker = new CareTaker<int>();
            careTaker.Memento = originator.Redo();

            Console.WriteLine(originator.State.ToString());

            originator.State = 2;
            Console.WriteLine(originator.State.ToString());

            originator.Undo(careTaker.Memento);

            Console.WriteLine(originator.State.ToString());
        }
    }
}