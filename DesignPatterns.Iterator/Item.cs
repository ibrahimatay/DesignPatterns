namespace DesignPatterns.Iterator
{
    public class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}