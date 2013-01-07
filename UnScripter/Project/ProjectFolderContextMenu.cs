using System;
using System.Windows.Forms;
using UnScripter.Project;

namespace UnScripter
{
	public class ProjectFolderContextMenu : ContextMenuStrip
	{
        public ProjectFolder ClickedProjectFolder { get; set; }

		public ProjectFolderContextMenu()
		{
			Items.Add("Add New File", null, AddNewFile);
			Items.Add("-");
			Items.Add("Open Path", null, OpenPath);
			Items.Add("Refresh Directories", null, RefreshDirectories);
		}

		private void AddNewFile(object sender, EventArgs e)
		{
			new ProjectNewFileDialog().ShowDialog();
		}

		private void OpenPath(object sender, EventArgs e)
		{
			ClickedProjectFolder.OpenPath();
		}

		private void RefreshDirectories(object sender, EventArgs e)
		{
			Globals.CurrentProject.FileList.RefreshDirectories();
		}
	}
}
