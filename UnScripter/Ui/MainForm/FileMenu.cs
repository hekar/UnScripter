using System;
using System.IO;
using System.Windows.Forms;

namespace UnScripter
{
    class FileMenu
    {
        private readonly MainForm mainForm;
        private readonly ProjectManager projectManager;
        private readonly NewProjectForm newProjectForm;
        private readonly EditorTabManager editorTabManager;
        private readonly ProjectNewFileDialog projectNewFileDialog;

        public FileMenu(MainForm mainForm, ProjectManager projectManager, NewProjectForm newProjectForm,
            EditorTabManager editorTabManager, ProjectNewFileDialog projectNewFileDialog)
        {
            this.mainForm = mainForm;
            this.projectManager = projectManager;
            this.newProjectForm = newProjectForm;
            this.editorTabManager = editorTabManager;
            this.projectNewFileDialog = projectNewFileDialog;
        }

        public void FileMenu_DropDown(object sender, EventArgs e)
        {
            var proj = projectManager.CurrentProject;

            // Enable Project saving only if a project is open
            if (proj == null)
            {
                mainForm.ProjectSaveMenuItem.Enabled = false;
            }
            else
            {
                mainForm.ProjectSaveMenuItem.Enabled = true;
            }

            // Temporarily disable new and open until projectless editing is supporting
            mainForm.NewToolStripMenuItem.Enabled = (proj != null);
            mainForm.OpenToolStripMenuItem.Enabled = (proj != null);

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

            if (result == DialogResult.OK)
            {
                if (File.Exists(opendialog.FileName))
                {
                    projectManager.CurrentProject = projectManager.OpenProject(opendialog.FileName);
                }
            }
        }

        public void ProjectSaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (projectManager.CurrentProject != null)
            {
                projectManager.CurrentProject.SaveProject();
            }
        }

        public void NewToolStripButton_Click(object sender, System.EventArgs e)
        {
            projectNewFileDialog.ShowDialog();
        }

        public void OpenToolStripButton_Click(object sender, System.EventArgs e)
        {
            // Can only open project files for now...
            if (projectManager.CurrentProject != null)
            {
                OpenFileDialog opendir = new OpenFileDialog();
                opendir.Title = "Open File";
                opendir.InitialDirectory = projectManager.CurrentProject.DevelopmentFolder;
                opendir.Filter = "UnrealScript (*.uc) |*.uc";
                opendir.CheckPathExists = true;

                // Open the file in a tab
                var result = opendir.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (projectManager.CurrentProject.FileList.IsProjectFile(opendir.FileName))
                    {
                        var projfile = projectManager.CurrentProject.FileList.GetProjectFile(opendir.FileName);
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
            if ((editorTabManager.CurrentTab != null))
            {
                editorTabManager.CurrentTab.ScintillaEditor.Printing.Print();
            }
        }

        public void PrintPreviewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((editorTabManager.CurrentTab != null))
            {
                editorTabManager.CurrentTab.ScintillaEditor.Printing.PrintPreview();
            }
        }

        public void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
