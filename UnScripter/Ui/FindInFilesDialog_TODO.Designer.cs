namespace UnScripter
{
	partial class FindInFilesDialog_TODO : System.Windows.Forms.Form
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
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 274);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
			this.TableLayoutPanel1.TabIndex = 0;
			//
			//OK_Button
			//
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Location = new System.Drawing.Point(3, 3);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(67, 23);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			//
			//Cancel_Button
			//
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			//
			//FindInFilesDialog
			//
			this.AcceptButton = this.OK_Button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			this.ClientSize = new System.Drawing.Size(435, 315);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FindInFilesDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FindInFilesDialog";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;

		internal System.Windows.Forms.Button Cancel_Button;
	}
}
