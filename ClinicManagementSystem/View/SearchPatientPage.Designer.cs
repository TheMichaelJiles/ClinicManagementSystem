namespace ClinicManagementSystem.View
{
	partial class SearchPatientPage
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
			this.patientDataGrid = new System.Windows.Forms.DataGridView();
			this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.selectPatientButton = new System.Windows.Forms.Button();
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
			this.panel2.Size = new System.Drawing.Size(937, 88);
			this.panel2.TabIndex = 27;
			// 
			// lnameTextBox
			// 
			this.lnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.lnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnameTextBox.Location = new System.Drawing.Point(305, 40);
			this.lnameTextBox.Name = "lnameTextBox";
			this.lnameTextBox.Size = new System.Drawing.Size(246, 27);
			this.lnameTextBox.TabIndex = 2;
			// 
			// fnameTextBox
			// 
			this.fnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.fnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnameTextBox.Location = new System.Drawing.Point(19, 41);
			this.fnameTextBox.Name = "fnameTextBox";
			this.fnameTextBox.Size = new System.Drawing.Size(246, 27);
			this.fnameTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "First name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(587, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Date of Birth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(302, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 4;
			this.label7.Text = "Last name";
			// 
			// dobDatePicker
			// 
			this.dobDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobDatePicker.Location = new System.Drawing.Point(591, 40);
			this.dobDatePicker.Name = "dobDatePicker";
			this.dobDatePicker.Size = new System.Drawing.Size(326, 27);
			this.dobDatePicker.TabIndex = 5;
			// 
			// searchPatientButton
			// 
			this.searchPatientButton.BackColor = System.Drawing.Color.SteelBlue;
			this.searchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.searchPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchPatientButton.Location = new System.Drawing.Point(22, 180);
			this.searchPatientButton.Name = "searchPatientButton";
			this.searchPatientButton.Size = new System.Drawing.Size(218, 36);
			this.searchPatientButton.TabIndex = 32;
			this.searchPatientButton.Text = "Search for Patient";
			this.searchPatientButton.UseVisualStyleBackColor = false;
			this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_OnClick);
			// 
			// patientDataGrid
			// 
			this.patientDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
			this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.patientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fnameColumn,
            this.lNameColumn,
            this.dobColumn,
            this.phoneColumn,
            this.genderColumn});
			this.patientDataGrid.Location = new System.Drawing.Point(21, 244);
			this.patientDataGrid.Name = "patientDataGrid";
			this.patientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.patientDataGrid.Size = new System.Drawing.Size(938, 296);
			this.patientDataGrid.TabIndex = 34;
			// 
			// idColumn
			// 
			this.idColumn.HeaderText = "ID";
			this.idColumn.Name = "idColumn";
			this.idColumn.ReadOnly = true;
			// 
			// fnameColumn
			// 
			this.fnameColumn.HeaderText = "First";
			this.fnameColumn.Name = "fnameColumn";
			this.fnameColumn.ReadOnly = true;
			// 
			// lNameColumn
			// 
			this.lNameColumn.HeaderText = "Last";
			this.lNameColumn.Name = "lNameColumn";
			this.lNameColumn.ReadOnly = true;
			// 
			// dobColumn
			// 
			this.dobColumn.HeaderText = "DOB";
			this.dobColumn.Name = "dobColumn";
			this.dobColumn.ReadOnly = true;
			// 
			// phoneColumn
			// 
			this.phoneColumn.HeaderText = "Phone #";
			this.phoneColumn.Name = "phoneColumn";
			this.phoneColumn.ReadOnly = true;
			// 
			// genderColumn
			// 
			this.genderColumn.HeaderText = "Gender";
			this.genderColumn.Name = "genderColumn";
			this.genderColumn.ReadOnly = true;
			// 
			// selectPatientButton
			// 
			this.selectPatientButton.BackColor = System.Drawing.Color.SteelBlue;
			this.selectPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectPatientButton.Location = new System.Drawing.Point(21, 553);
			this.selectPatientButton.Name = "selectPatientButton";
			this.selectPatientButton.Size = new System.Drawing.Size(218, 36);
			this.selectPatientButton.TabIndex = 35;
			this.selectPatientButton.Text = "Select Patient";
			this.selectPatientButton.UseVisualStyleBackColor = false;
			// 
			// SearchPatientPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(982, 606);
			this.Controls.Add(this.selectPatientButton);
			this.Controls.Add(this.patientDataGrid);
			this.Controls.Add(this.searchPatientButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Name = "SearchPatientPage";
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
		private System.Windows.Forms.DataGridView patientDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dobColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
		private System.Windows.Forms.Button selectPatientButton;
	}
}