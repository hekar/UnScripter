using Ninject;

namespace UnScripter
{
	class BuildMenu
	{
        private readonly MainForm mainForm;
        private readonly ProjectManager projectManager;

        [Inject]
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
			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void BuildAndRunToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Globals.ExecuteStandaloneOnBuildFinished = true;
			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void BuildFullToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			if (mainForm.BuildWorker.IsBusy) {
				mainForm.BuildWorker.CancelAsync();
			}

			mainForm.BuildWorker.RunWorkerAsync();
		}

		public void RunToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
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
