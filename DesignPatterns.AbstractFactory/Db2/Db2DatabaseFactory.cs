namespace DesignPatterns.AbstractFactory.Db2
{
    public class Db2DatabaseFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new Db2Connection();
        }

        public ICommand CreateCommand()
        {
            return new Db2Command();
        }
    }
}