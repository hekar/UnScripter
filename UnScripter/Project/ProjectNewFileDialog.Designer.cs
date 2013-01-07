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
	partial class ProjectNewFileDialog : System.Windows.Forms.Form
	{
		//Required by the Windows Form Designer

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.LabelClassName = new System.Windows.Forms.Label();
            this.TextBoxClassname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboBoxProjectFolder = new System.Windows.Forms.ComboBox();
            this.TextBoxFilename = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(278, 322);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(76, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Create File";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(3, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // LabelClassName
            // 
            this.LabelClassName.AutoSize = true;
            this.LabelClassName.Location = new System.Drawing.Point(36, 66);
            this.LabelClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelClassName.Name = "LabelClassName";
            this.LabelClassName.Size = new System.Drawing.Size(58, 13);
            this.LabelClassName.TabIndex = 1;
            this.LabelClassName.Text = "Classname";
            // 
            // TextBoxClassname
            // 
            this.TextBoxClassname.Location = new System.Drawing.Point(125, 66);
            this.TextBoxClassname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxClassname.Name = "TextBoxClassname";
            this.TextBoxClassname.Size = new System.Drawing.Size(223, 20);
            this.TextBoxClassname.TabIndex = 2;
            this.TextBoxClassname.Tag = "";
            this.TextBoxClassname.Click += new System.EventHandler(this.TextBoxClassname_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(36, 89);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Project Directory";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 114);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Filename";
            // 
            // ComboBoxProjectFolder
            // 
            this.ComboBoxProjectFolder.FormattingEnabled = true;
            this.ComboBoxProjectFolder.Location = new System.Drawing.Point(125, 89);
            this.ComboBoxProjectFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxProjectFolder.Name = "ComboBoxProjectFolder";
            this.ComboBoxProjectFolder.Size = new System.Drawing.Size(223, 21);
            this.ComboBoxProjectFolder.TabIndex = 5;
            // 
            // TextBoxFilename
            // 
            this.TextBoxFilename.Location = new System.Drawing.Point(125, 114);
            this.TextBoxFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxFilename.Name = "TextBoxFilename";
            this.TextBoxFilename.Size = new System.Drawing.Size(223, 20);
            this.TextBoxFilename.TabIndex = 6;
            // 
            // ProjectNewFileDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.TextBoxFilename);
            this.Controls.Add(this.ComboBoxProjectFolder);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxClassname);
            this.Controls.Add(this.LabelClassName);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectNewFileDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProjectNewFileDialog";
            this.Shown += new System.EventHandler(this.ProjectNewFileDialog_Shown);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.Label LabelClassName;
		internal System.Windows.Forms.TextBox TextBoxClassname;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox ComboBoxProjectFolder;

		internal System.Windows.Forms.TextBox TextBoxFilename;
	}
}
