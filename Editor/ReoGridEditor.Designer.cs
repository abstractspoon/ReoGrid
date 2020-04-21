/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * http://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGridEditor is released under MIT license.
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using unvell.UIControls;

namespace unvell.ReoGrid.Editor
{
	partial class ReoGridEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReoGridEditor));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.rangeInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.leadHeaderContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.resetAllPageBreaksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editorCtrl = new unvell.ReoGrid.Editor.ReoGridEditorControl();
			this.statusStrip1.SuspendLayout();
			this.leadHeaderContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.rangeInfoToolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 678);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusToolStripStatusLabel
			// 
			this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
			this.statusToolStripStatusLabel.Size = new System.Drawing.Size(727, 17);
			this.statusToolStripStatusLabel.Spring = true;
			this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rangeInfoToolStripStatusLabel
			// 
			this.rangeInfoToolStripStatusLabel.AutoSize = false;
			this.rangeInfoToolStripStatusLabel.Name = "rangeInfoToolStripStatusLabel";
			this.rangeInfoToolStripStatusLabel.Size = new System.Drawing.Size(260, 17);
			this.rangeInfoToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// leadHeaderContextMenuStrip
			// 
			this.leadHeaderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllPageBreaksToolStripMenuItem1});
			this.leadHeaderContextMenuStrip.Name = "leadHeaderContextMenuStrip";
			this.leadHeaderContextMenuStrip.Size = new System.Drawing.Size(186, 26);
			// 
			// resetAllPageBreaksToolStripMenuItem1
			// 
			this.resetAllPageBreaksToolStripMenuItem1.Name = "resetAllPageBreaksToolStripMenuItem1";
			this.resetAllPageBreaksToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
			this.resetAllPageBreaksToolStripMenuItem1.Text = "Reset All Page Breaks";
			// 
			// reoGridEditorCtrl1
			// 
			this.editorCtrl.CurrentFilePath = null;
			this.editorCtrl.CurrentSelectionRange = ((unvell.ReoGrid.RangePosition)(resources.GetObject("reoGridEditorCtrl1.CurrentSelectionRange")));
			this.editorCtrl.Location = new System.Drawing.Point(0, 0);
			this.editorCtrl.Name = "reoGridEditorCtrl1";
			this.editorCtrl.NewDocumentOnLoad = true;
			this.editorCtrl.Size = new System.Drawing.Size(1002, 675);
			this.editorCtrl.TabIndex = 6;
			// 
			// ReoGridEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 700);
			this.Controls.Add(this.editorCtrl);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(200, 10);
			this.Name = "ReoGridEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Untitlted - ReoGrid Editor";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.leadHeaderContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel rangeInfoToolStripStatusLabel;
		private System.Windows.Forms.ContextMenuStrip leadHeaderContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem resetAllPageBreaksToolStripMenuItem1;
		private ReoGridEditorControl editorCtrl;
	}
}

