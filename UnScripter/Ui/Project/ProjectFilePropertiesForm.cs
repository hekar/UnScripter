using System;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter
{
    partial class ProjectFilePropertiesForm
    {
        public ProjectFile ProjectFile { get; set; }

        public string ClassName
        {
            get { return LabelClassName.Text.Replace("ClassName: ", ""); }
            set { LabelClassName.Text = "ClassName: " + value; }
        }

        public string ContainingFolder
        {
            get { return LabelDirectory.Text.Replace("Containing Folder: ", ""); }
            // Set the destination folder for the link too
            set { LabelDirectory.Text = "Containing Folder: " + value; }
        }

        public string FullPath
        {
            get { return LabelFullPath.Text.Replace("FullPath: ", ""); }
            // Set the destination folder for the link too
            set { LabelFullPath.Text = "FullPath: " + value; }
        }

        public ProjectFilePropertiesForm()
        {
            InitializeComponent();
        }

        private void LinkLabelOpenFolder_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectFile.OpenPath();
        }

        private void LinkLabelFullPath_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectFile.OpenInSystemEditor();
        }
    }
}
