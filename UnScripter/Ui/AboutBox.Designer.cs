namespace UnScripter
{
    partial class AboutBox : System.Windows.Forms.Form
    {
        //Required by the Windows Form Designer

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(340, 239);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(62, 26);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(19, 239);
            this.AuthorsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(66, 13);
            this.AuthorsLabel.TabIndex = 1;
            this.AuthorsLabel.Text = "Hekar Khani";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(19, 216);
            this.ApplicationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(90, 13);
            this.ApplicationLabel.TabIndex = 2;
            this.ApplicationLabel.Text = "Application Name";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(21, 20);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(333, 180);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.Text = "UnScripter IDE for UnrealScript on the UDK\r\n\r\nIcons from the Oxygen Icon set";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 276);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Label AuthorsLabel;
        internal System.Windows.Forms.Label ApplicationLabel;

        internal System.Windows.Forms.TextBox TextBox1;
    }
}
