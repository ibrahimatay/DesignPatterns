using System;

namespace DesignPatterns.Builder
{
    public class EnginePluginBuilder : PluginBuilder
    {
        public EnginePluginBuilder()
        {
            this.Plugin = new Plugin()
            {
                PluginName = "EnginePlugin",
                PluginPath = "~/Share/",
                Permission = PermissionType.Engine
            };
        }

        public override void LoadPlugin()
        {
            Console.WriteLine("Engine Plugin is load");
        }

        public override void EnabledPlugin()
        {
            Console.WriteLine("Engine plugin is enablend");
        }

        public override void DisabledPlugin()
        {
            Console.WriteLine("Engine plugin is diablend");
        }
    }
}