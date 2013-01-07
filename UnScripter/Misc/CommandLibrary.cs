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
using System.Xml;
using System.Text;
namespace UnScripter
{
	// Stores shortened names for system commands (meant for embedding commands into html)
	public class CommandLibrary : Settings
	{
		public CommandLibrary() : base("xml/commands.xml", "commands", false)
		{
		}

		public void SetCommand(string command_key, string value)
		{
			base.SetTrait(command_key, value);
		}

		public string GetCommand(string command_key)
		{
			return base.GetTrait(command_key);
		}

		// Execute a command in the background
		public void ExecuteCommand(string command_key)
		{
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = GetCommand(command_key);
			Process proc = new Process();
			proc.StartInfo = startinfo;
			proc.Start();
		}
	}
}
