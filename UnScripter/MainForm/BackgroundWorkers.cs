using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace UnScripter
{
	class BackgroundWorkers
	{
        private MainForm mainForm;
        public BackgroundWorkers(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

		public void BuildWorker_DoWork(System.Object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Globals.Compiler.StartMake();
		}

		public void BuildWorker_ReportProgress(System.Object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			mainForm.ConsoleOutput.ConsoleText.Text = Globals.Compiler.BuildOutput;
		}

		public void BuildWorker_RunWorkerCompleted(System.Object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			Globals.Compiler.EndMake();

			mainForm.ProgressBarStatusBar.Visible = false;

			mainForm.ConsoleOutput.ConsoleText.Text = Globals.Compiler.BuildOutput;
			mainForm.ConsoleOutput.ConsoleText.SelectionStart = mainForm.ConsoleOutput.ConsoleText.Text.Length - 1;

			mainForm.ConsoleOutput.ConsoleText.SelectionLength = 0;

			mainForm.ConsoleOutput.ConsoleText.ScrollToCaret();

			// Check for a successful build and return according...
			if (Globals.Compiler.Errors.Count > 0) {
				mainForm.BuildMessageStatusLabel.Text = "Failed to Build";
			} else {
				mainForm.BuildMessageStatusLabel.Text = "Build Successful";
			}

			if (!Globals.Compiler.HasErrors & Globals.ExecuteStandaloneOnBuildFinished) {
				Globals.Run.RunStandalone();
				Globals.ExecuteStandaloneOnBuildFinished = false;
			}
		}

		public void UnrealParserWorker_DoWork(System.Object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			if ((Globals.CurrentProject != null)) {
				Project.Project proj = Globals.CurrentProject;
                foreach (var projfile in proj.FileList.ProjectFiles)
                {
					projfile.ParseUnrealScript();
				}
			}
		}

		public void UnrealParserWorker_RunWorkerCompleted(System.Object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			mainForm.ClassView.Nodes.Clear();
			if ((Globals.CurrentProject != null)) {
				Project.Project proj = Globals.CurrentProject;

				foreach (var projfile in proj.FileList.ProjectFiles) {
					mainForm.ClassView.Nodes.Add(projfile.UnrealClass.RootNode);
				}

				mainForm.ShowClassBrowserToolStripMenuItem.Enabled = true;
			} else {
				mainForm.ShowClassBrowserToolStripMenuItem.Enabled = false;
			}

			if ((mainForm.ParserStatusProgressBar != null)) {
				mainForm.ParserStatusProgressBar.Visible = false;
				mainForm.ParserStatusLabel.Text = "Finished Parsing UnrealScript";
			}

		}
	}
}
