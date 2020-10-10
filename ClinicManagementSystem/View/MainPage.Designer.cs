﻿namespace ClinicManagementSystem.View
{
	partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.currentUserToolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.navigationMenuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.registerPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.editPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			this.navigationMenuStrip.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.Color.SteelBlue;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripStatusLbl});
			this.statusStrip.Location = new System.Drawing.Point(0, 588);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(815, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// currentUserToolStripStatusLbl
			// 
			this.currentUserToolStripStatusLbl.BackColor = System.Drawing.SystemColors.Control;
			this.currentUserToolStripStatusLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentUserToolStripStatusLbl.Name = "currentUserToolStripStatusLbl";
			this.currentUserToolStripStatusLbl.Size = new System.Drawing.Size(200, 17);
			this.currentUserToolStripStatusLbl.Text = "User: nwilli27 - Nolan Williams";
			// 
			// navigationMenuStrip
			// 
			this.navigationMenuStrip.AutoSize = false;
			this.navigationMenuStrip.BackColor = System.Drawing.Color.SlateGray;
			this.navigationMenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
			this.navigationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientMenuItem,
            this.editPatientMenuItem});
			this.navigationMenuStrip.Location = new System.Drawing.Point(815, 24);
			this.navigationMenuStrip.Name = "navigationMenuStrip";
			this.navigationMenuStrip.Padding = new System.Windows.Forms.Padding(6, 15, 0, 2);
			this.navigationMenuStrip.Size = new System.Drawing.Size(214, 586);
			this.navigationMenuStrip.TabIndex = 1;
			// 
			// menuStrip2
			// 
			this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(1029, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "&File";
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem1.Text = "E&xit";
			// 
			// toolsToolStripMenuItem1
			// 
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem1.Text = "&Tools";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem1.Text = "&Help";
			// 
			// registerPatientMenuItem
			// 
			this.registerPatientMenuItem.AutoSize = false;
			this.registerPatientMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerPatientMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerPatientMenuItem.Image")));
			this.registerPatientMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.registerPatientMenuItem.Name = "registerPatientMenuItem";
			this.registerPatientMenuItem.Size = new System.Drawing.Size(195, 40);
			this.registerPatientMenuItem.Text = "Register Patient";
			this.registerPatientMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.registerPatientMenuItem.Click += new System.EventHandler(this.registerNewPatientMenuItem_OnClick);
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem1.Text = "&Edit";
			// 
			// controlPanel
			// 
			this.controlPanel.AutoSize = true;
			this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.controlPanel.Location = new System.Drawing.Point(0, 24);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(815, 564);
			this.controlPanel.TabIndex = 3;
			// 
			// editPatientMenuItem
			// 
			this.editPatientMenuItem.AutoSize = false;
			this.editPatientMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editPatientMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPatientMenuItem.Image")));
			this.editPatientMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editPatientMenuItem.Name = "editPatientMenuItem";
			this.editPatientMenuItem.Size = new System.Drawing.Size(195, 40);
			this.editPatientMenuItem.Text = "Edit Patient";
			this.editPatientMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editPatientMenuItem.Click += new System.EventHandler(this.editPatientMenuItem_OnClick);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1029, 610);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.navigationMenuStrip);
			this.Controls.Add(this.menuStrip2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.navigationMenuStrip;
			this.Name = "MainPage";
			this.Text = "Clinic Management System";
			this.Load += new System.EventHandler(this.mainPage_OnLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.navigationMenuStrip.ResumeLayout(false);
			this.navigationMenuStrip.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel currentUserToolStripStatusLbl;
		private System.Windows.Forms.MenuStrip navigationMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem registerPatientMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		public System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.ToolStripMenuItem editPatientMenuItem;
	}
}