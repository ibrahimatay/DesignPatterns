using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Page
    {
        public string PageName { get; set; }

        private readonly List<Subscriber> _subscribers;

        public Page()
        {
            _subscribers = new List<Subscriber>();
        }

        public bool UpdateToPage(string pageName)
        {
            this.PageName = pageName;
            Notify(ChangeType.Update);
            return true;
        }

        public bool AddToPage(string pageName)
        {
            this.PageName = pageName;
            Notify(ChangeType.Add);
            return true;
        }

        public bool DeleteToPage()
        {
            Notify(ChangeType.Delete);
            return true;
        }

        public void Subscribe(Subscriber subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        public void UnSubscribe(Subscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        private void Notify(ChangeType changeType)
        {
            foreach (Subscriber subscriber in _subscribers)
            {
                subscriber.Update(subscriber, this, changeType);
            }
        }
    }
}