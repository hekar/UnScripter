using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter.Project
{
    public class ProjectFileTree
    {
        private TreeView filetree;

        private string projectName;
        public TreeView FileTree
        {
            get { return filetree; }
        }

        public ProjectFileTree(string projectname, TreeView fileview, string folder, string fileMatch = "")
        {
            filetree = fileview;
            projectName = projectname;

            ScanDirectory(folder, fileMatch);
        }


        public void ScanDirectory(string folder, string fileMatch = "", TreeNode lastnode = null)
        {
            Regex re = new Regex(fileMatch);

            DirectoryInfo dir = new DirectoryInfo(folder);
            if ((lastnode == null))
            {
                lastnode = new TreeNode(dir.Name);
                filetree.Nodes.Add(lastnode);
                filetree.TopNode = lastnode;
            }
            else
            {
                // Ignore the Classes folders
                lastnode = lastnode.Nodes.Add(dir.Name);
            }

            if (lastnode.Text == "Src")
            {
                lastnode.Name = projectName;
                lastnode.Text = projectName;
                lastnode.ImageIndex = 0;
            }
            else
            {
                lastnode.ImageIndex = 1;
            }

            lastnode.SelectedImageIndex = lastnode.ImageIndex;

            //("*.*", SearchOption.AllDirectories)
            foreach (FileInfo fileinfo in dir.GetFiles())
            {
                // Check if filename matches regex
                if (re.IsMatch(fileinfo.Name))
                {
                    // Add file to list
                    ProjectFile actor_file = new ProjectFile(fileinfo.FullName);

                    lastnode.Nodes.Add(actor_file.FileName, actor_file.FileName, 2, 2);
                }
            }

            foreach (DirectoryInfo dir_loopVariable in dir.GetDirectories())
            {
                dir = dir_loopVariable;
                ScanDirectory(dir.FullName, fileMatch, lastnode);
                lastnode = lastnode.Parent;
            }
        }

        // Expand the main project folder and the "Classes" folders
        public void ExpandDefaultFolders()
        {
            // Collapse everything first
            filetree.Nodes[0].Collapse();

            // Expand the Root Project Node
            filetree.Nodes[0].Expand();

            foreach (TreeNode node in filetree.Nodes)
            {
                foreach (TreeNode secondnode in node.Nodes)
                {
                    foreach (TreeNode thirdnode in secondnode.Nodes)
                    {
                        // Expand 
                        if (thirdnode.Text.ToLower() == "classes")
                        {
                            thirdnode.Expand();
                        }
                    }
                }
            }
        }
    }
}
