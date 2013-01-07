using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace UnScripter.Project
{
    class Project
    {
        // Winforms TreeView for the Project Explorer
        public ProjectFileTree FileTreeView { get; set; }

        // Is the project saved?
        public bool Saved { get; set; }

        // Simple list of each file in the project
        private ProjectFileList _filelist;
        public ProjectFileList FileList
        {
            get { return _filelist; }
        }

        // Name of the Project
        private string _projectname;
        public string ProjectName
        {
            get { return _projectname; }
        }

        public string ProjectFileName
        {
            get { return ProjectFolder + ProjectName + ".axproj"; }
        }

        // Root folder of the Project (UDK Directory)
        private string _projectfolder;
        public string ProjectFolder
        {
            get { return _projectfolder; }
        }

        // Folder containing actual Source Code (UnrealScript)
        public string DevelopmentFolder
        {
            get { return _projectfolder + "Development\\Src\\"; }
        }

        public string NodeFullPathToFullName(string fullpath)
        {
            // hmmm...
            return DevelopmentFolder + fullpath.Replace(_projectname + "\\", "");
        }


        public Project(string name, string udkdir, string filebrowser_regex = Globals.kProjectFileRegex)
        {
            _projectname = name;
            _projectfolder = udkdir;

            // By default, we assume we're not saved
            Saved = false;

            // Add the path separator if needed
            if (!_projectfolder.EndsWith("\\"))
            {
                _projectfolder += "\\";
            }

            // Create our list of project files
            _filelist = new ProjectFileList(this, DevelopmentFolder, filebrowser_regex);
        }

        public static Project OpenProject(string path)
        {
            // Return a Project object from a file path 
            Settings projectsettings = new Settings(path, "Project");
            projectsettings.ReadFromXml();

            string projectname = projectsettings.GetTrait("Name", "Corrupt Project File");
            string folder = projectsettings.GetTrait("RootFolder", "Bad Root Directory");

            Project project = new Project(projectname, folder, Globals.kProjectFileRegex);

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
