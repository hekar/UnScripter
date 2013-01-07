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
using System.IO;

namespace UnScripter
{
	class FileMenu
	{
        private MainForm mainForm;
        private ProjectManager projectManager;
        private NewProjectForm newProjectForm;
        private EditorTabManager editorTabManager;

        public FileMenu(MainForm mainForm, ProjectManager projectManager, NewProjectForm newProjectForm,
            EditorTabManager editorTabManager)
        {
            this.mainForm = mainForm;
            this.projectManager = projectManager;
            this.newProjectForm = newProjectForm;
            this.editorTabManager = editorTabManager;
        }

		public void FileMenu_DropDown(object sender, EventArgs e)
		{
			// Enable Project saving only if a project is open
			if ((Globals.CurrentProject == null)) {
				mainForm.ProjectSaveMenuItem.Enabled = false;
			} else {
				mainForm.ProjectSaveMenuItem.Enabled = true;
			}

			// Temporarily disable new and open until projectless editing is supporting
			mainForm.NewToolStripMenuItem.Enabled = (Globals.CurrentProject != null);
			mainForm.OpenToolStripMenuItem.Enabled = (Globals.CurrentProject != null);

            var enable = editorTabManager.CurrentTab != null;
			mainForm.SaveToolStripMenuItem.Enabled = (enable);
			mainForm.SaveAsToolStripMenuItem.Enabled = (enable);
			mainForm.SaveAllToolStripMenuItem.Enabled = (enable);

			mainForm.PrintToolStripMenuItem.Enabled = (enable);
			mainForm.PrintPreviewToolStripMenuItem.Enabled = (enable);
		}

		public void ProjectNewToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			newProjectForm.Show();
		}

		public void ProjectOpenToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog opendialog = new OpenFileDialog();
			opendialog.Title = "Project Open";
			var result = opendialog.ShowDialog();

			if (result == DialogResult.OK) {
				if (File.Exists(opendialog.FileName)) {
					Globals.CurrentProject = projectManager.OpenProject(opendialog.FileName);
				}
			}
		}

		public void ProjectSaveToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((Globals.CurrentProject != null)) {
				Globals.CurrentProject.SaveProject();
			}
		}

		public void NewToolStripButton_Click(object sender, System.EventArgs e)
		{
			new ProjectNewFileDialog().ShowDialog();
		}

		public void OpenToolStripButton_Click(object sender, System.EventArgs e)
		{
			// Can only open project files for now...
			if ((Globals.CurrentProject != null)) {
				OpenFileDialog opendir = new OpenFileDialog();
				opendir.Title = "Open File";
				opendir.InitialDirectory = Globals.CurrentProject.DevelopmentFolder;
				opendir.Filter = "UnrealScript (*.uc) |*.uc";
				opendir.CheckPathExists = true;

				// Open the file in a tab
				var result = opendir.ShowDialog();
				if (result == DialogResult.OK) {
					if (Globals.CurrentProject.FileList.IsProjectFile(opendir.FileName)) {
						var projfile = Globals.CurrentProject.FileList.GetProjectFile(opendir.FileName);
						editorTabManager.AddTab(projfile.FileName, projfile);
					}
				}
			}
		}

		private void SaveToolStripButton_Click(object sender, System.EventArgs e)
		{
			editorTabManager.SaveCurrentTab();
		}

		public void SaveToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			editorTabManager.SaveCurrentTab();
		}

		public void SaveAllToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			editorTabManager.SaveAllTabs();
		}

		public void PrintToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((editorTabManager.CurrentTab != null)) {
				editorTabManager.CurrentTab.ScintillaEditor.Printing.Print();
			}
		}

		public void PrintPreviewToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((editorTabManager.CurrentTab != null)) {
				editorTabManager.CurrentTab.ScintillaEditor.Printing.PrintPreview();
			}
		}

		public void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
