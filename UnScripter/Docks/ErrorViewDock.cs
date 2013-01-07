using Ninject;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
    class ErrorViewDock : BaseDock
    {
        public ErrorView ErrorView { get; set; }

        [Inject]
        public ErrorViewDock(ErrorView errorView)
        {
            ErrorView = errorView;
            ErrorView.Dock = DockStyle.Fill;

            Text = "Error Output";

            DockHandler.HideOnClose = true;

            DockAreas = DockAreas.DockBottom |
                DockAreas.DockTop | 
                DockAreas.Float;

            // Default to bottom
            //DockState = WeifenLuo.WinFormsUI.Docking.DockState.DockBottom

            this.Controls.Add(ErrorView);
        }
    }
}
