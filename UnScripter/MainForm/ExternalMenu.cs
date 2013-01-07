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
	public class ExternalMenu
	{

		public void UnrealEditorToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Globals.CurrentProject.ProjectFolder + "\\Binaries\\UDKLift.exe";
			startinfo.Arguments = "editor";
			startinfo.WorkingDirectory = Globals.CurrentProject.ProjectFolder + "\\Binaries\\";
			proc.StartInfo = startinfo;
			proc.Start();
		}

		public void UnrealLocalizerToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Globals.CurrentProject.ProjectFolder + "\\Binaries\\UnrealLoc.exe";
			startinfo.WorkingDirectory = Globals.CurrentProject.ProjectFolder + "\\Binaries\\";
			proc.StartInfo = startinfo;
			proc.Start();
		}

		public void UnrealFrontendToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Globals.CurrentProject.ProjectFolder + "\\Binaries\\UnrealFrontend.exe";
			startinfo.WorkingDirectory = Globals.CurrentProject.ProjectFolder + "\\Binaries\\";
			proc.StartInfo = startinfo;
			proc.Start();
		}

		public void OpenConfigFolderToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Globals.kDefaultExplorer;
			startinfo.Arguments = Globals.CurrentProject.ProjectFolder + "UDKGame\\Config";
			proc.StartInfo = startinfo;
			proc.Start();
		}

		public void OpenExplorerToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Globals.kDefaultExplorer;
			startinfo.Arguments = Globals.CurrentProject.DevelopmentFolder;
			proc.StartInfo = startinfo;
			proc.Start();
		}

		public void OpenTerminalToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Process proc = new Process();
			ProcessStartInfo startinfo = new ProcessStartInfo();
			string curdir = System.IO.Directory.GetCurrentDirectory();
			startinfo.FileName = curdir + Globals.kDefaultTerminal;

			// Add in directories to the PATH
			startinfo.Arguments = "\"" + curdir + "\"" + " " + "\"" + curdir + "\\scripts" + "\"";
			if ((Globals.CurrentProject != null)) {
				startinfo.Arguments += " " + "\"" + Globals.CurrentProject.ProjectFolder + "Binaries" + "\"";
			}

			startinfo.WorkingDirectory = Globals.CurrentProject.ProjectFolder;

			proc.StartInfo = startinfo;
			proc.Start();
		}

	}
}
