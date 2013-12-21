using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnScripter.Plugin;
using UnScripter.Plugin.Implementations;

namespace UnScripter.Ninject
{
    class PluginModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<PluginLoader>().ToConstant(new PluginLoader("plugins"));
            this.Bind<PluginContainer>().ToSelf().InSingletonScope();
        }
    }
}
