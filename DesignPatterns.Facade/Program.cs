using System;

namespace DesignPatterns.Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product
            {
                Description = "...",
                Price = 12,
                ProductName = "Books"
            };

            Shopping shopping = new Shopping();

            if (shopping.SalesToProduct(product))
            {
                Console.WriteLine("successful!");
            }
            else
            {
                Console.WriteLine("Process is failed");
            }
        }
    }
}