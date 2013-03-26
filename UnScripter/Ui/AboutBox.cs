using System;

namespace UnScripter
{
    public sealed partial class AboutBox
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            Text = String.Format("About %s", Globals.ApplicationName);
            ApplicationLabel.Text = Globals.ApplicationName;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
