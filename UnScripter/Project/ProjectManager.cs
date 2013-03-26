using Ninject;
using UnScripterPlugin.Project;

namespace UnScripter
{
    // Singleton for dealing with Projects
    class ProjectManager
    {
        private GlobalSettings globalSettings;

        private UnScripterPlugin.Project.UsProject currentproject;
        public UnScripterPlugin.Project.UsProject CurrentProject
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

        public void ChangeProject(UnScripterPlugin.Project.UsProject newproject)
        {
            // Clear all the old files from the fileview
            //mainForm.FileView.Nodes.Clear();

            var newProjectName = newproject.ProjectName;
            var newProjectFileName = newproject.ProjectFileName;
            var newDevelopmentFolder = newproject.DevelopmentFolder;
            var newFileList = newproject.FileList;
            //var newFileTreeView = newproject.FileTreeView;

            // Are we using a tree format or a straight list
            if (Globals.UseFileTree)
            {
                //newFileTreeView = new ProjectFileTree(newProjectName, mainForm.FileView, newDevelopmentFolder, Globals.kProjectFileRegex);
            }
            else
            {
                //var paren = mainForm.FileView.Nodes.Add(newProjectName);
                //foreach (var actfilename in newFileList.RelativeFiles) {
                //    paren.Nodes.Add(actfilename);
                //}
            }

            globalSettings.SetTrait("LastProjectPath", newProjectFileName);
            //mainForm.FileStatusLabel.Text = "Opened Project " + newProjectName;

            //mainForm.StartParser();

            //newFileTreeView.ExpandDefaultFolders();
        }

        public UnScripterPlugin.Project.UsProject CreateProject(string name, string path)
        {
            return new Project.UnScripterProject(name, path, Globals.ProjectFileRegex);
        }

        public UnScripterPlugin.Project.UsProject OpenProject(string path)
        {
            return OpenProject(path);
        }
    }
}
