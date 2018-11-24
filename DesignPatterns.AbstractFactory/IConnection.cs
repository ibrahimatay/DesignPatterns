namespace DesignPatterns.AbstractFactory
{
    public interface IConnection
    {
        bool Connecte();
        bool Disconnect();
        StateType Type { get; }
    }
}