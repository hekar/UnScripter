using Ninject;
using System;
using System.Windows.Forms;

namespace UnScripter
{
    class ToolsMenu
    {
        private ProjectManager projectManager;
        private EditorTabManager editorTabManager;
        private OptionsDialog optionsDialog;
        private ResourceDialog resourceDialog;

        [Inject]
        public ToolsMenu(ProjectManager projectManager, EditorTabManager editorTabManager, OptionsDialog optionsDialog, ResourceDialog resourceDialog)
        {
            this.projectManager = projectManager;
            this.editorTabManager = editorTabManager;
            this.optionsDialog = optionsDialog;
            this.resourceDialog = resourceDialog;
        }

        public void ShowResourcesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            var proj = projectManager.CurrentProject;
            if (proj != null)
            {
                resourceDialog.Files = proj.FileList.RelativeFiles;
                var result = resourceDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var projectfile = proj.FileList.GetProjectFile(resourceDialog.SelectedFullName);
                    editorTabManager.AddTab(projectfile.FileName, projectfile);
                }
            }
        }

        public void ShowOptions(Object sender, EventArgs e)
        {
            optionsDialog.Show();
        }
    }
}
