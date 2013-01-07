using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }
    }
}
