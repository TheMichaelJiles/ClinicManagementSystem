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
			this.diastolicNumberUpDown = new System.Windows.Forms.NumericUpDown();
			this.systolicNumberUpDown = new System.Windows.Forms.NumericUpDown();
			this.bodyTempNumberUpDown = new System.Windows.Forms.NumericUpDown();
			this.pulseNumberUpDown = new System.Windows.Forms.NumericUpDown();
			this.weightNumberUpDown = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.symptomsTextArea = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.diastolicNumberUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.systolicNumberUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bodyTempNumberUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pulseNumberUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.weightNumberUpDown)).BeginInit();
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
			this.panel2.Controls.Add(this.diastolicNumberUpDown);
			this.panel2.Controls.Add(this.systolicNumberUpDown);
			this.panel2.Controls.Add(this.bodyTempNumberUpDown);
			this.panel2.Controls.Add(this.pulseNumberUpDown);
			this.panel2.Controls.Add(this.weightNumberUpDown);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.symptomsTextArea);
			this.panel2.Location = new System.Drawing.Point(25, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(859, 312);
			this.panel2.TabIndex = 1;
			// 
			// diastolicNumberUpDown
			// 
			this.diastolicNumberUpDown.BackColor = System.Drawing.Color.SlateGray;
			this.diastolicNumberUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diastolicNumberUpDown.Location = new System.Drawing.Point(274, 54);
			this.diastolicNumberUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.diastolicNumberUpDown.Name = "diastolicNumberUpDown";
			this.diastolicNumberUpDown.Size = new System.Drawing.Size(198, 27);
			this.diastolicNumberUpDown.TabIndex = 41;
			// 
			// systolicNumberUpDown
			// 
			this.systolicNumberUpDown.BackColor = System.Drawing.Color.SlateGray;
			this.systolicNumberUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.systolicNumberUpDown.Location = new System.Drawing.Point(23, 54);
			this.systolicNumberUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.systolicNumberUpDown.Name = "systolicNumberUpDown";
			this.systolicNumberUpDown.Size = new System.Drawing.Size(198, 27);
			this.systolicNumberUpDown.TabIndex = 40;
			// 
			// bodyTempNumberUpDown
			// 
			this.bodyTempNumberUpDown.BackColor = System.Drawing.Color.SlateGray;
			this.bodyTempNumberUpDown.DecimalPlaces = 2;
			this.bodyTempNumberUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bodyTempNumberUpDown.Location = new System.Drawing.Point(23, 126);
			this.bodyTempNumberUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.bodyTempNumberUpDown.Name = "bodyTempNumberUpDown";
			this.bodyTempNumberUpDown.Size = new System.Drawing.Size(198, 27);
			this.bodyTempNumberUpDown.TabIndex = 39;
			// 
			// pulseNumberUpDown
			// 
			this.pulseNumberUpDown.BackColor = System.Drawing.Color.SlateGray;
			this.pulseNumberUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pulseNumberUpDown.Location = new System.Drawing.Point(274, 126);
			this.pulseNumberUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.pulseNumberUpDown.Name = "pulseNumberUpDown";
			this.pulseNumberUpDown.Size = new System.Drawing.Size(198, 27);
			this.pulseNumberUpDown.TabIndex = 38;
			// 
			// weightNumberUpDown
			// 
			this.weightNumberUpDown.BackColor = System.Drawing.Color.SlateGray;
			this.weightNumberUpDown.DecimalPlaces = 2;
			this.weightNumberUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weightNumberUpDown.Location = new System.Drawing.Point(526, 126);
			this.weightNumberUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.weightNumberUpDown.Name = "weightNumberUpDown";
			this.weightNumberUpDown.Size = new System.Drawing.Size(198, 27);
			this.weightNumberUpDown.TabIndex = 37;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(523, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 18);
			this.label6.TabIndex = 34;
			this.label6.Text = "Weight";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(271, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 18);
			this.label5.TabIndex = 32;
			this.label5.Text = "Pulse";
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
			this.label3.Location = new System.Drawing.Point(271, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 18);
			this.label3.TabIndex = 27;
			this.label3.Text = "Diastolic Blood Pressure";
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
			this.label1.Size = new System.Drawing.Size(199, 18);
			this.label1.TabIndex = 29;
			this.label1.Text = "Systolic Blood Pressure";
			// 
			// symptomsTextArea
			// 
			this.symptomsTextArea.BackColor = System.Drawing.Color.SlateGray;
			this.symptomsTextArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.symptomsTextArea.Location = new System.Drawing.Point(19, 195);
			this.symptomsTextArea.Name = "symptomsTextArea";
			this.symptomsTextArea.Size = new System.Drawing.Size(796, 96);
			this.symptomsTextArea.TabIndex = 7;
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
			this.saveButton.TabIndex = 8;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(25, 408);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(218, 36);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
			this.ShowInTaskbar = false;
			this.Text = "Appointment";
			this.Load += new System.EventHandler(this.onLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.diastolicNumberUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.systolicNumberUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bodyTempNumberUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pulseNumberUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.weightNumberUpDown)).EndInit();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown weightNumberUpDown;
		private System.Windows.Forms.NumericUpDown diastolicNumberUpDown;
		private System.Windows.Forms.NumericUpDown systolicNumberUpDown;
		private System.Windows.Forms.NumericUpDown bodyTempNumberUpDown;
		private System.Windows.Forms.NumericUpDown pulseNumberUpDown;
	}
}