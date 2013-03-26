using Ninject;

namespace UnScripterPlugin.Plugin
{
    public interface PluginContext
    {
        IKernel Kernel { get; }

    }
}
