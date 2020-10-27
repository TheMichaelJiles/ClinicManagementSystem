namespace ClinicManagementSystem.View
{
	partial class ManageAppointmentPage
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
			this.labTestsDataGrid = new System.Windows.Forms.DataGridView();
			this.testTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.abnormalityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.resultsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.byNurseLabel = new System.Windows.Forms.Label();
			this.editCheckButton = new System.Windows.Forms.Button();
			this.routineFinishedCheckBox = new System.Windows.Forms.CheckBox();
			this.startCheckButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.initialDiagnosisTextArea = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.finalDiagnosisTextArea = new System.Windows.Forms.RichTextBox();
			this.saveAppointmentButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.labTestsDataGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(300, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Manage Appointment";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(37, 71);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 25);
			this.label13.TabIndex = 30;
			this.label13.Text = "Lab Tests";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.labTestsDataGrid);
			this.panel2.Controls.Add(this.orderButton);
			this.panel2.Controls.Add(this.editButton);
			this.panel2.Controls.Add(this.removeButton);
			this.panel2.Location = new System.Drawing.Point(22, 84);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(997, 227);
			this.panel2.TabIndex = 29;
			// 
			// labTestsDataGrid
			// 
			this.labTestsDataGrid.AllowUserToAddRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTestsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.labTestsDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
			this.labTestsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.labTestsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.labTestsDataGrid.ColumnHeadersHeight = 28;
			this.labTestsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.labTestsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testTypeColumn,
            this.dateColumn,
            this.abnormalityColumn,
            this.resultsColumn});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.labTestsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.labTestsDataGrid.Location = new System.Drawing.Point(0, 14);
			this.labTestsDataGrid.Name = "labTestsDataGrid";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.labTestsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.labTestsDataGrid.RowHeadersVisible = false;
			this.labTestsDataGrid.RowHeadersWidth = 50;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
			this.labTestsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.labTestsDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.labTestsDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTestsDataGrid.RowTemplate.Height = 50;
			this.labTestsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.labTestsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.labTestsDataGrid.Size = new System.Drawing.Size(845, 211);
			this.labTestsDataGrid.TabIndex = 1;
			// 
			// testTypeColumn
			// 
			this.testTypeColumn.HeaderText = "Test Type";
			this.testTypeColumn.MinimumWidth = 6;
			this.testTypeColumn.Name = "testTypeColumn";
			this.testTypeColumn.ReadOnly = true;
			this.testTypeColumn.Width = 60;
			// 
			// dateColumn
			// 
			this.dateColumn.HeaderText = "Date";
			this.dateColumn.MinimumWidth = 6;
			this.dateColumn.Name = "dateColumn";
			this.dateColumn.ReadOnly = true;
			this.dateColumn.Width = 200;
			// 
			// abnormalityColumn
			// 
			this.abnormalityColumn.HeaderText = "Abnormality";
			this.abnormalityColumn.MinimumWidth = 6;
			this.abnormalityColumn.Name = "abnormalityColumn";
			this.abnormalityColumn.ReadOnly = true;
			this.abnormalityColumn.Width = 120;
			// 
			// resultsColumn
			// 
			this.resultsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.resultsColumn.HeaderText = "Results";
			this.resultsColumn.MinimumWidth = 6;
			this.resultsColumn.Name = "resultsColumn";
			this.resultsColumn.ReadOnly = true;
			// 
			// orderButton
			// 
			this.orderButton.BackColor = System.Drawing.Color.SteelBlue;
			this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.orderButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderButton.Location = new System.Drawing.Point(844, 14);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(152, 36);
			this.orderButton.TabIndex = 2;
			this.orderButton.Text = "Order";
			this.orderButton.UseVisualStyleBackColor = false;
			this.orderButton.Click += new System.EventHandler(this.orderTestButton_OnClick);
			// 
			// editButton
			// 
			this.editButton.BackColor = System.Drawing.Color.SteelBlue;
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.editButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editButton.Location = new System.Drawing.Point(844, 49);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(152, 36);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editTestButton_OnClick);
			// 
			// removeButton
			// 
			this.removeButton.BackColor = System.Drawing.Color.SteelBlue;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.removeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeButton.Location = new System.Drawing.Point(844, 84);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(152, 36);
			this.removeButton.TabIndex = 4;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeTestButton_OnClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 323);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 25);
			this.label1.TabIndex = 39;
			this.label1.Text = "Routine Check";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.byNurseLabel);
			this.panel1.Controls.Add(this.editCheckButton);
			this.panel1.Controls.Add(this.routineFinishedCheckBox);
			this.panel1.Controls.Add(this.startCheckButton);
			this.panel1.Location = new System.Drawing.Point(22, 336);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(997, 118);
			this.panel1.TabIndex = 38;
			// 
			// byNurseLabel
			// 
			this.byNurseLabel.AutoSize = true;
			this.byNurseLabel.Enabled = false;
			this.byNurseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.byNurseLabel.Location = new System.Drawing.Point(112, 30);
			this.byNurseLabel.Name = "byNurseLabel";
			this.byNurseLabel.Size = new System.Drawing.Size(128, 25);
			this.byNurseLabel.TabIndex = 40;
			this.byNurseLabel.Text = "by Test Name";
			this.byNurseLabel.Visible = false;
			// 
			// editCheckButton
			// 
			this.editCheckButton.BackColor = System.Drawing.Color.SteelBlue;
			this.editCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.editCheckButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editCheckButton.Location = new System.Drawing.Point(265, 64);
			this.editCheckButton.Name = "editCheckButton";
			this.editCheckButton.Size = new System.Drawing.Size(225, 36);
			this.editCheckButton.TabIndex = 6;
			this.editCheckButton.Text = "Edit";
			this.editCheckButton.UseVisualStyleBackColor = false;
			this.editCheckButton.Click += new System.EventHandler(this.editCheckButton_OnClick);
			// 
			// routineFinishedCheckBox
			// 
			this.routineFinishedCheckBox.AutoSize = true;
			this.routineFinishedCheckBox.Enabled = false;
			this.routineFinishedCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.routineFinishedCheckBox.Location = new System.Drawing.Point(19, 29);
			this.routineFinishedCheckBox.Name = "routineFinishedCheckBox";
			this.routineFinishedCheckBox.Size = new System.Drawing.Size(102, 29);
			this.routineFinishedCheckBox.TabIndex = 38;
			this.routineFinishedCheckBox.Text = "Finished";
			this.routineFinishedCheckBox.UseVisualStyleBackColor = true;
			// 
			// startCheckButton
			// 
			this.startCheckButton.BackColor = System.Drawing.Color.SteelBlue;
			this.startCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startCheckButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startCheckButton.Location = new System.Drawing.Point(19, 64);
			this.startCheckButton.Name = "startCheckButton";
			this.startCheckButton.Size = new System.Drawing.Size(225, 36);
			this.startCheckButton.TabIndex = 5;
			this.startCheckButton.Text = "Start";
			this.startCheckButton.UseVisualStyleBackColor = false;
			this.startCheckButton.Click += new System.EventHandler(this.startButton_OnClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 18);
			this.label3.TabIndex = 41;
			this.label3.Text = "Initial";
			// 
			// initialDiagnosisTextArea
			// 
			this.initialDiagnosisTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.initialDiagnosisTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.initialDiagnosisTextArea.Location = new System.Drawing.Point(15, 47);
			this.initialDiagnosisTextArea.Name = "initialDiagnosisTextArea";
			this.initialDiagnosisTextArea.Size = new System.Drawing.Size(475, 185);
			this.initialDiagnosisTextArea.TabIndex = 7;
			this.initialDiagnosisTextArea.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(37, 468);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 25);
			this.label4.TabIndex = 42;
			this.label4.Text = "Diagnosis";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.finalDiagnosisTextArea);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.initialDiagnosisTextArea);
			this.panel3.Location = new System.Drawing.Point(22, 481);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(997, 250);
			this.panel3.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(505, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 18);
			this.label5.TabIndex = 43;
			this.label5.Text = "Final";
			// 
			// finalDiagnosisTextArea
			// 
			this.finalDiagnosisTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.finalDiagnosisTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.finalDiagnosisTextArea.Location = new System.Drawing.Point(504, 47);
			this.finalDiagnosisTextArea.Name = "finalDiagnosisTextArea";
			this.finalDiagnosisTextArea.Size = new System.Drawing.Size(475, 185);
			this.finalDiagnosisTextArea.TabIndex = 8;
			this.finalDiagnosisTextArea.Text = "";
			// 
			// saveAppointmentButton
			// 
			this.saveAppointmentButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveAppointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveAppointmentButton.Location = new System.Drawing.Point(288, 743);
			this.saveAppointmentButton.Name = "saveAppointmentButton";
			this.saveAppointmentButton.Size = new System.Drawing.Size(245, 36);
			this.saveAppointmentButton.TabIndex = 9;
			this.saveAppointmentButton.Text = "Save Appointment";
			this.saveAppointmentButton.UseVisualStyleBackColor = false;
			this.saveAppointmentButton.Click += new System.EventHandler(this.saveButton_OnClick);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(22, 743);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(245, 36);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_OnClick);
			// 
			// ManageAppointmentPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1041, 792);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveAppointmentButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pageTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ManageAppointmentPage";
			this.Text = "Appointment";
			this.Load += new System.EventHandler(this.manageFrm_OnLoad);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.labTestsDataGrid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView labTestsDataGrid;
		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn testTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn abnormalityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn resultsColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox routineFinishedCheckBox;
		private System.Windows.Forms.Button startCheckButton;
		private System.Windows.Forms.Button editCheckButton;
		private System.Windows.Forms.Label byNurseLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox initialDiagnosisTextArea;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox finalDiagnosisTextArea;
		private System.Windows.Forms.Button saveAppointmentButton;
		private System.Windows.Forms.Button cancelButton;
	}
}