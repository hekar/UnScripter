using Ninject;
using System.Diagnostics;
using System.IO;

namespace UnScripter
{
    class ExternalMenu
    {
        private readonly ProjectManager projectManager;

        [Inject]
        public ExternalMenu(ProjectManager projectManager)
        {
            this.projectManager = projectManager;
        }

        public void UnrealEditorToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Path.Combine(
                projectManager.CurrentProject.ProjectFolder, "Binaries", "UDKLift.exe");
            startinfo.Arguments = "editor";
            startinfo.WorkingDirectory = Path.Combine(
                projectManager.CurrentProject.ProjectFolder, "Binaries");
            proc.StartInfo = startinfo;
            proc.Start();
        }

        public void UnrealLocalizerToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Path.Combine(projectManager.CurrentProject.ProjectFolder, 
                "Binaries", "UnrealLoc.exe");
            startinfo.WorkingDirectory = Path.Combine(
                projectManager.CurrentProject.ProjectFolder, "Binaries");
            proc.StartInfo = startinfo;
            proc.Start();
        }

        public void UnrealFrontendToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Path.Combine(projectManager.CurrentProject.ProjectFolder, 
                "Binaries", "UnrealFrontend.exe");
            startinfo.WorkingDirectory = Path.Combine(
                projectManager.CurrentProject.ProjectFolder, "Binaries");
            proc.StartInfo = startinfo;
            proc.Start();
        }

        public void OpenConfigFolderToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.DefaultExplorer;
            startinfo.Arguments = Path.Combine(projectManager.CurrentProject.ProjectFolder, 
                "UDKGame", "Config");
            proc.StartInfo = startinfo;
            proc.Start();
        }

        public void OpenExplorerToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.DefaultExplorer;
            startinfo.Arguments = projectManager.CurrentProject.DevelopmentFolder;
            proc.StartInfo = startinfo;
            proc.Start();
        }

        public void OpenTerminalToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            string curdir = System.IO.Directory.GetCurrentDirectory();
            startinfo.FileName = curdir + Globals.DefaultTerminal;

            // Add in directories to the PATH
            startinfo.Arguments = Path.Combine(curdir, "scripts");
            if (projectManager.CurrentProject != null)
            {
                startinfo.Arguments += Path.Combine(curdir,
                    projectManager.CurrentProject.ProjectFolder, "Binaries");
            }

            startinfo.WorkingDirectory = projectManager.CurrentProject.ProjectFolder;

            proc.StartInfo = startinfo;
            proc.Start();
        }

    }
}
