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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }


        private void ProfileForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;
            UpdateDataFields();

            adminToolStripMenuItem.Visible = Program.currentUser.priviligeLevel > 0;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }


        }

        private void updateUserDataOption_Click(object sender, EventArgs e)
        {
            UpdateUserDataForm updateForm = new UpdateUserDataForm(Program.currentUser);
            this.Hide();
            updateForm.Closed += (s, args) => {
                UpdateDataFields();
                this.Show();
                updateForm.Dispose();
            };
            updateForm.ShowDialog(this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.SetIsLoggedIn(Program.currentUser.adojel.ToString(), false);
            Program.currentUser = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateDataFields()
        {
            adojelField.Text = Program.currentUser.adojel.ToString("D10");
            nameField.Text = Program.currentUser.name;
            addressField.Text = Program.currentUser.address;
            if (Program.currentUser.mobileNumber == 0)
            {
                mobileNumberField.Text = "";
            }
            else
            {
                mobileNumberField.Text = Program.currentUser.mobileNumber.ToString("D13");
            }
            mothersNameField.Text = Program.currentUser.mothersName;
        }
    }
}
