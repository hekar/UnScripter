using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnScripter.Plugin.Implementations;
using UnScripterPlugin.Build;

namespace UnScripter.Ninject
{
    class MainModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<MainForm>().ToSelf().InSingletonScope();
            this.Bind<MainFormDocks>().ToSelf().InSingletonScope();
            this.Bind<ProjectManager>().ToSelf().InSingletonScope();
            this.Bind<EditorTabManager>().ToSelf().InSingletonScope();

            this.Bind<GlobalSettings>().ToConstant(new GlobalSettings("xml/global_settings.xml", "GlobalSettings"));
            this.Bind<EditorSettings>().ToConstant(new EditorSettings("xml/editor_settings.xml", "EditorSettings"));
            this.Bind<UiSettings>().ToConstant(new UiSettings("xml/ui_settings.xml", "UISettings"));

            this.Bind<Compile>().To<CompileProvider>();
            this.Bind<Run>().To<RunProvider>();
        }
    }
}
