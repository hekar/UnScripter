using System.Collections.Generic;
using UnScripterPlugin.Build;
using UnScripterPlugin.Project;

namespace UnScripter.Plugin.Implementations
{
    class CompileProvider : Compile
    {
        private readonly ProjectManager projectManager;
        private StubCompile compile;

        public CompileProvider(ProjectManager projectManager)
        {
            this.projectManager = projectManager;

            this.compile = new StubCompile();
        }

        public bool FullRebuild
        {
            get { return compile.FullRebuild; }
            set { compile.FullRebuild = value; }
        }

        public string BuildOutput
        {
            get { return compile.BuildOutput; }
        }

        public List<CompileError> Errors
        {
            get { return compile.Errors; }
        }

        public List<CompileError> Warnings
        {
            get { return compile.Warnings; }
        }

        public void Make(UsProject project)
        {
            compile.Make(project);
        }

        public void InitMake()
        {
            compile.InitMake();
        }

        public void StartMake(UsProject project)
        {
            compile.StartMake(project);
        }

        public void EndMake()
        {
            compile.EndMake();
        }

        private class StubCompile : Compile
        {
            public bool FullRebuild
            {
                get { return false; }
                set { }
            }

            public string BuildOutput
            {
                get { return ""; }
            }

            public List<CompileError> Errors
            {
                get { return new List<CompileError>(); }
            }

            public List<CompileError> Warnings
            {
                get { return new List<CompileError>(); }
            }

            public void Make(UsProject project)
            {
            }

            public void InitMake()
            {
            }

            public void StartMake(UsProject project)
            {
            }

            public void EndMake()
            {
            }
        }
    }
}
