using System.Windows.Forms;

namespace UnScripter
{

	// Default page for adding to the options dialog
	public class OptionPage : TabPage
	{

		public virtual void OnLoadSettings()
		{
		}

		public virtual void OnApplySettings()
		{
		}

		public virtual void OnFocus()
		{
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
	}
}
