using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingatlan
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool success = true;
            usernameFeedbackLabel.Text = "";
            if (usernameField.Text.Length < 10 || !long.TryParse(usernameField.Text, out long res) || res < 0)
            {
                usernameFeedbackLabel.Text = "Érvénytelen adóazonosító jel";
                usernameFeedbackLabel.ForeColor = Color.Red;
                success = false;
            }

            passwordFeedbackLabel.ForeColor = Color.Red;

            passwordFeedbackLabel.Text = "";

            if (passwordField.Text.Length < 8)
            {
                passwordFeedbackLabel.Text = "Jelszó túl rövid (legalább 8 karakter)";
                success = false;

            }

            passwordConfirmFeedbackLabel.Text = "";
            if (passwordVerifyField.Text != passwordField.Text)
            {
                passwordConfirmFeedbackLabel.ForeColor = Color.Red;
                passwordConfirmFeedbackLabel.Text = "A két jelszó nem egyezik";
                success = false;
            }

            string password = passwordField.Text;
            passwordField.Text = "";
            passwordVerifyField.Text = "";

            if (success)
            {
                

                DBConnection.RegisterResult registerResult = DBConnection.Instance.Register(usernameField.Text, password);

                usernameFeedbackLabel.Text = "";
                usernameField.Text = "";
                passwordFeedbackLabel.Text = "";

                switch (registerResult)
                {
                    case DBConnection.RegisterResult.AdojelAlreadyTaken:
                        passwordConfirmFeedbackLabel.ForeColor = Color.Red;
                        usernameFeedbackLabel.Text = "Ezzel az adójellel már létezik fiók";
                        break;
                    case DBConnection.RegisterResult.Success:
                        passwordConfirmFeedbackLabel.ForeColor = Color.Green;
                        passwordConfirmFeedbackLabel.Text = "Sikeres regisztráció";
                        break;
                    case DBConnection.RegisterResult.Fail:
                        passwordConfirmFeedbackLabel.ForeColor = Color.Red;
                        usernameField.Text = "Hiba a regisztráció közben";
                        break;
                }


                
            }
            
        }

    }
}
