using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UnrealScriptLib.Unreal;

namespace UnScripter
{
    /// <summary>
    /// ???
    /// </summary>
    class BackgroundWorkers
    {
        private readonly MainForm mainForm;
        private readonly ProjectManager projectManager;

        [Inject]
        public BackgroundWorkers(MainForm mainForm, ProjectManager projectManager)
        {
            this.mainForm = mainForm;
            this.projectManager = projectManager;
        }

        public void BuildWorker_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        public void BuildWorker_ReportProgress(Object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        public void BuildWorker_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
        {
#if false
            compiler.EndMake();

            mainForm.ProgressBarStatusBar.Visible = false;

            mainForm.ConsoleOutput.ConsoleText.Text = compiler.BuildOutput;
            mainForm.ConsoleOutput.ConsoleText.SelectionStart = mainForm.ConsoleOutput.ConsoleText.Text.Length - 1;

            mainForm.ConsoleOutput.ConsoleText.SelectionLength = 0;

            mainForm.ConsoleOutput.ConsoleText.ScrollToCaret();

            // Check for a successful build and return according...
            if (compiler.Errors.Count > 0)
            {
                mainForm.BuildMessageStatusLabel.Text = "Failed to Build";
            }
            else
            {
                mainForm.BuildMessageStatusLabel.Text = "Build Successful";
            }

            if (compiler.Errors.Count == 0 & Globals.ExecuteStandaloneOnBuildFinished)
            {
                run.RunStandalone(projectManager.CurrentProject);
                Globals.ExecuteStandaloneOnBuildFinished = false;
            }
#endif
        }

        public void UnrealParserWorker_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (projectManager.CurrentProject != null)
            {
                UnScripterPlugin.Project.UsProject proj = projectManager.CurrentProject;
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

                foreach (var file in proj.FileList.ProjectFiles)
                {
                    var root = new TreeNode();
                    var unrealRoot = file.UnrealClass.RootNode;
                    ConvertUnrealNodesToWinforms(unrealRoot, root);
                    mainForm.ClassView.Nodes.Add(root);
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

        private static void ConvertUnrealNodesToWinforms(Node root, TreeNode node)
        {
            foreach (var children in root.Nodes)
            {
                var n = new TreeNode(children.Name);
                node.Nodes.Add(n);
                if (children.Nodes.Count > 0)
                {
                    ConvertUnrealNodesToWinforms(children, n);
                }
            }
        }
    }
}
