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
	public class AboutMenu
	{
		public void ShowAboutBox(object sender, EventArgs e)
		{
			new AboutBox().Show();
		}
	}
}
