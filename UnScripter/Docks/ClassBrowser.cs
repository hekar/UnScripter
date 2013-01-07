using Ninject;
using System.Drawing;
using System.Windows.Forms;

namespace UnScripter
{
    class ClassView : TreeView
    {
        private EditorTabManager editorTabManager;
        private ProjectManager projectManager;

        [Inject]
        public ClassView(EditorTabManager editorTabManager, ProjectManager projectManager)
        {
            this.editorTabManager = editorTabManager;
            this.projectManager = projectManager;
            DoubleClick += ClassView_DoubleClick;
            KeyDown += ClassView_KeyDown;
            Font = new Font("Segoe UI", 9.5f);
            Nodes.Add("Loading...");
        }

        private void ClassView_KeyDown(System.Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSelectedNodeEditorTab();
            }
        }

        private void ClassView_DoubleClick(System.Object sender, System.EventArgs e)
        {
            OpenSelectedNodeEditorTab();
        }

        private void OpenSelectedNodeEditorTab()
        {
            if (projectManager.ProjectOpen)
            {
                var curproj = Globals.CurrentProject;
                if (SelectedNode.Parent == null)
                {
                    // We clicked a class
                    string classname = SelectedNode.Text;
                    var projfile = curproj.FileList.GetProjectFileByClassName(classname);
                    var tab = editorTabManager.AddTab(projfile.FileName, projfile);
                    tab.ScintillaEditor.Focus();
                }
                else
                {
                    // We clicked a function or variable
                    string classname = SelectedNode.Parent.Text;
                    var projfile = curproj.FileList.GetProjectFileByClassName(classname);

                    var tab = editorTabManager.AddTab(projfile.FileName, projfile);

                    string signature = SelectedNode.Text;
                    var func = projfile.UnrealClass.GetFunctionBySignature(signature);

                    // TODO: Replace null checks with mocks
                    if (func == null)
                    {
                        // It isn't a function
                        var variable = projfile.UnrealClass.GetVariableBySignature(signature);
                        if (variable != null)
                        {
                            // It's a variable!
                            tab.ScintillaEditor.GoTo.Line(variable.LineNumber);
                            tab.ScintillaEditor.Caret.LineNumber = variable.LineNumber - 1;
                            tab.ScintillaEditor.Focus();
                        }
                    }
                    else
                    {
                        tab.ScintillaEditor.GoTo.Line(func.LineNumber);
                        tab.ScintillaEditor.Caret.LineNumber = func.LineNumber - 1;
                        tab.ScintillaEditor.Focus();
                    }
                }
            }
        }
    }
}
