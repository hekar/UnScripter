using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace UnScripterPlugin.Project
{
    public class ProjectFileList
    {
        private UsProject project;
        private List<ProjectFile> projectfiles = new List<ProjectFile>();

        private List<ProjectFolder> projectfolders = new List<ProjectFolder>();
        public List<string> Files
        {
            get
            {
                List<string> filenames = new List<string>();
                foreach (var projectfile in projectfiles)
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
                foreach (ProjectFile projectfile in projectfiles)
                {
                    filenames.Add(projectfile.FullName.Replace(project.DevelopmentFolder, ""));
                }

                return filenames;
            }
        }

        public List<ProjectFile> ProjectFiles
        {
            get { return projectfiles; }
        }

        public List<ProjectFolder> ProjectFolders
        {
            get { return projectfolders; }
        }

        public bool IsProjectFile(string fullname)
        {
            foreach (var projectfile in projectfiles)
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
            foreach (ProjectFolder profolder in projectfolders)
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
            foreach (var projectfile in projectfiles)
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
            foreach (ProjectFile projectfile in projectfiles)
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
            foreach (ProjectFolder projectfolder in projectfolders)
            {
                if (projectfolder.FullName == fullname)
                {
                    return projectfolder;
                }
            }

            throw new KeyNotFoundException("Could not find Project File");
        }

        public ProjectFileList(UsProject project)
        {
            this.project = project;
        }

        public ProjectFileList(UsProject project, string rootDirectory, 
            string regularMatch = "", bool recursive = true)
        {
            this.project = project;
            ScanDirectory(rootDirectory, regularMatch, recursive);
        }

        public void RefreshDirectories()
        {
            throw new NotImplementedException();
            //_projectfiles.Clear();
            //_projectfolders.Clear();
            //
            //ScanDirectory(_project.DevelopmentFolder, Globals.ProjectFileRegex);
            //
            //_project.FileTreeView.FileTree.Nodes.Clear();
            //_project.FileTreeView.ScanDirectory(_project.DevelopmentFolder, Globals.ProjectFileRegex);
            //_project.FileTreeView.ExpandDefaultFolders();
        }

        public void ScanDirectory(string folder, string fileMatch = "", bool recursive = true)
        {
            Regex re = new Regex(fileMatch);

            DirectoryInfo dir = new DirectoryInfo(folder);
            if (!dir.Exists)
            {
                dir.Create();
            }

            projectfolders.Add(new ProjectFolder(dir));

            foreach (var fileinfo in dir.GetFiles())
            {
                // Check if filename matches regex
                if (re.IsMatch(fileinfo.Name))
                {
                    // Add file to list
                    ProjectFile actorFile = new ProjectFile(fileinfo.FullName);
                    projectfiles.Add(actorFile);
                }
            }

            if (recursive)
            {
                foreach (var subdir in dir.GetDirectories())
                {
                    ScanDirectory(subdir.FullName, fileMatch, recursive);
                }
            }
        }
    }
}
