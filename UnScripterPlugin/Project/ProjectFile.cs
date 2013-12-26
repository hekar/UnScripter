using Ninject;
using System.Diagnostics;
using System.IO;
using UnScripter;
using UnScripter.Unreal;

namespace UnScripterPlugin.Project
{
    public class ProjectFile
    {
        public string FullName { get; private set; }

        public string FileName
        {
            get
            {
                return Path.GetFileName(FullName);
            }
        }

        private string filecontents = "";
        public string FileContents
        {
            get
            {
                LoadContents();
                return filecontents;
            }
            set
            {
                filecontents = value;
                SaveContents();
            }
        }

        public string Directory
        {
            get
            {
                return Path.GetDirectoryName(FullName);
            }
        }

        public UnrealClass UnrealClass { get; private set; }

        [Inject]
        public ProjectFile(string fullname)
        {
            this.FullName = fullname;
            this.UnrealClass = new UnrealClass(fullname);
        }

        public void ParseUnrealScript()
        {
            UnrealClass.Parse();
        }

        private void LoadContents()
        {
            StreamReader reader = new StreamReader(FullName);
            filecontents = reader.ReadToEnd();
            reader.Close();
        }

        public void SaveContents()
        {
            StreamWriter writer = new StreamWriter(FullName);
            writer.Write(filecontents);
            writer.Close();

            //mainForm.FileStatusLabel.Text = "Saved: " + FileName;
        }

        public void OpenPath()
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.DefaultExplorer;
            startinfo.Arguments = Directory;
            proc.StartInfo = startinfo;
            proc.Start();
        }

        // Open an external editor
        public void OpenInSystemEditor()
        {
            // TODO: Add in default editor
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.DefaultEditor;
            startinfo.Arguments = FullName;
            proc.StartInfo = startinfo;
            proc.Start();
        }
    }
}
