using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnScripter.Plugin;
using UnScripter.Plugin.Implementations;
using UnScripterPlugin.Build;

namespace UnScripter.Ninject
{
    class PluginModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<PluginLoader>().ToConstant(new PluginLoader("plugins"));
            this.Bind<PluginContainer>().ToSelf().InSingletonScope();

            this.Bind<Compile>().To<CompileProvider>();
            this.Bind<Run>().To<RunProvider>();
        }
    }
}
