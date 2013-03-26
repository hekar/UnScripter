using System.Windows.Forms;

namespace UnScripter
{
	partial class NewProjectForm : System.Windows.Forms.Form
	{
		//Required by the Windows Form Designer

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.FinishButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GameLabel = new System.Windows.Forms.Label();
            this.gameComboBox = new System.Windows.Forms.ComboBox();
            this.LabelError = new System.Windows.Forms.Label();
            this.ProjectDirectoryLabel = new System.Windows.Forms.Label();
            this.TextBoxUDKDir = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TextBoxProjectName = new System.Windows.Forms.TextBox();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishButton.Location = new System.Drawing.Point(338, 322);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(63, 26);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "&Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(271, 322);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(63, 26);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.Location = new System.Drawing.Point(9, 322);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(63, 26);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.GameLabel);
            this.Panel1.Controls.Add(this.gameComboBox);
            this.Panel1.Controls.Add(this.LabelError);
            this.Panel1.Controls.Add(this.ProjectDirectoryLabel);
            this.Panel1.Controls.Add(this.TextBoxUDKDir);
            this.Panel1.Controls.Add(this.BrowseButton);
            this.Panel1.Controls.Add(this.TextBoxProjectName);
            this.Panel1.Controls.Add(this.ProjectNameLabel);
            this.Panel1.Location = new System.Drawing.Point(10, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(392, 296);
            this.Panel1.TabIndex = 3;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(14, 43);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(38, 13);
            this.GameLabel.TabIndex = 8;
            this.GameLabel.Text = "Game:";
            // 
            // gameComboBox
            // 
            this.gameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.Location = new System.Drawing.Point(106, 40);
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(208, 21);
            this.gameComboBox.TabIndex = 7;
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(4, 262);
            this.LabelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 13);
            this.LabelError.TabIndex = 6;
            // 
            // ProjectDirectoryLabel
            // 
            this.ProjectDirectoryLabel.AutoSize = true;
            this.ProjectDirectoryLabel.Location = new System.Drawing.Point(14, 102);
            this.ProjectDirectoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectDirectoryLabel.Name = "ProjectDirectoryLabel";
            this.ProjectDirectoryLabel.Size = new System.Drawing.Size(88, 13);
            this.ProjectDirectoryLabel.TabIndex = 5;
            this.ProjectDirectoryLabel.Text = "Project Directory:";
            // 
            // TextBoxUDKDir
            // 
            this.TextBoxUDKDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUDKDir.Location = new System.Drawing.Point(106, 100);
            this.TextBoxUDKDir.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUDKDir.Name = "TextBoxUDKDir";
            this.TextBoxUDKDir.Size = new System.Drawing.Size(208, 20);
            this.TextBoxUDKDir.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(319, 96);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(63, 26);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "&Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TextBoxProjectName
            // 
            this.TextBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxProjectName.Location = new System.Drawing.Point(106, 66);
            this.TextBoxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.Size = new System.Drawing.Size(208, 20);
            this.TextBoxProjectName.TabIndex = 0;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(14, 68);
            this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "Project Name:";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Project";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewProjectWizard_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Button FinishButton;
		internal System.Windows.Forms.Button BackButton;
		internal System.Windows.Forms.Button CloseButton;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox TextBoxProjectName;
		internal System.Windows.Forms.Label ProjectNameLabel;
		internal System.Windows.Forms.Label ProjectDirectoryLabel;
		internal System.Windows.Forms.TextBox TextBoxUDKDir;
		internal System.Windows.Forms.Button BrowseButton;
        internal System.Windows.Forms.Label LabelError;
        private Label GameLabel;
        private ComboBox gameComboBox;
	}
}
