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
            this.LabelError = new System.Windows.Forms.Label();
            this.LabelUDKDirectory = new System.Windows.Forms.Label();
            this.TextBoxUDKDir = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.LabelCreateProject = new System.Windows.Forms.Label();
            this.TextBoxProjectName = new System.Windows.Forms.TextBox();
            this.LabelProjectName = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(338, 322);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(63, 26);
            this.FinishButton.TabIndex = 0;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BackButton
            // 
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
            this.CloseButton.Location = new System.Drawing.Point(9, 322);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(63, 26);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.LabelError);
            this.Panel1.Controls.Add(this.LabelUDKDirectory);
            this.Panel1.Controls.Add(this.TextBoxUDKDir);
            this.Panel1.Controls.Add(this.BrowseButton);
            this.Panel1.Controls.Add(this.LabelCreateProject);
            this.Panel1.Controls.Add(this.TextBoxProjectName);
            this.Panel1.Controls.Add(this.LabelProjectName);
            this.Panel1.Location = new System.Drawing.Point(10, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(392, 296);
            this.Panel1.TabIndex = 3;
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
            // LabelUDKDirectory
            // 
            this.LabelUDKDirectory.AutoSize = true;
            this.LabelUDKDirectory.Location = new System.Drawing.Point(14, 102);
            this.LabelUDKDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUDKDirectory.Name = "LabelUDKDirectory";
            this.LabelUDKDirectory.Size = new System.Drawing.Size(78, 13);
            this.LabelUDKDirectory.TabIndex = 5;
            this.LabelUDKDirectory.Text = "UDK Directory:";
            // 
            // TextBoxUDKDir
            // 
            this.TextBoxUDKDir.Location = new System.Drawing.Point(95, 100);
            this.TextBoxUDKDir.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUDKDir.Name = "TextBoxUDKDir";
            this.TextBoxUDKDir.Size = new System.Drawing.Size(219, 20);
            this.TextBoxUDKDir.TabIndex = 4;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(319, 96);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(63, 26);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // LabelCreateProject
            // 
            this.LabelCreateProject.AutoSize = true;
            this.LabelCreateProject.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreateProject.Location = new System.Drawing.Point(13, 18);
            this.LabelCreateProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCreateProject.Name = "LabelCreateProject";
            this.LabelCreateProject.Size = new System.Drawing.Size(115, 22);
            this.LabelCreateProject.TabIndex = 2;
            this.LabelCreateProject.Text = "UDK Project";
            // 
            // TextBoxProjectName
            // 
            this.TextBoxProjectName.Location = new System.Drawing.Point(95, 66);
            this.TextBoxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.Size = new System.Drawing.Size(219, 20);
            this.TextBoxProjectName.TabIndex = 1;
            // 
            // LabelProjectName
            // 
            this.LabelProjectName.AutoSize = true;
            this.LabelProjectName.Location = new System.Drawing.Point(14, 68);
            this.LabelProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProjectName.Name = "LabelProjectName";
            this.LabelProjectName.Size = new System.Drawing.Size(71, 13);
            this.LabelProjectName.TabIndex = 0;
            this.LabelProjectName.Text = "ProjectName:";
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnScripter - New Project";
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
		internal System.Windows.Forms.Label LabelProjectName;
		internal System.Windows.Forms.Label LabelUDKDirectory;
		internal System.Windows.Forms.TextBox TextBoxUDKDir;
		internal System.Windows.Forms.Button BrowseButton;
		internal System.Windows.Forms.Label LabelError;
		internal System.Windows.Forms.Label LabelCreateProject;
	}
}
