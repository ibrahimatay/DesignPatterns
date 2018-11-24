namespace DesignPatterns.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PluginManager pluginManager = new PluginManager(new DataManagementPlugin());
            pluginManager.Call();
        }
    }
}