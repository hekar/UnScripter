using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UnScripter
{

    public class FileView : TreeView
    {
        private IContainer components;

        internal ImageList FileBrowserImageList;

        public FileView()
        {
            InitializeComponent();

            this.ImageList = FileBrowserImageList;
            this.Font = new Font("Segoe UI", 9.5f);
            this.Indent = 5;
        }

        public enum FileViewMode
        {
            CLASSIC,
            CONTEMPORARY,
            MODERN
        }

        private FileViewMode _fileviewmode = FileViewMode.CLASSIC;
        public FileViewMode FileViewType
        {
            get { return _fileviewmode; }
            set
            {
                _fileviewmode = value;
                switch (value)
                {
                    case FileViewMode.CLASSIC:
                        ShowLines = true;
                        ShowPlusMinus = true;
                        ShowRootLines = true;
                        break;
                    case FileViewMode.CONTEMPORARY:
                        ShowLines = true;
                        ShowPlusMinus = false;
                        ShowRootLines = false;
                        break;
                    case FileViewMode.MODERN:
                        ShowLines = false;
                        ShowPlusMinus = false;
                        ShowRootLines = false;
                        break;
                }

                Globals.UISettings.SetTrait("FileViewType", value.ToString());
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FileView));
            this.FileBrowserImageList = new ImageList(this.components);
            this.SuspendLayout();
            //
            //FileBrowserImageList
            //
            this.FileBrowserImageList.ImageStream = (ImageListStreamer)resources.GetObject("FileBrowserImageList.ImageStream");
            this.FileBrowserImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileBrowserImageList.Images.SetKeyName(0, "project_open.png");
            this.FileBrowserImageList.Images.SetKeyName(1, "document_open_folder.png");
            this.FileBrowserImageList.Images.SetKeyName(2, "document_properties.png");
            //
            //FileView
            //
            this.LineColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);
        }
    }
}