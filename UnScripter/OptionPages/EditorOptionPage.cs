using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using Ninject;

namespace UnScripter
{
    class EditorOptionPage : OptionPage
    {
        // TODO: private
        public CheckBox FlatTabs;
        public CheckBox ShowLineNumbers;

        private EditorTabManager editorTabManager;

        [Inject]
        public EditorOptionPage(EditorTabManager editorTabManager)
        {
            this.editorTabManager = editorTabManager;
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

            Globals.UISettings.SetTrait<bool>("FlatTabs", FlatTabs.Checked);

            foreach (var etab in editorTabManager.TabPages)
            {
                EditorTabPage editortab = (EditorTabPage)etab;

                // TODO: Line numbers
                //editortab.ScintillaEditor = ShowLineNumbers.Checked;
                Globals.EditorSettings.SetTrait<bool>("LineNumbers", ShowLineNumbers.Checked);
            }

        }

        public override void OnLoadSettings()
        {
            bool flattab = Globals.UISettings.GetTrait("FlatTabs", true);

            FlatTabs.Checked = flattab;

            bool linenumbers = Globals.EditorSettings.GetTrait("LineNumbers", true);

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
