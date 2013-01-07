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
using System.IO;
using Ninject;
using UnScripter.Unreal;

namespace UnScripter.Project
{
    class ProjectFile
    {
        public string FullName { get; private set; }

        public string FileName
        {
            get
            {
                int lastslash = FullName.LastIndexOf("\\");
                if (lastslash >= 0)
                {
                    return FullName.Substring(lastslash + 1, FullName.Length - lastslash - 1);
                }
                else
                {
                    return FullName;
                }
            }
        }

        private string _filecontents = "";
        public string FileContents
        {
            get
            {
                LoadContents();
                return _filecontents;
            }
            set
            {
                _filecontents = value;
                SaveContents();
            }
        }

        public string Directory
        {
            get
            {
                var lastslash = FullName.LastIndexOf("\\");
                return FullName.Substring(0, lastslash);
            }
        }

        public UnrealClass UnrealClass { get; private set; }

        [Inject]
        public ProjectFile(string fullname)
        {
            this.FullName = fullname;
            this.UnrealClass = new Unreal.UnrealClass(fullname);
        }

        public void ParseUnrealScript()
        {
            UnrealClass.Parse();
        }

        private void LoadContents()
        {
            StreamReader reader = new StreamReader(FullName);
            _filecontents = reader.ReadToEnd();
            reader.Close();
        }

        public void SaveContents()
        {
            StreamWriter writer = new StreamWriter(FullName);
            writer.Write(_filecontents);
            writer.Close();

            //mainForm.FileStatusLabel.Text = "Saved: " + FileName;
        }

        public void OpenPath()
        {
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.kDefaultExplorer;
            startinfo.Arguments = Directory;
            proc.StartInfo = startinfo;
            proc.Start();
        }

        // Open an external editor
        public void OpenEditor()
        {
            // TODO: Add in default editor
            Process proc = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Globals.kDefaultEditor;
            startinfo.Arguments = FullName;
            proc.StartInfo = startinfo;
            proc.Start();
        }
    }
}
