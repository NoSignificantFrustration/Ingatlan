
namespace Ingatlan
{
    partial class RegisterForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordVerifyField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameFeedbackLabel = new System.Windows.Forms.Label();
            this.passwordFeedbackLabel = new System.Windows.Forms.Label();
            this.passwordConfirmFeedbackLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(161, 109);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Adóazonosító jel";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(164, 125);
            this.usernameField.MaxLength = 10;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 1;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(164, 184);
            this.passwordField.MaxLength = 100;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // passwordVerifyField
            // 
            this.passwordVerifyField.Location = new System.Drawing.Point(164, 248);
            this.passwordVerifyField.MaxLength = 100;
            this.passwordVerifyField.Name = "passwordVerifyField";
            this.passwordVerifyField.PasswordChar = '*';
            this.passwordVerifyField.Size = new System.Drawing.Size(100, 20);
            this.passwordVerifyField.TabIndex = 3;
            this.passwordVerifyField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jelszó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó újra";
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginButton.Location = new System.Drawing.Point(164, 372);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Már van fiókom";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameFeedbackLabel
            // 
            this.usernameFeedbackLabel.AutoSize = true;
            this.usernameFeedbackLabel.Location = new System.Drawing.Point(161, 148);
            this.usernameFeedbackLabel.Name = "usernameFeedbackLabel";
            this.usernameFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameFeedbackLabel.TabIndex = 8;
            // 
            // passwordFeedbackLabel
            // 
            this.passwordFeedbackLabel.AutoSize = true;
            this.passwordFeedbackLabel.Location = new System.Drawing.Point(161, 207);
            this.passwordFeedbackLabel.Name = "passwordFeedbackLabel";
            this.passwordFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordFeedbackLabel.TabIndex = 9;
            // 
            // passwordConfirmFeedbackLabel
            // 
            this.passwordConfirmFeedbackLabel.AutoSize = true;
            this.passwordConfirmFeedbackLabel.Location = new System.Drawing.Point(161, 271);
            this.passwordConfirmFeedbackLabel.Name = "passwordConfirmFeedbackLabel";
            this.passwordConfirmFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordConfirmFeedbackLabel.TabIndex = 10;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(164, 321);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 23);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Regisztráció";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordConfirmFeedbackLabel);
            this.Controls.Add(this.passwordFeedbackLabel);
            this.Controls.Add(this.usernameFeedbackLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordVerifyField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.usernameLabel);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "RegisterForm";
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox passwordVerifyField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameFeedbackLabel;
        private System.Windows.Forms.Label passwordFeedbackLabel;
        private System.Windows.Forms.Label passwordConfirmFeedbackLabel;
        private System.Windows.Forms.Button registerButton;
    }
}