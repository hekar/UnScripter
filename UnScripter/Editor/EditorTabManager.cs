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
    class EditorTabManager
    {
        public TabPage TabClicked { get; set; }

        private Dictionary<string, Project.ProjectFile> _projectfiles = new Dictionary<string, Project.ProjectFile>();
        public TabControl Tabs { get; set; }

        [Inject]
        public EditorTabManager()
        {
        }

        private Project.ProjectFile _selectedtabprojectfile;
        private string _selectedtabname = "";
        public EditorTabPage AddTab(string name, Project.ProjectFile projecfile)
        {
            TabPage tab = null;
            if (_projectfiles.ContainsKey(name))
            {
                // Select the page
                tab = Tabs.TabPages[name];
            }
            else
            {
                Tabs.TabPages.Add(new EditorTabPage(name, projecfile));
                tab = Tabs.TabPages[Tabs.TabPages.Count - 1];
                tab.Name = name;
                tab.Text = name;
                tab.Controls.Add(new ScintillaEditor());
                tab.Controls[tab.Controls.Count - 1].Text = projecfile.FileContents;
                _projectfiles.Add(name, projecfile);
            }

            _selectedtabname = name;
            _selectedtabprojectfile = projecfile;

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
                    _projectfiles.Remove(tab.Name);
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

        public Project.ProjectFile CurrentTabProjectFile
        {
            get { return CurrentTab.ProjectFile; }
        }

        public string SelectedTabName
        {
            get { return _selectedtabname; }
        }

        public EditorTabPage SelectedTab
        {
            get
            {
                EditorTabPage selected_tab = default(EditorTabPage);
                selected_tab = (EditorTabPage)Tabs.TabPages[_selectedtabname];

                return selected_tab;
            }
        }

        public Project.ProjectFile SelectedTabProjectFile
        {
            get { return _selectedtabprojectfile; }
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
