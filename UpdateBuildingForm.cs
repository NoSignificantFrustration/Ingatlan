using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ingatlan
{
    public partial class UpdateBuildingForm : Form
    {
        private Dictionary<string, ListViewItem> plotItems;
        private Dictionary<string, int> buildingTypeDict;
        private Dictionary<int, string> buildingTypeReverseDict;

        private Dictionary<long, ListViewItem> buildingItems;

        private Dictionary<long, ListViewItem> userItems;
        private Dictionary<long, ListViewItem> hiddenUserItems;

        private Dictionary<long, ListViewItem> ownerItems;
        private Dictionary<long, OwnerInfo> startingOwners;

        private PlotInfo currentPlot;
        private BuildingInfo currentBuilding;

        public UpdateBuildingForm()
        {
            InitializeComponent();
        }

        private void UpdateBuildingForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;

            ResetFeedbackLabels();

            plotItems = new Dictionary<string, ListViewItem>();
            List<PlotInfo> plots = DBConnection.Instance.GetPlots();

            buildingItems = new Dictionary<long, ListViewItem>();
            buildingListView.Columns.Add("Ingatlan", -2);

            foreach (PlotInfo item in plots)
            {
                string title = $"[{item.parcelNumber}] - {item.city}";
                ListViewItem listItem = plotListView.Items.Add(title);
                listItem.Tag = item;
                plotItems.Add(title.ToLower(), listItem);
            }

            userItems = new Dictionary<long, ListViewItem>();

            List<UserInfo> users = DBConnection.Instance.GetUsers();

            foreach (UserInfo item in users)
            {
                string title = $"[{item.adojel}] - {item.name}";
                ListViewItem listItem = userListView.Items.Add(title);
                listItem.Tag = item;


                userItems.Add(item.adojel, listItem);

            }

            hiddenUserItems = new Dictionary<long, ListViewItem>();

            ownerItems = new Dictionary<long, ListViewItem>();
            startingOwners = new Dictionary<long, OwnerInfo>();


            DBConnection.Instance.GetPlotTypes(out buildingTypeDict);
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

        private void plotListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plotListView.SelectedItems.Count != 1)
            {
                return;
            }


            SelectPlot((PlotInfo)plotListView.SelectedItems[0].Tag);
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

        private void SelectPlot(PlotInfo plot)
        {
            currentBuilding = null;

            ResetFeedbackLabels();
            currentPlot = plot;

            ResetBuildingOwnerLists();
            successFeedbackLabel.Visible = false;

            parcelNumberDisplayField.Text = currentPlot.parcelNumber.ToString();
            //typeDropdown.Text = plotTypeReverseDict[currentPlot.plotType];
            //zipCodeField.Text = currentPlot.zipCode.ToString();
            //cityField.Text = currentPlot.city;
            //sizeField.Text = currentPlot.size.ToString();
            //valueField.Text = currentPlot.value.ToString();

            buildingItems.Clear();
            buildingListView.Items.Clear();


            foreach (BuildingInfo item in DBConnection.Instance.GetPlotBuildings(currentPlot.id))
            {
                string title = $"[{item.id}] - {item.yearBuilt} - {item.publicSpace} {item.houseNumber}";
                ListViewItem listItem = new ListViewItem(title);
                listItem.Tag = item;
                listItem.Name = "Ingatlan";
                listItem.Text = title;
                //listItem.SubItems.Add(title);

                buildingItems.Add(item.id, listItem);
                buildingListView.Items.Add(listItem);

            }

            buildingListView.Sort();

        }

        private void SelectBuilding(BuildingInfo buildingInfo)
        {
            ResetFeedbackLabels();
            ResetBuildingOwnerLists();

            currentBuilding = buildingInfo;

            typeDropdown.Text = buildingTypeReverseDict[buildingInfo.buildingType];
            yearBuiltField.Text = buildingInfo.yearBuilt.ToString();
            publicSpaceField.Text = buildingInfo.publicSpace;
            houseNumberField.Text = buildingInfo.houseNumber;
            valueField.Text = buildingInfo.value.ToString();



            foreach (OwnerInfo item in DBConnection.Instance.GetBuildingOwners(currentBuilding.id.ToString()))
            {
                ListViewItem userItem = userItems[item.ownerID];
                userListView.Items.Remove(userItem);

                hiddenUserItems.Add(item.ownerID, userItem);

                string title = $"{item.ownerID} - {((UserInfo)userItems[item.ownerID].Tag).name} - {item.ownerPercentage}%";

                ListViewItem ownerItem = ownerListView.Items.Add(title);

                ownerItem.Tag = item;

                ownerItems.Add(item.ownerID, ownerItem);
                startingOwners.Add(item.ownerID, item);

            }

            userListView.Sort();
        }

        private void ResetBuildingOwnerLists()
        {
            foreach (ListViewItem item in hiddenUserItems.Values)
            {

                userListView.Items.Add(item);
            }

            ownerListView.Items.Clear();
            ownerItems.Clear();

            startingOwners.Clear();

            hiddenUserItems.Clear();
        }

        private void ResetFeedbackLabels()
        {
            parcelNumberDisplayFeedbackLabel.Text = "";
            yearBuiltFeedbackLabel.Text = "";
            houseNumberFeedbackLabel.Text = "";
            valueFeedbackLabel.Text = "";
            successFeedbackLabel.Text = "";
            //percentageFeedbackLabel.Text = "";
            //adojelFeedbackLabel.Text = "";
        }

        private void buildingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buildingListView.SelectedItems.Count != 1)
            {
                return;
            }


            SelectBuilding((BuildingInfo)buildingListView.SelectedItems[0].Tag);
        }

        private void ResetBuildingFields()
        {
            parcelNumberDisplayField.Text = "";
            yearBuiltField.Text = "";
            publicSpaceField.Text = "";
            houseNumberField.Text = "";
            valueField.Text = "";
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
                    parcelNumberFeedbackLabel.Text = "";
                }
                else
                {

                    ResetBuildingFields();
                    ResetBuildingOwnerLists();
                    parcelNumberFeedbackLabel.Text = "Ezzel a helyrajzi számmal nincs felvett telek";
                    adojelField.Text = "";
                    adojelFeedbackLabel.Text = "";
                }

            }
            else
            {
                ResetBuildingFields();
                ResetBuildingOwnerLists();
                parcelNumberFeedbackLabel.Text = "Érvénytelen helyrajzi szám";
                adojelField.Text = "";
                adojelFeedbackLabel.Text = "";
            }
        }

        private void setOwnerPercentageButton_Click(object sender, EventArgs e)
        {
            if (ownerListView.SelectedItems.Count != 1)
            {
                return;
            }

            if (int.TryParse(ownerPercentageField.Text, out int percentage))
            {
                if (percentage > 0 && percentage <= 100)
                {
                    OwnerInfo ownerInfo = (OwnerInfo)ownerListView.SelectedItems[0].Tag;

                    ownerInfo.ownerPercentage = percentage;
                    percentageFeedbackLabel.Text = "";
                    ownerPercentageField.Text = "";
                    ownerListView.SelectedItems[0].Text = $"{ownerInfo.ownerID} - {((UserInfo)userItems[ownerInfo.ownerID].Tag).name} - {ownerInfo.ownerPercentage}%";
                }
                else
                {
                    percentageFeedbackLabel.Text = "Érvénytelen érték";
                }

            }
            else
            {
                percentageFeedbackLabel.Text = "Érvénytelen érték";
            }
        }

        private void adojelSearchButton_Click(object sender, EventArgs e)
        {
            percentageFeedbackLabel.Text = "";
            ownerPercentageField.Text = "";

            if (long.TryParse(adojelField.Text, out long adojel))
            {
                if (ownerItems.ContainsKey(adojel))
                {
                    adojelFeedbackLabel.Text = "Ez a személy már tulajdonos";
                }
                else if (userItems.TryGetValue(adojel, out ListViewItem listItem))
                {
                    AddOwner((UserInfo)listItem.Tag);
                    adojelField.Text = "";
                    adojelFeedbackLabel.Text = "";
                }
                else
                {
                    adojelFeedbackLabel.Text = "Felhasználó nem található";
                }

            }
            else
            {
                adojelFeedbackLabel.Text = "Érvénytelen adójel";
            }
        }

        private void AddOwner(UserInfo userInfo)
        {
            if (currentBuilding == null)
            {
                return;
            }

            ListViewItem item = userItems[userInfo.adojel];

            userListView.Items.Remove(item);
            hiddenUserItems.Add(userInfo.adojel, item);

            if (!startingOwners.TryGetValue(userInfo.adojel, out OwnerInfo ownerInfo))
            {
                ownerInfo = new OwnerInfo(currentBuilding.id, userInfo.adojel, DateTime.Now, 0);
            }



            string title = $"{ownerInfo.ownerID} - {userInfo.name} - {ownerInfo.ownerPercentage}%";

            ListViewItem ownerItem = ownerListView.Items.Add(title);
            ownerListView.Sort();

            ownerItem.Tag = ownerInfo;

            ownerItems.Add(ownerInfo.ownerID, ownerItem);
            ownerListView.SelectedItems.Clear();
            ownerListView.SelectedIndices.Add(ownerItems.Count - 1);
        }

        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            if (currentPlot == null)
            {
                return;
            }

            foreach (ListViewItem item in userListView.SelectedItems)
            {
                UserInfo userInfo = (UserInfo)item.Tag;

                AddOwner(userInfo);
            }
        }

        private void removeOwnerButton_Click(object sender, EventArgs e)
        {

            if (currentPlot == null)
            {
                return;
            }

            foreach (ListViewItem item in ownerListView.SelectedItems)
            {
                OwnerInfo userInfo = (OwnerInfo)item.Tag;

                userListView.Items.Add(hiddenUserItems[userInfo.ownerID]);
                userListView.Sort();
                hiddenUserItems.Remove(userInfo.ownerID);

                ownerItems.Remove(userInfo.ownerID);
                ownerListView.Items.Remove(item);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentBuilding == null)
            {
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
                currentBuilding.buildingType = buildingTypeDict[typeDropdown.Text];
                currentBuilding.yearBuilt = yearBuilt;
                currentBuilding.publicSpace = publicSpaceField.Text;
                currentBuilding.houseNumber = houseNumberField.Text;
                currentBuilding.value = value;

                buildingItems[currentBuilding.id].Text = $"[{currentBuilding.id}] - {currentBuilding.yearBuilt} - {currentBuilding.publicSpace} {currentBuilding.houseNumber}";

                DBConnection.Instance.UpdateBuilding(currentBuilding);
                ResetBuildingFields();
                successFeedbackLabel.Visible = true;
                UpdateBuildingOwners();

            }


        }

        private void UpdateBuildingOwners()
        {

            foreach (ListViewItem item in ownerListView.Items)
            {
                OwnerInfo ownerInfo = (OwnerInfo)item.Tag;

                if (startingOwners.TryGetValue(ownerInfo.ownerID, out OwnerInfo value))
                {
                    startingOwners.Remove(ownerInfo.ownerID);

                    DBConnection.Instance.UpdateBuildingOwner(value);
                }
                else
                {
                    DBConnection.Instance.AddBuildingOwner(ownerInfo);
                }

            }

            foreach (OwnerInfo item in startingOwners.Values)
            {
                DBConnection.Instance.RemoveBuildingOwner(item);
            }

            startingOwners.Clear();

            foreach (ListViewItem item in ownerListView.Items)
            {
                OwnerInfo ownerInfo = (OwnerInfo)item.Tag;

                startingOwners.Add(ownerInfo.ownerID, ownerInfo);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentBuilding == null)
            {
                return;
            }


            if (MessageBox.Show("Biztosan törli ezt az ingatlant?", "ingatlan törlése", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                return;
            }

            ResetFeedbackLabels();
            ResetBuildingFields();
            ResetBuildingOwnerLists();


            DBConnection.Instance.DeleteBuilding(currentBuilding);

           

            ListViewItem buildingListItem = buildingItems[currentBuilding.id];

            buildingListView.Items.Remove(buildingListItem);
            buildingItems.Remove(currentBuilding.id);

            currentBuilding = null;
        }
    }
}
