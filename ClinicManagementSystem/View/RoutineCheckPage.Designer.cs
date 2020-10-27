namespace ClinicManagementSystem.View
{
	partial class RoutineCheckPage
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.pulseTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.bodyTempTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.diastolicTextBox = new System.Windows.Forms.TextBox();
			this.systolicTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.symptomsTextArea = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pageTitleLabel
			// 
			this.pageTitleLabel.AutoSize = true;
			this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pageTitleLabel.Location = new System.Drawing.Point(19, 17);
			this.pageTitleLabel.Name = "pageTitleLabel";
			this.pageTitleLabel.Size = new System.Drawing.Size(200, 37);
			this.pageTitleLabel.TabIndex = 0;
			this.pageTitleLabel.Text = "Routine Check";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pulseTextBox);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.bodyTempTextBox);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.diastolicTextBox);
			this.panel2.Controls.Add(this.systolicTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.symptomsTextArea);
			this.panel2.Location = new System.Drawing.Point(25, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(859, 312);
			this.panel2.TabIndex = 23;
			// 
			// pulseTextBox
			// 
			this.pulseTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.pulseTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pulseTextBox.Location = new System.Drawing.Point(325, 125);
			this.pulseTextBox.Mask = "###";
			this.pulseTextBox.Name = "pulseTextBox";
			this.pulseTextBox.Size = new System.Drawing.Size(98, 27);
			this.pulseTextBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(321, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 18);
			this.label5.TabIndex = 32;
			this.label5.Text = "Pulse";
			// 
			// bodyTempTextBox
			// 
			this.bodyTempTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.bodyTempTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bodyTempTextBox.Location = new System.Drawing.Point(23, 125);
			this.bodyTempTextBox.Mask = "###.##";
			this.bodyTempTextBox.Name = "bodyTempTextBox";
			this.bodyTempTextBox.Size = new System.Drawing.Size(198, 27);
			this.bodyTempTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Body Temperature";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(321, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 18);
			this.label3.TabIndex = 27;
			this.label3.Text = "Diastolic";
			// 
			// diastolicTextBox
			// 
			this.diastolicTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.diastolicTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diastolicTextBox.Location = new System.Drawing.Point(324, 54);
			this.diastolicTextBox.Name = "diastolicTextBox";
			this.diastolicTextBox.Size = new System.Drawing.Size(242, 27);
			this.diastolicTextBox.TabIndex = 2;
			// 
			// systolicTextBox
			// 
			this.systolicTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.systolicTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.systolicTextBox.Location = new System.Drawing.Point(22, 54);
			this.systolicTextBox.Name = "systolicTextBox";
			this.systolicTextBox.Size = new System.Drawing.Size(242, 27);
			this.systolicTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "Symptoms";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 18);
			this.label1.TabIndex = 29;
			this.label1.Text = "Systolic";
			// 
			// symptomsTextArea
			// 
			this.symptomsTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.symptomsTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.symptomsTextArea.Location = new System.Drawing.Point(19, 195);
			this.symptomsTextArea.Name = "symptomsTextArea";
			this.symptomsTextArea.Size = new System.Drawing.Size(796, 96);
			this.symptomsTextArea.TabIndex = 5;
			this.symptomsTextArea.Text = "";
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
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(260, 408);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(218, 36);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(25, 408);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(218, 36);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			// 
			// RoutineCheckPage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(904, 459);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pageTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "RoutineCheckPage";
			this.Text = "Appointment";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pageTitleLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox symptomsTextArea;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox diastolicTextBox;
		private System.Windows.Forms.TextBox systolicTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox pulseTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox bodyTempTextBox;
		private System.Windows.Forms.Label label4;
	}
}