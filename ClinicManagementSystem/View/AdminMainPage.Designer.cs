namespace ClinicManagementSystem.View
{
	partial class AdminMainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.currentUserToolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.navigationMenuStrip = new System.Windows.Forms.MenuStrip();
			this.registerUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.statusStrip.SuspendLayout();
			this.navigationMenuStrip.SuspendLayout();
			this.topMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.Color.SteelBlue;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripStatusLbl});
			this.statusStrip.Location = new System.Drawing.Point(0, 588);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(910, 22);
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
            this.registerUserMenuItem,
            this.editUserMenuItem,
            this.logoutMenuItem});
			this.navigationMenuStrip.Location = new System.Drawing.Point(910, 24);
			this.navigationMenuStrip.Name = "navigationMenuStrip";
			this.navigationMenuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.navigationMenuStrip.Size = new System.Drawing.Size(214, 586);
			this.navigationMenuStrip.TabIndex = 1;
			// 
			// registerUserMenuItem
			// 
			this.registerUserMenuItem.AutoSize = false;
			this.registerUserMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerUserMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerUserMenuItem.Image")));
			this.registerUserMenuItem.Name = "registerUserMenuItem";
			this.registerUserMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.registerUserMenuItem.Size = new System.Drawing.Size(217, 45);
			this.registerUserMenuItem.Text = "Register User";
			this.registerUserMenuItem.Click += new System.EventHandler(this.registerNewUserMenuItem_OnClick);
			// 
			// editUserMenuItem
			// 
			this.editUserMenuItem.AutoSize = false;
			this.editUserMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editUserMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editUserMenuItem.Image")));
			this.editUserMenuItem.Name = "editUserMenuItem";
			this.editUserMenuItem.Size = new System.Drawing.Size(217, 45);
			this.editUserMenuItem.Text = "Edit User       ";
			this.editUserMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.editUserMenuItem.Click += new System.EventHandler(this.editUserMenuItem_OnClick);
			// 
			// logoutMenuItem
			// 
			this.logoutMenuItem.AutoSize = false;
			this.logoutMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logoutMenuItem.Margin = new System.Windows.Forms.Padding(0, 451, 0, 0);
			this.logoutMenuItem.Name = "logoutMenuItem";
			this.logoutMenuItem.Size = new System.Drawing.Size(217, 45);
			this.logoutMenuItem.Text = "Logout";
			this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_OnClick);
			// 
			// topMenuStrip
			// 
			this.topMenuStrip.BackColor = System.Drawing.Color.SteelBlue;
			this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
			this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.topMenuStrip.Name = "topMenuStrip";
			this.topMenuStrip.Size = new System.Drawing.Size(1124, 24);
			this.topMenuStrip.TabIndex = 2;
			this.topMenuStrip.Text = "menuStrip2";
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
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem1.Text = "E&xit";
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem1.Text = "&Edit";
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
			// controlPanel
			// 
			this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.controlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controlPanel.Location = new System.Drawing.Point(0, 24);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(910, 564);
			this.controlPanel.TabIndex = 3;
			// 
			// AdminMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1124, 610);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.navigationMenuStrip);
			this.Controls.Add(this.topMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.navigationMenuStrip;
			this.Name = "AdminMainPage";
			this.Text = "Clinic Management System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminPage_OnClose);
			this.Load += new System.EventHandler(this.adminPage_OnLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.navigationMenuStrip.ResumeLayout(false);
			this.navigationMenuStrip.PerformLayout();
			this.topMenuStrip.ResumeLayout(false);
			this.topMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel currentUserToolStripStatusLbl;
		private System.Windows.Forms.MenuStrip navigationMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem registerUserMenuItem;
		private System.Windows.Forms.MenuStrip topMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		public System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.ToolStripMenuItem editUserMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
	}
}