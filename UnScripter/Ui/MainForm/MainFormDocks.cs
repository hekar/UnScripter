using Ninject;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;

namespace UnScripter
{
    class MainFormDocks
    {
        private const string kDockSettingsFile = "xml/dock_settings.xml";

        // Dock Panels
        public ErrorViewDock ErrorViewDock          { get; private set; }
        public ConsoleOutputDock ConsoleOutputDock  { get; private set; }
        public FileViewDock FileViewDock            { get; private set; }
        public EditorTabDock EditorTabDock          { get; private set; }
        public ClassBrowserDock ClassBrowserDock    { get; private set; }

        [Inject]
        public MainFormDocks(
                ErrorViewDock errorViewDock,
                ConsoleOutputDock consoleOutputDock,
                FileViewDock fileViewDock,
                EditorTabDock editorTabDock,
                ClassBrowserDock classBrowserDock,
                DockPanel dockPanel)
        {
            this.ErrorViewDock = errorViewDock;
            this.ConsoleOutputDock = consoleOutputDock;
            this.FileViewDock = fileViewDock;
            this.EditorTabDock = editorTabDock;
            this.ClassBrowserDock = classBrowserDock;
        }

        public void LoadDockSettings(DockPanel dockPanel)
        {
            if (File.Exists(kDockSettingsFile))
            {
                dockPanel.LoadFromXml(kDockSettingsFile, GetContentFromPersistantString);
            }
        }

        public void SaveDockSettings(DockPanel dockPanel)
        {
            dockPanel.SaveAsXml(kDockSettingsFile);
        }

        public void ShowDefaultDocks(DockPanel dockPanel)
        {
            EditorTabDock.Show(dockPanel);
        }

        public DockContent GetContentFromPersistantString(string name)
        {
            if (name == ErrorViewDock.GetType().FullName)
            {
                return ErrorViewDock;
            }
            else if (name == FileViewDock.GetType().FullName)
            {
                return FileViewDock;
            }
            else if (name == ClassBrowserDock.GetType().FullName)
            {
                return ClassBrowserDock;
            }
            else if (name == ConsoleOutputDock.GetType().FullName)
            {
                return ConsoleOutputDock;
            }

            return null;
        }

    }
}
