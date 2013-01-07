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
namespace UnScripter
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class ErrorView : System.Windows.Forms.UserControl
	{

		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorView));
			this.ListView = new System.Windows.Forms.ListView();
			this.Type = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.Message = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.Line = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.Filename = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ErrorViewImageList = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			//
			//ListView
			//
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.Type,
				this.Message,
				this.Line,
				this.Filename
			});
			this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListView.FullRowSelect = true;
			this.ListView.GridLines = true;
			this.ListView.HideSelection = false;
			this.ListView.Location = new System.Drawing.Point(0, 0);
			this.ListView.MultiSelect = false;
			this.ListView.Name = "ListView";
			this.ListView.ShowGroups = false;
			this.ListView.Size = new System.Drawing.Size(1308, 234);
			this.ListView.SmallImageList = this.ErrorViewImageList;
			this.ListView.TabIndex = 0;
			this.ListView.UseCompatibleStateImageBehavior = false;
			this.ListView.View = System.Windows.Forms.View.Details;
			//
			//Type
			//
			this.Type.Text = "Type";
			this.Type.Width = 77;
			//
			//Message
			//
			this.Message.Text = "Message";
			this.Message.Width = 384;
			//
			//Line
			//
			this.Line.Text = "Line";
			this.Line.Width = 104;
			//
			//Filename
			//
			this.Filename.Text = "Filename";
			this.Filename.Width = 189;
			//
			//ErrorViewImageList
			//
			this.ErrorViewImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ErrorViewImageList.ImageStream");
			this.ErrorViewImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.ErrorViewImageList.Images.SetKeyName(0, "messagebox_warning.png");
			this.ErrorViewImageList.Images.SetKeyName(1, "no.png");
			//
			//ErrorView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ListView);
			this.Name = "ErrorView";
			this.Size = new System.Drawing.Size(1308, 234);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ListView ListView;
		internal System.Windows.Forms.ColumnHeader Type;
		internal System.Windows.Forms.ColumnHeader Message;
		internal System.Windows.Forms.ColumnHeader Line;
		internal System.Windows.Forms.ColumnHeader Filename;

		internal System.Windows.Forms.ImageList ErrorViewImageList;
	}
}
