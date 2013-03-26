using Ninject;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
	public class FileViewDock : BaseDock
	{
		public FileView FileView { get; set; }

        [Inject]
		public FileViewDock(FileView fileview)
		{
            this.FileView = fileview;
			FileView.Dock = DockStyle.Fill;

			Text = "Project Explorer";

			DockHandler.HideOnClose = true;

			// Disallow dock in center
			DockAreas = DockAreas.DockLeft | 
                DockAreas.DockRight | 
                DockAreas.Float;


			// Default to left
			//DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft

			Controls.Add(FileView);
		}
	}
}
