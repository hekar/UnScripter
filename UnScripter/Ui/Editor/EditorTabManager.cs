using Ninject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnScripter.Project;
using UnScripterPlugin.Project;

namespace UnScripter
{
    class EditorTabManager
    {
        public TabPage TabClicked { get; set; }

        private readonly Dictionary<string, ProjectFile> projectfiles = new Dictionary<string, ProjectFile>();

        public TabControl Tabs { get; set; }

        [Inject]
        public EditorTabManager()
        {
        }

        private ProjectFile selectedtabprojectfile;
        private string selectedtabname = "";
        public EditorTabPage AddTab(string name, ProjectFile projectFile)
        {
            TabPage tab = null;
            if (projectfiles.ContainsKey(name))
            {
                // Select the page
                tab = Tabs.TabPages[name];
            }
            else
            {
                var editor = new ScintillaEditor();
                var editorTab =  new EditorTabPage(name, projectFile, editor);
                Tabs.TabPages.Add(editorTab);
                tab = Tabs.TabPages[Tabs.TabPages.Count - 1];
                tab.Name = name;
                tab.Text = name;
                tab.Controls.Add(editor);
                tab.Controls[tab.Controls.Count - 1].Text = projectFile.FileContents;
                projectfiles.Add(name, projectFile);
            }

            selectedtabname = name;
            selectedtabprojectfile = projectFile;

            Tabs.SelectedTab = tab;

            return (EditorTabPage)tab;
        }

        public void SaveCurrentTab()
        {
            if ((CurrentTab != null))
            {
                CurrentTab.SaveFile();
            }
        }

        public void SaveAsTab()
        {
            throw new NotImplementedException();
            // CurrentTab.ShowSaveFileDialog()
        }

        public void SaveAllTabs()
        {
            for (int i = 0; i <= Tabs.TabCount - 1; i++)
            {
                EditorTabPage tab = (EditorTabPage)Tabs.TabPages[i];
                tab.SaveFile();
            }
        }

        public void CloseTab(string name)
        {
            var tab = Tabs.TabPages[name];
            CloseTab(tab);
        }

        public void CloseTab(TabPage tab)
        {
            if ((tab != null))
            {
                if (CurrentTab.ShouldCloseTab())
                {
                    projectfiles.Remove(tab.Name);
                    Tabs.TabPages.Remove(tab);
                }
            }
        }

        public void CloseCurrentTab()
        {
            if (Tabs.SelectedIndex >= 0 & Tabs.SelectedIndex < Tabs.TabPages.Count)
            {
                CloseTab(CurrentTab);
                //Tabs.TabPages.RemoveAt(Tabs.SelectedIndex)
            }
        }

        public void CloseOthers(TabPage tab)
        {
            // Close in reverse order

            for (int i = Tabs.TabCount - 1; i >= 0; i += -1)
            {
                var tabtoclose = Tabs.TabPages[i];
                if (tabtoclose.Name != tab.Name)
                {
                    CloseTab(tabtoclose);
                }
            }
        }

        public void CloseAll()
        {
            Tabs.TabPages.Clear();
        }

        public void ChangeThemes(string themepath)
        {
            foreach (var tabpage in Tabs.TabPages)
            {
                var editortab = (EditorTabPage)tabpage;
                //editortab.ScintillaEditor.ChangeTheme(themepath);
            }
        }

        public EditorTabPage CurrentTab
        {
            get
            {
                if (Tabs.SelectedIndex >= 0 & Tabs.SelectedIndex < Tabs.TabCount)
                {
                    return (EditorTabPage)Tabs.TabPages[Tabs.SelectedIndex];
                }
                else
                {
                    return null;
                }
            }
        }

        public ProjectFile CurrentTabProjectFile
        {
            get { return CurrentTab.ProjectFile; }
        }

        public string SelectedTabName
        {
            get { return selectedtabname; }
        }

        public EditorTabPage SelectedTab
        {
            get
            {
                EditorTabPage selectedTab = default(EditorTabPage);
                selectedTab = (EditorTabPage)Tabs.TabPages[selectedtabname];

                return selectedTab;
            }
        }

        public ProjectFile SelectedTabProjectFile
        {
            get { return selectedtabprojectfile; }
        }

        public TabControl TabControl
        {
            get { return Tabs; }
        }

        public TabControl.TabPageCollection TabPages
        {
            get { return Tabs.TabPages; }
        }

        public int TabCount
        {
            get { return Tabs.TabCount; }
        }

    }
}
