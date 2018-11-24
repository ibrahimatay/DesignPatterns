namespace DesignPatterns.AbstractFactory.MySql
{
    public class MySqlDatabaseFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new MySqlConection();
        }

        public ICommand CreateCommand()
        {
            return new MySqlCommand();
        }
    }
}