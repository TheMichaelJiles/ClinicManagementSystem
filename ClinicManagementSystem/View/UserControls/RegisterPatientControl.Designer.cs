﻿namespace ClinicManagementSystem.View
{
	partial class RegisterPatientControl
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
			this.fnameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lnameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.addressOneTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.addressTwoTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.zipTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.registerPatientButton = new System.Windows.Forms.Button();
			this.stateComboBox = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(287, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Register New Patient";
			// 
			// fnameTextBox
			// 
			this.fnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.fnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnameTextBox.Location = new System.Drawing.Point(19, 63);
			this.fnameTextBox.Name = "fnameTextBox";
			this.fnameTextBox.Size = new System.Drawing.Size(198, 27);
			this.fnameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "First name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(289, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Last name";
			// 
			// lnameTextBox
			// 
			this.lnameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.lnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnameTextBox.Location = new System.Drawing.Point(292, 63);
			this.lnameTextBox.Name = "lnameTextBox";
			this.lnameTextBox.Size = new System.Drawing.Size(198, 27);
			this.lnameTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone #";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberTextBox.Location = new System.Drawing.Point(19, 125);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(198, 27);
			this.phoneNumberTextBox.TabIndex = 3;
			// 
			// genderComboBox
			// 
			this.genderComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.genderComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.genderComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.genderComboBox.Location = new System.Drawing.Point(253, 125);
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(91, 26);
			this.genderComboBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(250, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Gender";
			// 
			// dateOfBirthDatePicker
			// 
			this.dateOfBirthDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDatePicker.Location = new System.Drawing.Point(381, 125);
			this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
			this.dateOfBirthDatePicker.Size = new System.Drawing.Size(319, 27);
			this.dateOfBirthDatePicker.TabIndex = 5;
			this.dateOfBirthDatePicker.ValueChanged += new System.EventHandler(this.dateOfBirth_OnValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(378, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Date of Birth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "Address 1";
			// 
			// addressOneTextBox
			// 
			this.addressOneTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.addressOneTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressOneTextBox.Location = new System.Drawing.Point(22, 63);
			this.addressOneTextBox.Name = "addressOneTextBox";
			this.addressOneTextBox.Size = new System.Drawing.Size(319, 27);
			this.addressOneTextBox.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(378, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 18);
			this.label8.TabIndex = 14;
			this.label8.Text = "Address 2";
			// 
			// addressTwoTextBox
			// 
			this.addressTwoTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.addressTwoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressTwoTextBox.Location = new System.Drawing.Point(381, 63);
			this.addressTwoTextBox.Name = "addressTwoTextBox";
			this.addressTwoTextBox.Size = new System.Drawing.Size(319, 27);
			this.addressTwoTextBox.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(19, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 18);
			this.label9.TabIndex = 16;
			this.label9.Text = "City";
			// 
			// cityTextBox
			// 
			this.cityTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.cityTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityTextBox.Location = new System.Drawing.Point(22, 126);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(198, 27);
			this.cityTextBox.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(253, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 18);
			this.label10.TabIndex = 18;
			this.label10.Text = "State";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(378, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 18);
			this.label11.TabIndex = 20;
			this.label11.Text = "Zip";
			// 
			// zipTextBox
			// 
			this.zipTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.zipTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zipTextBox.Location = new System.Drawing.Point(381, 126);
			this.zipTextBox.MaxLength = 5;
			this.zipTextBox.Name = "zipTextBox";
			this.zipTextBox.Size = new System.Drawing.Size(198, 27);
			this.zipTextBox.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.stateComboBox);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.addressOneTextBox);
			this.panel1.Controls.Add(this.zipTextBox);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.addressTwoTextBox);
			this.panel1.Controls.Add(this.cityTextBox);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Location = new System.Drawing.Point(25, 291);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(722, 175);
			this.panel1.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(43, 277);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(196, 25);
			this.label12.TabIndex = 22;
			this.label12.Text = "Address Information";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lnameTextBox);
			this.panel2.Controls.Add(this.fnameTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dateOfBirthDatePicker);
			this.panel2.Controls.Add(this.phoneNumberTextBox);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.genderComboBox);
			this.panel2.Location = new System.Drawing.Point(25, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(722, 175);
			this.panel2.TabIndex = 23;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(43, 71);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(201, 25);
			this.label13.TabIndex = 24;
			this.label13.Text = "Personal Information";
			// 
			// registerPatientButton
			// 
			this.registerPatientButton.BackColor = System.Drawing.Color.SteelBlue;
			this.registerPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.registerPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerPatientButton.Location = new System.Drawing.Point(25, 502);
			this.registerPatientButton.Name = "registerPatientButton";
			this.registerPatientButton.Size = new System.Drawing.Size(218, 36);
			this.registerPatientButton.TabIndex = 11;
			this.registerPatientButton.Text = "Register Patient";
			this.registerPatientButton.UseVisualStyleBackColor = false;
			this.registerPatientButton.Click += new System.EventHandler(this.registerPatientButton_OnClick);
			// 
			// stateComboBox
			// 
			this.stateComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.stateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.stateComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stateComboBox.FormattingEnabled = true;
			this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
			this.stateComboBox.Location = new System.Drawing.Point(253, 127);
			this.stateComboBox.Name = "stateComboBox";
			this.stateComboBox.Size = new System.Drawing.Size(91, 26);
			this.stateComboBox.TabIndex = 21;
			// 
			// RegisterPatientControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.registerPatientButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "RegisterPatientControl";
			this.Size = new System.Drawing.Size(768, 558);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fnameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lnameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.ComboBox genderComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox addressOneTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox addressTwoTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox zipTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button registerPatientButton;
		private System.Windows.Forms.ComboBox stateComboBox;
	}
}