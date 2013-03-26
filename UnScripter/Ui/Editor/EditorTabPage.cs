using System;
using System.Windows.Forms;
using ScintillaNET;
using ScintillaNET.Configuration;
using UnScripter.Project;
using UnScripterPlugin.Project;

class EditorTabPage : TabPage
{
    private bool _firstchange = true;
    public EditorTabPage(string name, ProjectFile projectfile)
    {
        _projectfile = projectfile;
    }

    private ProjectFile _projectfile;
    public ProjectFile ProjectFile
    {
        get { return _projectfile; }
    }

    // Return fullname of file open in tab
    public string FullName
    {
        get { return _projectfile.FullName; }
    }

    private Scintilla _scintila;
    public Scintilla ScintillaEditor
    {
        get { return _scintila; }
    }

    // TODO: Fix for C#
    public void OnControlAdded(object sender, EventArgs e)
    {
        _scintila = (Scintilla)Controls[0];
    }

    // TODO: Fix for C#
    public void OnEditorTextChanged()
    {
        if (_firstchange)
        {
            // Do not change the fact that we haven't saved the file
            _firstchange = false;
        }
        else
        {
            _projectfilesaved = false;
        }
    }

    private bool _projectfilesaved = true;
    public bool ShouldCloseTab()
    {

        if (!_projectfilesaved)
        {
            // Ask if really want to quit and if want to save project file
            var result = MessageBox.Show("Do you want to save before closing?", "Save File?", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Save File...
                SaveFile();
                return true;
            }
            else if (result == DialogResult.No)
            {
                // Close it without saving
                return true;
            }
            else if (result == DialogResult.Cancel)
            {
                return false;
            }

            return false;
        }
        else
        {
            return true;
        }

    }

    public void SaveFile()
    {
        _projectfile.FileContents = _scintila.Text;
        _projectfilesaved = true;
    }

    public DialogResult ShowSaveFileDialog()
    {
        throw new NotImplementedException();
    }
}
