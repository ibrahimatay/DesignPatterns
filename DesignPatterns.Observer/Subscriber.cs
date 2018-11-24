using System;

namespace DesignPatterns.Observer
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            this.Name = name;
        }

        public void Update(Subscriber subscriber, Page page, ChangeType changeType)
        {
            var type = Enum.GetName(typeof(ChangeType), changeType);
            Console.WriteLine($"Subscriber Name:{subscriber.Name} Change Type:{type} Page Name:{page.PageName}");
        }
    }
}