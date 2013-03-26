using System;
using System.IO;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter
{

    // Events for controls inside of the Mainform
    class ControlEvents
    {

        // Context Menu strips
        private ProjectFileContextMenu ProjectFileMenuStrip { get; set; }
        private ProjectFolderContextMenu ProjectFolderMenuStrip { get; set; }
        private readonly MainForm mainForm;
        private readonly EditorTabManager editorTabManager;
        private readonly ProjectManager projectManager;

        public ControlEvents(MainForm mainForm, EditorTabManager editorTabManager, ProjectManager projectManager)
        {
            this.mainForm = mainForm;
            this.editorTabManager = editorTabManager;
            this.projectManager = projectManager;
        }

        public void FileView_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var selectednode = mainForm.FileView.SelectedNode;
            if ((selectednode != null))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var curproj = projectManager.CurrentProject;
                    string fullpath = curproj.NodeFullPathToFullName(selectednode.FullPath);
                    if (curproj.FileList.IsProjectFile(fullpath))
                    {
                        var projectfile = curproj.FileList.GetProjectFile(fullpath);
                        editorTabManager.AddTab(projectfile.FileName, projectfile);
                    }
                    else if (fullpath.EndsWith(curproj.ProjectName))
                    {
                        if (selectednode.IsExpanded)
                        {
                            selectednode.Collapse();
                        }
                        else
                        {
                            selectednode.Expand();
                        }

                    }
                    else if (curproj.FileList.IsProjectFolder(fullpath))
                    {
                        if (selectednode.IsExpanded)
                        {
                            selectednode.Collapse();
                        }
                        else
                        {
                            selectednode.ExpandAll();
                        }
                    }
                }
            }
        }

        public void FileView_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TreeNode node = (TreeNode)mainForm.FileView.GetNodeAt(e.Location);
            mainForm.FileView.SelectedNode = node;
            string fullpath = projectManager.CurrentProject.NodeFullPathToFullName(node.FullPath);
            fullpath = fullpath.Replace(projectManager.CurrentProject.ProjectName + "\\", "");

            var curproj = projectManager.CurrentProject;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (mainForm.FileView.FileViewType != FileView.FileViewMode.CLASSIC)
                {
                    // Expand the Folder
                    if (!curproj.FileList.IsProjectFile(fullpath) & !fullpath.EndsWith(curproj.ProjectName))
                    {
                        if (node.IsExpanded)
                        {
                            node.Collapse();
                        }
                        else
                        {
                            node.ExpandAll();
                        }
                    }
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // Open the context menu
                if (curproj.FileList.IsProjectFile(fullpath))
                {
                    ProjectFileMenuStrip.ClickedProjectFile = projectManager.CurrentProject.FileList.GetProjectFile(fullpath);

                    var location = new System.Drawing.Point(e.Location.X, e.Location.Y + Convert.ToInt32(ProjectFileMenuStrip.Height / 2) +
                        Convert.ToInt32(ProjectFileMenuStrip.Items[0].Height * 1.5));

                    ProjectFileMenuStrip.Show(location);
                }
                else if (curproj.FileList.IsProjectFolder(fullpath))
                {
                    // Do a project folder context strip
                    ProjectFolderMenuStrip.ClickedProjectFolder = projectManager.CurrentProject.FileList.GetProjectFolder(fullpath);

                    var location = new System.Drawing.Point(e.Location.X, e.Location.Y + Convert.ToInt32(ProjectFileMenuStrip.Height / 2) +
                        Convert.ToInt32(ProjectFileMenuStrip.Items[0].Height * 1.5));

                    ProjectFolderMenuStrip.Show(location);
                }
                else
                {
                    // This is the actual project node
                }
            }
        }

        public void FileView_NodeMouseDoubleClick(System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            var profilename = projectManager.CurrentProject.DevelopmentFolder +
                mainForm.FileView.SelectedNode.FullPath.Replace(projectManager.CurrentProject.ProjectName + "\\", "");
            ProjectFile projectfile = new ProjectFile(profilename);
            FileInfo fileinfo = new FileInfo(projectfile.FullName);
            if (fileinfo.Exists && !(fileinfo.Attributes == FileAttributes.Directory))
            {
                editorTabManager.AddTab(projectfile.FileName, projectfile);
            }
        }

        public void EditorTabs_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers.HasFlag(Keys.Control))
            {
                if (e.KeyCode == Keys.W)
                {
                    editorTabManager.CloseCurrentTab();
                }
            }
        }


        public void EditorTabs_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            editorTabManager.TabClicked = null;
            for (int i = 0; i <= mainForm.EditorTabs.TabCount - 1; i++)
            {
                if (mainForm.EditorTabs.GetTabRect(i).Contains(e.Location))
                {
                    editorTabManager.TabClicked = mainForm.EditorTabs.TabPages[i];
                    break;
                }
            }

            // Exit Tabs on Middle Click
            if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                editorTabManager.CloseTab(editorTabManager.TabClicked.Name);
            }
            else if (e.Button == MouseButtons.Right)
            {
                mainForm.EditorTabMenuStrip.Show(mainForm.EditorTabs, e.Location);
            }
        }
    }
}
