using System;

namespace DesignPatterns.Builder
{
    public class ViewPluginBuilder : PluginBuilder
    {
        public ViewPluginBuilder()
        {
            this.Plugin = new Plugin()
            {
                PluginName = "ViewPlugin",
                PluginPath = "~/Share/",
                Permission = PermissionType.Anonymous
            };
        }

        public override void LoadPlugin()
        {
            Console.WriteLine("View Plugin is load");
        }

        public override void EnabledPlugin()
        {
            Console.WriteLine("View plugin is enablend");
        }

        public override void DisabledPlugin()
        {
            Console.WriteLine("View plugin is diablend");
        }
    }
}