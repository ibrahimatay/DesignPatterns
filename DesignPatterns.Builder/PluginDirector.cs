namespace DesignPatterns.Builder
{
    public class PluginDirector
    {
        public void Costruct(PluginBuilder pluginBuilder)
        {
            pluginBuilder.LoadPlugin();
            pluginBuilder.EnabledPlugin();
            pluginBuilder.DisabledPlugin();
        }
    }
}