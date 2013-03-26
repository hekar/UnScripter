using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnScripterPlugin
{
    public interface ErrorReceiver
    {
        string BuildMessage { get; set; }
        bool ProgressVisible { get; set; }
        int ProgressValue { get; set; }


        void ClearErrors();

        void AddError(string[] columns);
        void AddWarning(string[] columns);
    }
}
