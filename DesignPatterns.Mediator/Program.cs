using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Mediator
{
    public abstract class Messenger
    {
        public abstract void Receiver(string message);
    }
    
    public interface IChat
    {
        void SendMessage(Messenger receiver, string message);

        void AddMessenger(Messenger messenger);
    }

    public class AliceMessenger : Messenger
    {
        public override void Receiver(string message)
        {
            Console.WriteLine($"received the message:{message}");
        }
    }

    public class BobMessenger : Messenger
    {
        public override void Receiver(string message)
        {
            Console.WriteLine($"received the message:{message}");
        }
    }

    public class AnonymousChat : IChat
    {
        private List<Messenger> messengers;

        public AnonymousChat()
        {
            messengers = new List<Messenger>();
        }


        public void SendMessage(Messenger receiver, string message)
        {
            var messenger = messengers.SingleOrDefault(x => x == receiver);
            if (messenger == null) return;

            messenger.Receiver(message);
        }

        public void AddMessenger(Messenger messenger)
        {
            messengers.Add(messenger);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            IChat chat = new AnonymousChat();
            
            Messenger bobMessenger = new BobMessenger();
            Messenger aliceMessenger = new AliceMessenger();
            
            chat.AddMessenger(bobMessenger);
            chat.AddMessenger(aliceMessenger);
            
            chat.SendMessage(aliceMessenger,"Hello");
        }
    }
}