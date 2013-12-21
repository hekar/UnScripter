using Ninject;
using System.Windows.Forms;

namespace UnScripter
{
    [System.ComponentModel.DesignerCategory("")]
    class EditorOptionPage : OptionPage
    {
        // TODO: private
        public CheckBox FlatTabs;
        public CheckBox ShowLineNumbers;

        private readonly EditorTabManager editorTabManager;
        private UiSettings uiSettings;
        private EditorSettings editorSettings;

        [Inject]
        public EditorOptionPage(EditorTabManager editorTabManager, UiSettings uiSettings, EditorSettings editorSettings)
        {
            this.editorTabManager = editorTabManager;
            this.uiSettings = uiSettings;
            this.editorSettings = editorSettings;
            InitializeComponent();
        }

        public override void OnApplySettings()
        {
            if (FlatTabs.Checked)
            {
                editorTabManager.TabControl.Appearance = TabAppearance.FlatButtons;
            }
            else
            {
                editorTabManager.TabControl.Appearance = TabAppearance.Normal;
            }

            uiSettings.SetTrait<bool>("FlatTabs", FlatTabs.Checked);

            foreach (var etab in editorTabManager.TabPages)
            {
                EditorTabPage editortab = (EditorTabPage)etab;

                // TODO: Line numbers
                //editortab.ScintillaEditor = ShowLineNumbers.Checked;
                editorSettings.SetTrait<bool>("LineNumbers", ShowLineNumbers.Checked);
            }

        }

        public override void OnLoadSettings()
        {
            bool flattab = uiSettings.GetTrait("FlatTabs", true);

            FlatTabs.Checked = flattab;

            bool linenumbers = editorSettings.GetTrait("LineNumbers", true);
            ShowLineNumbers.Checked = linenumbers;
        }

        private void InitializeComponent()
        {
            this.ShowLineNumbers = new System.Windows.Forms.CheckBox();
            this.FlatTabs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ShowLineNumbers
            // 
            this.ShowLineNumbers.Location = new System.Drawing.Point(10, 10);
            this.ShowLineNumbers.Name = "ShowLineNumbers";
            this.ShowLineNumbers.Size = new System.Drawing.Size(200, 24);
            this.ShowLineNumbers.TabIndex = 0;
            this.ShowLineNumbers.Text = "Show Line Numbers";
            this.ShowLineNumbers.UseVisualStyleBackColor = true;
            // 
            // FlatTabs
            // 
            this.FlatTabs.Location = new System.Drawing.Point(10, 30);
            this.FlatTabs.Name = "FlatTabs";
            this.FlatTabs.Size = new System.Drawing.Size(150, 24);
            this.FlatTabs.TabIndex = 1;
            this.FlatTabs.Text = "Use Flat Tabs";
            this.FlatTabs.UseVisualStyleBackColor = true;
            // 
            // EditorOptionPage
            // 
            this.Controls.Add(this.ShowLineNumbers);
            this.Controls.Add(this.FlatTabs);
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

    }
}
