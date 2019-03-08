using System;

namespace DesignPatterns.Flyweight
{
    public class CalculateMultiplier : ICalculator
    {
        public CalculateType Type => CalculateType.Multiplier;
        
        public void Calculate(int val1, int val2)
        {
            Console.WriteLine($"{val1} * {val2} = {val1 * val2}");
        }
    }
}