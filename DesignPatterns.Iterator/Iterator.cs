using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class Iterator : IIterator
    {
        private readonly List<Item> _items;
        private int index;

        public Iterator()
        {
            index = 0;
            _items = new List<Item>();
        }

        public bool HasNext()
        {
            return index < _items.Count;
        }

        public Item Next()
        {
            Item currentItem =_items[index];
            
            index++;
            return currentItem;
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public bool Remove()
        {
            return _items.Remove(_items[index]);
        }
    }
}