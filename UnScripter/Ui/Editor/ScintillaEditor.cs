using Ninject;
using ScintillaNET;
using ScintillaNET.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace UnScripter
{

	public class ScintillaEditor : Scintilla
	{

        // TODO: Inject this component
		public ScintillaEditor()
		{
            var editorSettings = App.Kernel.Get<EditorSettings>();
            string editortheme = editorSettings.GetTrait("EditorTheme", "themes/dark.xml");

			this.Dock = DockStyle.Fill;

			Lexing.LexerLanguageMap.Add("us", "cpp");

			ChangeTheme(editortheme);

            LineNumbers = editorSettings.GetTrait("LineNumbers", true);
		}

		public bool LineNumbers {
			get { return Margins[0].Width > 0; }
			set {
				if (value) {
					Margins[0].Width = 30;
				} else {
					Margins[0].Width = 0;
				}
			}
		}

		public void ChangeTheme(string themepath)
		{
            if (!File.Exists(themepath))
            {
                throw new ArgumentException(String.Format("Theme {0} does not exist", themepath));
            }

			ConfigurationManager.IsUserEnabled = true;
			ConfigurationManager.IsBuiltInEnabled = true;
			ConfigurationManager.LoadOrder = ConfigurationLoadOrder.CustomUserBuiltIn;
			ConfigurationManager.CustomLocation = themepath;
			ConfigurationManager.Language = "us";
			ConfigurationManager.Configure();

			// Adjust the color of the caret
			this.Caret.Color = this.Styles.Default.ForeColor;
		}

		private void InitializeComponent()
		{
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			this.SuspendLayout();
			//
			//ScintillaEditor
			//
			this.Styles.BraceBad.FontName = "Verdana";
			this.Styles.BraceLight.FontName = "Verdana";
			this.Styles.ControlChar.FontName = "Verdana";
			this.Styles.Default.FontName = "Verdana";
			this.Styles.IndentGuide.FontName = "Verdana";
			this.Styles.LastPredefined.FontName = "Verdana";
			this.Styles.LineNumber.FontName = "Verdana";
			this.Styles.Max.FontName = "Verdana";
			((System.ComponentModel.ISupportInitialize)this).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
