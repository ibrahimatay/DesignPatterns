namespace DesignPatterns.Flyweight
{
    public interface ICalculator
    {
        CalculateType Type { get; }
        void Calculate(int val1, int val2);
    }
}