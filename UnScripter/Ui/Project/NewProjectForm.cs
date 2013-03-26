using Ninject;
using System.Windows.Forms;
using UnScripter.Plugin;

namespace UnScripter
{
    partial class NewProjectForm
    {
        private readonly ProjectManager projectManager;
        private readonly PluginContainer pluginContainer;

        [Inject]
        public NewProjectForm(ProjectManager projectManager, PluginContainer pluginContainer)
        {
            this.projectManager = projectManager;
            this.pluginContainer = pluginContainer;
            InitializeComponent();
        }

        private void NewProjectWizard_Load(System.Object sender, System.EventArgs e)
        {
            var plugins = pluginContainer.Plugins;
            if (plugins.Count == 0)
            {
                gameComboBox.Items.Add("<No Game Plugins>");
                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (var plugin in plugins)
                {
                    gameComboBox.Items.Add(plugin.Name);
                }
            }

            TextBoxUDKDir.Text = Globals.DefaultUDKFolder;
        }

        private void BrowseButton_Click(System.Object sender, System.EventArgs e)
        {
            // Choose the directory
            var folderdialog = new FolderBrowserDialog();
            if (folderdialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxUDKDir.Text = folderdialog.SelectedPath;
            }
        }

        private void FinishButton_Click(System.Object sender, System.EventArgs e)
        {
            var projectname = TextBoxProjectName.Text;
            var udkfolder = TextBoxUDKDir.Text;
            var project = projectManager.CreateProject(projectname, udkfolder);
            projectManager.CurrentProject = project;

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
