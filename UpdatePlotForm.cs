using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ingatlan
{
    public partial class UpdatePlotForm : Form
    {

        private Dictionary<string, int> plotTypeDict;
        private Dictionary<int, string> plotTypeReverseDict;

        Dictionary<string, ListViewItem> plotItems;
        Dictionary<long, ListViewItem> userItems;
        Dictionary<long, ListViewItem> hiddenUserItems;

        Dictionary<long, ListViewItem> ownerItems;
        Dictionary<long, OwnerInfo> startingOwners;
        PlotInfo currentPlot;


        public UpdatePlotForm()
        {
            InitializeComponent();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }


        }

        private void UpdatePlotForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;

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


            DBConnection.Instance.GetPlotTypes(out plotTypeDict);
            plotTypeReverseDict = new Dictionary<int, string>();

            foreach (KeyValuePair<string, int> item in plotTypeDict)
            {
                typeDropdown.Items.Add(item.Key);
                plotTypeReverseDict.Add(item.Value, item.Key);
            }
            typeDropdown.SelectedIndex = 0;

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

            ResetPlotOwnerLists();

            parcelNumberDisplayField.Text = currentPlot.parcelNumber.ToString();
            typeDropdown.Text = plotTypeReverseDict[currentPlot.plotType];
            zipCodeField.Text = currentPlot.zipCode.ToString();
            cityField.Text = currentPlot.city;
            sizeField.Text = currentPlot.size.ToString();
            valueField.Text = currentPlot.value.ToString();
            


            foreach (OwnerInfo item in DBConnection.Instance.GetPlotOwners(currentPlot.id.ToString()))
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

        private void AddOwner(UserInfo userInfo)
        {
            ListViewItem item = userItems[userInfo.adojel];

            userListView.Items.Remove(item);
            hiddenUserItems.Add(userInfo.adojel, item);

            if (!startingOwners.TryGetValue(userInfo.adojel, out OwnerInfo ownerInfo))
            {
                ownerInfo = new OwnerInfo(currentPlot.id, userInfo.adojel, DateTime.Now, 0);
            }



            string title = $"{ownerInfo.ownerID} - {userInfo.name} - {ownerInfo.ownerPercentage}%";

            ListViewItem ownerItem = ownerListView.Items.Add(title);
            ownerListView.Sort();

            ownerItem.Tag = ownerInfo;

            ownerItems.Add(ownerInfo.ownerID, ownerItem);
            ownerListView.SelectedItems.Clear();
            ownerListView.SelectedIndices.Add(ownerListView.Items.Count - 1);
        }

        private void ResetFeedbackLabels()
        {
            parcelNumberFeedbackLabel.Text = "";
            zipCodeFeedbackLabel.Text = "";
            sizeFeedbackLabel.Text = "";
            valueFeedbackLabel.Text = "";
            successFeedbackLabel.Text = "";
            cityFeedbackLabel.Text = "";
            parcelNumberFeedbackLabel.Text = "";
            adojelFeedbackLabel.Text = "";
            percentageFeedbackLabel.Text = "";
        }

        private void ResetPlotFields()
        {
            
            parcelNumberDisplayField.Text = "";
            typeDropdown.Text = "";
            zipCodeField.Text = "";
            cityField.Text = "";
            sizeField.Text = "";
            valueField.Text = "";
            
        }

        private void ResetPlotOwnerLists()
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentPlot == null)
            {
                return;
            }

            ResetFeedbackLabels();
            bool success = true;


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
                //currentPlot = new PlotInfo(parcelNumber, plotTypeDict[(string)typeDropdown.SelectedItem], zipCode, publicSpaceField.Text, cityField.Text, size, value);

                PlotInfo modifiedPlot = new PlotInfo(currentPlot);


                modifiedPlot.plotType = plotTypeDict[(string)typeDropdown.SelectedItem];
                modifiedPlot.zipCode = zipCode;
                modifiedPlot.city = cityField.Text;
                modifiedPlot.size = size;
                modifiedPlot.value = value;

                DBConnection.InsertResult result = DBConnection.Instance.UpdatePlot(modifiedPlot);

                switch (result)
                {
                    case DBConnection.InsertResult.AlreadyExists:
                        if (currentPlot.city.ToLower() == modifiedPlot.city.ToLower())
                        {
                            goto case DBConnection.InsertResult.Success;
                        }
                        cityFeedbackLabel.Text = "Ebben a városban már létezik ezzel az helyrajzi számmal telek";
                        break;
                    case DBConnection.InsertResult.Success:


                        UpdatePlotOwners();
                        ResetPlotFields();
                        ResetFeedbackLabels();
                        ResetPlotOwnerLists();

                        string title = $"[{currentPlot.parcelNumber}] - {currentPlot.city.ToLower()}";

                        ListViewItem listViewItem = plotItems[title];
                        plotItems.Remove(title);

                        currentPlot.plotType = modifiedPlot.plotType;
                        currentPlot.zipCode = modifiedPlot.zipCode;
                        currentPlot.city = modifiedPlot.city;
                        currentPlot.size = modifiedPlot.size;
                        currentPlot.value = modifiedPlot.value;

                        title = $"[{currentPlot.parcelNumber}] - {currentPlot.city}";
                        listViewItem.Text = title;
                        plotItems.Add(title.ToLower(), listViewItem);

                        


                        successFeedbackLabel.ForeColor = Color.Green;
                        successFeedbackLabel.Text = "Telek sikeresen módosítva";
                        

                        
                        break;
                    case DBConnection.InsertResult.Fail:
                        successFeedbackLabel.ForeColor = Color.Red;
                        successFeedbackLabel.Text = "Hiba a telek módosítása közben";
                        break;
                    default:
                        break;
                }

                
            }




        }

        private void UpdatePlotOwners()
        {

            foreach (ListViewItem item in ownerListView.Items)
            {
                OwnerInfo ownerInfo = (OwnerInfo)item.Tag;

                if (startingOwners.TryGetValue(ownerInfo.ownerID, out OwnerInfo value))
                {
                    startingOwners.Remove(ownerInfo.ownerID);

                    DBConnection.Instance.UpdatePlotOwner(value);
                }
                else
                {
                    DBConnection.Instance.AddPlotOwner(ownerInfo);
                }

            }

            foreach (OwnerInfo item in startingOwners.Values)
            {
                DBConnection.Instance.RemovePlotOwner(item);
            }

            startingOwners.Clear();

            foreach (ListViewItem item in ownerListView.Items)
            {
                OwnerInfo ownerInfo = (OwnerInfo)item.Tag;

                startingOwners.Add(ownerInfo.ownerID, ownerInfo);
            }
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
                    ResetPlotFields();
                    ResetPlotOwnerLists();
                    parcelNumberFeedbackLabel.Text = "Ezzel a helyrajzi számmal nincs felvett telek";
                    adojelField.Text = "";
                    adojelFeedbackLabel.Text = "";
                }
                
            }
            else
            {
                ResetPlotFields();
                ResetPlotOwnerLists();
                parcelNumberFeedbackLabel.Text = "Érvénytelen helyrajzi szám";
                adojelField.Text = "";
                adojelFeedbackLabel.Text = "";
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentPlot == null)
            {
                return;
            }
            int buildings = DBConnection.Instance.CountPlotBuildings(currentPlot.parcelNumber);

            if (buildings != 0)
            {
                if (MessageBox.Show($"Biztosan törli ezt a telket? A {buildings} rajta lévő ingatlan is törölve lesz!", "Telek törlése", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.OK)
                {
                    return;
                }

            }
            else if (MessageBox.Show("Biztosan törli ezt a telket?", "Telek törlése", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                return;
            }

            ResetFeedbackLabels();
            ResetPlotFields();
            ResetPlotOwnerLists();


            DBConnection.Instance.DeletePlot(currentPlot);

            string title = $"[{currentPlot.parcelNumber}] - {currentPlot.city.ToLower()}";

            ListViewItem plotListItem = plotItems[title];

            plotListView.Items.Remove(plotListItem);
            plotItems.Remove(title);

            currentPlot = null;

        }

        
    }
}

