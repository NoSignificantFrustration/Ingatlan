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
            //Adatbázis check
            else if (false)
            {
                usernameFeedbackLabel.Text = "Ezzel az adóazonosító jellel már létezik fiók";
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
            passwordField.Text = "";
            passwordVerifyField.Text = "";

            if (success)
            {
                usernameFeedbackLabel.Text = "";
                usernameField.Text = "";
                passwordFeedbackLabel.Text = "";
                
                

                passwordConfirmFeedbackLabel.ForeColor = Color.Green;
                passwordConfirmFeedbackLabel.Text = "Sikeres regisztráció";
            }
            
        }

    }
}
