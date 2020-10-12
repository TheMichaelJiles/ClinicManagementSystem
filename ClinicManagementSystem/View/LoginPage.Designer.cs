namespace ClinicManagementSystem.View
{
	partial class LoginPage
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.adminLoginLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.loginButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.loginButton.Location = new System.Drawing.Point(30, 227);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(111, 32);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_OnClick);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(30, 169);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(255, 31);
			this.passwordTextBox.TabIndex = 2;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.Color.SlateGray;
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.Location = new System.Drawing.Point(30, 103);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(255, 31);
			this.usernameTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(28, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(28, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.titleLabel.Location = new System.Drawing.Point(26, 23);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(137, 32);
			this.titleLabel.TabIndex = 5;
			this.titleLabel.Text = "User Login";
			// 
			// adminLoginLabel
			// 
			this.adminLoginLabel.AutoSize = true;
			this.adminLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.adminLoginLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminLoginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.adminLoginLabel.Location = new System.Drawing.Point(203, 235);
			this.adminLoginLabel.Name = "adminLoginLabel";
			this.adminLoginLabel.Size = new System.Drawing.Size(82, 16);
			this.adminLoginLabel.TabIndex = 4;
			this.adminLoginLabel.Text = "Admin login";
			this.adminLoginLabel.Click += new System.EventHandler(this.adminLabel_OnClick);
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(321, 296);
			this.Controls.Add(this.adminLoginLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.loginButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoginPage";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label adminLoginLabel;
	}
}