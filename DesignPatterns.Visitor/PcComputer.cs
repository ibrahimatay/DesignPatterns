namespace DesignPatterns.Visitor
{
    public class PcComputer : Computer
    {
        public PcComputer() : base("PC", "Any brand")
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}