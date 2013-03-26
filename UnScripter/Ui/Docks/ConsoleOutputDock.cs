using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
	public class ConsoleOutputDock : BaseDock
	{
		public ConsoleOutput ConsoleOutput { get; private set; }

		public ConsoleOutputDock()
		{
			ConsoleOutput = new ConsoleOutput();
			ConsoleOutput.Dock = DockStyle.Fill;

			Text = "Console Output";

			DockHandler.HideOnClose = true;

			DockAreas = DockAreas.DockBottom | 
                DockAreas.DockTop | 
                DockAreas.Float;

			// Default to bottom
			//DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockBottom

			this.Controls.Add(ConsoleOutput);
		}
	}
}
