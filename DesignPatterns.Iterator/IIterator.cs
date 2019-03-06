namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        Item Next();
        void Add(Item item);
        bool Remove();
    }
}