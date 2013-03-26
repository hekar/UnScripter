using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter.Project
{
    public class ProjectFileTree
    {
        private TreeView _filetree;

        private string _projectname;
        public TreeView FileTree
        {
            get { return _filetree; }
        }

        public ProjectFileTree(string projectname, TreeView fileview, string folder, string regular_match = "")
        {
            _filetree = fileview;
            _projectname = projectname;

            ScanDirectory(folder, regular_match);
        }


        public void ScanDirectory(string folder, string regular_match = "", TreeNode lastnode = null)
        {
            Regex re = new Regex(regular_match);

            DirectoryInfo dir = new DirectoryInfo(folder);
            if ((lastnode == null))
            {
                lastnode = new TreeNode(dir.Name);
                _filetree.Nodes.Add(lastnode);
                _filetree.TopNode = lastnode;
            }
            else
            {
                // Ignore the Classes folders
                lastnode = lastnode.Nodes.Add(dir.Name);
            }

            if (lastnode.Text == "Src")
            {
                lastnode.Name = _projectname;
                lastnode.Text = _projectname;
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
                ScanDirectory(dir.FullName, regular_match, lastnode);
                lastnode = lastnode.Parent;
            }
        }

        // Expand the main project folder and the "Classes" folders
        public void ExpandDefaultFolders()
        {
            // Collapse everything first
            _filetree.Nodes[0].Collapse();

            // Expand the Root Project Node
            _filetree.Nodes[0].Expand();

            foreach (TreeNode node in _filetree.Nodes)
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
