namespace ClinicManagementSystem.View.UserControls
{
	partial class SearchPatientControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lnameTextBox = new System.Windows.Forms.TextBox();
			this.fnameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
			this.searchPatientButton = new System.Windows.Forms.Button();
			this.selectPatientButton = new System.Windows.Forms.Button();
			this.patientDataGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search for Patient";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(37, 66);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(141, 25);
			this.label13.TabIndex = 28;
			this.label13.Text = "Search Criteria";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lnameTextBox);
			this.panel2.Controls.Add(this.fnameTextBox);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.dobDatePicker);
			this.panel2.Location = new System.Drawing.Point(22, 81);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(860, 84);
			this.panel2.TabIndex = 27;
			// 
			// lnameTextBox
			// 
			this.lnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.lnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnameTextBox.Location = new System.Drawing.Point(268, 41);
			this.lnameTextBox.Name = "lnameTextBox";
			this.lnameTextBox.Size = new System.Drawing.Size(204, 27);
			this.lnameTextBox.TabIndex = 2;
			// 
			// fnameTextBox
			// 
			this.fnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.fnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnameTextBox.Location = new System.Drawing.Point(19, 41);
			this.fnameTextBox.Name = "fnameTextBox";
			this.fnameTextBox.Size = new System.Drawing.Size(204, 27);
			this.fnameTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "First name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(513, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Date of Birth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(265, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 4;
			this.label7.Text = "Last name";
			// 
			// dobDatePicker
			// 
			this.dobDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobDatePicker.Location = new System.Drawing.Point(516, 41);
			this.dobDatePicker.Name = "dobDatePicker";
			this.dobDatePicker.Size = new System.Drawing.Size(314, 27);
			this.dobDatePicker.TabIndex = 5;
			// 
			// searchPatientButton
			// 
			this.searchPatientButton.BackColor = System.Drawing.Color.SteelBlue;
			this.searchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.searchPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchPatientButton.Location = new System.Drawing.Point(22, 173);
			this.searchPatientButton.Name = "searchPatientButton";
			this.searchPatientButton.Size = new System.Drawing.Size(218, 36);
			this.searchPatientButton.TabIndex = 32;
			this.searchPatientButton.Text = "Search for Patient";
			this.searchPatientButton.UseVisualStyleBackColor = false;
			this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_OnClick);
			// 
			// selectPatientButton
			// 
			this.selectPatientButton.BackColor = System.Drawing.Color.SteelBlue;
			this.selectPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectPatientButton.Location = new System.Drawing.Point(22, 503);
			this.selectPatientButton.Name = "selectPatientButton";
			this.selectPatientButton.Size = new System.Drawing.Size(218, 36);
			this.selectPatientButton.TabIndex = 35;
			this.selectPatientButton.Text = "Select Patient";
			this.selectPatientButton.UseVisualStyleBackColor = false;
			this.selectPatientButton.Click += new System.EventHandler(this.selectPatientButton_OnClick);
			// 
			// patientDataGrid
			// 
			this.patientDataGrid.AllowUserToAddRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patientDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.patientDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
			this.patientDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.patientDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.patientDataGrid.ColumnHeadersHeight = 25;
			this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.patientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.patientDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.patientDataGrid.Location = new System.Drawing.Point(22, 232);
			this.patientDataGrid.Name = "patientDataGrid";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.patientDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.patientDataGrid.RowHeadersVisible = false;
			this.patientDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.patientDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patientDataGrid.RowTemplate.Height = 40;
			this.patientDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.patientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.patientDataGrid.Size = new System.Drawing.Size(860, 264);
			this.patientDataGrid.TabIndex = 36;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 70;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "First";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 155;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Last";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 155;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Phone #";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 160;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// SearchPatientControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.patientDataGrid);
			this.Controls.Add(this.selectPatientButton);
			this.Controls.Add(this.searchPatientButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Name = "SearchPatientControl";
			this.Size = new System.Drawing.Size(909, 558);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox lnameTextBox;
		private System.Windows.Forms.TextBox fnameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dobDatePicker;

		#endregion

		private System.Windows.Forms.Button searchPatientButton;
		private System.Windows.Forms.Button selectPatientButton;
		private System.Windows.Forms.DataGridView patientDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}
