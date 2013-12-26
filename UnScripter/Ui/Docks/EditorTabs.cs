using System.Windows.Forms;
using Ninject;

namespace UnScripter
{
    [System.ComponentModel.DesignerCategory("")]
	public class EditorTabs : TabControl
	{
		public EditorTabs()
		{
			Appearance = TabAppearance.FlatButtons;

            var uiSettings = App.Kernel.Get<UiSettings>();
            var flat = uiSettings.GetTrait("FlatTabs", true);
            if (flat)
            {
                Appearance = TabAppearance.FlatButtons;
            }
            else
            {
                Appearance = TabAppearance.Normal;
            }
		}
	}
}
