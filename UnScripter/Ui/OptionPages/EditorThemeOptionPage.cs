using Ninject;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnScripter
{
    class EditorThemeOptionPage : OptionPage
    {
        private PictureBox ThemePreviewBox;
        private ListBox ThemeSelectionBox;

        private const string kThemeDir = "themes";

        private EditorTabManager editorTabManager;
        private EditorSettings editorSettings;

        [Inject]
        public EditorThemeOptionPage(EditorTabManager editorTabManager, EditorSettings editorSettings)
        {
            this.editorTabManager = editorTabManager;
            this.editorSettings = editorSettings;
            InitializeComponent();
        }

        public override void OnApplySettings()
        {
            var path = Path.Combine(kThemeDir, ThemeSelectionBox.SelectedItem.ToString().ToLower());
            var themename = String.Format("%s.xml", path);
            editorTabManager.ChangeThemes(themename);

            editorSettings.SetTrait("EditorTheme", themename);
        }

        public override void OnLoadSettings()
        {
            LoadThemeList();
        }

        public override void OnFocus()
        {
            ThemeSelectionBox.Focus();
        }

        public void LoadThemeList()
        {
            ThemeSelectionBox.Items.Clear();

            var dir = new DirectoryInfo(kThemeDir);
            foreach (var themefile in dir.GetFiles())
            {
                if (themefile.Name.EndsWith(".xml"))
                {
                    var themename = themefile.Name.Replace(".xml", "");
                    themename = themename.ToUpper()[0] + themename.Substring(1, themename.Count() - 1);
                    ThemeSelectionBox.Items.Add(themename);
                }
            }

            var lasttheme = editorSettings.GetTrait("EditorTheme", Path.Combine(kThemeDir, "dark.xml"));
            for (int i = 0; i <= ThemeSelectionBox.Items.Count - 1; i++)
            {
                // Select the first element by default
                var themename = Path.Combine(kThemeDir, ThemeSelectionBox.Items[i].ToString().ToLower()) + ".xml";
                if (themename == lasttheme)
                {
                    ThemeSelectionBox.SelectedIndex = i;
                }
            }
        }

        private void ThemeSelectionBox_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            // Change the Preview Picture according to the selected theme
            var themepic = Path.Combine(kThemeDir, ThemeSelectionBox.SelectedItem.ToString().ToLower()) + ".png";
            try
            {
                ThemePreviewBox.Image = Image.FromFile(themepic);
            }
            catch (Exception)
            {
                // Ignore 
                ThemePreviewBox.Image = null;
            }
        }

        private void InitializeComponent()
        {
            this.ThemeSelectionBox = new System.Windows.Forms.ListBox();
            this.ThemePreviewBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThemePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeSelectionBox
            // 
            this.ThemeSelectionBox.FormattingEnabled = true;
            this.ThemeSelectionBox.Location = new System.Drawing.Point(10, 10);
            this.ThemeSelectionBox.Name = "ThemeSelectionBox";
            this.ThemeSelectionBox.Size = new System.Drawing.Size(400, 400);
            this.ThemeSelectionBox.TabIndex = 0;
            this.ThemeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.ThemeSelectionBox_SelectedIndexChanged);
            // 
            // ThemePreviewBox
            // 
            this.ThemePreviewBox.Location = new System.Drawing.Point(430, 10);
            this.ThemePreviewBox.Name = "ThemePreviewBox";
            this.ThemePreviewBox.Size = new System.Drawing.Size(450, 390);
            this.ThemePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThemePreviewBox.TabIndex = 0;
            this.ThemePreviewBox.TabStop = false;
            // 
            // EditorThemeOptionPage
            // 
            this.Controls.Add(this.ThemePreviewBox);
            this.Controls.Add(this.ThemeSelectionBox);
            this.Text = "Themes";
            ((System.ComponentModel.ISupportInitialize)(this.ThemePreviewBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
