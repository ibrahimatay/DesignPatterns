using System;

namespace DesignPatterns.Facade
{
    public class Order
    {
        public bool AddToProduct(Product product)
        {
            Console.WriteLine("This product is join to sales order");
            return true;
        }
    }
}