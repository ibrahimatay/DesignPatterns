namespace DesignPatterns.Visitor
{
    public class MacComputer : Computer
    {
        public MacComputer() : base("Mac", "Apple")
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}