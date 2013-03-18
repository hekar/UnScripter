using Ninject;
using System;
using System.Windows.Forms;
using UnScripter.Project;

namespace UnScripter
{
	class ProjectFolderContextMenu : ContextMenuStrip
	{
        public ProjectFolder ClickedProjectFolder { get; set; }

        private ProjectManager projectManager;
        private ProjectNewFileDialog projectNewFileDialog;

        [Inject]
        public ProjectFolderContextMenu(ProjectManager projectManager, ProjectNewFileDialog projectNewFileDialog)
		{
            this.projectManager = projectManager;
            this.projectNewFileDialog = projectNewFileDialog;

			Items.Add("Add New File", null, AddNewFile);
			Items.Add("-");
			Items.Add("Open Path", null, OpenPath);
			Items.Add("Refresh Directories", null, RefreshDirectories);
		}

		private void AddNewFile(object sender, EventArgs e)
		{
			projectNewFileDialog.ShowDialog();
		}

		private void OpenPath(object sender, EventArgs e)
		{
			ClickedProjectFolder.OpenPath();
		}

		private void RefreshDirectories(object sender, EventArgs e)
		{
			projectManager.CurrentProject.FileList.RefreshDirectories();
		}
	}
}
