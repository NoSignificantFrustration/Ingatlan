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
    public partial class OverviewForm : Form
    {

        private UserInfo currentUser;


        public OverviewForm()
        {
            InitializeComponent();
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {
            FormClosing += OnFormClosing;

            foreach (UserInfo item in DBConnection.Instance.GetUsers())
            {
                ListViewItem listItem = userListView.Items.Add($"[{item.adojel}] - {item.name}");
                listItem.Tag = item;
            }

            foreach (string[] item in DBConnection.Instance.GetMultiOwnedBuildings())
            {
                ListViewItem listItem = new ListViewItem(item);
                multiOwnedBuildingListView.Items.Add(listItem);
            }

            foreach (string[] item in DBConnection.Instance.GetEmptyPlots())
            {
                ListViewItem listItem = new ListViewItem(item);
                emptyPlotsView.Items.Add(listItem);
            }


            string currentGroupName = "";
            ListViewGroup currentGroup = null;

            foreach (string[] item in DBConnection.Instance.GetMultiBuildingPlots())
            {
                if (item[0] != currentGroupName)
                {
                    currentGroupName = item[0];
                    currentGroup = multiBuildingPlotListView.Groups.Add(currentGroupName, currentGroupName);
                }

                ListViewItem listItem = new ListViewItem(new string[]{ item[1], item[2], item[3] });
                multiBuildingPlotListView.Items.Add(listItem);
                listItem.Group = currentGroup;
            }

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count != 1)
            {
                return;
            }

            currentUser = (UserInfo)userListView.SelectedItems[0].Tag;
        }

        private void viewPropertiesButton_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                return;
            }

            ViewPropertiesForm viewPropertiesForm = new ViewPropertiesForm(currentUser.adojel);
            this.Hide();
            viewPropertiesForm.Closed += (s, args) => {
                this.Show();
                viewPropertiesForm.Dispose();
            };
            viewPropertiesForm.ShowDialog(this);
        }

        
    }
}
