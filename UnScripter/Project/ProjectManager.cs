using System.Windows.Forms;
using Ninject;
using UnScripter.Project;
using UnScripterPlugin.Project;

namespace UnScripter
{
    // Singleton for dealing with Projects
    class ProjectManager
    {
        private GlobalSettings globalSettings;

        private UsProject currentproject;
        public UsProject CurrentProject
        {
            get { return currentproject; }
            set
            {
                currentproject = value;
                ChangeProject(currentproject);
            }
        }

        [Inject]
        public ProjectManager(MainForm mainForm, GlobalSettings globalSettings)
        {
            this.mainForm = mainForm;
            this.globalSettings = globalSettings;
        }

        public bool ProjectOpen
        {
            get { return (CurrentProject != null); }
        }

        public void ChangeProject(UsProject project)
        {
            project.FileList.ScanDirectory(project.ProjectFolder);
            globalSettings.SetTrait("LastProjectPath", project.ProjectName);
            mainForm.FileView.Nodes.Clear();
            foreach (var item in project.FileList.ProjectFiles)
            {
                mainForm.FileView.Nodes.Add(item.FullName, item.FileName);
            }

            mainForm.FileStatusLabel.Text =
                string.Format("Opened Project {0}", project.ProjectName);
            mainForm.StartParser();
            //newFileTreeView.ExpandDefaultFolders();
        }

        public UsProject CreateProject(string name, string path)
        {
            return new UnScripterProject(name, path, Globals.ProjectFileRegex);
        }

        public UsProject OpenProject(string path)
        {
            var data = new UsProjectData();
            data.Load(path);

            var name = data.Properties["Name"];
            var root = data.Properties["RootFolder"];

            return new UnScripterProject(name, root, Globals.ProjectFileRegex);
        }

        public MainForm mainForm { get; set; }
    }
}
