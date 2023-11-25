
namespace Ingatlan
{
    partial class UpdateBuildingForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.citySearchField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.publicSpaceField = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.parcelNumberDisplayFeedbackLabel = new System.Windows.Forms.Label();
            this.successFeedbackLabel = new System.Windows.Forms.Label();
            this.valueFeedbackLabel = new System.Windows.Forms.Label();
            this.houseNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.yearBuiltFeedbackLabel = new System.Windows.Forms.Label();
            this.valueField = new System.Windows.Forms.TextBox();
            this.houseNumberField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parcelNumberDisplayField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parcelSearchButton = new System.Windows.Forms.Button();
            this.parcelNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelNumberField = new System.Windows.Forms.TextBox();
            this.plotListView = new System.Windows.Forms.ListView();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.yearBuiltField = new System.Windows.Forms.TextBox();
            this.buildingListView = new System.Windows.Forms.ListView();
            this.percentageFeedbackLabel = new System.Windows.Forms.Label();
            this.setOwnerPercentageButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ownerPercentageField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adojelFeedbackLabel = new System.Windows.Forms.Label();
            this.adojelSearchButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.adojelField = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.removeOwnerButton = new System.Windows.Forms.Button();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.ownerListView = new System.Windows.Forms.ListView();
            this.userListView = new System.Windows.Forms.ListView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Település";
            // 
            // citySearchField
            // 
            this.citySearchField.Location = new System.Drawing.Point(92, 183);
            this.citySearchField.MaxLength = 255;
            this.citySearchField.Name = "citySearchField";
            this.citySearchField.Size = new System.Drawing.Size(98, 20);
            this.citySearchField.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Közterület";
            // 
            // publicSpaceField
            // 
            this.publicSpaceField.Location = new System.Drawing.Point(319, 207);
            this.publicSpaceField.MaxLength = 255;
            this.publicSpaceField.Name = "publicSpaceField";
            this.publicSpaceField.Size = new System.Drawing.Size(276, 20);
            this.publicSpaceField.TabIndex = 59;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(36, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 23);
            this.cancelButton.TabIndex = 58;
            this.cancelButton.Text = "Vissza";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(319, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 57;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // parcelNumberDisplayFeedbackLabel
            // 
            this.parcelNumberDisplayFeedbackLabel.AutoSize = true;
            this.parcelNumberDisplayFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.parcelNumberDisplayFeedbackLabel.Location = new System.Drawing.Point(321, 65);
            this.parcelNumberDisplayFeedbackLabel.Name = "parcelNumberDisplayFeedbackLabel";
            this.parcelNumberDisplayFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.parcelNumberDisplayFeedbackLabel.TabIndex = 56;
            this.parcelNumberDisplayFeedbackLabel.Text = "label";
            // 
            // successFeedbackLabel
            // 
            this.successFeedbackLabel.AutoSize = true;
            this.successFeedbackLabel.ForeColor = System.Drawing.Color.Green;
            this.successFeedbackLabel.Location = new System.Drawing.Point(316, 419);
            this.successFeedbackLabel.Name = "successFeedbackLabel";
            this.successFeedbackLabel.Size = new System.Drawing.Size(133, 13);
            this.successFeedbackLabel.TabIndex = 55;
            this.successFeedbackLabel.Text = "Ingatlan sikeresen frissítve";
            // 
            // valueFeedbackLabel
            // 
            this.valueFeedbackLabel.AutoSize = true;
            this.valueFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.valueFeedbackLabel.Location = new System.Drawing.Point(316, 347);
            this.valueFeedbackLabel.Name = "valueFeedbackLabel";
            this.valueFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.valueFeedbackLabel.TabIndex = 54;
            this.valueFeedbackLabel.Text = "label";
            // 
            // houseNumberFeedbackLabel
            // 
            this.houseNumberFeedbackLabel.AutoSize = true;
            this.houseNumberFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.houseNumberFeedbackLabel.Location = new System.Drawing.Point(316, 287);
            this.houseNumberFeedbackLabel.Name = "houseNumberFeedbackLabel";
            this.houseNumberFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.houseNumberFeedbackLabel.TabIndex = 53;
            this.houseNumberFeedbackLabel.Text = "label";
            // 
            // yearBuiltFeedbackLabel
            // 
            this.yearBuiltFeedbackLabel.AutoSize = true;
            this.yearBuiltFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.yearBuiltFeedbackLabel.Location = new System.Drawing.Point(316, 171);
            this.yearBuiltFeedbackLabel.Name = "yearBuiltFeedbackLabel";
            this.yearBuiltFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.yearBuiltFeedbackLabel.TabIndex = 52;
            this.yearBuiltFeedbackLabel.Text = "label";
            // 
            // valueField
            // 
            this.valueField.Location = new System.Drawing.Point(319, 324);
            this.valueField.MaxLength = 18;
            this.valueField.Name = "valueField";
            this.valueField.Size = new System.Drawing.Size(100, 20);
            this.valueField.TabIndex = 51;
            // 
            // houseNumberField
            // 
            this.houseNumberField.Location = new System.Drawing.Point(319, 264);
            this.houseNumberField.MaxLength = 255;
            this.houseNumberField.Name = "houseNumberField";
            this.houseNumberField.Size = new System.Drawing.Size(100, 20);
            this.houseNumberField.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Becsült érték";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Házszám";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Építés éve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Jelleg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Helyrajzi szám";
            // 
            // parcelNumberDisplayField
            // 
            this.parcelNumberDisplayField.Enabled = false;
            this.parcelNumberDisplayField.Location = new System.Drawing.Point(319, 42);
            this.parcelNumberDisplayField.MaxLength = 9;
            this.parcelNumberDisplayField.Name = "parcelNumberDisplayField";
            this.parcelNumberDisplayField.ReadOnly = true;
            this.parcelNumberDisplayField.Size = new System.Drawing.Size(100, 20);
            this.parcelNumberDisplayField.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Telek lista";
            // 
            // parcelSearchButton
            // 
            this.parcelSearchButton.Location = new System.Drawing.Point(196, 182);
            this.parcelSearchButton.Name = "parcelSearchButton";
            this.parcelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.parcelSearchButton.TabIndex = 42;
            this.parcelSearchButton.Text = "Keresés";
            this.parcelSearchButton.UseVisualStyleBackColor = true;
            this.parcelSearchButton.Click += new System.EventHandler(this.parcelSearchButton_Click);
            // 
            // parcelNumberFeedbackLabel
            // 
            this.parcelNumberFeedbackLabel.AutoSize = true;
            this.parcelNumberFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.parcelNumberFeedbackLabel.Location = new System.Drawing.Point(9, 205);
            this.parcelNumberFeedbackLabel.Name = "parcelNumberFeedbackLabel";
            this.parcelNumberFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.parcelNumberFeedbackLabel.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Helyrajzi szám";
            // 
            // parcelNumberField
            // 
            this.parcelNumberField.Location = new System.Drawing.Point(12, 182);
            this.parcelNumberField.MaxLength = 9;
            this.parcelNumberField.Name = "parcelNumberField";
            this.parcelNumberField.Size = new System.Drawing.Size(74, 20);
            this.parcelNumberField.TabIndex = 39;
            // 
            // plotListView
            // 
            this.plotListView.HideSelection = false;
            this.plotListView.Location = new System.Drawing.Point(12, 60);
            this.plotListView.MultiSelect = false;
            this.plotListView.Name = "plotListView";
            this.plotListView.Size = new System.Drawing.Size(259, 97);
            this.plotListView.TabIndex = 38;
            this.plotListView.UseCompatibleStateImageBehavior = false;
            this.plotListView.View = System.Windows.Forms.View.List;
            this.plotListView.SelectedIndexChanged += new System.EventHandler(this.plotListView_SelectedIndexChanged);
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Location = new System.Drawing.Point(319, 102);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 21);
            this.typeDropdown.TabIndex = 37;
            // 
            // yearBuiltField
            // 
            this.yearBuiltField.Location = new System.Drawing.Point(319, 146);
            this.yearBuiltField.MaxLength = 4;
            this.yearBuiltField.Name = "yearBuiltField";
            this.yearBuiltField.Size = new System.Drawing.Size(100, 20);
            this.yearBuiltField.TabIndex = 36;
            // 
            // buildingListView
            // 
            this.buildingListView.HideSelection = false;
            this.buildingListView.Location = new System.Drawing.Point(12, 221);
            this.buildingListView.Name = "buildingListView";
            this.buildingListView.Size = new System.Drawing.Size(259, 177);
            this.buildingListView.TabIndex = 63;
            this.buildingListView.UseCompatibleStateImageBehavior = false;
            this.buildingListView.View = System.Windows.Forms.View.Details;
            this.buildingListView.SelectedIndexChanged += new System.EventHandler(this.buildingListView_SelectedIndexChanged);
            // 
            // percentageFeedbackLabel
            // 
            this.percentageFeedbackLabel.AutoSize = true;
            this.percentageFeedbackLabel.Location = new System.Drawing.Point(556, 181);
            this.percentageFeedbackLabel.Name = "percentageFeedbackLabel";
            this.percentageFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.percentageFeedbackLabel.TabIndex = 78;
            // 
            // setOwnerPercentageButton
            // 
            this.setOwnerPercentageButton.Location = new System.Drawing.Point(664, 156);
            this.setOwnerPercentageButton.Name = "setOwnerPercentageButton";
            this.setOwnerPercentageButton.Size = new System.Drawing.Size(75, 23);
            this.setOwnerPercentageButton.TabIndex = 77;
            this.setOwnerPercentageButton.Text = "Beállítás";
            this.setOwnerPercentageButton.UseVisualStyleBackColor = true;
            this.setOwnerPercentageButton.Click += new System.EventHandler(this.setOwnerPercentageButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(556, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Tulajdonhányad megadása";
            // 
            // ownerPercentageField
            // 
            this.ownerPercentageField.Location = new System.Drawing.Point(559, 158);
            this.ownerPercentageField.MaxLength = 3;
            this.ownerPercentageField.Name = "ownerPercentageField";
            this.ownerPercentageField.Size = new System.Drawing.Size(100, 20);
            this.ownerPercentageField.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(680, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Tulajdonos lista";
            // 
            // adojelFeedbackLabel
            // 
            this.adojelFeedbackLabel.AutoSize = true;
            this.adojelFeedbackLabel.Location = new System.Drawing.Point(931, 187);
            this.adojelFeedbackLabel.Name = "adojelFeedbackLabel";
            this.adojelFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.adojelFeedbackLabel.TabIndex = 73;
            // 
            // adojelSearchButton
            // 
            this.adojelSearchButton.Location = new System.Drawing.Point(1040, 161);
            this.adojelSearchButton.Name = "adojelSearchButton";
            this.adojelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.adojelSearchButton.TabIndex = 72;
            this.adojelSearchButton.Text = "Hozzáadás";
            this.adojelSearchButton.UseVisualStyleBackColor = true;
            this.adojelSearchButton.Click += new System.EventHandler(this.adojelSearchButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(931, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Adójel megadása";
            // 
            // adojelField
            // 
            this.adojelField.Location = new System.Drawing.Point(934, 164);
            this.adojelField.MaxLength = 10;
            this.adojelField.Name = "adojelField";
            this.adojelField.Size = new System.Drawing.Size(100, 20);
            this.adojelField.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(931, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Felhasználó lista";
            // 
            // removeOwnerButton
            // 
            this.removeOwnerButton.Location = new System.Drawing.Point(879, 93);
            this.removeOwnerButton.Name = "removeOwnerButton";
            this.removeOwnerButton.Size = new System.Drawing.Size(39, 24);
            this.removeOwnerButton.TabIndex = 68;
            this.removeOwnerButton.Text = ">>";
            this.removeOwnerButton.UseVisualStyleBackColor = true;
            this.removeOwnerButton.Click += new System.EventHandler(this.removeOwnerButton_Click);
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.Location = new System.Drawing.Point(879, 63);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(39, 24);
            this.addOwnerButton.TabIndex = 67;
            this.addOwnerButton.Text = "<<";
            this.addOwnerButton.UseVisualStyleBackColor = true;
            this.addOwnerButton.Click += new System.EventHandler(this.addOwnerButton_Click);
            // 
            // ownerListView
            // 
            this.ownerListView.HideSelection = false;
            this.ownerListView.Location = new System.Drawing.Point(560, 42);
            this.ownerListView.Name = "ownerListView";
            this.ownerListView.Size = new System.Drawing.Size(303, 97);
            this.ownerListView.TabIndex = 66;
            this.ownerListView.UseCompatibleStateImageBehavior = false;
            this.ownerListView.View = System.Windows.Forms.View.List;
            // 
            // userListView
            // 
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(934, 42);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(200, 97);
            this.userListView.TabIndex = 65;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.List;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(464, 380);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 79;
            this.deleteButton.Text = "TÖRLÉS";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UpdateBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.percentageFeedbackLabel);
            this.Controls.Add(this.setOwnerPercentageButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ownerPercentageField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.adojelFeedbackLabel);
            this.Controls.Add(this.adojelSearchButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.adojelField);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.removeOwnerButton);
            this.Controls.Add(this.addOwnerButton);
            this.Controls.Add(this.ownerListView);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.buildingListView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.citySearchField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.publicSpaceField);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.parcelNumberDisplayFeedbackLabel);
            this.Controls.Add(this.successFeedbackLabel);
            this.Controls.Add(this.valueFeedbackLabel);
            this.Controls.Add(this.houseNumberFeedbackLabel);
            this.Controls.Add(this.yearBuiltFeedbackLabel);
            this.Controls.Add(this.valueField);
            this.Controls.Add(this.houseNumberField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parcelNumberDisplayField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parcelSearchButton);
            this.Controls.Add(this.parcelNumberFeedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parcelNumberField);
            this.Controls.Add(this.plotListView);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.yearBuiltField);
            this.Name = "UpdateBuildingForm";
            this.Text = "Ingatlanok módosítása";
            this.Load += new System.EventHandler(this.UpdateBuildingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox citySearchField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox publicSpaceField;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label parcelNumberDisplayFeedbackLabel;
        private System.Windows.Forms.Label successFeedbackLabel;
        private System.Windows.Forms.Label valueFeedbackLabel;
        private System.Windows.Forms.Label houseNumberFeedbackLabel;
        private System.Windows.Forms.Label yearBuiltFeedbackLabel;
        private System.Windows.Forms.TextBox valueField;
        private System.Windows.Forms.TextBox houseNumberField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parcelNumberDisplayField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button parcelSearchButton;
        private System.Windows.Forms.Label parcelNumberFeedbackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parcelNumberField;
        private System.Windows.Forms.ListView plotListView;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.TextBox yearBuiltField;
        private System.Windows.Forms.ListView buildingListView;
        private System.Windows.Forms.Label percentageFeedbackLabel;
        private System.Windows.Forms.Button setOwnerPercentageButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ownerPercentageField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label adojelFeedbackLabel;
        private System.Windows.Forms.Button adojelSearchButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox adojelField;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button removeOwnerButton;
        private System.Windows.Forms.Button addOwnerButton;
        private System.Windows.Forms.ListView ownerListView;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.Button deleteButton;
    }
}