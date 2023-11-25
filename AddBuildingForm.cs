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
    public partial class AddBuildingForm : Form
    {

        private Dictionary<string, int> buildingTypeDict;
        private Dictionary<int, string> buildingTypeReverseDict;
        Dictionary<string, ListViewItem> plotItems;
        PlotInfo currentPlot;


        public AddBuildingForm()
        {
            InitializeComponent();
        }

        private void AddBuildingForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;

            DBConnection.Instance.GetBuildingTypes(out buildingTypeDict);

            ResetFeedbackLabels();

            plotItems = new Dictionary<string, ListViewItem>();
            List<PlotInfo> plots = DBConnection.Instance.GetPlots();

            foreach (PlotInfo item in plots)
            {
                string title = $"[{item.parcelNumber}] - {item.city}";
                ListViewItem listItem = plotListView.Items.Add(title);
                listItem.Tag = item;
                plotItems.Add(title.ToLower(), listItem);
            }



            buildingTypeReverseDict = new Dictionary<int, string>();

            foreach (KeyValuePair<string, int> item in buildingTypeDict)
            {
                typeDropdown.Items.Add(item.Key);
                buildingTypeReverseDict.Add(item.Value, item.Key);
            }
            typeDropdown.SelectedIndex = 0;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }


        }

        /*private string StringCapitalize(string s)
        {
            s = s.Trim();

            if (s.Length == 0)
            {
                return s;
            }
            return char.ToUpper(s[0]) + s.ToLower().Substring(1, s.Length - 1);
        }*/

        private void ResetForm()
        {
            currentPlot = null;
            parcelNumberDisplayField.Text = "";
            typeDropdown.SelectedIndex = 0;
            yearBuiltField.Text = "";
            publicSpaceField.Text = "";
            houseNumberField.Text = "";
            valueField.Text = "";
            ResetFeedbackLabels();
        }

        private void ResetFeedbackLabels()
        {
            parcelNumberFeedbackLabel.Text = "";
            parcelNumberDisplayFeedbackLabel.Text = "";
            yearBuiltFeedbackLabel.Text = "";
            houseNumberFeedbackLabel.Text = "";
            valueFeedbackLabel.Text = "";
            successFeedbackLabel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentPlot == null)
            {
                parcelNumberDisplayFeedbackLabel.Text = "Válassz ki egy telket a telek listából";
                successFeedbackLabel.Text = "";
                return;
            }

            ResetFeedbackLabels();
            bool success = true;


            if (!int.TryParse(yearBuiltField.Text, out int yearBuilt) || yearBuilt <= 0)
            {
                success = false;
                yearBuiltFeedbackLabel.Text = "Érvénytelen év";
            }


            if (!ulong.TryParse(valueField.Text, out ulong value))
            {
                success = false;
                valueFeedbackLabel.Text = "Érvénytelen érték";
            }

            if (success)
            {


                BuildingInfo buildingInfo = new BuildingInfo(-1, currentPlot.id, buildingTypeDict[typeDropdown.Text], yearBuilt, publicSpaceField.Text, houseNumberField.Text, value);

                DBConnection.Instance.AddBuilding(buildingInfo);
                ResetForm();
                successFeedbackLabel.Visible = true;
                currentPlot = null;
                

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plotListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plotListView.SelectedItems.Count != 1)
            {
                return;
            }


            SelectPlot((PlotInfo)plotListView.SelectedItems[0].Tag);
        }

        private void SelectPlot(PlotInfo plot)
        {
            ResetFeedbackLabels();
            currentPlot = plot;


            parcelNumberDisplayField.Text = currentPlot.parcelNumber.ToString();
            
        }

        private void parcelSearchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(parcelNumberField.Text, out int parcelNumber))
            {
                if (plotItems.TryGetValue($"[{parcelNumber}] - {citySearchField.Text.ToLower()}", out ListViewItem listItem))
                {

                    SelectPlot((PlotInfo)listItem.Tag);
                    parcelNumberField.Text = "";
                    citySearchField.Text = "";
                    parcelNumberFeedbackLabel.ForeColor = Color.Green;
                    parcelNumberFeedbackLabel.Text = "Telek sikeresen kiválasztva";
                }
                else
                {
                    parcelNumberFeedbackLabel.ForeColor = Color.Red;
                    parcelNumberFeedbackLabel.Text = "Ezzel a helyrajzi számmal és településsel nincs felvett telek";
                }

            }
            else
            {
                parcelNumberFeedbackLabel.Text = "Érvénytelen helyrajzi szám";
            }
        }
    }
}
