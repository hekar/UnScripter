using System.IO;
using UnScripterPlugin;

namespace UnScripter
{
    /// <summary>
    /// TODO: kill this class with fire
    /// </summary>
    public class Globals
    {
        public const string ApplicationName = "UnScripter";
        public static readonly string DefaultExplorer = 
            Path.Combine("C:", "Windows", "explorer.exe");
        public static readonly string DefaultEditor = 
            Path.Combine("C:", "Windows", "notepad.exe");

        public static readonly string DefaultTerminal = 
            Path.Combine("scripts", "cmd_udk.bat");

        public const bool UseFileTree = true;
        public const string ProjectFileRegex = "^*\\.uc$";

        public static readonly string DefaultUDKFolder = 
            Path.Combine("C:", "UDK", "UDK-2010-07") + Path.DirectorySeparatorChar;
        public static readonly string DefaultUDKDevelopmentFolder =
            Path.Combine(DefaultUDKFolder, "Development", "Src") + Path.DirectorySeparatorChar;

        public static bool ExecuteStandaloneOnBuildFinished { get; set; }
    }
}

