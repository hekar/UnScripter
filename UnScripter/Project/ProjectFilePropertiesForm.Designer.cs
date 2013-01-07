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
	partial class ProjectFilePropertiesForm : System.Windows.Forms.Form
	{
		//Required by the Windows Form Designer

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.TabVariables = new System.Windows.Forms.TabPage();
			this.TabFunction = new System.Windows.Forms.TabPage();
			this.TabProperties = new System.Windows.Forms.TabPage();
			this.LabelClassName = new System.Windows.Forms.Label();
			this.LabelDirectory = new System.Windows.Forms.Label();
			this.LinkLabelOpenFolder = new System.Windows.Forms.LinkLabel();
			this.LabelFullPath = new System.Windows.Forms.Label();
			this.LinkLabelFullPath = new System.Windows.Forms.LinkLabel();
			this.ProjectFileTabs = new System.Windows.Forms.TabControl();
			this.TabProperties.SuspendLayout();
			this.ProjectFileTabs.SuspendLayout();
			this.SuspendLayout();
			//
			//TabVariables
			//
			this.TabVariables.Location = new System.Drawing.Point(4, 25);
			this.TabVariables.Name = "TabVariables";
			this.TabVariables.Padding = new System.Windows.Forms.Padding(3);
			this.TabVariables.Size = new System.Drawing.Size(875, 271);
			this.TabVariables.TabIndex = 4;
			this.TabVariables.Text = "Variables";
			this.TabVariables.UseVisualStyleBackColor = true;
			//
			//TabFunction
			//
			this.TabFunction.Location = new System.Drawing.Point(4, 25);
			this.TabFunction.Name = "TabFunction";
			this.TabFunction.Padding = new System.Windows.Forms.Padding(3);
			this.TabFunction.Size = new System.Drawing.Size(875, 271);
			this.TabFunction.TabIndex = 3;
			this.TabFunction.Text = "Functions";
			this.TabFunction.UseVisualStyleBackColor = true;
			//
			//TabProperties
			//
			this.TabProperties.Controls.Add(this.LinkLabelFullPath);
			this.TabProperties.Controls.Add(this.LabelFullPath);
			this.TabProperties.Controls.Add(this.LinkLabelOpenFolder);
			this.TabProperties.Controls.Add(this.LabelDirectory);
			this.TabProperties.Controls.Add(this.LabelClassName);
			this.TabProperties.Location = new System.Drawing.Point(4, 25);
			this.TabProperties.Name = "TabProperties";
			this.TabProperties.Padding = new System.Windows.Forms.Padding(3);
			this.TabProperties.Size = new System.Drawing.Size(875, 271);
			this.TabProperties.TabIndex = 1;
			this.TabProperties.Text = "Properties";
			this.TabProperties.UseVisualStyleBackColor = true;
			//
			//LabelClassName
			//
			this.LabelClassName.AutoSize = true;
			this.LabelClassName.Location = new System.Drawing.Point(18, 19);
			this.LabelClassName.Name = "LabelClassName";
			this.LabelClassName.Size = new System.Drawing.Size(164, 17);
			this.LabelClassName.TabIndex = 0;
			this.LabelClassName.Text = "ClassName: {classname}";
			//
			//LabelDirectory
			//
			this.LabelDirectory.AutoSize = true;
			this.LabelDirectory.Location = new System.Drawing.Point(18, 52);
			this.LabelDirectory.Name = "LabelDirectory";
			this.LabelDirectory.Size = new System.Drawing.Size(238, 17);
			this.LabelDirectory.TabIndex = 5;
			this.LabelDirectory.Text = "Containing Folder: {containingfolder}";
			//
			//LinkLabelOpenFolder
			//
			this.LinkLabelOpenFolder.AutoSize = true;
			this.LinkLabelOpenFolder.Location = new System.Drawing.Point(18, 80);
			this.LinkLabelOpenFolder.Name = "LinkLabelOpenFolder";
			this.LinkLabelOpenFolder.Size = new System.Drawing.Size(87, 17);
			this.LinkLabelOpenFolder.TabIndex = 6;
			this.LinkLabelOpenFolder.TabStop = true;
			this.LinkLabelOpenFolder.Text = "Open Folder";
			//
			//LabelFullPath
			//
			this.LabelFullPath.AutoSize = true;
			this.LabelFullPath.Location = new System.Drawing.Point(18, 111);
			this.LabelFullPath.Name = "LabelFullPath";
			this.LabelFullPath.Size = new System.Drawing.Size(123, 17);
			this.LabelFullPath.TabIndex = 7;
			this.LabelFullPath.Text = "FullPath: {fullpath}";
			//
			//LinkLabelFullPath
			//
			this.LinkLabelFullPath.AutoSize = true;
			this.LinkLabelFullPath.Location = new System.Drawing.Point(18, 139);
			this.LinkLabelFullPath.Name = "LinkLabelFullPath";
			this.LinkLabelFullPath.Size = new System.Drawing.Size(84, 17);
			this.LinkLabelFullPath.TabIndex = 8;
			this.LinkLabelFullPath.TabStop = true;
			this.LinkLabelFullPath.Text = "Open Editor";
			//
			//ProjectFileTabs
			//
			this.ProjectFileTabs.Controls.Add(this.TabProperties);
			this.ProjectFileTabs.Controls.Add(this.TabFunction);
			this.ProjectFileTabs.Controls.Add(this.TabVariables);
			this.ProjectFileTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjectFileTabs.Location = new System.Drawing.Point(0, 0);
			this.ProjectFileTabs.Name = "ProjectFileTabs";
			this.ProjectFileTabs.SelectedIndex = 0;
			this.ProjectFileTabs.Size = new System.Drawing.Size(883, 300);
			this.ProjectFileTabs.TabIndex = 0;
			//
			//ProjectFilePropertiesForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 300);
			this.Controls.Add(this.ProjectFileTabs);
			this.Name = "ProjectFilePropertiesForm";
			this.Text = "ProjectFilePropertiesForm";
			this.TabProperties.ResumeLayout(false);
			this.TabProperties.PerformLayout();
			this.ProjectFileTabs.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabPage TabVariables;
		internal System.Windows.Forms.TabPage TabFunction;
		internal System.Windows.Forms.TabPage TabProperties;
		internal System.Windows.Forms.LinkLabel LinkLabelFullPath;
		internal System.Windows.Forms.Label LabelFullPath;
		internal System.Windows.Forms.LinkLabel LinkLabelOpenFolder;
		internal System.Windows.Forms.Label LabelDirectory;
		internal System.Windows.Forms.Label LabelClassName;
		internal System.Windows.Forms.TabControl ProjectFileTabs;
	}
}
