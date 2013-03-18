using Ninject;
using System;
using System.ComponentModel;

namespace UnScripter
{
    class BackgroundWorkers
    {
        private MainForm mainForm;
        private ProjectManager projectManager;

        [Inject]
        public BackgroundWorkers(MainForm mainForm, ProjectManager projectManager)
        {
            this.mainForm = mainForm;
            this.projectManager = projectManager;
        }

        public void BuildWorker_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Globals.Compiler.StartMake();
        }

        public void BuildWorker_ReportProgress(Object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            mainForm.ConsoleOutput.ConsoleText.Text = Globals.Compiler.BuildOutput;
        }

        public void BuildWorker_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            Globals.Compiler.EndMake();

            mainForm.ProgressBarStatusBar.Visible = false;

            mainForm.ConsoleOutput.ConsoleText.Text = Globals.Compiler.BuildOutput;
            mainForm.ConsoleOutput.ConsoleText.SelectionStart = mainForm.ConsoleOutput.ConsoleText.Text.Length - 1;

            mainForm.ConsoleOutput.ConsoleText.SelectionLength = 0;

            mainForm.ConsoleOutput.ConsoleText.ScrollToCaret();

            // Check for a successful build and return according...
            if (Globals.Compiler.Errors.Count > 0)
            {
                mainForm.BuildMessageStatusLabel.Text = "Failed to Build";
            }
            else
            {
                mainForm.BuildMessageStatusLabel.Text = "Build Successful";
            }

            if (!Globals.Compiler.HasErrors & Globals.ExecuteStandaloneOnBuildFinished)
            {
                Globals.Run.RunStandalone();
                Globals.ExecuteStandaloneOnBuildFinished = false;
            }
        }

        public void UnrealParserWorker_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (projectManager.CurrentProject != null)
            {
                Project.Project proj = projectManager.CurrentProject;
                foreach (var projfile in proj.FileList.ProjectFiles)
                {
                    projfile.ParseUnrealScript();
                }
            }
        }

        public void UnrealParserWorker_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
            mainForm.ClassView.Nodes.Clear();
            if (projectManager.CurrentProject != null)
            {
                var proj = projectManager.CurrentProject;

                foreach (var projfile in proj.FileList.ProjectFiles)
                {
                    mainForm.ClassView.Nodes.Add(projfile.UnrealClass.RootNode);
                }

                mainForm.ShowClassBrowserToolStripMenuItem.Enabled = true;
            }
            else
            {
                mainForm.ShowClassBrowserToolStripMenuItem.Enabled = false;
            }

            if ((mainForm.ParserStatusProgressBar != null))
            {
                mainForm.ParserStatusProgressBar.Visible = false;
                mainForm.ParserStatusLabel.Text = "Finished Parsing UnrealScript";
            }

        }
    }
}
