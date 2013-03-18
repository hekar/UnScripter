using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnScripterPlugin.Plugin;

namespace UnScripter.Plugin
{
    /// <summary>
    /// Handle loading plugins
    /// </summary>
    class PluginLoader
    {
        private string directory;
        public PluginLoader(string directory)
        {
            this.directory = directory;
        }

        public List<UsPlugin> ListPlugins()
        {
            var files = Directory.GetFiles(directory)
                .Where(s => s.ToUpper().EndsWith("_PLUGIN.DLL"));

            var plugins = files.Select(file =>
            {
                Assembly assembly = Assembly.LoadFrom(file);
                Type type = assembly.GetType("Plugin");
                return Activator.CreateInstance(type) as UsPlugin;
            });

            return plugins.ToList();
        }

    }
}
