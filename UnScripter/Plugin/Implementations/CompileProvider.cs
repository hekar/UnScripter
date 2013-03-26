using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnScripterPlugin.Build;

namespace UnScripter.Plugin.Implementations
{
    class CompileProvider : Compile
    {
        public bool FullRebuild
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string BuildOutput
        {
            get { throw new NotImplementedException(); }
        }

        public List<CompileError> Errors
        {
            get { throw new NotImplementedException(); }
        }

        public List<CompileError> Warnings
        {
            get { throw new NotImplementedException(); }
        }

        public void Make(UnScripterPlugin.Project.UsProject project)
        {
            throw new NotImplementedException();
        }

        public void InitMake()
        {
            throw new NotImplementedException();
        }

        public void StartMake(UnScripterPlugin.Project.UsProject project)
        {
            throw new NotImplementedException();
        }

        public void EndMake()
        {
            throw new NotImplementedException();
        }
    }
}
