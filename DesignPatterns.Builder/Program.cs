using System;

namespace DesignPatterns.Builder
{
    public class Connection
    {
        public string Database { get; set; }
        public string Server { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        
        public override string ToString()
        {
            return $"Server={Server};Database={Database};UserId={UserId};Password={Password};";
        }
    }

    public class ConnectionBuilder
    {
        private Connection _connection { get; }

        public ConnectionBuilder()
        {
            _connection = new Connection();
        }
        
        public ConnectionBuilder SetDatabase(string database)
        {
            _connection.Database = database;
            return this;
        }

        public ConnectionBuilder SetServer(string server)
        {
            _connection.Server = server;
            return this;
        }

        public ConnectionBuilder SetUserId(string userId)
        {
            _connection.UserId = userId;
            return this;
        }

        public ConnectionBuilder SetPassword(string password)
        {
            _connection.Password = password;
            return this;
        }

        public Connection Build()
        {
            return _connection;
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Connection connection = new ConnectionBuilder()
                .SetServer("127.0.0.1")
                .SetDatabase("Northwind")
                .SetUserId("Nancy")
                .SetPassword("123456")
                .Build();

            Console.WriteLine(connection.ToString());
        }
    }
}