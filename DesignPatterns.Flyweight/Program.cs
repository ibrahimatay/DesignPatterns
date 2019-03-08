namespace DesignPatterns.Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculatorFactory calculatorFactory = CalculatorFactory.GetInstance();
            
            ICalculator adder = calculatorFactory.GetCalculator(CalculateType.Adder);
            adder.Calculate(1,2);

            ICalculator multiplier = calculatorFactory.GetCalculator(CalculateType.Multiplier);
            multiplier.Calculate(4, 2);
        }
    }
}