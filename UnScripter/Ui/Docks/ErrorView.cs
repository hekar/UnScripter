using Ninject;
using System;
using System.IO;
using System.Windows.Forms;
using UnScripterPlugin.Project;

namespace UnScripter
{
    [System.ComponentModel.DesignerCategory("")]
    partial class ErrorView
    {
        private EditorTabManager editorTabManager;

        [Inject]
        public ErrorView(EditorTabManager editorTabManager)
        {
            this.editorTabManager = editorTabManager;
            InitializeComponent();
        }

        private void ListView_MouseDoubleClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((GetChildAtPoint(e.Location) != null))
                {
                    GotoError(ListView.SelectedIndices[0]);
                }
            }
        }

        public void PrevError()
        {
            int nextindex = ListView.SelectedIndices[0] - 1;
            if (nextindex >= 0)
            {
                ListView.SelectedIndices.Clear();
                ListView.SelectedIndices.Add(nextindex);
            }
        }

        public void NextError()
        {
            int nextindex = ListView.SelectedIndices[0] + 1;
            if (nextindex < ListView.Items.Count)
            {
                ListView.SelectedIndices.Clear();
                ListView.SelectedIndices.Add(nextindex);
            }
        }

        public void GotoError(int index)
        {
            ListView.SelectedIndices.Clear();
            ListView.SelectedIndices.Add(index);

            string fullname = ListView.SelectedItems[0].SubItems[3].Text;

            if (!File.Exists(fullname))
            {
                // Bail out if the file does not exist
                return;
            }

            int line = Convert.ToInt32(ListView.SelectedItems[0].SubItems[2].Text);

            if (line < 0)
            {
                line = -line;
            }

            string leaf = fullname.Substring(fullname.LastIndexOf("\\") + 1, fullname.Length - fullname.LastIndexOf("\\") - 1);

            var tab = editorTabManager.AddTab(leaf, new ProjectFile(fullname));

            if (tab != null)
            {
                tab.ScintillaEditor.GoTo.Line(line);
                tab.ScintillaEditor.Caret.LineNumber = line - 1;
                tab.ScintillaEditor.Caret.Position += tab.ScintillaEditor.Lines[line - 1].Length;
                tab.ScintillaEditor.Selection.Start = tab.ScintillaEditor.Selection.End;
                tab.ScintillaEditor.Scrolling.ScrollToCaret();
                tab.ScintillaEditor.Focus();
            }
        }

        public void Clear()
        {
            ListView.Items.Clear();
        }

        public void Add(ListViewItem item)
        {
            ListView.Items.Add(item);
        }
    }
}
