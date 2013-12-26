
namespace UnScripterPlugin.Project
{
    public interface UsProject
    {
        /// <summary>
        /// Is the project saved?
        /// </summary>
        bool Saved { get; set; }

        /// <summary>
        /// Simple list of each file in the project
        /// </summary>
        ProjectFileList FileList { get; }

        /// <summary>
        /// Name of the project
        /// </summary>
        string ProjectName { get; }

        string ProjectFileName { get; }

        string ProjectFolder { get; }

        string DevelopmentFolder { get; }

        void AddFile(string folder, string filename);
        void SaveProject();
    }
}
