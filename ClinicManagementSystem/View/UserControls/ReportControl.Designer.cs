namespace ClinicManagementSystem.View.UserControls
{
	partial class ReportControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pageTitleLabel = new System.Windows.Forms.Label();
			this.beginningDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.endDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.runVisitReportButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(315, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Run Breakdown Report";
			// 
			// beginningDatePicker
			// 
			this.beginningDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.beginningDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.beginningDatePicker.Location = new System.Drawing.Point(22, 45);
			this.beginningDatePicker.Name = "beginningDatePicker";
			this.beginningDatePicker.Size = new System.Drawing.Size(319, 27);
			this.beginningDatePicker.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Beginning Date";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.endDatePicker);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.beginningDatePicker);
			this.panel2.Location = new System.Drawing.Point(25, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(859, 94);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(394, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "End Date";
			// 
			// endDatePicker
			// 
			this.endDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endDatePicker.Location = new System.Drawing.Point(397, 45);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.Size = new System.Drawing.Size(319, 27);
			this.endDatePicker.TabIndex = 3;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(43, 71);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(166, 25);
			this.label13.TabIndex = 24;
			this.label13.Text = "Enter Date Range";
			// 
			// runVisitReportButton
			// 
			this.runVisitReportButton.BackColor = System.Drawing.Color.SteelBlue;
			this.runVisitReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.runVisitReportButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.runVisitReportButton.Location = new System.Drawing.Point(25, 192);
			this.runVisitReportButton.Name = "runVisitReportButton";
			this.runVisitReportButton.Size = new System.Drawing.Size(259, 36);
			this.runVisitReportButton.TabIndex = 4;
			this.runVisitReportButton.Text = "View Visit Breakdown";
			this.runVisitReportButton.UseVisualStyleBackColor = false;
			this.runVisitReportButton.Click += new System.EventHandler(this.runVisitReport_OnClick);
			// 
			// ReportControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.runVisitReportButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pageTitleLabel);
			this.Name = "ReportControl";
			this.Size = new System.Drawing.Size(909, 558);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.DateTimePicker beginningDatePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button runVisitReportButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker endDatePicker;
	}
}
