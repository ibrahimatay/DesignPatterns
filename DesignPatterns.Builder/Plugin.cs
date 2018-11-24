namespace DesignPatterns.Builder
{
    public class Plugin
    {
        public string PluginName { get; set; }
        public string PluginPath { get; set; }
        public PermissionType Permission { get; set; }

        public override string ToString()
        {
            return this.PluginName;
        }
    }
}