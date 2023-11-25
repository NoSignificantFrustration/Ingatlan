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
            if (MessageBox.Show("Bitosan ki akar jelentkezni?", "Kijelentkezés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

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
            dateOfBirthField.Text = Program.currentUser.dateOfBirth.ToString("yyyy-MM-dd");
            mothersNameField.Text = Program.currentUser.mothersName;
        }

        private void addPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlotForm addPlotForm = new AddPlotForm();
            this.Hide();
            addPlotForm.Closed += (s, args) => {
                this.Show();
                addPlotForm.Dispose();
            };
            addPlotForm.ShowDialog(this);
        }

        private void updatePlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePlotForm updatePlotForm = new UpdatePlotForm();
            this.Hide();
            updatePlotForm.Closed += (s, args) => {
                this.Show();
                updatePlotForm.Dispose();
            };
            updatePlotForm.ShowDialog(this);
        }

        private void addBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBuildingForm addBuildingForm = new AddBuildingForm();
            this.Hide();
            addBuildingForm.Closed += (s, args) => {
                this.Show();
                addBuildingForm.Dispose();
            };
            addBuildingForm.ShowDialog(this);
        }

        private void updateBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBuildingForm updateBuildingForm = new UpdateBuildingForm();
            this.Hide();
            updateBuildingForm.Closed += (s, args) => {
                this.Show();
                updateBuildingForm.Dispose();
            };
            updateBuildingForm.ShowDialog(this);
        }

        private void viewMyPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPropertiesForm viewPropertiesForm = new ViewPropertiesForm(Program.currentUser.adojel);
            this.Hide();
            viewPropertiesForm.Closed += (s, args) => {
                this.Show();
                viewPropertiesForm.Dispose();
            };
            viewPropertiesForm.ShowDialog(this);
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverviewForm overviewForm = new OverviewForm();
            this.Hide();
            overviewForm.Closed += (s, args) => {
                this.Show();
                overviewForm.Dispose();
            };
            overviewForm.ShowDialog(this);
        }
    }
}
