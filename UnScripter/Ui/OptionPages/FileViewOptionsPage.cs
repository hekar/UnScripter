using Ninject;
using System.Windows.Forms;

namespace UnScripter
{
	class FileViewOptionsPage : OptionPage
	{
		private RadioButton ExplorerModern;
		private RadioButton ExplorerContemporary;
		private RadioButton ExplorerClassic;

		private GroupBox ExplorerType;

        private MainForm mainForm;
        private UiSettings uiSettings;

        [Inject]
        public FileViewOptionsPage(MainForm mainForm, UiSettings uiSettings)
		{
            this.mainForm = mainForm;
            this.uiSettings = uiSettings;
			InitializeComponent();
		}

		public override void OnApplySettings()
		{
			if (ExplorerClassic.Checked) {
				mainForm.FileView.FileViewType = FileView.FileViewMode.CLASSIC;
			} else if (ExplorerContemporary.Checked) {
				mainForm.FileView.FileViewType = FileView.FileViewMode.CONTEMPORARY;
			} else if (ExplorerModern.Checked) {
				mainForm.FileView.FileViewType = FileView.FileViewMode.MODERN;
			}

			uiSettings.SetTrait("FileViewType", mainForm.FileView.FileViewType.ToString());
		}

		public override void OnLoadSettings()
		{
		}

		public override void OnFocus()
		{
			ExplorerClassic.Checked = false;
			ExplorerContemporary.Checked = false;
			ExplorerModern.Checked = false;

			if (mainForm.FileView.FileViewType == FileView.FileViewMode.CLASSIC) {
				ExplorerClassic.Checked = true;
			} else if (mainForm.FileView.FileViewType == FileView.FileViewMode.CONTEMPORARY) {
				ExplorerContemporary.Checked = true;
			} else if (mainForm.FileView.FileViewType == FileView.FileViewMode.MODERN) {
				ExplorerModern.Checked = true;
			}
		}

		private void InitializeComponent()
		{
            this.ExplorerType = new System.Windows.Forms.GroupBox();
            this.ExplorerClassic = new System.Windows.Forms.RadioButton();
            this.ExplorerContemporary = new System.Windows.Forms.RadioButton();
            this.ExplorerModern = new System.Windows.Forms.RadioButton();
            this.ExplorerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExplorerType
            // 
            this.ExplorerType.Controls.Add(this.ExplorerClassic);
            this.ExplorerType.Controls.Add(this.ExplorerContemporary);
            this.ExplorerType.Controls.Add(this.ExplorerModern);
            this.ExplorerType.Location = new System.Drawing.Point(10, 20);
            this.ExplorerType.Name = "ExplorerType";
            this.ExplorerType.Size = new System.Drawing.Size(220, 150);
            this.ExplorerType.TabIndex = 0;
            this.ExplorerType.TabStop = false;
            this.ExplorerType.Text = "View Type";
            // 
            // ExplorerClassic
            // 
            this.ExplorerClassic.AutoSize = true;
            this.ExplorerClassic.Location = new System.Drawing.Point(10, 35);
            this.ExplorerClassic.Name = "ExplorerClassic";
            this.ExplorerClassic.Size = new System.Drawing.Size(58, 17);
            this.ExplorerClassic.TabIndex = 0;
            this.ExplorerClassic.TabStop = true;
            this.ExplorerClassic.Text = "Classic";
            this.ExplorerClassic.UseVisualStyleBackColor = true;
            // 
            // ExplorerContemporary
            // 
            this.ExplorerContemporary.AutoSize = true;
            this.ExplorerContemporary.Location = new System.Drawing.Point(10, 70);
            this.ExplorerContemporary.Name = "ExplorerContemporary";
            this.ExplorerContemporary.Size = new System.Drawing.Size(90, 17);
            this.ExplorerContemporary.TabIndex = 0;
            this.ExplorerContemporary.TabStop = true;
            this.ExplorerContemporary.Text = "Contemporary";
            this.ExplorerContemporary.UseVisualStyleBackColor = true;
            // 
            // ExplorerModern
            // 
            this.ExplorerModern.AutoSize = true;
            this.ExplorerModern.Location = new System.Drawing.Point(10, 105);
            this.ExplorerModern.Name = "ExplorerModern";
            this.ExplorerModern.Size = new System.Drawing.Size(61, 17);
            this.ExplorerModern.TabIndex = 0;
            this.ExplorerModern.TabStop = true;
            this.ExplorerModern.Text = "Modern";
            this.ExplorerModern.UseVisualStyleBackColor = true;
            // 
            // FileViewOptionsPage
            // 
            this.Controls.Add(this.ExplorerType);
            this.Text = "File Explorer";
            this.ExplorerType.ResumeLayout(false);
            this.ExplorerType.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
