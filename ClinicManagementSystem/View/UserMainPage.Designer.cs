namespace ClinicManagementSystem.View
{
	partial class UserMainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainPage));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.currentUserToolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.navigationMenuStrip = new System.Windows.Forms.MenuStrip();
			this.searchPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registerPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.patientStatusStrip = new System.Windows.Forms.StatusStrip();
			this.currentPatientStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			this.navigationMenuStrip.SuspendLayout();
			this.topMenuStrip.SuspendLayout();
			this.patientStatusStrip.SuspendLayout();
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
			this.statusStrip.SizingGrip = false;
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
            this.searchPatientMenuItem,
            this.homeMenuItem,
            this.viewPatientMenuItem,
            this.registerPatientMenuItem,
            this.apptMenuItem,
            this.reportMenuItem,
            this.logoutMenuItem});
			this.navigationMenuStrip.Location = new System.Drawing.Point(910, 24);
			this.navigationMenuStrip.Name = "navigationMenuStrip";
			this.navigationMenuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.navigationMenuStrip.Size = new System.Drawing.Size(214, 586);
			this.navigationMenuStrip.TabIndex = 1;
			// 
			// searchPatientMenuItem
			// 
			this.searchPatientMenuItem.AutoSize = false;
			this.searchPatientMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchPatientMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchPatientMenuItem.Image")));
			this.searchPatientMenuItem.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
			this.searchPatientMenuItem.Name = "searchPatientMenuItem";
			this.searchPatientMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.searchPatientMenuItem.Size = new System.Drawing.Size(220, 45);
			this.searchPatientMenuItem.Text = "Search Patient";
			this.searchPatientMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchPatientMenuItem.Click += new System.EventHandler(this.searchPatientMenuItem_OnClick);
			// 
			// homeMenuItem
			// 
			this.homeMenuItem.AutoSize = false;
			this.homeMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.homeMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeMenuItem.Image")));
			this.homeMenuItem.Name = "homeMenuItem";
			this.homeMenuItem.Size = new System.Drawing.Size(220, 45);
			this.homeMenuItem.Text = "Home            ";
			this.homeMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_OnClick);
			// 
			// viewPatientMenuItem
			// 
			this.viewPatientMenuItem.AutoSize = false;
			this.viewPatientMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewPatientMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPatientMenuItem.Image")));
			this.viewPatientMenuItem.Name = "viewPatientMenuItem";
			this.viewPatientMenuItem.Size = new System.Drawing.Size(220, 45);
			this.viewPatientMenuItem.Text = "View Patient  ";
			this.viewPatientMenuItem.Click += new System.EventHandler(this.viewPatientMenuItem_OnClick);
			// 
			// registerPatientMenuItem
			// 
			this.registerPatientMenuItem.AutoSize = false;
			this.registerPatientMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerPatientMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerPatientMenuItem.Image")));
			this.registerPatientMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.registerPatientMenuItem.Name = "registerPatientMenuItem";
			this.registerPatientMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.registerPatientMenuItem.Size = new System.Drawing.Size(220, 45);
			this.registerPatientMenuItem.Text = "Register Patient ";
			this.registerPatientMenuItem.Click += new System.EventHandler(this.registerNewPatientMenuItem_OnClick);
			// 
			// apptMenuItem
			// 
			this.apptMenuItem.AutoSize = false;
			this.apptMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apptMenuItem.Image")));
			this.apptMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.apptMenuItem.Name = "apptMenuItem";
			this.apptMenuItem.Size = new System.Drawing.Size(220, 45);
			this.apptMenuItem.Text = "Appointments   ";
			this.apptMenuItem.Click += new System.EventHandler(this.apptButton_OnClick);
			// 
			// logoutMenuItem
			// 
			this.logoutMenuItem.AutoSize = false;
			this.logoutMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logoutMenuItem.Margin = new System.Windows.Forms.Padding(0, 294, 0, 0);
			this.logoutMenuItem.Name = "logoutMenuItem";
			this.logoutMenuItem.Size = new System.Drawing.Size(220, 45);
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
			this.controlPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controlPanel.Location = new System.Drawing.Point(0, 37);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(910, 551);
			this.controlPanel.TabIndex = 3;
			// 
			// patientStatusStrip
			// 
			this.patientStatusStrip.BackColor = System.Drawing.Color.SlateGray;
			this.patientStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
			this.patientStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPatientStripStatusLbl});
			this.patientStatusStrip.Location = new System.Drawing.Point(0, 24);
			this.patientStatusStrip.Name = "patientStatusStrip";
			this.patientStatusStrip.Size = new System.Drawing.Size(910, 22);
			this.patientStatusStrip.SizingGrip = false;
			this.patientStatusStrip.TabIndex = 4;
			// 
			// currentPatientStripStatusLbl
			// 
			this.currentPatientStripStatusLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentPatientStripStatusLbl.Name = "currentPatientStripStatusLbl";
			this.currentPatientStripStatusLbl.Size = new System.Drawing.Size(110, 17);
			this.currentPatientStripStatusLbl.Text = "Current Patient: ";
			// 
			// reportMenuItem
			// 
			this.reportMenuItem.AutoSize = false;
			this.reportMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportMenuItem.Image")));
			this.reportMenuItem.Name = "reportMenuItem";
			this.reportMenuItem.Size = new System.Drawing.Size(213, 45);
			this.reportMenuItem.Text = "Run Report    ";
			this.reportMenuItem.Click += new System.EventHandler(this.runReportMenuItem_OnClick);
			// 
			// UserMainPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1124, 610);
			this.Controls.Add(this.patientStatusStrip);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.navigationMenuStrip);
			this.Controls.Add(this.topMenuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.navigationMenuStrip;
			this.Name = "UserMainPage";
			this.Text = "Clinic Management System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainPage_OnClose);
			this.Load += new System.EventHandler(this.mainPage_OnLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.navigationMenuStrip.ResumeLayout(false);
			this.navigationMenuStrip.PerformLayout();
			this.topMenuStrip.ResumeLayout(false);
			this.topMenuStrip.PerformLayout();
			this.patientStatusStrip.ResumeLayout(false);
			this.patientStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel currentUserToolStripStatusLbl;
		private System.Windows.Forms.MenuStrip navigationMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem registerPatientMenuItem;
		private System.Windows.Forms.MenuStrip topMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		public System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.ToolStripMenuItem searchPatientMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
		private System.Windows.Forms.StatusStrip patientStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem viewPatientMenuItem;
		private System.Windows.Forms.ToolStripMenuItem apptMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel currentPatientStripStatusLbl;
		private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
	}
}