using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
    public class EditorTabDock : DockContent
    {
        public EditorTabs EditorTabs { get; set; }

        public EditorTabDock()
        {
            EditorTabs = new EditorTabs();
            EditorTabs.Dock = DockStyle.Fill;

            DockHandler.CloseButtonVisible = false;
            DockAreas = DockAreas.Document;

            this.Controls.Add(EditorTabs);
        }
    }
}
