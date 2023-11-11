
namespace Ingatlan
{
    partial class UpdatePlotForm
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
            this.plotListView = new System.Windows.Forms.ListView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userListView = new System.Windows.Forms.ListView();
            this.ownerListView = new System.Windows.Forms.ListView();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.removeOwnerButton = new System.Windows.Forms.Button();
            this.parcelNumberField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.parcelSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adojelField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adojelSearchButton = new System.Windows.Forms.Button();
            this.adojelFeedbackLabel = new System.Windows.Forms.Label();
            this.valueFeedbackLabel = new System.Windows.Forms.Label();
            this.sizeFeedbackLabel = new System.Windows.Forms.Label();
            this.zipCodeFeedbackLabel = new System.Windows.Forms.Label();
            this.valueField = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.sizeField = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.cityField = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.publicSpaceField = new System.Windows.Forms.TextBox();
            this.publicSpaceLabel = new System.Windows.Forms.Label();
            this.zipCodeField = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.successFeedbackLabel = new System.Windows.Forms.Label();
            this.parcelNumberDisplayField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ownerPercentageField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.setOwnerPercentageButton = new System.Windows.Forms.Button();
            this.percentageFeedbackLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plotListView
            // 
            this.plotListView.HideSelection = false;
            this.plotListView.Location = new System.Drawing.Point(56, 131);
            this.plotListView.Name = "plotListView";
            this.plotListView.Size = new System.Drawing.Size(259, 97);
            this.plotListView.TabIndex = 0;
            this.plotListView.UseCompatibleStateImageBehavior = false;
            this.plotListView.View = System.Windows.Forms.View.List;
            this.plotListView.SelectedIndexChanged += new System.EventHandler(this.plotListView_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(56, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Vissza";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // userListView
            // 
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(1065, 131);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(170, 97);
            this.userListView.TabIndex = 2;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.List;
            // 
            // ownerListView
            // 
            this.ownerListView.HideSelection = false;
            this.ownerListView.Location = new System.Drawing.Point(814, 131);
            this.ownerListView.Name = "ownerListView";
            this.ownerListView.Size = new System.Drawing.Size(180, 97);
            this.ownerListView.TabIndex = 3;
            this.ownerListView.UseCompatibleStateImageBehavior = false;
            this.ownerListView.View = System.Windows.Forms.View.List;
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.Location = new System.Drawing.Point(1010, 152);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(39, 24);
            this.addOwnerButton.TabIndex = 4;
            this.addOwnerButton.Text = "<<";
            this.addOwnerButton.UseVisualStyleBackColor = true;
            this.addOwnerButton.Click += new System.EventHandler(this.addOwnerButton_Click);
            // 
            // removeOwnerButton
            // 
            this.removeOwnerButton.Location = new System.Drawing.Point(1010, 182);
            this.removeOwnerButton.Name = "removeOwnerButton";
            this.removeOwnerButton.Size = new System.Drawing.Size(39, 24);
            this.removeOwnerButton.TabIndex = 5;
            this.removeOwnerButton.Text = ">>";
            this.removeOwnerButton.UseVisualStyleBackColor = true;
            this.removeOwnerButton.Click += new System.EventHandler(this.removeOwnerButton_Click);
            // 
            // parcelNumberField
            // 
            this.parcelNumberField.Location = new System.Drawing.Point(56, 253);
            this.parcelNumberField.Name = "parcelNumberField";
            this.parcelNumberField.Size = new System.Drawing.Size(100, 20);
            this.parcelNumberField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Helyrajzi szám megadása";
            // 
            // parcelNumberFeedbackLabel
            // 
            this.parcelNumberFeedbackLabel.AutoSize = true;
            this.parcelNumberFeedbackLabel.Location = new System.Drawing.Point(53, 276);
            this.parcelNumberFeedbackLabel.Name = "parcelNumberFeedbackLabel";
            this.parcelNumberFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.parcelNumberFeedbackLabel.TabIndex = 8;
            // 
            // parcelSearchButton
            // 
            this.parcelSearchButton.Location = new System.Drawing.Point(162, 250);
            this.parcelSearchButton.Name = "parcelSearchButton";
            this.parcelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.parcelSearchButton.TabIndex = 9;
            this.parcelSearchButton.Text = "Keresés";
            this.parcelSearchButton.UseVisualStyleBackColor = true;
            this.parcelSearchButton.Click += new System.EventHandler(this.parcelSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telek lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1062, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Felhasználó lista";
            // 
            // adojelField
            // 
            this.adojelField.Location = new System.Drawing.Point(1065, 253);
            this.adojelField.Name = "adojelField";
            this.adojelField.Size = new System.Drawing.Size(100, 20);
            this.adojelField.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1062, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adójel megadása";
            // 
            // adojelSearchButton
            // 
            this.adojelSearchButton.Location = new System.Drawing.Point(1171, 250);
            this.adojelSearchButton.Name = "adojelSearchButton";
            this.adojelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.adojelSearchButton.TabIndex = 14;
            this.adojelSearchButton.Text = "Hozzáadás";
            this.adojelSearchButton.UseVisualStyleBackColor = true;
            this.adojelSearchButton.Click += new System.EventHandler(this.adojelSearchButton_Click);
            // 
            // adojelFeedbackLabel
            // 
            this.adojelFeedbackLabel.AutoSize = true;
            this.adojelFeedbackLabel.Location = new System.Drawing.Point(1062, 276);
            this.adojelFeedbackLabel.Name = "adojelFeedbackLabel";
            this.adojelFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.adojelFeedbackLabel.TabIndex = 15;
            // 
            // valueFeedbackLabel
            // 
            this.valueFeedbackLabel.AutoSize = true;
            this.valueFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.valueFeedbackLabel.Location = new System.Drawing.Point(356, 412);
            this.valueFeedbackLabel.Name = "valueFeedbackLabel";
            this.valueFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.valueFeedbackLabel.TabIndex = 36;
            this.valueFeedbackLabel.Text = "label4";
            // 
            // sizeFeedbackLabel
            // 
            this.sizeFeedbackLabel.AutoSize = true;
            this.sizeFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.sizeFeedbackLabel.Location = new System.Drawing.Point(356, 354);
            this.sizeFeedbackLabel.Name = "sizeFeedbackLabel";
            this.sizeFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeFeedbackLabel.TabIndex = 35;
            this.sizeFeedbackLabel.Text = "label4";
            // 
            // zipCodeFeedbackLabel
            // 
            this.zipCodeFeedbackLabel.AutoSize = true;
            this.zipCodeFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.zipCodeFeedbackLabel.Location = new System.Drawing.Point(356, 219);
            this.zipCodeFeedbackLabel.Name = "zipCodeFeedbackLabel";
            this.zipCodeFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.zipCodeFeedbackLabel.TabIndex = 34;
            this.zipCodeFeedbackLabel.Text = "label4";
            // 
            // valueField
            // 
            this.valueField.Location = new System.Drawing.Point(359, 389);
            this.valueField.MaxLength = 18;
            this.valueField.Name = "valueField";
            this.valueField.Size = new System.Drawing.Size(100, 20);
            this.valueField.TabIndex = 33;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(356, 373);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(69, 13);
            this.valueLabel.TabIndex = 32;
            this.valueLabel.Text = "Becsült érték";
            // 
            // sizeField
            // 
            this.sizeField.Location = new System.Drawing.Point(359, 331);
            this.sizeField.MaxLength = 18;
            this.sizeField.Name = "sizeField";
            this.sizeField.Size = new System.Drawing.Size(100, 20);
            this.sizeField.TabIndex = 31;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(356, 315);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(34, 13);
            this.sizeLabel.TabIndex = 30;
            this.sizeLabel.Text = "Méret";
            // 
            // cityField
            // 
            this.cityField.Location = new System.Drawing.Point(360, 253);
            this.cityField.MaxLength = 255;
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(365, 20);
            this.cityField.TabIndex = 29;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(357, 237);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(53, 13);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "Település";
            // 
            // publicSpaceField
            // 
            this.publicSpaceField.Location = new System.Drawing.Point(359, 292);
            this.publicSpaceField.MaxLength = 255;
            this.publicSpaceField.Name = "publicSpaceField";
            this.publicSpaceField.Size = new System.Drawing.Size(365, 20);
            this.publicSpaceField.TabIndex = 27;
            // 
            // publicSpaceLabel
            // 
            this.publicSpaceLabel.AutoSize = true;
            this.publicSpaceLabel.Location = new System.Drawing.Point(356, 276);
            this.publicSpaceLabel.Name = "publicSpaceLabel";
            this.publicSpaceLabel.Size = new System.Drawing.Size(54, 13);
            this.publicSpaceLabel.TabIndex = 26;
            this.publicSpaceLabel.Text = "Közterület";
            // 
            // zipCodeField
            // 
            this.zipCodeField.Location = new System.Drawing.Point(359, 196);
            this.zipCodeField.MaxLength = 9;
            this.zipCodeField.Name = "zipCodeField";
            this.zipCodeField.Size = new System.Drawing.Size(100, 20);
            this.zipCodeField.TabIndex = 25;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(356, 180);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.zipCodeLabel.TabIndex = 24;
            this.zipCodeLabel.Text = "Irányítószám";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(356, 130);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(61, 13);
            this.typeLabel.TabIndex = 23;
            this.typeLabel.Text = "Telek jelleg";
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Location = new System.Drawing.Point(359, 146);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 21);
            this.typeDropdown.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tulajdonos lista";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(359, 452);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // successFeedbackLabel
            // 
            this.successFeedbackLabel.AutoSize = true;
            this.successFeedbackLabel.ForeColor = System.Drawing.Color.Green;
            this.successFeedbackLabel.Location = new System.Drawing.Point(356, 493);
            this.successFeedbackLabel.Name = "successFeedbackLabel";
            this.successFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.successFeedbackLabel.TabIndex = 39;
            this.successFeedbackLabel.Text = "label6";
            // 
            // parcelNumberDisplayField
            // 
            this.parcelNumberDisplayField.Enabled = false;
            this.parcelNumberDisplayField.Location = new System.Drawing.Point(359, 107);
            this.parcelNumberDisplayField.Name = "parcelNumberDisplayField";
            this.parcelNumberDisplayField.Size = new System.Drawing.Size(100, 20);
            this.parcelNumberDisplayField.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Helyrajzi szám";
            // 
            // ownerPercentageField
            // 
            this.ownerPercentageField.Location = new System.Drawing.Point(814, 253);
            this.ownerPercentageField.Name = "ownerPercentageField";
            this.ownerPercentageField.Size = new System.Drawing.Size(100, 20);
            this.ownerPercentageField.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tulajdonhányad megadása";
            // 
            // setOwnerPercentageButton
            // 
            this.setOwnerPercentageButton.Location = new System.Drawing.Point(919, 251);
            this.setOwnerPercentageButton.Name = "setOwnerPercentageButton";
            this.setOwnerPercentageButton.Size = new System.Drawing.Size(75, 23);
            this.setOwnerPercentageButton.TabIndex = 44;
            this.setOwnerPercentageButton.Text = "Beállítás";
            this.setOwnerPercentageButton.UseVisualStyleBackColor = true;
            this.setOwnerPercentageButton.Click += new System.EventHandler(this.setOwnerPercentageButton_Click);
            // 
            // percentageFeedbackLabel
            // 
            this.percentageFeedbackLabel.AutoSize = true;
            this.percentageFeedbackLabel.Location = new System.Drawing.Point(811, 276);
            this.percentageFeedbackLabel.Name = "percentageFeedbackLabel";
            this.percentageFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.percentageFeedbackLabel.TabIndex = 45;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(545, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 46;
            this.deleteButton.Text = "TÖRLÉS";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UpdatePlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 554);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.percentageFeedbackLabel);
            this.Controls.Add(this.setOwnerPercentageButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ownerPercentageField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parcelNumberDisplayField);
            this.Controls.Add(this.successFeedbackLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueFeedbackLabel);
            this.Controls.Add(this.sizeFeedbackLabel);
            this.Controls.Add(this.zipCodeFeedbackLabel);
            this.Controls.Add(this.valueField);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.sizeField);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.publicSpaceField);
            this.Controls.Add(this.publicSpaceLabel);
            this.Controls.Add(this.zipCodeField);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.adojelFeedbackLabel);
            this.Controls.Add(this.adojelSearchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adojelField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parcelSearchButton);
            this.Controls.Add(this.parcelNumberFeedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parcelNumberField);
            this.Controls.Add(this.removeOwnerButton);
            this.Controls.Add(this.addOwnerButton);
            this.Controls.Add(this.ownerListView);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.plotListView);
            this.Name = "UpdatePlotForm";
            this.Text = "Telkek módosítása";
            this.Load += new System.EventHandler(this.UpdatePlotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView plotListView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ListView ownerListView;
        private System.Windows.Forms.Button addOwnerButton;
        private System.Windows.Forms.Button removeOwnerButton;
        private System.Windows.Forms.TextBox parcelNumberField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label parcelNumberFeedbackLabel;
        private System.Windows.Forms.Button parcelSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adojelField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adojelSearchButton;
        private System.Windows.Forms.Label adojelFeedbackLabel;
        private System.Windows.Forms.Label valueFeedbackLabel;
        private System.Windows.Forms.Label sizeFeedbackLabel;
        private System.Windows.Forms.Label zipCodeFeedbackLabel;
        private System.Windows.Forms.TextBox valueField;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox sizeField;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox publicSpaceField;
        private System.Windows.Forms.Label publicSpaceLabel;
        private System.Windows.Forms.TextBox zipCodeField;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label successFeedbackLabel;
        private System.Windows.Forms.TextBox parcelNumberDisplayField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ownerPercentageField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setOwnerPercentageButton;
        private System.Windows.Forms.Label percentageFeedbackLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}