using Ninject;
using System;
using System.Windows.Forms;
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
