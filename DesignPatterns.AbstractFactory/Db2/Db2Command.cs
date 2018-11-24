using System;

namespace DesignPatterns.AbstractFactory.Db2
{
    public class Db2Command : ICommand
    {
        public bool Execute(string query)
        {
            Console.WriteLine("Db2 query executed");
            return true;
        }
    }
}