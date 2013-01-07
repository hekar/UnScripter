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
using Ninject;

namespace UnScripter
{
	partial class NewProjectForm
	{
        private ProjectManager projectManager;

        [Inject]
        public NewProjectForm(ProjectManager projectManager)
        {
            this.projectManager = projectManager;
            InitializeComponent();
        }

		private void NewProjectWizard_Load(System.Object sender, System.EventArgs e)
		{
			TextBoxUDKDir.Text = Globals.kDefaultUDKFolder;
		}

		private void BrowseButton_Click(System.Object sender, System.EventArgs e)
		{
			// Choose the directory
			var folderdialog = new FolderBrowserDialog();
			if (folderdialog.ShowDialog() == DialogResult.OK) {
				TextBoxUDKDir.Text = folderdialog.SelectedPath;
			}
		}

		private void FinishButton_Click(System.Object sender, System.EventArgs e)
		{
			string projectname = TextBoxProjectName.Text;
			string udkfolder = TextBoxUDKDir.Text;
			Project.Project project = projectManager.CreateProject(projectname, udkfolder);
			Globals.CurrentProject = project;

			this.Hide();
		}

		private void BackButton_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void CloseButton_Click(System.Object sender, System.EventArgs e)
		{
			// Reset fields
			this.Hide();
		}
	}
}
