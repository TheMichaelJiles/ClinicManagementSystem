namespace ClinicManagementSystem.View
{
	partial class VisitBreakdownPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pageTitleLabel = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.viewButton = new System.Windows.Forms.Button();
			this.visitsDataGrid = new System.Windows.Forms.DataGridView();
			this.cancelButton = new System.Windows.Forms.Button();
			this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.doctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reasonsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.visitsDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(226, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Visit Breakdown";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(37, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(163, 25);
			this.label13.TabIndex = 30;
			this.label13.Text = "Visit Information";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.viewButton);
			this.panel2.Controls.Add(this.visitsDataGrid);
			this.panel2.Location = new System.Drawing.Point(22, 77);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1101, 449);
			this.panel2.TabIndex = 4;
			// 
			// viewButton
			// 
			this.viewButton.BackColor = System.Drawing.Color.SteelBlue;
			this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewButton.Location = new System.Drawing.Point(948, 14);
			this.viewButton.Name = "viewButton";
			this.viewButton.Size = new System.Drawing.Size(152, 36);
			this.viewButton.TabIndex = 2;
			this.viewButton.Text = "View";
			this.viewButton.UseVisualStyleBackColor = false;
			this.viewButton.Click += new System.EventHandler(this.viewButton_OnClick);
			// 
			// visitsDataGrid
			// 
			this.visitsDataGrid.AllowUserToAddRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visitsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.visitsDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
			this.visitsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.visitsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.visitsDataGrid.ColumnHeadersHeight = 28;
			this.visitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.visitsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.patientColumn,
            this.doctorColumn,
            this.reasonsColumn});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.visitsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.visitsDataGrid.Location = new System.Drawing.Point(0, 14);
			this.visitsDataGrid.Name = "visitsDataGrid";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.visitsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.visitsDataGrid.RowHeadersVisible = false;
			this.visitsDataGrid.RowHeadersWidth = 50;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
			this.visitsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.visitsDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.visitsDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visitsDataGrid.RowTemplate.Height = 50;
			this.visitsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.visitsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.visitsDataGrid.Size = new System.Drawing.Size(949, 433);
			this.visitsDataGrid.TabIndex = 1;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(22, 539);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(245, 36);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_OnClick);
			// 
			// dateColumn
			// 
			this.dateColumn.HeaderText = "Date";
			this.dateColumn.MinimumWidth = 6;
			this.dateColumn.Name = "dateColumn";
			this.dateColumn.ReadOnly = true;
			this.dateColumn.Width = 200;
			// 
			// patientColumn
			// 
			this.patientColumn.HeaderText = "Patient";
			this.patientColumn.Name = "patientColumn";
			this.patientColumn.ReadOnly = true;
			this.patientColumn.Width = 150;
			// 
			// doctorColumn
			// 
			this.doctorColumn.HeaderText = "Doctor";
			this.doctorColumn.Name = "doctorColumn";
			this.doctorColumn.ReadOnly = true;
			this.doctorColumn.Width = 150;
			// 
			// reasonsColumn
			// 
			this.reasonsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.reasonsColumn.HeaderText = "Reasons";
			this.reasonsColumn.Name = "reasonsColumn";
			this.reasonsColumn.ReadOnly = true;
			// 
			// VisitBreakdownPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1147, 588);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pageTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "VisitBreakdownPage";
			this.ShowInTaskbar = false;
			this.Text = "Patient Visit Breakdown";
			this.Load += new System.EventHandler(this.visitBreakdownPage_OnLoad);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.visitsDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView visitsDataGrid;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button viewButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn patientColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn doctorColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reasonsColumn;
	}
}