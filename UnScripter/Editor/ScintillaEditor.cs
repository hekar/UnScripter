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
using System.IO;
using ScintillaNET;
using ScintillaNET.Configuration;

namespace UnScripter
{

	public class ScintillaEditor : Scintilla
	{

		public ScintillaEditor()
		{
			string editortheme = Globals.EditorSettings.GetTrait("EditorTheme", "themes/dark.xml");

			this.Dock = DockStyle.Fill;

			Lexing.LexerLanguageMap.Add("us", "cpp");

			ChangeTheme(editortheme);

			LineNumbers = Globals.EditorSettings.GetTrait("LineNumbers", true);

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
