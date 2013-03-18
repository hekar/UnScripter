using System;

namespace UnScripterPlugin.Plugin.Menu
{
    public interface MenuItem
    {
        string Name { get; }
        string Label { get; }

        event EventHandler Selected;
    }
}
