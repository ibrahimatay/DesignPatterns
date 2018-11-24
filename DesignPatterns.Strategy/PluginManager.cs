namespace DesignPatterns.Strategy
{
    public class PluginManager
    {
        private readonly IPlugin _plugin;

        public PluginManager(IPlugin plugin)
        {
            this._plugin = plugin;
        }

        public void Call()
        {
            _plugin.Call();
        }
    }
}