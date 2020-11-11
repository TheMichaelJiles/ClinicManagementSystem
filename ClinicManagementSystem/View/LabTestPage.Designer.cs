namespace ClinicManagementSystem.View
{
	partial class LabTestPage
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
			this.step1Panel = new System.Windows.Forms.Panel();
			this.testTypesComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.abnormalityTextArea = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.resultsTextArea = new System.Windows.Forms.RichTextBox();
			this.step2Panel = new System.Windows.Forms.Panel();
			this.routineFinishedCheckBox = new System.Windows.Forms.CheckBox();
			this.testDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.step3Panel = new System.Windows.Forms.Panel();
			this.step1Panel.SuspendLayout();
			this.step2Panel.SuspendLayout();
			this.step3Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(122, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Lab Test";
			// 
			// step1Panel
			// 
			this.step1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.step1Panel.Controls.Add(this.testTypesComboBox);
			this.step1Panel.Controls.Add(this.label1);
			this.step1Panel.Location = new System.Drawing.Point(25, 86);
			this.step1Panel.Name = "step1Panel";
			this.step1Panel.Size = new System.Drawing.Size(744, 88);
			this.step1Panel.TabIndex = 1;
			// 
			// testTypesComboBox
			// 
			this.testTypesComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.testTypesComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.testTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.testTypesComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.testTypesComboBox.FormattingEnabled = true;
			this.testTypesComboBox.Location = new System.Drawing.Point(22, 46);
			this.testTypesComboBox.Name = "testTypesComboBox";
			this.testTypesComboBox.Size = new System.Drawing.Size(314, 26);
			this.testTypesComboBox.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 18);
			this.label1.TabIndex = 29;
			this.label1.Text = "Select Test Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "Enter any Abnormalities";
			// 
			// abnormalityTextArea
			// 
			this.abnormalityTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.abnormalityTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.abnormalityTextArea.Location = new System.Drawing.Point(22, 43);
			this.abnormalityTextArea.Name = "abnormalityTextArea";
			this.abnormalityTextArea.Size = new System.Drawing.Size(693, 62);
			this.abnormalityTextArea.TabIndex = 7;
			this.abnormalityTextArea.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(43, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 25);
			this.label13.TabIndex = 24;
			this.label13.Text = "Step 1";
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(260, 476);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(218, 36);
			this.saveButton.TabIndex = 8;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_OnClick);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(25, 476);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(218, 36);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_OnClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(363, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 18);
			this.label3.TabIndex = 31;
			this.label3.Text = "Enter Results";
			// 
			// resultsTextArea
			// 
			this.resultsTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.resultsTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsTextArea.Location = new System.Drawing.Point(365, 44);
			this.resultsTextArea.Name = "resultsTextArea";
			this.resultsTextArea.Size = new System.Drawing.Size(350, 62);
			this.resultsTextArea.TabIndex = 30;
			this.resultsTextArea.Text = "";
			// 
			// step2Panel
			// 
			this.step2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.step2Panel.Controls.Add(this.routineFinishedCheckBox);
			this.step2Panel.Controls.Add(this.testDatePicker);
			this.step2Panel.Controls.Add(this.label5);
			this.step2Panel.Controls.Add(this.label3);
			this.step2Panel.Controls.Add(this.resultsTextArea);
			this.step2Panel.Location = new System.Drawing.Point(25, 197);
			this.step2Panel.Name = "step2Panel";
			this.step2Panel.Size = new System.Drawing.Size(744, 123);
			this.step2Panel.TabIndex = 30;
			// 
			// routineFinishedCheckBox
			// 
			this.routineFinishedCheckBox.AutoSize = true;
			this.routineFinishedCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.routineFinishedCheckBox.Location = new System.Drawing.Point(22, 23);
			this.routineFinishedCheckBox.Name = "routineFinishedCheckBox";
			this.routineFinishedCheckBox.Size = new System.Drawing.Size(95, 22);
			this.routineFinishedCheckBox.TabIndex = 39;
			this.routineFinishedCheckBox.Text = "Finished";
			this.routineFinishedCheckBox.UseVisualStyleBackColor = true;
			this.routineFinishedCheckBox.CheckedChanged += new System.EventHandler(this.finishedTest_OnCheckChanged);
			// 
			// testDatePicker
			// 
			this.testDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.testDatePicker.Enabled = false;
			this.testDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.testDatePicker.Location = new System.Drawing.Point(22, 78);
			this.testDatePicker.Name = "testDatePicker";
			this.testDatePicker.Size = new System.Drawing.Size(314, 27);
			this.testDatePicker.TabIndex = 33;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(19, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 18);
			this.label5.TabIndex = 32;
			this.label5.Text = "Performed on";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(43, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 25);
			this.label4.TabIndex = 31;
			this.label4.Text = "Step 2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(43, 331);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 25);
			this.label6.TabIndex = 35;
			this.label6.Text = "Step 3";
			// 
			// step3Panel
			// 
			this.step3Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.step3Panel.Controls.Add(this.label2);
			this.step3Panel.Controls.Add(this.abnormalityTextArea);
			this.step3Panel.Location = new System.Drawing.Point(25, 345);
			this.step3Panel.Name = "step3Panel";
			this.step3Panel.Size = new System.Drawing.Size(744, 120);
			this.step3Panel.TabIndex = 34;
			// 
			// LabTestPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(794, 522);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.step3Panel);
			this.Controls.Add(this.step2Panel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.step1Panel);
			this.Controls.Add(this.pageTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LabTestPage";
			this.Text = "Appointment";
			this.Load += new System.EventHandler(this.labTestPage_OnLoad);
			this.step1Panel.ResumeLayout(false);
			this.step1Panel.PerformLayout();
			this.step2Panel.ResumeLayout(false);
			this.step2Panel.PerformLayout();
			this.step3Panel.ResumeLayout(false);
			this.step3Panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.Panel step1Panel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox abnormalityTextArea;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox testTypesComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox resultsTextArea;
		private System.Windows.Forms.Panel step2Panel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker testDatePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel step3Panel;
		private System.Windows.Forms.CheckBox routineFinishedCheckBox;
	}
}