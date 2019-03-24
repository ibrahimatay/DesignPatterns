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
        public Connection Connection { get; }

        public ConnectionBuilder()
        {
            Connection = new Connection();
        }
        
        public ConnectionBuilder SetDatabase(string database)
        {
            Connection.Database = database;
            return this;
        }

        public ConnectionBuilder SetServer(string server)
        {
            Connection.Server = server;
            return this;
        }

        public ConnectionBuilder SetUserId(string userId)
        {
            Connection.UserId = userId;
            return this;
        }

        public ConnectionBuilder SetPassword(string password)
        {
            Connection.Password = password;
            return this;
        }

        public Connection Build()
        {
            return Connection;
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