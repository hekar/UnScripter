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
namespace UnScripter
{
	class EditMenu
	{
        private MainForm mainForm;
        private EditorTabManager editorTabManager;
        public EditMenu(MainForm mainForm, EditorTabManager editorTabManager)
        {
            this.editorTabManager = editorTabManager;
            this.mainForm = mainForm;
        }

		public void EditMenu_DropDown(object sender, System.EventArgs e)
		{
            var enable = editorTabManager.CurrentTab != null;
			mainForm.UndoToolStripMenuItem.Enabled = (enable);
			mainForm.RedoToolStripMenuItem.Enabled = (enable);
			mainForm.CutToolStripMenuItem.Enabled = (enable);
			mainForm.CopyToolStripMenuItem.Enabled = (enable);
			mainForm.PasteToolStripMenuItem.Enabled = (enable);
			mainForm.FindToolStripMenuItem.Enabled = (enable);
			mainForm.ReplaceToolStripMenuItem.Enabled = (enable);
			mainForm.SelectAllToolStripMenuItem.Enabled = (enable);
			mainForm.GoToParentToolStripMenuItem.Enabled = (enable);

			if ((enable)) {
				mainForm.UndoToolStripMenuItem.Enabled = editorTabManager.CurrentTab.ScintillaEditor.UndoRedo.CanUndo;
				mainForm.RedoToolStripMenuItem.Enabled = editorTabManager.CurrentTab.ScintillaEditor.UndoRedo.CanRedo;
				mainForm.PasteToolStripMenuItem.Enabled = editorTabManager.CurrentTab.ScintillaEditor.Clipboard.CanPaste;
			}
		}

		public void UndoToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.UndoRedo.Undo();
		}

		public void RedoToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.UndoRedo.Redo();
		}

		public void CutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.Clipboard.Cut();
		}

		public void CopyToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.Clipboard.Copy();
		}

		public void PasteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.Clipboard.Paste();
		}

		public void FindToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			// Temporary until a find tool is created
			editorTabManager.CurrentTab.ScintillaEditor.FindReplace.ShowFind();
		}


		public void FindFilesToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
		}

		public void ReplaceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			// Temporary until a replace is created
			editorTabManager.CurrentTab.ScintillaEditor.FindReplace.ShowReplace();
		}


		public void ReplaceFilesToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
		}

		public void SelectAllToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			editorTabManager.CurrentTab.ScintillaEditor.Selection.SelectAll();
		}

		public void GotoParentClassToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			bool completedparsing = editorTabManager.CurrentTab.ProjectFile.UnrealClass.CompletedParsing;
			if (completedparsing) {
				var unrealclass = editorTabManager.CurrentTab.ProjectFile.UnrealClass;
				string parentname = unrealclass.ParentName;
				var parentfile = Globals.CurrentProject.FileList.GetProjectFileByClassName(parentname);

				if ((parentfile != null)) {
					var tab = editorTabManager.AddTab(parentfile.FileName, parentfile);
				}
			}
		}

	}
}
