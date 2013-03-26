using UnScripterPlugin.Project;

namespace UnScripter.Project
{
    class UnScripterProject : UnScripterPlugin.Project.UsProject
    {
        // Winforms TreeView for the Project Explorer
        public ProjectFileTree FileTreeView { get; set; }

        // Is the project saved?
        public bool Saved { get; set; }

        // Simple list of each file in the project
        public ProjectFileList FileList { get; private set; }

        // Name of the Project
        public string ProjectName { get; private set; }

        public string ProjectFileName
        {
            get { return ProjectFolder + ProjectName + ".axproj"; }
        }

        // Root folder of the Project (UDK Directory)
        public string ProjectFolder { get; private set; }

        // Folder containing actual Source Code (UnrealScript)
        public string DevelopmentFolder
        {
            get { return ProjectFolder + "Development\\Src\\"; }
        }

        public string NodeFullPathToFullName(string fullpath)
        {
            // hmmm...
            return DevelopmentFolder + fullpath.Replace(ProjectName + "\\", "");
        }


        public UnScripterProject(string name, string udkdir, string filebrowser_regex = Globals.ProjectFileRegex)
        {
            ProjectName = name;
            ProjectFolder = udkdir;

            // By default, we assume we're not saved
            Saved = false;

            // Add the path separator if needed
            if (!ProjectFolder.EndsWith("\\"))
            {
                ProjectFolder += "\\";
            }

            // Create our list of project files
            FileList = new ProjectFileList(this, DevelopmentFolder, filebrowser_regex);
        }

        public static UnScripterProject OpenProject(string path)
        {
            // Return a Project object from a file path 
            Settings projectsettings = new Settings(path, "Project");
            projectsettings.ReadFromXml();

            string projectname = projectsettings.GetTrait("Name", "Corrupt Project File");
            string folder = projectsettings.GetTrait("RootFolder", "Bad Root Directory");

            UnScripterProject project = new UnScripterProject(projectname, folder, Globals.ProjectFileRegex);

            // TODO: Load Database for Actor Parser

            return project;
        }

        public void AddFile(string folder, string filename)
        {
            for (int i = 0; i <= FileTreeView.FileTree.Nodes.Count - 1; i++)
            {
                var node = FileTreeView.FileTree.Nodes[i];
                if (NodeFullPathToFullName(node.FullPath) == folder)
                {
                    node.Nodes.Add(filename);
                }
            }
        }

        public void SaveProject()
        {
            // Save the Project to a XML file
            Settings projectsettings = new Settings(ProjectFolder + ProjectName + ".axproj", "Project");

            projectsettings.SetTrait("First", ProjectName);
            projectsettings.SetTrait("Name", ProjectName);
            projectsettings.SetTrait("RootFolder", ProjectFolder);
            projectsettings.WriteToXml();

            // TODO: Save settings per file...

            // TODO: Save Database for Actor Parser
        }

    }
}
