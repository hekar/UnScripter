using System.Windows.Forms;

namespace UnScripter
{
    [System.ComponentModel.DesignerCategory("")]
	public class EditorTabs : TabControl
	{
		public EditorTabs()
		{
			Appearance = TabAppearance.FlatButtons;

            if (true)//Globals.UISettings.GetTrait("FlatTabs", true))
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
