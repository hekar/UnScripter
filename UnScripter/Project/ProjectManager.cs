using Ninject;
using UnScripter.Project;

namespace UnScripter
{
    // Singleton for dealing with Projects
    class ProjectManager
    {
        private Project.Project _currentproject;
        public Project.Project CurrentProject
        {
            get { return _currentproject; }
            set
            {
                _currentproject = value;
                ChangeProject(_currentproject);
            }
        }

        [Inject]
        public ProjectManager()
        {
        }

        public bool ProjectOpen
        {
            get { return (CurrentProject != null); }
        }

        public void ChangeProject(Project.Project newproject)
        {
            // Clear all the old files from the fileview
            //mainForm.FileView.Nodes.Clear();

            var newProjectName = newproject.ProjectName;
            var newProjectFileName = newproject.ProjectFileName;
            var newDevelopmentFolder = newproject.DevelopmentFolder;
            var newFileList = newproject.FileList;
            var newFileTreeView = newproject.FileTreeView;

            // Are we using a tree format or a straight list
            if (Globals.kUseFileTree)
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

            Globals.Settings.SetTrait("LastProjectPath", newProjectFileName);
            //mainForm.FileStatusLabel.Text = "Opened Project " + newProjectName;

            //mainForm.StartParser();

            //newFileTreeView.ExpandDefaultFolders();
        }

        public Project.Project CreateProject(string name, string path)
        {
            return new Project.Project(name, path, Globals.kProjectFileRegex);
        }

        public Project.Project OpenProject(string path)
        {
            return OpenProject(path);
        }
    }
}
