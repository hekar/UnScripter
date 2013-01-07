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

namespace UnScripter
{
    /// <summary>
    /// TODO: kill this class with fire
    /// </summary>
    class Globals
    {
        public const string kApplicationName = "UnScripter";
        public const string kDefaultExplorer = "C:\\Windows\\explorer.exe";
        public const string kDefaultEditor = "C:\\Windows\\notepad.exe";

        public const string kDefaultTerminal = "\\scripts\\cmd_udk.bat";

        public const bool kUseFileTree = true;
        // Project restart is required for the changing of any of these variables!
        public const string kProjectFileRegex = "^*\\.uc$";

        public const string kDefaultUDKFolder = "C:\\UDK\\UDK-2010-07\\";

        public static string kDefaultUDKDevelopmentFolder = kDefaultUDKFolder + "Development\\Src\\";
        public static Settings Settings;
        public static Settings EditorSettings;

        public static Settings UISettings;
        public static bool ExecuteStandaloneOnBuildFinished { get; set; }
        public static Build.Compile Compiler { get; set; }
        public static Build.Run Run { get; set; }

        private static Project.Project _currentproject;
        public static Project.Project CurrentProject
        {
            get { return _currentproject; }
            set
            {
                _currentproject = value;
                //projectManager.ChangeProject(_currentproject);
            }
        }

    }
}

