namespace ClinicManagementSystem.View
{
	partial class AppointmentInfoPage
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
			this.doctorComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.appointmentButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lengthComboBox = new System.Windows.Forms.ComboBox();
			this.timeComboBox = new System.Windows.Forms.ComboBox();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(248, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Appointment Info";
			// 
			// doctorComboBox
			// 
			this.doctorComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.doctorComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.doctorComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doctorComboBox.FormattingEnabled = true;
			this.doctorComboBox.Location = new System.Drawing.Point(22, 45);
			this.doctorComboBox.Name = "doctorComboBox";
			this.doctorComboBox.Size = new System.Drawing.Size(195, 26);
			this.doctorComboBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(19, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Select Doctor";
			// 
			// dateOfBirthDatePicker
			// 
			this.dateOfBirthDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDatePicker.Enabled = false;
			this.dateOfBirthDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDatePicker.Location = new System.Drawing.Point(498, 44);
			this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
			this.dateOfBirthDatePicker.Size = new System.Drawing.Size(319, 27);
			this.dateOfBirthDatePicker.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(495, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Date";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.timeComboBox);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.lengthComboBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dateOfBirthDatePicker);
			this.panel2.Controls.Add(this.richTextBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.doctorComboBox);
			this.panel2.Location = new System.Drawing.Point(25, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(859, 231);
			this.panel2.TabIndex = 23;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(43, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(123, 25);
			this.label13.TabIndex = 24;
			this.label13.Text = "Enter Details";
			// 
			// appointmentButton
			// 
			this.appointmentButton.BackColor = System.Drawing.Color.SteelBlue;
			this.appointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.appointmentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(24, 340);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(218, 36);
			this.appointmentButton.TabIndex = 11;
			this.appointmentButton.Text = "Create Appointment";
			this.appointmentButton.UseVisualStyleBackColor = false;
			this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_OnClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(619, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "Time";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
			this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(22, 111);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(555, 96);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "Reasons";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(258, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 18);
			this.label3.TabIndex = 16;
			this.label3.Text = "Choose Length";
			// 
			// lengthComboBox
			// 
			this.lengthComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.lengthComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lengthComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lengthComboBox.FormattingEnabled = true;
			this.lengthComboBox.Location = new System.Drawing.Point(261, 45);
			this.lengthComboBox.Name = "lengthComboBox";
			this.lengthComboBox.Size = new System.Drawing.Size(195, 26);
			this.lengthComboBox.TabIndex = 15;
			// 
			// timeComboBox
			// 
			this.timeComboBox.BackColor = System.Drawing.Color.SlateGray;
			this.timeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeComboBox.Enabled = false;
			this.timeComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeComboBox.FormattingEnabled = true;
			this.timeComboBox.Location = new System.Drawing.Point(622, 111);
			this.timeComboBox.Name = "timeComboBox";
			this.timeComboBox.Size = new System.Drawing.Size(195, 26);
			this.timeComboBox.TabIndex = 17;
			// 
			// AppointmentInfoPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(904, 397);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pageTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AppointmentInfoPage";
			this.Text = "Appointment";
			this.Load += new System.EventHandler(this.appointmentFrm_OnLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.ComboBox doctorComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button appointmentButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox timeComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox lengthComboBox;
	}
}