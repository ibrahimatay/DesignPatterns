namespace DesignPatterns.AbstractFactory.MySql
{
    public class MySqlConection : IConnection
    {
        public bool Connecte()
        {
            return false;
        }

        public bool Disconnect()
        {
            return true;
        }

        public StateType Type => StateType.Open;
    }
}