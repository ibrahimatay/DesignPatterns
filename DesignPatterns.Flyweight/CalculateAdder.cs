using System;

namespace DesignPatterns.Flyweight
{
    public class CalculateAdder : ICalculator
    {
        public CalculateType Type => CalculateType.Adder;
        
        public void Calculate(int val1, int val2)
        {
            Console.WriteLine($"{val1} + {val2} = {val1+val2}");
        }
    }
}