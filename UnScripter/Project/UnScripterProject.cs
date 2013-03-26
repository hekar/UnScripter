using System.IO;
using UnScripterPlugin.Project;

namespace UnScripter.Project
{
    class UnScripterProject : UsProject
    {
        private readonly UsProjectData data;

        /// <summary>
        /// Winforms TreeView for the Project Explorer
        /// </summary>
        public ProjectFileTree FileTreeView { get; set; }

        /// <summary>
        /// Is the project saved?
        /// </summary>
        public bool Saved { get; set; }

        /// <summary>
        /// Simple list of each file in the project
        /// </summary>
        public ProjectFileList FileList { get; private set; }

        /// <summary>
        /// Name of the Project
        /// </summary>
        public string ProjectName { get; private set; }

        public string ProjectFileName
        {
            get { return Path.Combine(ProjectFolder, ProjectName) + ".axproj"; }
        }

        /// <summary>
        /// Root folder of the Project (UDK Directory)
        /// </summary>
        public string ProjectFolder { get; private set; }

        /// <summary>
        /// Folder containing actual Source Code (UnrealScript)
        /// </summary>
        public string DevelopmentFolder
        {
            get { return Path.Combine(ProjectFolder, "Development", "Src"); }
        }

        public string NodeFullPathToFullName(string fullpath)
        {
            // hmmm...
            return DevelopmentFolder + fullpath.Replace(ProjectName + Path.DirectorySeparatorChar, "");
        }

        public UnScripterProject(string name, string udkdir, string filebrowser_regex = Globals.ProjectFileRegex)
        {
            ProjectName = name;
            ProjectFolder = udkdir;

            data = new UsProjectData();

            // By default, we assume we're not saved
            Saved = false;

            // Add the path separator if needed
            if (!ProjectFolder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                ProjectFolder += Path.DirectorySeparatorChar;
            }

            // Create our list of project files
            FileList = new ProjectFileList(this, DevelopmentFolder, filebrowser_regex);
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
            var path = ProjectFolder + ProjectName + ".axproj";

            data.Properties.Add("First", ProjectName);
            data.Properties.Add("Name", ProjectName);
            data.Properties.Add("RootFolder", ProjectFolder);

            data.Save(path);
        }

    }
}
