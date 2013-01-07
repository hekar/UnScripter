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

	// Default page for adding to the options dialog
	public class OptionPage : TabPage
	{

		public virtual void OnLoadSettings()
		{
		}

		public virtual void OnApplySettings()
		{
		}

		public virtual void OnFocus()
		{
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
	}
}
