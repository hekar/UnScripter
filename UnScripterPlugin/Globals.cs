using UnScripterPlugin.Build;

namespace UnScripter
{
    /// <summary>
    /// TODO: kill this class with fire
    /// </summary>
    public class Globals
    {
        public const string ApplicationName = "UnScripter";
        public const string DefaultExplorer = "C:\\Windows\\explorer.exe";
        public const string DefaultEditor = "C:\\Windows\\notepad.exe";

        public const string DefaultTerminal = "\\scripts\\cmd_udk.bat";

        public const bool UseFileTree = true;
        // Project restart is required for the changing of any of these variables!
        public const string ProjectFileRegex = "^*\\.uc$";

        public const string DefaultUDKFolder = "C:\\UDK\\UDK-2010-07\\";

        public static string DefaultUDKDevelopmentFolder = DefaultUDKFolder + "Development\\Src\\";

        public static bool ExecuteStandaloneOnBuildFinished { get; set; }
    }
}

