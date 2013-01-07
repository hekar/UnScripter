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
	class BuildMenu
	{
        private MainForm mainForm;
        private ProjectManager projectManager;
        public BuildMenu(MainForm mainForm, ProjectManager projectManager)
        {
            this.mainForm = mainForm;
            this.projectManager = projectManager;
        }

		public void BuildMenu_DropDown(System.Object sender, System.EventArgs e)
		{
			mainForm.BuildAllToolStripMenuItem.Enabled = projectManager.ProjectOpen;
			mainForm.BuildAndRunToolStripMenuItem.Enabled = projectManager.ProjectOpen;
			mainForm.RunToolStripMenuItem.Enabled = projectManager.ProjectOpen;
		}

		public void BuildAllToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Globals.Compiler.FullRebuild = false;
			Globals.Compiler.InitMake();
			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void BuildAndRunToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Globals.ExecuteStandaloneOnBuildFinished = true;
			Globals.Compiler.FullRebuild = false;

			Globals.Compiler.InitMake();
			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void BuildFullToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Globals.Compiler.FullRebuild = true;
			Globals.Compiler.InitMake();

			if (mainForm.BuildWorker.IsBusy) {
				mainForm.BuildWorker.CancelAsync();
			}

			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void RunToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Globals.Run.RunStandalone();
		}

		public void ErrorPrevStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			mainForm.ErrorView.PrevError();
		}

		public void ErrorNextStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			mainForm.ErrorView.NextError();
		}

	}
}
