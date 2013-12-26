using System;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter
{
    /// <summary>
    /// Context menu to open up on right click of a file or folder in the project explorer
    /// </summary>
    [System.ComponentModel.DesignerCategory("")]
    class ProjectFileContextMenu : ContextMenuStrip
    {
        public ProjectFileContextMenu()
        {
            Items.Add("Open Path", null, OpenPath_Clicked);
            Items.Add("Open Editor", null, OpenEditor_Clicked);
            Items.Add("-");
            Items.Add("Rename File", null, RenameFile_Clicked).Enabled = false;
            Items.Add("-");
            Items.Add("Delete File", null, RemoveFile_Clicked).Enabled = false;
            Items.Add("-");
            Items.Add("Properties", null, OpenProperties_Clicked);
        }

        // Project file of the clicked item (set by MainForm)
        public ProjectFile ClickedProjectFile { get; set; }

        public void OpenPath_Clicked(object sender, EventArgs e)
        {
            ClickedProjectFile.OpenPath();
        }

        public void OpenEditor_Clicked(object sender, EventArgs e)
        {
            ClickedProjectFile.OpenInSystemEditor();
        }

        public void RenameFile_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void RemoveFile_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OpenProperties_Clicked(object sender, EventArgs e)
        {
            var form = new ProjectFilePropertiesForm();

            form.ClassName = ClickedProjectFile.UnrealClass.Name;
            form.Text = ""; //TODO: Fix ProjectFilePropertiesForm.ClassName;
            form.ContainingFolder = ClickedProjectFile.Directory;
            form.FullPath = ClickedProjectFile.FullName;
            form.ProjectFile = ClickedProjectFile;
            form.Show();
        }

    }
}
