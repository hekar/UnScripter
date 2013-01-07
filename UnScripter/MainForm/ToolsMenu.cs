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
using UnScripter.Project;
using Ninject;

namespace UnScripter
{
	class ToolsMenu
	{
        private EditorTabManager editorTabManager;
        private OptionsDialog optionsDialog;

        [Inject]
        public ToolsMenu(EditorTabManager editorTabManager, OptionsDialog optionsDialog)
        {
            this.editorTabManager = editorTabManager;
            this.optionsDialog = optionsDialog;
        }

		public void ShowResourcesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			if ((Globals.CurrentProject != null)) {
                var resDialog = new ResourceDialog();
                resDialog.Files = Globals.CurrentProject.FileList.RelativeFiles;
                var result = resDialog.ShowDialog();
				if (result == System.Windows.Forms.DialogResult.OK) {
                    var projectfile = Globals.CurrentProject.FileList.GetProjectFile(resDialog.SelectedFullName);
					editorTabManager.AddTab(projectfile.FileName, projectfile);
				}
			}
		}

		public void ShowOptions(System.Object sender, System.EventArgs e)
		{
			optionsDialog.Show();
		}
	}
}
