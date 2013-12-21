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
        public ProjectManager(GlobalSettings globalSettings)
        {
            this.globalSettings = globalSettings;
        }

        public bool ProjectOpen
        {
            get { return (CurrentProject != null); }
        }

        public void ChangeProject(UsProject newproject)
        {
            var newProjectName = newproject.ProjectName;
            var newProjectFileName = newproject.ProjectFileName;
            var newDevelopmentFolder = newproject.DevelopmentFolder;
            var newFileList = newproject.FileList;

            newFileList.ScanDirectory(newproject.ProjectFolder);

            globalSettings.SetTrait("LastProjectPath", newProjectFileName);
            //mainForm.FileView.Nodes.Clear();
            //mainForm.FileStatusLabel.Text = "Opened Project " + newProjectName;
            //mainForm.StartParser();
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
    }
}
