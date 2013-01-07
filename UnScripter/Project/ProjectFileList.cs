using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace UnScripter.Project
{
    // Creates a simple list of projectfiles
    class ProjectFileList
    {
        private Project _project;
        private List<ProjectFile> _projectfiles = new List<ProjectFile>();

        private List<ProjectFolder> _projectfolders = new List<ProjectFolder>();
        public List<string> Files
        {
            get
            {
                List<string> filenames = new List<string>();
                foreach (var projectfile in _projectfiles)
                {
                    filenames.Add(projectfile.FullName);
                }

                return filenames;
            }
        }

        public List<string> RelativeFiles
        {
            get
            {
                List<string> filenames = new List<string>();
                foreach (ProjectFile projectfile in _projectfiles)
                {
                    filenames.Add(projectfile.FullName.Replace(_project.DevelopmentFolder, ""));
                }

                return filenames;
            }
        }

        public List<ProjectFile> ProjectFiles
        {
            get { return _projectfiles; }
        }

        public List<ProjectFolder> ProjectFolders
        {
            get { return _projectfolders; }
        }

        public bool IsProjectFile(string fullname)
        {
            foreach (var projectfile in _projectfiles)
            {
                if (projectfile.FullName == fullname)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsProjectFolder(string fullname)
        {
            foreach (ProjectFolder profolder in _projectfolders)
            {
                if (profolder.FullName == fullname)
                {
                    return true;
                }
            }

            return false;
        }

        public ProjectFile GetProjectFile(string fullname)
        {
            foreach (var projectfile in _projectfiles)
            {
                if (projectfile.FullName == fullname)
                {
                    return projectfile;
                }
            }

            throw new KeyNotFoundException("Could not find Project File");
        }

        public ProjectFile GetProjectFileByClassName(string name)
        {
            foreach (ProjectFile projectfile in _projectfiles)
            {
                if (projectfile.UnrealClass.Name == name)
                {
                    return projectfile;
                }
            }

            return null;
        }

        public ProjectFolder GetProjectFolder(string fullname)
        {
            foreach (ProjectFolder projectfolder in _projectfolders)
            {
                if (projectfolder.FullName == fullname)
                {
                    return projectfolder;
                }
            }

            throw new KeyNotFoundException("Could not find Project File");
        }

        public ProjectFileList(Project project)
        {
            _project = project;
        }

        public ProjectFileList(Project project, string rootdir, string regular_match = "", bool recursive = true)
        {
            _project = project;
            ScanDirectory(rootdir, regular_match, recursive);
        }

        public void RefreshDirectories()
        {
            _projectfiles.Clear();
            _projectfolders.Clear();

            ScanDirectory(_project.DevelopmentFolder, Globals.kProjectFileRegex);

            _project.FileTreeView.FileTree.Nodes.Clear();
            _project.FileTreeView.ScanDirectory(_project.DevelopmentFolder, Globals.kProjectFileRegex);
            _project.FileTreeView.ExpandDefaultFolders();
        }

        public void ScanDirectory(string folder, string regular_match = "", bool recursive = true)
        {
            Regex re = new Regex(regular_match);

            DirectoryInfo dir = new DirectoryInfo(folder);
            _projectfolders.Add(new ProjectFolder(dir));

            foreach (var fileinfo in dir.GetFiles())
            {
                // Check if filename matches regex
                if (re.IsMatch(fileinfo.Name))
                {
                    // Add file to list
                    ProjectFile actorFile = new ProjectFile(fileinfo.FullName);
                    _projectfiles.Add(actorFile);
                }
            }

            if (recursive)
            {
                foreach (var subdir in dir.GetDirectories())
                {
                    ScanDirectory(subdir.FullName, regular_match, recursive);
                }
            }
        }
    }
}
