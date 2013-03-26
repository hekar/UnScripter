using Ninject;
using System.Collections.Generic;

namespace UnScripter
{
    partial class OptionsDialog
    {
        private List<OptionPage> optionspage = new List<OptionPage>();

        [Inject]
        public OptionsDialog(FileViewOptionsPage fileViewOptionsPage,
            EditorOptionPage editorOptionPage, EditorThemeOptionPage editorThemeOptionPage)
        {
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            AddOptionsPage(fileViewOptionsPage);
            AddOptionsPage(editorOptionPage);
            AddOptionsPage(editorThemeOptionPage);
        }

        private void OptionsDialog_Load(System.Object sender, System.EventArgs e)
        {
        }

        private void OptionTabPages_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            OptionPage optiontab = (OptionPage)OptionTabPages.SelectedTab;
            optiontab.OnFocus();
        }

        private void OptionsDialog_Shown(System.Object sender, System.EventArgs e)
        {
            foreach (var optionpage in optionspage)
            {
                optionpage.OnLoadSettings();
            }

            OptionPage optiontab = (OptionPage)OptionTabPages.SelectedTab;
            optiontab.OnFocus();
        }

        public void AddOptionsPage(OptionPage optionpage)
        {
            optionspage.Add(optionpage);
            OptionTabPages.TabPages.Add(optionpage);
        }

        private void OK_Button_Click(System.Object sender, System.EventArgs e)
        {
            foreach (var optionpage in optionspage)
            {
                optionpage.OnApplySettings();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(System.Object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
