using System;
using System.Windows.Forms;

namespace UnScripter
{

	class TabContextMenu : ContextMenuStrip
	{

		private EditorTabManager _editortabmanager;
		public TabContextMenu(EditorTabManager editortabmanager)
		{
			_editortabmanager = editortabmanager;
			this.Items.Add("Close", null, CloseButton_Click);
			this.Items.Add("Close Others", null, CloseOthersButton_Click);
			this.Items.Add("Close All", null, CloseAllButton_Click);
			this.Items.Add("-");
			this.Items.Add("Open Path", null, OpenPathButton_Click);
			this.Items.Add("Open Editor", null, OpenEditorButton_Click);
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			_editortabmanager.CloseTab(_editortabmanager.TabClicked);
		}

		private void CloseOthersButton_Click(object sender, EventArgs e)
		{
			_editortabmanager.CloseOthers(_editortabmanager.TabClicked);
		}

		private void OpenPathButton_Click(object sender, EventArgs e)
		{
			_editortabmanager.SelectedTabProjectFile.OpenPath();
		}

		private void OpenEditorButton_Click(object sender, EventArgs e)
		{
			_editortabmanager.SelectedTabProjectFile.OpenEditor();
		}

		private void CloseAllButton_Click(object sender, EventArgs e)
		{
			_editortabmanager.CloseAll();
		}

	}
}
