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
	class WindowsMenu
	{
        private MainForm mainForm;
        private MainFormDocks docks;
        private EditorTabManager editorTabManager;

        public WindowsMenu(MainForm mainForm, MainFormDocks docks, EditorTabManager editorTabManager)
        {
            this.mainForm = mainForm;
            this.editorTabManager = editorTabManager;
            this.docks = docks;
        }

		public void WindowsToolStripMenuItem_DropDownOpened(System.Object sender, System.EventArgs e)
		{
			var wintoolitems = mainForm.WindowsToolStripMenuItem;

			// Clear up to the first separator

			for (int i = wintoolitems.DropDownItems.Count - 1; i >= 0; i--) {
				// Is this the separator?
				var text = wintoolitems.DropDownItems[i].Text;
				if (text.Length > 0) {
					if (char.IsDigit(text[0])) {
						wintoolitems.DropDownItems.RemoveAt(i);
					}
				}
			}

			// Calculate the window items for all the open tabs, etc
			for (int i = 0; i <= editorTabManager.TabCount - 1; i++) {
				EditorTabPage tabpage = (EditorTabPage)editorTabManager.TabPages[i];
				string menuitemname = (editorTabManager.TabCount - i).ToString() + " " + tabpage.Text;
				var menuitem = new ToolStripMenuItem(menuitemname, null, SelectWindow);
				wintoolitems.DropDownItems.Insert(0, menuitem);
			}

		}

		public void SelectWindow(System.Object sender, System.EventArgs e)
		{
			var menuitem = (ToolStripMenuItem)sender;
			foreach (var etab in editorTabManager.TabPages) {
				EditorTabPage editortab = (EditorTabPage)etab;
				string desiredtab = menuitem.Text.Substring(2, menuitem.Text.Count() - 2);
				if (editortab.Name == desiredtab) {
					editorTabManager.TabControl.SelectedTab = editortab;
				}
			}
		}

		public void FocusEditor(System.Object sender, System.EventArgs e)
		{
			if ((editorTabManager.CurrentTab != null)) {
				editorTabManager.CurrentTab.ScintillaEditor.Focus();
			}
		}

		public void ShowClassBrowser(System.Object sender, System.EventArgs e)
		{
			if (!docks.ClassBrowserDock.Visible) {
				docks.ClassBrowserDock.Show(mainForm.DockPanel);
			} else {
				docks.ClassBrowserDock.Hide();
			}
		}

		public void ShowFileExplorer(System.Object sender, System.EventArgs e)
		{
			if (!docks.FileViewDock.Visible) {
				docks.FileViewDock.Show(mainForm.DockPanel);
			} else {
				docks.FileViewDock.Hide();
			}
		}

		public void ShowErrorView(System.Object sender, System.EventArgs e)
		{
			if (!docks.ErrorViewDock.Visible) {
				docks.ErrorViewDock.Show(mainForm.DockPanel);
			} else {
				docks.ErrorViewDock.Hide();
			}
		}

		public void ShowConsoleOutput(System.Object sender, System.EventArgs e)
		{
			if (!docks.ConsoleOutputDock.Visible) {
				docks.ConsoleOutputDock.Show(mainForm.DockPanel);
			} else {
				docks.ConsoleOutputDock.Hide();
			}
		}

		public void Close(System.Object sender, System.EventArgs e)
		{
			editorTabManager.CloseCurrentTab();
		}

		public void CloseOthers(System.Object sender, System.EventArgs e)
		{
			editorTabManager.CloseOthers(editorTabManager.CurrentTab);
		}

		public void CloseAll(System.Object sender, System.EventArgs e)
		{
			editorTabManager.CloseAll();
		}

    }
}
