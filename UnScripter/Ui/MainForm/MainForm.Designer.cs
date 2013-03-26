using WeifenLuo.WinFormsUI.Docking;
using System.ComponentModel;
using System.Windows.Forms;

namespace UnScripter
{
	partial class MainForm : Form
	{
		//Required by the Windows Form Designer

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ParserStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ParserStatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.BuildMessageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBarStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.FileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ProjectNewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProjectOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProjectSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PreferencesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ShowResDialogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToDeclarationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RebuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ErrorPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ProjectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExternalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnrealEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnrealLocalizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnrealFrontendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenConfigFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.FocusEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ProjectViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowClassBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseOthersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildWorker = new System.ComponentModel.BackgroundWorker();
            this.UnrealParserWorker = new System.ComponentModel.BackgroundWorker();
            this.DockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.StatusStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.AutoSize = false;
            this.StatusStrip.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParserStatusLabel,
            this.ParserStatusProgressBar,
            this.BuildMessageStatusLabel,
            this.ProgressBarStatusBar,
            this.FileStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 508);
            this.StatusStrip.Margin = new System.Windows.Forms.Padding(8);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStrip.Size = new System.Drawing.Size(688, 32);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // ParserStatusLabel
            // 
            this.ParserStatusLabel.Name = "ParserStatusLabel";
            this.ParserStatusLabel.Size = new System.Drawing.Size(10, 27);
            this.ParserStatusLabel.Text = " ";
            // 
            // ParserStatusProgressBar
            // 
            this.ParserStatusProgressBar.MarqueeAnimationSpeed = 10;
            this.ParserStatusProgressBar.Name = "ParserStatusProgressBar";
            this.ParserStatusProgressBar.Size = new System.Drawing.Size(112, 26);
            this.ParserStatusProgressBar.Step = 5;
            this.ParserStatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ParserStatusProgressBar.Visible = false;
            // 
            // BuildMessageStatusLabel
            // 
            this.BuildMessageStatusLabel.Name = "BuildMessageStatusLabel";
            this.BuildMessageStatusLabel.Size = new System.Drawing.Size(10, 27);
            this.BuildMessageStatusLabel.Spring = true;
            this.BuildMessageStatusLabel.Text = " ";
            this.BuildMessageStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProgressBarStatusBar
            // 
            this.ProgressBarStatusBar.MarqueeAnimationSpeed = 30;
            this.ProgressBarStatusBar.Name = "ProgressBarStatusBar";
            this.ProgressBarStatusBar.Size = new System.Drawing.Size(135, 26);
            this.ProgressBarStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarStatusBar.Visible = false;
            // 
            // FileStatusLabel
            // 
            this.FileStatusLabel.Name = "FileStatusLabel";
            this.FileStatusLabel.Size = new System.Drawing.Size(657, 27);
            this.FileStatusLabel.Spring = true;
            this.FileStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectNewToolStripButton,
            this.ProjectOpenToolStripButton,
            this.ProjectSaveToolStripButton,
            this.ToolStripSeparator8,
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.SaveAllToolStripButton,
            this.toolStripSeparator,
            this.PreferencesToolStripButton,
            this.ShowResDialogToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(688, 25);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "ToolStrip1";
            // 
            // ProjectNewToolStripButton
            // 
            this.ProjectNewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProjectNewToolStripButton.Image = global::UnScripter.Properties.Resources.folder_new;
            this.ProjectNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProjectNewToolStripButton.Name = "ProjectNewToolStripButton";
            this.ProjectNewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ProjectNewToolStripButton.Text = "New Project";
            // 
            // ProjectOpenToolStripButton
            // 
            this.ProjectOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProjectOpenToolStripButton.Image = global::UnScripter.Properties.Resources.project_open;
            this.ProjectOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProjectOpenToolStripButton.Name = "ProjectOpenToolStripButton";
            this.ProjectOpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ProjectOpenToolStripButton.Text = "Project Open";
            // 
            // ProjectSaveToolStripButton
            // 
            this.ProjectSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProjectSaveToolStripButton.Image = global::UnScripter.Properties.Resources.bookmark_folder;
            this.ProjectSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProjectSaveToolStripButton.Name = "ProjectSaveToolStripButton";
            this.ProjectSaveToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ProjectSaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ProjectSaveToolStripButton.Text = "Project Save";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = global::UnScripter.Properties.Resources.filenew;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "&New";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::UnScripter.Properties.Resources.fileopen;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::UnScripter.Properties.Resources.document_save;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            // 
            // SaveAllToolStripButton
            // 
            this.SaveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAllToolStripButton.Image = global::UnScripter.Properties.Resources.save_all;
            this.SaveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAllToolStripButton.Name = "SaveAllToolStripButton";
            this.SaveAllToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveAllToolStripButton.Text = "Save All";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // PreferencesToolStripButton
            // 
            this.PreferencesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreferencesToolStripButton.Image = global::UnScripter.Properties.Resources.games_config_options;
            this.PreferencesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreferencesToolStripButton.Name = "PreferencesToolStripButton";
            this.PreferencesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PreferencesToolStripButton.Text = "Preferences";
            // 
            // ShowResDialogToolStripButton
            // 
            this.ShowResDialogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowResDialogToolStripButton.Image = global::UnScripter.Properties.Resources.edit_select_all;
            this.ShowResDialogToolStripButton.Name = "ShowResDialogToolStripButton";
            this.ShowResDialogToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ShowResDialogToolStripButton.Text = "Show &Resource Dialog";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.BuildToolStripMenuItem,
            this.ExternalToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.WindowsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(688, 24);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectNewToolStripMenuItem,
            this.ProjectOpenToolStripMenuItem,
            this.ProjectSaveMenuItem,
            this.ToolStripSeparator7,
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator2,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.SaveAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.PrintToolStripMenuItem,
            this.PrintPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ProjectNewToolStripMenuItem
            // 
            this.ProjectNewToolStripMenuItem.Image = global::UnScripter.Properties.Resources.folder_new;
            this.ProjectNewToolStripMenuItem.Name = "ProjectNewToolStripMenuItem";
            this.ProjectNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProjectNewToolStripMenuItem.Text = "Project New";
            // 
            // ProjectOpenToolStripMenuItem
            // 
            this.ProjectOpenToolStripMenuItem.Image = global::UnScripter.Properties.Resources.project_open;
            this.ProjectOpenToolStripMenuItem.Name = "ProjectOpenToolStripMenuItem";
            this.ProjectOpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProjectOpenToolStripMenuItem.Text = "Project Open";
            // 
            // ProjectSaveMenuItem
            // 
            this.ProjectSaveMenuItem.Image = global::UnScripter.Properties.Resources.bookmark_folder;
            this.ProjectSaveMenuItem.Name = "ProjectSaveMenuItem";
            this.ProjectSaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProjectSaveMenuItem.Text = "Project Save";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = global::UnScripter.Properties.Resources.filenew;
            this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "&New";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::UnScripter.Properties.Resources.fileopen;
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::UnScripter.Properties.Resources.document_save;
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Image = global::UnScripter.Properties.Resources.filesaveas1;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // SaveAllToolStripMenuItem
            // 
            this.SaveAllToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_select_all;
            this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
            this.SaveAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAllToolStripMenuItem.Text = "Save All";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = global::UnScripter.Properties.Resources.document_print;
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            // 
            // PrintPreviewToolStripMenuItem
            // 
            this.PrintPreviewToolStripMenuItem.Image = global::UnScripter.Properties.Resources.document_preview;
            this.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem";
            this.PrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator5,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.FindToolStripMenuItem,
            this.FindInFilesToolStripMenuItem,
            this.ReplaceToolStripMenuItem,
            this.ReplaceInFilesToolStripMenuItem,
            this.ToolStripSeparator11,
            this.SelectAllToolStripMenuItem,
            this.ToolStripSeparator10,
            this.RenameToolStripMenuItem,
            this.GoToDeclarationToolStripMenuItem1,
            this.GoToParentToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_undo;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_redo;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RedoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = global::UnScripter.Properties.Resources.editcut;
            this.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CutToolStripMenuItem.Text = "Cu&t";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = global::UnScripter.Properties.Resources.editcopy;
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::UnScripter.Properties.Resources.editpaste;
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.Image = global::UnScripter.Properties.Resources.find;
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FindToolStripMenuItem.Text = "Find";
            // 
            // FindInFilesToolStripMenuItem
            // 
            this.FindInFilesToolStripMenuItem.Enabled = false;
            this.FindInFilesToolStripMenuItem.Name = "FindInFilesToolStripMenuItem";
            this.FindInFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FindInFilesToolStripMenuItem.Text = "Find In Files";
            // 
            // ReplaceToolStripMenuItem
            // 
            this.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem";
            this.ReplaceToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ReplaceToolStripMenuItem.Text = "Replace";
            // 
            // ReplaceInFilesToolStripMenuItem
            // 
            this.ReplaceInFilesToolStripMenuItem.Enabled = false;
            this.ReplaceInFilesToolStripMenuItem.Name = "ReplaceInFilesToolStripMenuItem";
            this.ReplaceInFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ReplaceInFilesToolStripMenuItem.Text = "Replace In Files";
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(171, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_select_all;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SelectAllToolStripMenuItem.Text = "Select &All";
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(171, 6);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Enabled = false;
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            // 
            // GoToDeclarationToolStripMenuItem1
            // 
            this.GoToDeclarationToolStripMenuItem1.Enabled = false;
            this.GoToDeclarationToolStripMenuItem1.Name = "GoToDeclarationToolStripMenuItem1";
            this.GoToDeclarationToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.GoToDeclarationToolStripMenuItem1.Text = "Go to Declaration";
            // 
            // GoToParentToolStripMenuItem
            // 
            this.GoToParentToolStripMenuItem.Name = "GoToParentToolStripMenuItem";
            this.GoToParentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.GoToParentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.GoToParentToolStripMenuItem.Text = "Go to Parent";
            // 
            // BuildToolStripMenuItem
            // 
            this.BuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildAllToolStripMenuItem,
            this.RunToolStripMenuItem,
            this.BuildAndRunToolStripMenuItem,
            this.RebuildToolStripMenuItem,
            this.ToolStripSeparator9,
            this.ErrorPreviousToolStripMenuItem,
            this.ErrorNextToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.ProjectSettingsToolStripMenuItem});
            this.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem";
            this.BuildToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.BuildToolStripMenuItem.Text = "&Build";
            // 
            // BuildAllToolStripMenuItem
            // 
            this.BuildAllToolStripMenuItem.Image = global::UnScripter.Properties.Resources.run1;
            this.BuildAllToolStripMenuItem.Name = "BuildAllToolStripMenuItem";
            this.BuildAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.BuildAllToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.BuildAllToolStripMenuItem.Text = "B&uild";
            // 
            // RunToolStripMenuItem
            // 
            this.RunToolStripMenuItem.Image = global::UnScripter.Properties.Resources._1rightarrow;
            this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
            this.RunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RunToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.RunToolStripMenuItem.Text = "&Run";
            // 
            // BuildAndRunToolStripMenuItem
            // 
            this.BuildAndRunToolStripMenuItem.Image = global::UnScripter.Properties.Resources.run_build;
            this.BuildAndRunToolStripMenuItem.Name = "BuildAndRunToolStripMenuItem";
            this.BuildAndRunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.BuildAndRunToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.BuildAndRunToolStripMenuItem.Text = "Bui&ld && Run";
            // 
            // RebuildToolStripMenuItem
            // 
            this.RebuildToolStripMenuItem.Image = global::UnScripter.Properties.Resources.rebuild;
            this.RebuildToolStripMenuItem.Name = "RebuildToolStripMenuItem";
            this.RebuildToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.RebuildToolStripMenuItem.Text = "Rebuild";
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(158, 6);
            // 
            // ErrorPreviousToolStripMenuItem
            // 
            this.ErrorPreviousToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_undo;
            this.ErrorPreviousToolStripMenuItem.Name = "ErrorPreviousToolStripMenuItem";
            this.ErrorPreviousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ErrorPreviousToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ErrorPreviousToolStripMenuItem.Text = "Error Previous";
            // 
            // ErrorNextToolStripMenuItem
            // 
            this.ErrorNextToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_redo;
            this.ErrorNextToolStripMenuItem.Name = "ErrorNextToolStripMenuItem";
            this.ErrorNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ErrorNextToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ErrorNextToolStripMenuItem.Text = "Error Next";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(158, 6);
            // 
            // ProjectSettingsToolStripMenuItem
            // 
            this.ProjectSettingsToolStripMenuItem.Enabled = false;
            this.ProjectSettingsToolStripMenuItem.Name = "ProjectSettingsToolStripMenuItem";
            this.ProjectSettingsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ProjectSettingsToolStripMenuItem.Text = "Project Settings";
            // 
            // ExternalToolStripMenuItem
            // 
            this.ExternalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnrealEditorToolStripMenuItem,
            this.UnrealLocalizerToolStripMenuItem,
            this.UnrealFrontendToolStripMenuItem,
            this.ToolStripMenuItem4,
            this.OpenConfigFolderToolStripMenuItem,
            this.ToolStripSeparator1,
            this.OpenExplorerToolStripMenuItem,
            this.OpenTerminalToolStripMenuItem});
            this.ExternalToolStripMenuItem.Name = "ExternalToolStripMenuItem";
            this.ExternalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ExternalToolStripMenuItem.Text = "E&xternal";
            // 
            // UnrealEditorToolStripMenuItem
            // 
            this.UnrealEditorToolStripMenuItem.Name = "UnrealEditorToolStripMenuItem";
            this.UnrealEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.UnrealEditorToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.UnrealEditorToolStripMenuItem.Text = "Unreal Editor";
            // 
            // UnrealLocalizerToolStripMenuItem
            // 
            this.UnrealLocalizerToolStripMenuItem.Name = "UnrealLocalizerToolStripMenuItem";
            this.UnrealLocalizerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.UnrealLocalizerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.UnrealLocalizerToolStripMenuItem.Text = "Unreal Localizer";
            // 
            // UnrealFrontendToolStripMenuItem
            // 
            this.UnrealFrontendToolStripMenuItem.Name = "UnrealFrontendToolStripMenuItem";
            this.UnrealFrontendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.UnrealFrontendToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.UnrealFrontendToolStripMenuItem.Text = "Unreal Frontend";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(210, 6);
            // 
            // OpenConfigFolderToolStripMenuItem
            // 
            this.OpenConfigFolderToolStripMenuItem.Image = global::UnScripter.Properties.Resources.compfile;
            this.OpenConfigFolderToolStripMenuItem.Name = "OpenConfigFolderToolStripMenuItem";
            this.OpenConfigFolderToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.OpenConfigFolderToolStripMenuItem.Text = "Open Config Folder";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // OpenExplorerToolStripMenuItem
            // 
            this.OpenExplorerToolStripMenuItem.Image = global::UnScripter.Properties.Resources.folder_blue;
            this.OpenExplorerToolStripMenuItem.Name = "OpenExplorerToolStripMenuItem";
            this.OpenExplorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.OpenExplorerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.OpenExplorerToolStripMenuItem.Text = "Open &Explorer";
            // 
            // OpenTerminalToolStripMenuItem
            // 
            this.OpenTerminalToolStripMenuItem.Image = global::UnScripter.Properties.Resources.utilities_terminal;
            this.OpenTerminalToolStripMenuItem.Name = "OpenTerminalToolStripMenuItem";
            this.OpenTerminalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.OpenTerminalToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.OpenTerminalToolStripMenuItem.Text = "Ope&n Terminal";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowResourcesToolStripMenuItem,
            this.PreferencesToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // ShowResourcesToolStripMenuItem
            // 
            this.ShowResourcesToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_select_all;
            this.ShowResourcesToolStripMenuItem.Name = "ShowResourcesToolStripMenuItem";
            this.ShowResourcesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.ShowResourcesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ShowResourcesToolStripMenuItem.Text = "&Show Resources";
            // 
            // PreferencesToolStripMenuItem
            // 
            this.PreferencesToolStripMenuItem.Image = global::UnScripter.Properties.Resources.games_config_options;
            this.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem";
            this.PreferencesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.PreferencesToolStripMenuItem.Text = "P&references";
            // 
            // WindowsToolStripMenuItem
            // 
            this.WindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2,
            this.FocusEditorToolStripMenuItem,
            this.ToolStripMenuItem5,
            this.ProjectViewToolStripMenuItem,
            this.ShowClassBrowserToolStripMenuItem,
            this.ErrorViewToolStripMenuItem,
            this.ConsoleOutputToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.CloseToolStripMenuItem,
            this.CloseOthersToolStripMenuItem,
            this.CloseAllToolStripMenuItem});
            this.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem";
            this.WindowsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.WindowsToolStripMenuItem.Text = "&Windows";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // FocusEditorToolStripMenuItem
            // 
            this.FocusEditorToolStripMenuItem.Image = global::UnScripter.Properties.Resources.text_block;
            this.FocusEditorToolStripMenuItem.Name = "FocusEditorToolStripMenuItem";
            this.FocusEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.FocusEditorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.FocusEditorToolStripMenuItem.Text = "Focus Editor";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(168, 6);
            // 
            // ProjectViewToolStripMenuItem
            // 
            this.ProjectViewToolStripMenuItem.Image = global::UnScripter.Properties.Resources.folder_html;
            this.ProjectViewToolStripMenuItem.Name = "ProjectViewToolStripMenuItem";
            this.ProjectViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ProjectViewToolStripMenuItem.Text = "Project Explorer";
            // 
            // ShowClassBrowserToolStripMenuItem
            // 
            this.ShowClassBrowserToolStripMenuItem.Image = global::UnScripter.Properties.Resources.world;
            this.ShowClassBrowserToolStripMenuItem.Name = "ShowClassBrowserToolStripMenuItem";
            this.ShowClassBrowserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ShowClassBrowserToolStripMenuItem.Text = "Class Browser";
            // 
            // ErrorViewToolStripMenuItem
            // 
            this.ErrorViewToolStripMenuItem.Image = global::UnScripter.Properties.Resources.mail_mark_important;
            this.ErrorViewToolStripMenuItem.Name = "ErrorViewToolStripMenuItem";
            this.ErrorViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ErrorViewToolStripMenuItem.Text = "Error View";
            // 
            // ConsoleOutputToolStripMenuItem
            // 
            this.ConsoleOutputToolStripMenuItem.Image = global::UnScripter.Properties.Resources.utilities_terminal1;
            this.ConsoleOutputToolStripMenuItem.Name = "ConsoleOutputToolStripMenuItem";
            this.ConsoleOutputToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ConsoleOutputToolStripMenuItem.Text = "Console Output";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = global::UnScripter.Properties.Resources.application_exit;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            // 
            // CloseOthersToolStripMenuItem
            // 
            this.CloseOthersToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_delete_shred;
            this.CloseOthersToolStripMenuItem.Name = "CloseOthersToolStripMenuItem";
            this.CloseOthersToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CloseOthersToolStripMenuItem.Text = "Close Others";
            // 
            // CloseAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Image = global::UnScripter.Properties.Resources.edit_delete_shred;
            this.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CloseAllToolStripMenuItem.Text = "Close All";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.HelpToolStripMenuItem.Text = "&About";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::UnScripter.Properties.Resources.help_about;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.AboutToolStripMenuItem.Text = "&About...";
            // 
            // DockPanel
            // 
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            this.DockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.DockPanel.Location = new System.Drawing.Point(0, 49);
            this.DockPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(688, 459);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.DockPanel.Skin = dockPanelSkin1;
            this.DockPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(688, 540);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "{Application.Name}";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal StatusStrip StatusStrip;
		internal ToolStrip ToolStrip;
		internal MenuStrip MenuStrip;
		internal ToolStripButton NewToolStripButton;
		internal ToolStripButton OpenToolStripButton;
		internal ToolStripButton SaveToolStripButton;
		internal ToolStripSeparator toolStripSeparator;
		internal ToolStripMenuItem FileToolStripMenuItem;
		internal ToolStripMenuItem NewToolStripMenuItem;
		internal ToolStripMenuItem OpenToolStripMenuItem;
		internal ToolStripSeparator toolStripSeparator2;
		internal ToolStripMenuItem SaveToolStripMenuItem;
		internal ToolStripMenuItem SaveAsToolStripMenuItem;
		internal ToolStripSeparator toolStripSeparator3;
		internal ToolStripMenuItem PrintToolStripMenuItem;
		internal ToolStripMenuItem PrintPreviewToolStripMenuItem;
		internal ToolStripSeparator toolStripSeparator4;
		internal ToolStripMenuItem ExitToolStripMenuItem;
		internal ToolStripMenuItem EditToolStripMenuItem;
		internal ToolStripMenuItem UndoToolStripMenuItem;
		internal ToolStripMenuItem RedoToolStripMenuItem;
		internal ToolStripSeparator toolStripSeparator5;
		internal ToolStripMenuItem CutToolStripMenuItem;
		internal ToolStripMenuItem CopyToolStripMenuItem;
		internal ToolStripMenuItem PasteToolStripMenuItem;
		internal ToolStripSeparator toolStripSeparator6;
		internal ToolStripMenuItem SelectAllToolStripMenuItem;
		internal ToolStripMenuItem HelpToolStripMenuItem;
		internal ToolStripMenuItem AboutToolStripMenuItem;
		internal ToolStripMenuItem ToolsToolStripMenuItem;
		internal ToolStripButton ShowResDialogToolStripButton;
		internal ToolStripMenuItem ShowResourcesToolStripMenuItem;
		internal ToolStripMenuItem PreferencesToolStripMenuItem;
		internal ToolStripMenuItem WindowsToolStripMenuItem;
		internal ToolStripMenuItem FindToolStripMenuItem;
		internal ToolStripMenuItem FindInFilesToolStripMenuItem;
		internal ToolStripMenuItem ReplaceToolStripMenuItem;
		internal ToolStripMenuItem ReplaceInFilesToolStripMenuItem;
		internal ToolStripSeparator ToolStripSeparator11;
		internal ToolStripSeparator ToolStripSeparator10;
		internal ToolStripMenuItem GoToDeclarationToolStripMenuItem1;
		internal ToolStripMenuItem RenameToolStripMenuItem;
		internal ToolStripMenuItem BuildToolStripMenuItem;
		internal ToolStripMenuItem BuildAllToolStripMenuItem;
		internal ToolStripMenuItem BuildAndRunToolStripMenuItem;
		internal ToolStripMenuItem RunToolStripMenuItem;
		internal ToolStripMenuItem ExternalToolStripMenuItem;
		internal ToolStripMenuItem UnrealLocalizerToolStripMenuItem;
		internal ToolStripMenuItem OpenExplorerToolStripMenuItem;
		internal ToolStripMenuItem OpenTerminalToolStripMenuItem;
		internal ToolStripMenuItem UnrealFrontendToolStripMenuItem;
		internal ToolStripSeparator ToolStripSeparator1;
		internal ToolStripButton ProjectNewToolStripButton;
		internal ToolStripButton ProjectOpenToolStripButton;
		internal ToolStripSeparator ToolStripSeparator8;
		internal ToolStripMenuItem ProjectNewToolStripMenuItem;
		internal ToolStripMenuItem ProjectOpenToolStripMenuItem;
		internal ToolStripSeparator ToolStripSeparator7;
		internal ToolStripMenuItem UnrealEditorToolStripMenuItem;
		internal ToolStripButton ProjectSaveToolStripButton;
		internal ToolStripMenuItem ProjectSaveMenuItem;
		internal ToolStripMenuItem SaveAllToolStripMenuItem;
		internal ToolStripButton SaveAllToolStripButton;
		internal ToolStripStatusLabel BuildMessageStatusLabel;
		internal ToolStripSeparator ToolStripSeparator9;
		internal ToolStripMenuItem ErrorNextToolStripMenuItem;
		internal ToolStripMenuItem ErrorPreviousToolStripMenuItem;
		internal ToolStripProgressBar ProgressBarStatusBar;
		internal BackgroundWorker BuildWorker;
		internal BackgroundWorker UnrealParserWorker;
		internal ToolStripStatusLabel ParserStatusLabel;
		internal ToolStripProgressBar ParserStatusProgressBar;
		internal ToolStripStatusLabel FileStatusLabel;
		internal ToolStripMenuItem ProjectViewToolStripMenuItem;
		internal ToolStripMenuItem ErrorViewToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem1;
		internal ToolStripMenuItem CloseToolStripMenuItem;
		internal ToolStripMenuItem CloseAllToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem2;
		internal ToolStripMenuItem CloseOthersToolStripMenuItem;
		internal ToolStripMenuItem FocusEditorToolStripMenuItem;
		internal ToolStripButton PreferencesToolStripButton;
		internal ToolStripSeparator ToolStripMenuItem3;
		internal ToolStripMenuItem ProjectSettingsToolStripMenuItem;
		internal ToolStripMenuItem RebuildToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem4;
		internal ToolStripMenuItem OpenConfigFolderToolStripMenuItem;
        internal DockPanel DockPanel;
		internal ToolStripMenuItem ShowClassBrowserToolStripMenuItem;
		internal ToolStripMenuItem ConsoleOutputToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem5;

		internal ToolStripMenuItem GoToParentToolStripMenuItem;
	}
}
