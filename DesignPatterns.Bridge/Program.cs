namespace DesignPatterns.Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVehicle schoolBus = new SchoolBus(new Engine());
            schoolBus.Drive();
            
            IVehicle taxi = new Taxi(null);
            taxi.Drive();
        }
    }
}