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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void registerButtom_Click(object sender, EventArgs e)
        {
            
            RegisterForm reg = new RegisterForm();
            this.Hide();
            reg.Closed +=  (s, args) => { 
                this.Show();
                reg.Dispose();
            };
            reg.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text.Length < 10 || !long.TryParse(usernameField.Text, out long res))
            {
                feedbackLabel.Text = "Érvénytelen adóazonosító jel";
                feedbackLabel.ForeColor = Color.Red;
                return;
            }

            UserInfo user = DBConnection.Instance.GetUserByAdojel(usernameField.Text);

            if (passwordField.Text.Length < 8 || user == null || !PasswordUtility.Validate(passwordField.Text, user.passHash))
            {
                feedbackLabel.Text = "Hibás adóazonosító jel vagy jelszó";
                feedbackLabel.ForeColor = Color.Red;
                return;
            }

            Program.currentUser = user;
            DBConnection.Instance.SetIsLoggedIn(user.adojel.ToString(), true);

            feedbackLabel.Text = "";

            ProfileForm prof = new ProfileForm();
            this.Hide();
            usernameField.Text = "";
            passwordField.Text = "";

            prof.Closed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
                
                prof.Dispose();
            };
            prof.ShowDialog(this);
        }

        
    }
}
