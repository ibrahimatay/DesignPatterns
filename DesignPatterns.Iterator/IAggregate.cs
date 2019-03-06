namespace DesignPatterns.Iterator
{
    public interface IAggregate
    {
        Iterator CreateIterator();
    }
}