using System;

namespace DesignPatterns.Mediator
{
    public abstract class Messenger
    {
        protected IChat _chat;
        public Messenger(IChat chat)
        {
            _chat = chat;
        }

        public abstract void Sender(string message);
        public abstract void Receiver(string message);
    }
    
    public interface IChat
    {
        void SendMessage(Messenger sender, Messenger receiver, string message);
    }

    public class AliceMessenger : Messenger
    {
        public AliceMessenger(IChat chat) : base(chat)
        {
        }

        public override void Sender(string message)
        {
            Console.WriteLine($"Sent message:{message}");
        }

        public override void Receiver(string message)
        {
            Console.WriteLine($"received the message:{message}");
        }
    }

    public class BobMessenger : Messenger
    {
        public BobMessenger(IChat chat) : base(chat)
        {
        }

        public override void Sender(string message)
        {
            Console.WriteLine($"Sent message:{message}");
        }

        public override void Receiver(string message)
        {
            Console.WriteLine($"received the message:{message}");
        }
    }

    public class WhatsApp : IChat
    {
        public void SendMessage(Messenger sender, Messenger receiver, string message)
        {
            sender.Sender(message);
            receiver.Receiver(message);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            IChat whatsApp = new WhatsApp();
            
            Messenger bobMessenger = new BobMessenger(whatsApp);
            Messenger aliceMessenger = new AliceMessenger(whatsApp);
            
            whatsApp.SendMessage(bobMessenger, aliceMessenger,"Hello");
        }
    }
}