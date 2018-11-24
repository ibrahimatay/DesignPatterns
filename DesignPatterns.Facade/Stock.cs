using System;

namespace DesignPatterns.Facade
{
    public class Stock
    {
        public bool CheckStokByProduct(Product product)
        {
            Console.WriteLine("Product is in the stock");
            return true;
        }

        public bool LookProductTemporary(Product product)
        {
            Console.WriteLine("This product is look");
            return true;
        }
    }
}