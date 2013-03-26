using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnScripterPlugin.Plugin;
using UnScripterPlugin.Project;

namespace UnScripter.Plugin
{
    /// <summary>
    /// Central plugin loader. Loads external assemblies from specified plugin directory
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

        /// <summary>
        /// List all the plugins that a specific project utilizes
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public List<UsPlugin> ListPlugins(UsProject project)
        {
            // TODO: Get referenced plugins from project XML
            throw new NotImplementedException();
        }
    }
}
