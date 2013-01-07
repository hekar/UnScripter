using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
	class ClassBrowserDock : BaseDock
	{
		public ClassView ClassView { get; set; }

		public ClassBrowserDock(ClassView classView)
		{
			ClassView = classView;
			ClassView.Dock = DockStyle.Fill;

			Text = "Class Browser";

			DockHandler.HideOnClose = true;

			DockAreas = DockAreas.DockLeft | DockAreas.DockRight;

			this.Controls.Add(ClassView);
		}
	}
}
