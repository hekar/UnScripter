using System;
using System.IO;
using System.Windows.Forms;

namespace UnScripter
{
    public partial class ProjectNewFileDialog
    {
        public ProjectNewFileDialog()
        {
            InitializeComponent();
        }

        private void ProjectNewFileDialog_Shown(Object sender, System.EventArgs e)
        {
            TextBoxClassname.Focus();

            // Clear the previous project folders
            ComboBoxProjectFolder.Items.Clear();

            // Tally up project folders
            var curproj = Globals.CurrentProject;
            foreach (var folder in curproj.FileList.ProjectFolders)
            {
                if (folder.FullName.ToLower().EndsWith("classes"))
                {
                    var projectFolder = folder.FullName
                        .Replace(curproj.DevelopmentFolder, "")
                        .Replace("\\Classes", "").Replace("\\classes", "");
                    ComboBoxProjectFolder.Items.Add(projectFolder);
                }
            }

            ComboBoxProjectFolder.SelectedIndex = 0;
        }

        private void OK_Button_Click(Object sender, System.EventArgs e)
        {
            var curproj = Globals.CurrentProject;

            // Create the new project file
            var writer = File.CreateText(curproj.DevelopmentFolder + ComboBoxProjectFolder.Text + 
                "\\Classes\\" + TextBoxFilename.Text);

            if (writer != null)
            {
                writer.WriteLine("// Header Comment");
                writer.WriteLine("class " + TextBoxClassname.Text + " extends object");
                writer.Close();

                // Add file to project view
                Globals.CurrentProject.FileList.RefreshDirectories();

                // Return the dialog result
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create file: " + TextBoxFilename.Text);
            }
        }

        private void Cancel_Button_Click(Object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void TextBoxClassname_TextChanged(Object sender, System.EventArgs e)
        {
            TextBoxFilename.Text = TextBoxClassname.Text + ".uc";
        }
    }
}
