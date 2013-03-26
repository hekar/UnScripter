using Ninject;
using System.Windows.Forms;

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
