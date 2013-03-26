using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnScripter
{

    partial class ResourceDialog
    {
        private readonly ProjectManager projectManager;

        public ResourceDialog(ProjectManager projectManager)
        {
            this.projectManager = projectManager;

            Shown += ResourceDialog_Shown;
            Load += ResourceDialog_Load;

            InitializeComponent();
        }

        private void ResourceDialog_Load(Object sender, EventArgs e)
        {
            CenterToScreen();

            SearchResults.SelectedIndex = 0;
        }

        private void ResourceDialog_Shown(Object sender, EventArgs e)
        {
            // Dirty hack to default select the search box on opening
            SelectNextControl(SearchLabel, true, true, false, false);
        }

        private void OK_Button_Click(Object sender, EventArgs e)
        {
            if (InSearchResultItemRange(SearchResults.SelectedIndex))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                _selectedfullname = projectManager.CurrentProject.DevelopmentFolder + 
                    Convert.ToString(SearchResults.Items[SearchResults.SelectedIndex]);
                this.Close();
            }
            else
            {
                // This should never happen, but if it does...
                throw new ArgumentOutOfRangeException("No Filename selected or Filename selected is not in range");
            }
        }

        private void Cancel_Button_Click(Object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        // Filter the search results according to the SearchBox
        private void SearchBox_TextChanged(Object sender, EventArgs e)
        {
            SearchResults.Items.Clear();
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                SearchResults.Items.AddRange(_files.ToArray());
            }
            else
            {
                for (int i = 0; i <= _files.Count - 1; i++)
                {
                    if (_files[i].ToLower().IndexOf(SearchBox.Text.ToLower()) >= 0)
                    {
                        SearchResults.Items.Add(_files[i]);
                    }
                }
            }

            // Select the first index if there are items
            if (SearchResults.Items.Count > 0)
            {
                SearchResults.SelectedIndex = 0;
            }

            OK_Button.Enabled = InSearchResultItemRange(SearchResults.SelectedIndex);
        }

        private void SearchResults_SelectedIndexChanged(Object sender, EventArgs e)
        {
            OK_Button.Enabled = InSearchResultItemRange(SearchResults.SelectedIndex);
        }

        private void SearchResults_MouseDoubleClick(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (InSearchResultItemRange(SearchResults.SelectedIndex))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                _selectedfullname = projectManager.CurrentProject.DevelopmentFolder + 
                    Convert.ToString(SearchResults.Items[SearchResults.SelectedIndex]);
                this.Close();
            }
        }

        private List<string> _files;
        public List<string> Files
        {
            set
            {
                _files = value;
                SearchResults.Items.AddRange(value.ToArray());
            }
        }

        private string _selectedfullname = "";
        public string SelectedFullName
        {
            get { return _selectedfullname; }
        }

        private bool InSearchResultItemRange(int index)
        {
            if (index >= 0 & index < SearchResults.Items.Count)
            {
                return true;
            }

            return false;
        }

        private void SearchBox_KeyDown(Object sender, KeyEventArgs e)
        {
            int newindex = SearchResults.SelectedIndex;
            if (e.KeyCode == Keys.Up)
            {
                newindex -= 1;
            }
            else if (e.KeyCode == Keys.Down)
            {
                newindex += 1;
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                newindex -= SearchResults.ItemHeight;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                newindex += SearchResults.ItemHeight;
                if (!InSearchResultItemRange(newindex))
                {
                    newindex = SearchResults.Items.Count - 1;
                }
            }
            else if (e.KeyCode == Keys.Home)
            {
                newindex = 0;
            }
            else if (e.KeyCode == Keys.End)
            {
                newindex = SearchResults.Items.Count - 1;
            }

            if (InSearchResultItemRange(newindex))
            {
                SearchResults.SelectedIndex = newindex;
            }

        }
    }
}
