namespace DesignPatterns.Visitor
{
    public abstract class Computer
    {
        private readonly string _name;
        private readonly string _brand;

        public Computer(string name, string brand)
        {
            _name = name;
            _brand = brand;
        }

        public abstract void Accept(IVisitor visitor);

        public override string ToString()
        {
            return $"Name:{_name} - Brand:{_brand}";
        }
    }
}