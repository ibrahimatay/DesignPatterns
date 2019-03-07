namespace DesignPatterns.Bridge
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        void Drive();
    }
}