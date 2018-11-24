namespace DesignPatterns.Observer
{
    public interface ISubscriber
    {
        void Update(Subscriber subscriber, Page page, ChangeType changeType);
    }
}