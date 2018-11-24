using System;

namespace DesignPatterns.AbstractFactory
{
    public class Factory
    {
        private IDatabaseFactory _databaseFactory;
        private readonly IConnection _connection;
        private readonly ICommand _command;

        public Factory(IDatabaseFactory databaseFactory)
        {
            this._databaseFactory = databaseFactory;

            _connection = databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Run()
        {
            if (_connection.Type == StateType.Open)
            {
                Console.WriteLine("execute query");
            }
        }
    }
}