namespace DesignPatterns.Builder
{
    public abstract class PluginBuilder
    {
        protected Plugin Plugin { get; set; }

        public abstract void LoadPlugin();

        public abstract void EnabledPlugin();

        public abstract void DisabledPlugin();
    }
}