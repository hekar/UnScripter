
using Ninject;
using System.Collections.Generic;
using UnScripterPlugin.Plugin;
namespace UnScripter.Plugin
{
    /// <summary>
    /// Flywheel between PluginLoader and 
    /// </summary>
    class PluginContainer
    {
        private readonly PluginLoader pluginLoader;

        [Inject]
        public PluginContainer(PluginLoader pluginLoader)
        {
            this.pluginLoader = pluginLoader;
        }

        private readonly List<UsPlugin> plugins = new List<UsPlugin>();
        public List<UsPlugin> Plugins
        {
            get
            {
                if (plugins.Count == 0)
                {
                    plugins.AddRange(pluginLoader.ListPlugins());
                }

                return plugins;
            }
        }
    }
}
