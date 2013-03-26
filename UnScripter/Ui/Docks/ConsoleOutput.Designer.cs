namespace UnScripter
{
	partial class ConsoleOutput : System.Windows.Forms.UserControl
	{
		//Required by the Windows Form Designer

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.ConsoleText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			//ConsoleText
			//
			this.ConsoleText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConsoleText.Location = new System.Drawing.Point(0, 0);
			this.ConsoleText.Multiline = true;
			this.ConsoleText.Name = "ConsoleText";
			this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ConsoleText.Size = new System.Drawing.Size(631, 324);
			this.ConsoleText.TabIndex = 2;
			//
			//ConsoleOutput
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ConsoleText);
			this.Name = "ConsoleOutput";
			this.Size = new System.Drawing.Size(631, 324);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public System.Windows.Forms.TextBox ConsoleText;
	}
}
