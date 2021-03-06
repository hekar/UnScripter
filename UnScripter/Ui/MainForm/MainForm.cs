using Ninject;
using System;
using System.Windows.Forms;
using UnScripterPlugin;
using System.Drawing;
using System.Reactive;

namespace UnScripter
{
    // The Main Window for the IDE where most of the work is done
    partial class MainForm : ErrorReceiver
    {
        // Context menu strip
        public TabContextMenu EditorTabMenuStrip { get; set; }
        private readonly EditorTabManager editorTabManager;
        private readonly ProjectManager projectManager;

        private FileMenu fileMenu;
        private EditMenu editMenu;
        private ExternalMenu externalMenu;
        private ToolsMenu toolsMenu;
        private BuildMenu buildMenu;
        private WindowsMenu windowsMenu;
        private AboutMenu aboutMenu;

        private ControlEvents controlEvents;
        private BackgroundWorkers backgroundWorkers;

        [Inject]
        public MainForm(
            MainFormDocks docks,
            EditorTabManager editorTabManager, 
            UiSettings uiSettings, 
            GlobalSettings globalsSettings,
            EventStream eventStream)
        {
            InitializeComponent();

            this.docks = docks;
            this.editorTabManager = editorTabManager;
            this.uiSettings = uiSettings;
            this.globalsSettings = globalsSettings;
            this.eventStream = eventStream;

            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
        }

        private void AddMenuHandlers()
        {
            // File menu
            this.FileToolStripMenuItem.DropDownOpening += fileMenu.FileMenu_DropDown;

            this.ProjectNewToolStripMenuItem.Click += fileMenu.ProjectNewToolStripMenuItem_Click;
            this.ProjectOpenToolStripMenuItem.Click += fileMenu.ProjectOpenToolStripMenuItem_Click;
            this.ProjectSaveMenuItem.Click += fileMenu.ProjectSaveToolStripMenuItem_Click;
            this.NewToolStripMenuItem.Click += fileMenu.NewToolStripButton_Click;
            this.OpenToolStripMenuItem.Click += fileMenu.OpenToolStripButton_Click;
            this.SaveToolStripMenuItem.Click += fileMenu.SaveToolStripMenuItem_Click;
            this.SaveAllToolStripMenuItem.Click += fileMenu.SaveAllToolStripMenuItem_Click;
            this.PrintToolStripMenuItem.Click += fileMenu.PrintToolStripMenuItem_Click;
            this.PrintPreviewToolStripMenuItem.Click += fileMenu.PrintPreviewToolStripMenuItem_Click;
            this.ExitToolStripMenuItem.Click += fileMenu.ExitToolStripMenuItem_Click;
        
            // Edit menu
            this.EditToolStripMenuItem.DropDownOpening += editMenu.EditMenu_DropDown;

            this.UndoToolStripMenuItem.Click += editMenu.UndoToolStripMenuItem_Click;
            this.RedoToolStripMenuItem.Click += editMenu.RedoToolStripMenuItem_Click;
            this.CutToolStripMenuItem.Click += editMenu.CutToolStripMenuItem_Click;
            this.CopyToolStripMenuItem.Click += editMenu.CopyToolStripMenuItem_Click;
            this.PasteToolStripMenuItem.Click += editMenu.PasteToolStripMenuItem_Click;
            this.FindToolStripMenuItem.Click += editMenu.FindToolStripMenuItem_Click;
            this.FindInFilesToolStripMenuItem.Click += editMenu.FindFilesToolStripMenuItem_Click;
            this.ReplaceToolStripMenuItem.Click += editMenu.ReplaceToolStripMenuItem_Click;
            this.ReplaceInFilesToolStripMenuItem.Click += editMenu.ReplaceFilesToolStripMenuItem_Click;
            this.SelectAllToolStripMenuItem.Click += editMenu.SelectAllToolStripMenuItem_Click;

            this.GoToParentToolStripMenuItem.Click += editMenu.GotoParentClassToolStripMenuItem_Click;
        
            // Build menu
            buildMenu = new BuildMenu(this);

            this.BuildToolStripMenuItem.DropDownOpening += buildMenu.BuildMenu_DropDown;

            this.BuildAllToolStripMenuItem.Click += buildMenu.BuildAllToolStripMenuItem_Click;
            this.BuildAndRunToolStripMenuItem.Click += buildMenu.BuildAndRunToolStripMenuItem_Click;
            this.RunToolStripMenuItem.Click += buildMenu.RunToolStripMenuItem_Click;
            this.RebuildToolStripMenuItem.Click += buildMenu.BuildFullToolStripMenuItem_Click;

            this.ErrorNextToolStripMenuItem.Click += buildMenu.RunToolStripMenuItem_Click;

            // Tool menus
            this.UnrealEditorToolStripMenuItem.Click += externalMenu.UnrealEditorToolStripMenuItem_Click;
            this.UnrealLocalizerToolStripMenuItem.Click += externalMenu.UnrealLocalizerToolStripMenuItem_Click;
            this.UnrealFrontendToolStripMenuItem.Click += externalMenu.UnrealFrontendToolStripMenuItem_Click;
            this.OpenConfigFolderToolStripMenuItem.Click += externalMenu.OpenConfigFolderToolStripMenuItem_Click;
            this.OpenExplorerToolStripMenuItem.Click += externalMenu.OpenExplorerToolStripMenuItem_Click;
            this.OpenTerminalToolStripMenuItem.Click += externalMenu.OpenTerminalToolStripMenuItem_Click;
        
            // Options menu
            this.ShowResourcesToolStripMenuItem.Click += toolsMenu.ShowResourcesToolStripMenuItem_Click;
            this.PreferencesToolStripMenuItem.Click += toolsMenu.ShowOptions;

            // Windows menu
            windowsMenu = new WindowsMenu(this, docks, editorTabManager);

            WindowsToolStripMenuItem.DropDownOpening += windowsMenu.WindowsToolStripMenuItem_DropDownOpened;

            this.FocusEditorToolStripMenuItem.Click += windowsMenu.FocusEditor;
            this.ShowClassBrowserToolStripMenuItem.Click += windowsMenu.ShowClassBrowser;
            this.ProjectViewToolStripMenuItem.Click += windowsMenu.ShowFileExplorer;
            this.ErrorViewToolStripMenuItem.Click += windowsMenu.ShowErrorView;
            this.ConsoleOutputToolStripMenuItem.Click += windowsMenu.ShowConsoleOutput;
            this.CloseToolStripMenuItem.Click += windowsMenu.Close;
            this.CloseOthersToolStripMenuItem.Click += windowsMenu.CloseOthers;
            this.CloseAllToolStripMenuItem.Click += windowsMenu.CloseAll;

            // About menu
            aboutMenu = new AboutMenu();

            this.AboutToolStripMenuItem.Click += aboutMenu.ShowAboutBox;
        }

        private void AddToolStripHandlers()
        {
            this.ProjectNewToolStripButton.Click += fileMenu.ProjectNewToolStripMenuItem_Click;
            this.ProjectOpenToolStripButton.Click += fileMenu.ProjectOpenToolStripMenuItem_Click;
            this.ProjectSaveToolStripButton.Click += fileMenu.ProjectSaveToolStripMenuItem_Click;
            this.NewToolStripButton.Click += fileMenu.NewToolStripButton_Click;
            this.OpenToolStripButton.Click += fileMenu.OpenToolStripButton_Click;
            this.SaveToolStripButton.Click += fileMenu.SaveToolStripMenuItem_Click;
            this.SaveAllToolStripButton.Click += fileMenu.SaveAllToolStripMenuItem_Click;
            this.PreferencesToolStripButton.Click += toolsMenu.ShowOptions;
            this.ShowResDialogToolStripButton.Click += toolsMenu.ShowResourcesToolStripMenuItem_Click;
        }

        private void AddControlEvents()
        {
            // Add events handlers for controls inside of mainforms
            EditorTabs.KeyDown += controlEvents.EditorTabs_KeyDown;
            EditorTabs.MouseClick += controlEvents.EditorTabs_MouseClick;

            FileView.KeyDown += controlEvents.FileView_KeyDown;
            FileView.NodeMouseClick += controlEvents.FileView_MouseClick;
            FileView.NodeMouseDoubleClick += controlEvents.FileView_NodeMouseDoubleClick;
        }

        private void AddBackgroundWorkers()
        {
            this.BuildWorker.DoWork += backgroundWorkers.BuildWorker_DoWork;
            this.BuildWorker.RunWorkerCompleted += backgroundWorkers.BuildWorker_RunWorkerCompleted;
            this.UnrealParserWorker.DoWork += backgroundWorkers.UnrealParserWorker_DoWork;
            this.UnrealParserWorker.RunWorkerCompleted += backgroundWorkers.UnrealParserWorker_RunWorkerCompleted;
        }

        private void AddEventHandlers()
        {
            // Setup the event handlers
            AddMenuHandlers();
            AddToolStripHandlers();
            AddControlEvents();
            AddBackgroundWorkers();
        }

        private void MainForm_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                Text = Globals.ApplicationName;

                var projectManager = App.Kernel.Get<ProjectManager>();

                fileMenu = new FileMenu(this, projectManager, App.Kernel.Get<NewProjectForm>(), editorTabManager, App.Kernel.Get<ProjectNewFileDialog>());
                editMenu = new EditMenu(this, editorTabManager, projectManager);
                toolsMenu = new ToolsMenu(projectManager, editorTabManager,
                    App.Kernel.Get<OptionsDialog>(), App.Kernel.Get<ResourceDialog>());
                this.externalMenu = new ExternalMenu(projectManager);

                backgroundWorkers = new BackgroundWorkers(this, projectManager);
                controlEvents = new ControlEvents(this, editorTabManager, projectManager);

                // TODO: Fix
                editorTabManager.Tabs = EditorTabs;
                EditorTabMenuStrip = new TabContextMenu(editorTabManager);

                // We'll set everything at the end to avoid segment faults
                AddEventHandlers();

                // TODO: Move somewhere else
                var lastproject = globalsSettings.GetTrait("LastProjectPath");
                if (System.IO.File.Exists(lastproject))
                {
                    projectManager.CurrentProject = projectManager.OpenProject(lastproject);
                }

                // TODO: Move somewhere else...
                // Load the settings for the file explorer
                string fileviewtypestring = uiSettings.GetTrait("FileViewType", "CONTEMPORARY");

                FileView.FileViewMode fileviewparsed = default(FileView.FileViewMode);
                Enum.TryParse<FileView.FileViewMode>(fileviewtypestring, out fileviewparsed);

                FileView.FileViewType = fileviewparsed;

                docks.LoadDockSettings(DockPanel);
                docks.ShowDefaultDocks(DockPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void MainForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            docks.SaveDockSettings(DockPanel);
        }

        /// <summary>
        /// TODO: Move elsewhere
        /// </summary>
        public void StartParser()
        {
            ParserStatusLabel.Text = "Parsing UnrealScript...";
            ParserStatusProgressBar.Visible = true;
            ParserStatusProgressBar.Value = 10;
            UnrealParserWorker.RunWorkerAsync();
        }

        #region "Things that do not belong in this class"
        /// <summary>
        /// TODO: Move
        /// </summary>
        private MainFormDocks docks;
        private UiSettings uiSettings;
        private GlobalSettings globalsSettings;
        private EventStream eventStream;

        public ErrorView ErrorView
        {
            get { return docks.ErrorViewDock.ErrorView; }
        }

        public ConsoleOutput ConsoleOutput
        {
            get { return docks.ConsoleOutputDock.ConsoleOutput; }
        }

        public FileView FileView
        {
            get { return docks.FileViewDock.FileView; }
        }

        public EditorTabs EditorTabs
        {
            get { return docks.EditorTabDock.EditorTabs; }
        }

        public ClassView ClassView
        {
            get { return docks.ClassBrowserDock.ClassView; }
        }

        private void HideEditorToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            if (docks.EditorTabDock.Visible)
            {
                docks.EditorTabDock.Hide();
            }
            else
            {
                docks.EditorTabDock.Show(DockPanel);
            }
        }

        #endregion

        #region "ErrorReceiver"
        public string BuildMessage
        {
            get { return BuildMessageStatusLabel.Text; }
            set { BuildMessageStatusLabel.Text = value; }
        }

        public bool ProgressVisible
        {
            get { return ProgressBarStatusBar.Visible; }
            set { ProgressBarStatusBar.Visible = value; }
        }

        public int ProgressValue
        {
            get { return ProgressBarStatusBar.Value; }
            set { ProgressBarStatusBar.Value = value; }
        }

        public void ClearErrors()
        {
            ErrorView.Clear();
        }

        public void AddError(string[] columns)
        {
            ErrorView.Add(new ListViewItem(columns, 1, Color.Black,
                Color.WhiteSmoke, new Font("Segoe UI", 10)));
        }


        public void AddWarning(string[] columns)
        {
            ErrorView.Add(new ListViewItem(columns, 0, Color.Black,
                    Color.LightYellow, new Font(FontFamily.GenericSerif, 10)));
        }
        #endregion
    }
}
