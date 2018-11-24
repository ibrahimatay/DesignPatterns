namespace DesignPatterns.Strategy
{
    public interface IPlugin
    {
        string PluginName { get;  } 
        string Version { get;  }
        void Call();
    }
}