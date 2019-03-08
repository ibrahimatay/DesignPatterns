using System;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class CalculatorFactory
    {
        private readonly Dictionary<CalculateType, ICalculator> _memoryObject;

        private static readonly object Lock = new object();

        private static CalculatorFactory _calculatorFactory;

        private CalculatorFactory()
        {
            _memoryObject = new Dictionary<CalculateType, ICalculator>();
        }
        
        public static CalculatorFactory GetInstance()
        {
            lock (Lock)
            {

                if (_calculatorFactory == null)
                {
                    _calculatorFactory = new CalculatorFactory();
                }

                return _calculatorFactory;
            }
        }
        
        public ICalculator GetCalculator(CalculateType type)
        {
            if (_memoryObject.ContainsKey(type))
            {
                return _memoryObject[type];
            }

            ICalculator swap;

            switch (type)
            {
                case CalculateType.Adder:
                    swap = new CalculateAdder();
                    break;
                case CalculateType.Multiplier:
                    swap = new CalculateMultiplier();
                    break;
                default:
                    throw new Exception("CalculateType must be selected");
            }
            
            _memoryObject.Add(type,swap);

            return swap;
        }
    }
}