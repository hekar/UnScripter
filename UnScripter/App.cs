using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Ninject;
using UnScripter.Ninject;

namespace UnScripter
{
	class App
	{
        // TODO: Make this non-global
        public static readonly IKernel Kernel = new StandardKernel(new MainModule());

		[STAThread]
		public static void Main(string[] args)
		{
            Application.Run(Kernel.Get<MainForm>());
		}
	}
}
