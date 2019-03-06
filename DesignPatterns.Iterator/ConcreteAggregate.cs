namespace DesignPatterns.Iterator
{
    public class ConcreteAggregate : IAggregate
    {
        public Iterator CreateIterator()
        {
            return new Iterator();
        }
    }
}