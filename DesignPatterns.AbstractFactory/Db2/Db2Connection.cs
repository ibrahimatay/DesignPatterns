namespace DesignPatterns.AbstractFactory.Db2
{
    public class Db2Connection : IConnection
    {
        public bool Connecte()
        {
            return true;
        }

        public bool Disconnect()
        {
            return false;
        }

        public StateType Type => StateType.Open;
    }
}