using System;

namespace DesignPatterns.AbstractFactory.MySql
{
    public class MySqlCommand : ICommand
    {
        public bool Execute(string query)
        {
            Console.WriteLine("Mysql query executed");
            return true;
        }
    }
}