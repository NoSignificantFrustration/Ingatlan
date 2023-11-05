using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ingatlan
{
    public partial class UpdateUserDataForm : Form
    {

        UserInfo userInfo;

        //public UpdateUserDataForm()
        //{
        //    InitializeComponent();
        //}

        public UpdateUserDataForm(UserInfo userInfo)
        {
            InitializeComponent();

            this.userInfo = userInfo;

            nameField.Text = userInfo.name;
            addressField.Text = userInfo.address;
            mobileNumberField.Text = userInfo.mobileNumber.ToString("D13");

            if (Program.currentUser.dateOfBirth != DateTime.MinValue)
            {
                dateOfBirthYearField.Text = userInfo.dateOfBirth.Year.ToString();
                dateOfBirthMonthField.Text = userInfo.dateOfBirth.Month.ToString();
                dateOfBirthDayField.Text = userInfo.dateOfBirth.Day.ToString();
            }

            mothersNameField.Text = userInfo.mothersName;
        }


        private void UpdateUserDataForm_Load(object sender, EventArgs e)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dateOfBirthFeedbackLabel.Text = "";
            mobileNumberFeedbackLabel.Text = "";


            bool success = true;

            string mobileNumber = mobileNumberField.Text;
            if (mobileNumber.StartsWith("+"))
            {
                mobileNumber = "06" + mobileNumber.Substring(1);
            }

            long mobileNumberLong = 0;

            if (mobileNumber.Length != 13 || !long.TryParse(mobileNumber, out mobileNumberLong))
            {
                mobileNumberFeedbackLabel.ForeColor = Color.Red;
                mobileNumberFeedbackLabel.Text = "Érvénytelen telefonszám";
                success = false;
            }



            bool dateValid = true;

            if (!int.TryParse(dateOfBirthYearField.Text, out int year))
            {
                dateValid = false;
            }

            if (!int.TryParse(dateOfBirthMonthField.Text, out int month))
            {
                dateValid = false;
            }

            if (!int.TryParse(dateOfBirthDayField.Text, out int day))
            {
                dateValid = false;
            }

            DateTime dt = DateTime.MinValue;

            if (dateValid)
            {
                dateOfBirthFeedbackLabel.Text = "";
                try
                {
                    dt = new DateTime(year, month, day);
                }
                catch (ArgumentException)
                {
                    dateOfBirthFeedbackLabel.ForeColor = Color.Red;
                    dateOfBirthFeedbackLabel.Text = "Érvénytelen dátum";
                    success = false;

                }


            }
            else
            {
                dateOfBirthFeedbackLabel.ForeColor = Color.Red;
                dateOfBirthFeedbackLabel.Text = "Érvénytelen dátum";
                success = false;
            }



            if (success)
            {
                userInfo.name = nameField.Text;
                userInfo.address = addressField.Text;
                userInfo.mobileNumber = mobileNumberLong;
                userInfo.dateOfBirth = dt;
                userInfo.mothersName = mothersNameField.Text;

                DBConnection.Instance.UpdateUserData(userInfo);

                DialogResult = DialogResult.Abort;
                Close();
            }


        }

    }
}
