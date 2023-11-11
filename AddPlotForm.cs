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
    public partial class AddPlotForm : Form
    {

        private Dictionary<string, int> plotTypeDict;

        public AddPlotForm()
        {
            InitializeComponent();
        }

        private void AddPlotForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;
            SetupTypeDropdown();
            ResetForm();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetFeedbackLabels()
        {
            parcelNumberFeedbackLabel.Text = "";
            zipCodeFeedbackLabel.Text = "";
            sizeFeedbackLabel.Text = "";
            valueFeedbackLabel.Text = "";
            successFeedbackLabel.Text = "";
        }

        private void ResetForm()
        {
            ResetFeedbackLabels();
            parcelNumberField.Text = "";
            zipCodeField.Text = "";
            publicSpaceField.Text = "";
            cityField.Text = "";
            sizeField.Text = "";
            valueField.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ResetFeedbackLabels();
            bool success = true;

            if (!int.TryParse(parcelNumberField.Text, out int parcelNumber) || parcelNumber <= 0)
            {
                success = false;
                parcelNumberFeedbackLabel.Text = "Érvénytelen helyrajzi szám";
            }
            

            if (!int.TryParse(zipCodeField.Text, out int zipCode) || zipCode <= 0)
            {
                success = false;
                zipCodeFeedbackLabel.Text = "Érvénytelen irányítószám";
            }

            if (!ulong.TryParse(sizeField.Text, out ulong size))
            {
                success = false;
                sizeFeedbackLabel.Text = "Érvénytelen méret";
            }

            if (!ulong.TryParse(valueField.Text, out ulong value))
            {
                success = false;
                valueFeedbackLabel.Text = "Érvénytelen érték";
            }

            if (success)
            {
                PlotInfo plot = new PlotInfo(parcelNumber, plotTypeDict[(string)typeDropdown.SelectedItem], zipCode, publicSpaceField.Text, cityField.Text, size, value);

                switch (DBConnection.Instance.AddPlot(plot))
                {
                    case DBConnection.InsertResult.AlreadyExists:
                        parcelNumberFeedbackLabel.Text = "Ezzel a helyrajzi számmal már létezik telek";
                        return;
                    case DBConnection.InsertResult.Success:
                        ResetForm();
                        successFeedbackLabel.Text = "Telek sikeresen felvéve";
                        
                        break;
                    case DBConnection.InsertResult.Fail:
                        successFeedbackLabel.Text = "Hiba a telek felvétele közben";
                        break;
                }


                
            }
        }

        private void SetupTypeDropdown()
        {
            DBConnection.Instance.GetPlotTypes(out plotTypeDict);

            foreach (KeyValuePair<string, int> item in plotTypeDict)
            {
                typeDropdown.Items.Add(item.Key);
            }
            typeDropdown.SelectedIndex = 0;
        }

    }
}
