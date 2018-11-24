using DesignPatterns.AbstractFactory.Db2;
using DesignPatterns.AbstractFactory.MySql;

namespace DesignPatterns.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Factory mysqlFactory = new Factory(new MySqlDatabaseFactory());
            mysqlFactory.Run();

            Factory db2Factory = new Factory(new Db2DatabaseFactory());
            db2Factory.Run();
        }
    }
}