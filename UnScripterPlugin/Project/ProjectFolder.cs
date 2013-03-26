using System.Diagnostics;
using System.IO;
using UnScripter;

namespace UnScripterPlugin.Project
{
    public class ProjectFolder
    {
        public DirectoryInfo DirectoryInfo { get; private set; }

        public string FullName
        {
            get { return DirectoryInfo.FullName; }
        }

        // Path to folder
        public ProjectFolder(string fullpath)
        {
            DirectoryInfo = new DirectoryInfo(fullpath);
        }

        public ProjectFolder(DirectoryInfo dirinfo)
        {
            DirectoryInfo = dirinfo;
        }

        public void OpenPath()
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.DefaultExplorer;
            startinfo.Arguments = FullName;
            proc.StartInfo = startinfo;
            proc.Start();
        }
    }
}
