
namespace Ingatlan
{
    partial class OverviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewPropertiesButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.multiOwnedBuildingListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emptyPlotsView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.multiBuildingPlotListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(12, 36);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(197, 158);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.userListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Felhasználók";
            this.columnHeader1.Width = 191;
            // 
            // viewPropertiesButton
            // 
            this.viewPropertiesButton.Location = new System.Drawing.Point(71, 200);
            this.viewPropertiesButton.Name = "viewPropertiesButton";
            this.viewPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.viewPropertiesButton.TabIndex = 1;
            this.viewPropertiesButton.Text = "Megtekintés";
            this.viewPropertiesButton.UseVisualStyleBackColor = true;
            this.viewPropertiesButton.Click += new System.EventHandler(this.viewPropertiesButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.closeButton.Location = new System.Drawing.Point(12, 477);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(145, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Vissza";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // multiOwnedBuildingListView
            // 
            this.multiOwnedBuildingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.multiOwnedBuildingListView.HideSelection = false;
            this.multiOwnedBuildingListView.Location = new System.Drawing.Point(12, 250);
            this.multiOwnedBuildingListView.Name = "multiOwnedBuildingListView";
            this.multiOwnedBuildingListView.Size = new System.Drawing.Size(599, 158);
            this.multiOwnedBuildingListView.TabIndex = 3;
            this.multiOwnedBuildingListView.UseCompatibleStateImageBehavior = false;
            this.multiOwnedBuildingListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Helyrajzi szám";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Település";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Közterület";
            this.columnHeader4.Width = 220;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Házszám";
            this.columnHeader10.Width = 66;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tulajdonosok száma";
            this.columnHeader11.Width = 110;
            // 
            // emptyPlotsView
            // 
            this.emptyPlotsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.emptyPlotsView.HideSelection = false;
            this.emptyPlotsView.Location = new System.Drawing.Point(240, 36);
            this.emptyPlotsView.Name = "emptyPlotsView";
            this.emptyPlotsView.Size = new System.Drawing.Size(371, 158);
            this.emptyPlotsView.TabIndex = 4;
            this.emptyPlotsView.UseCompatibleStateImageBehavior = false;
            this.emptyPlotsView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Helyrajzi szám";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Település";
            this.columnHeader6.Width = 274;
            // 
            // multiBuildingPlotListView
            // 
            this.multiBuildingPlotListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.multiBuildingPlotListView.HideSelection = false;
            this.multiBuildingPlotListView.Location = new System.Drawing.Point(629, 36);
            this.multiBuildingPlotListView.Name = "multiBuildingPlotListView";
            this.multiBuildingPlotListView.Size = new System.Drawing.Size(400, 372);
            this.multiBuildingPlotListView.TabIndex = 5;
            this.multiBuildingPlotListView.UseCompatibleStateImageBehavior = false;
            this.multiBuildingPlotListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tulajdonos adójel";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tulajdonos neve";
            this.columnHeader8.Width = 193;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tulajdonhányad";
            this.columnHeader9.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Felhasználók tulajdonainak  megtekintése";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Több ingatlant tartalmazó telkek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Üres telkek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Több tulajdonossal rendelkező ingatlanok";
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiBuildingPlotListView);
            this.Controls.Add(this.emptyPlotsView);
            this.Controls.Add(this.multiOwnedBuildingListView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewPropertiesButton);
            this.Controls.Add(this.userListView);
            this.Name = "OverviewForm";
            this.Text = "Tulajdonok áttekintése";
            this.Load += new System.EventHandler(this.OverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.Button viewPropertiesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView multiOwnedBuildingListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView emptyPlotsView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView multiBuildingPlotListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}