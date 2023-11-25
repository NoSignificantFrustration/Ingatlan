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
    public partial class ViewPropertiesForm : Form
    {
        public ViewPropertiesForm(long userId)
        {
            InitializeComponent();


            foreach (string[] item in DBConnection.Instance.ListOwnedPlots(userId))
            {
                plotListView.Items.Add(new ListViewItem(item));
            }

            foreach (string[] item in DBConnection.Instance.ListOwnedBuildings(userId))
            {
                buildingListView.Items.Add(new ListViewItem(item));
            }


        }

        private void ViewPropertiesForm_Load(object sender, EventArgs e)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
