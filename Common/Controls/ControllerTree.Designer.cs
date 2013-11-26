﻿namespace Common.Controls
{
	partial class ControllerTree
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerTree));
			this.treeIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.channelCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeview = new Common.Controls.MultiSelectTreeview();
			this.contextMenuStripTreeView.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeIconsImageList
			// 
			this.treeIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeIconsImageList.ImageStream")));
			this.treeIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.treeIconsImageList.Images.SetKeyName(0, "Group");
			this.treeIconsImageList.Images.SetKeyName(1, "GreyBall");
			this.treeIconsImageList.Images.SetKeyName(2, "RedBall");
			this.treeIconsImageList.Images.SetKeyName(3, "GreenBall");
			this.treeIconsImageList.Images.SetKeyName(4, "YellowBall");
			this.treeIconsImageList.Images.SetKeyName(5, "BlueBall");
			this.treeIconsImageList.Images.SetKeyName(6, "WhiteBall");
			// 
			// contextMenuStripTreeView
			// 
			this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.channelCountToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
			this.contextMenuStripTreeView.Size = new System.Drawing.Size(155, 92);
			this.contextMenuStripTreeView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTreeView_Opening);
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.configureToolStripMenuItem.Text = "Configure";
			this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
			// 
			// channelCountToolStripMenuItem
			// 
			this.channelCountToolStripMenuItem.Name = "channelCountToolStripMenuItem";
			this.channelCountToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.channelCountToolStripMenuItem.Text = "Channel Count";
			this.channelCountToolStripMenuItem.Click += new System.EventHandler(this.channelCountToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// treeview
			// 
			this.treeview.AllowDrop = true;
			this.treeview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeview.ContextMenuStrip = this.contextMenuStripTreeView;
			this.treeview.Cursor = System.Windows.Forms.Cursors.Default;
			this.treeview.CustomDragCursor = null;
			this.treeview.DragDefaultMode = System.Windows.Forms.DragDropEffects.None;
			this.treeview.DragDestinationNodeBackColor = System.Drawing.SystemColors.Highlight;
			this.treeview.DragDestinationNodeForeColor = System.Drawing.SystemColors.HighlightText;
			this.treeview.DragSourceNodeBackColor = System.Drawing.SystemColors.ControlLight;
			this.treeview.DragSourceNodeForeColor = System.Drawing.SystemColors.ControlText;
			this.treeview.HideSelection = false;
			this.treeview.ImageIndex = 0;
			this.treeview.ImageList = this.treeIconsImageList;
			this.treeview.Location = new System.Drawing.Point(0, 0);
			this.treeview.Name = "treeview";
			this.treeview.SelectedImageIndex = 0;
			this.treeview.SelectedNodes = ((System.Collections.Generic.List<System.Windows.Forms.TreeNode>)(resources.GetObject("treeview.SelectedNodes")));
			this.treeview.Size = new System.Drawing.Size(200, 400);
			this.treeview.TabIndex = 13;
			this.treeview.UsingCustomDragCursor = false;
			this.treeview.Deselected += new System.EventHandler(this.treeview_Deselected);
			this.treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_AfterSelect);
			this.treeview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeview_KeyDown);
			// 
			// ControllerTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.treeview);
			this.Name = "ControllerTree";
			this.Size = new System.Drawing.Size(200, 400);
			this.Load += new System.EventHandler(this.ControllerTree_Load);
			this.contextMenuStripTreeView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MultiSelectTreeview treeview;
		private System.Windows.Forms.ImageList treeIconsImageList;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem channelCountToolStripMenuItem;
	}
}