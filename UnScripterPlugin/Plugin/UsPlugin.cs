
namespace UnScripterPlugin.Plugin
{
    public interface UsPlugin
    {
        string Name { get; }

        void Start(PluginContext pluginContext);
        void Stop(PluginContext pluginContext);
    }
}
