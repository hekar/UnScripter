using System;
using System.Windows.Forms;
using ScintillaNET;
using ScintillaNET.Configuration;
using UnScripter.Project;
using UnScripterPlugin.Project;

[System.ComponentModel.DesignerCategory("")]
class EditorTabPage : TabPage
{
    private bool firstchange = true;
    public EditorTabPage(string name, ProjectFile projectfile)
    {
        this.projectfile = projectfile;
    }

    private ProjectFile projectfile;
    public ProjectFile ProjectFile
    {
        get { return projectfile; }
    }

    // Return fullname of file open in tab
    public string FullName
    {
        get { return projectfile.FullName; }
    }

    private Scintilla scintila;
    public Scintilla ScintillaEditor
    {
        get { return scintila; }
    }

    public void OnControlAdded(object sender, EventArgs e)
    {
        scintila = (Scintilla)Controls[0];
    }

    public void OnEditorTextChanged()
    {
        if (firstchange)
        {
            // Do not change the fact that we haven't saved the file
            firstchange = false;
        }
        else
        {
            projectfilesaved = false;
        }
    }

    private bool projectfilesaved = true;
    public bool ShouldCloseTab()
    {

        if (!projectfilesaved)
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
        projectfile.FileContents = scintila.Text;
        projectfilesaved = true;
    }

    public DialogResult ShowSaveFileDialog()
    {
        throw new NotImplementedException();
    }
}
