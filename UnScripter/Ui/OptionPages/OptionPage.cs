using System.Windows.Forms;

namespace UnScripter
{
	/// <summary>
    /// Default page for adding to the options dialog
	/// </summary>
    [System.ComponentModel.DesignerCategory("")]
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
