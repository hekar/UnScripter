using System;
using System.Windows.Forms;

namespace UnScripter
{
    [System.ComponentModel.DesignerCategory("")]
    class TabContextMenu : ContextMenuStrip
    {
        private EditorTabManager editorTabManager;
        public TabContextMenu(EditorTabManager editortabmanager)
        {
            this.editorTabManager = editortabmanager;
            this.Items.Add("Close", null, CloseButton_Click);
            this.Items.Add("Close Others", null, CloseOthersButton_Click);
            this.Items.Add("Close All", null, CloseAllButton_Click);
            this.Items.Add("-");
            this.Items.Add("Open Path", null, OpenPathButton_Click);
            this.Items.Add("Open Editor", null, OpenEditorButton_Click);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            editorTabManager.CloseTab(editorTabManager.TabClicked);
        }

        private void CloseOthersButton_Click(object sender, EventArgs e)
        {
            editorTabManager.CloseOthers(editorTabManager.TabClicked);
        }

        private void OpenPathButton_Click(object sender, EventArgs e)
        {
            editorTabManager.SelectedTabProjectFile.OpenPath();
        }

        private void OpenEditorButton_Click(object sender, EventArgs e)
        {
            editorTabManager.SelectedTabProjectFile.OpenEditor();
        }

        private void CloseAllButton_Click(object sender, EventArgs e)
        {
            editorTabManager.CloseAll();
        }

    }
}
