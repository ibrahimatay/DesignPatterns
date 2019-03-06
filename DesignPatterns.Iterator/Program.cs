using System;

namespace DesignPatterns.Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item item1 = new Item("Item 1");
            Item item2 = new Item("Item 2");
            Item item3 = new Item("Item 3");
            Item item4 = new Item("Item 4");
            
            
            ConcreteAggregate concreteAggregate = new ConcreteAggregate();
            Iterator iterator = concreteAggregate.CreateIterator();
            
            iterator.Add(item1);
            iterator.Add(item2);
            iterator.Add(item3);
            iterator.Add(item4);
            

            while (iterator.HasNext())
            {
                var item = iterator.Next();
                Console.WriteLine(item);
            }
        }
    }
}