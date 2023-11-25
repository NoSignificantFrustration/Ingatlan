
namespace Ingatlan
{
    partial class AddBuildingForm
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
            this.yearBuiltField = new System.Windows.Forms.TextBox();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parcelSearchButton = new System.Windows.Forms.Button();
            this.parcelNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelNumberField = new System.Windows.Forms.TextBox();
            this.plotListView = new System.Windows.Forms.ListView();
            this.parcelNumberDisplayField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.houseNumberField = new System.Windows.Forms.TextBox();
            this.valueField = new System.Windows.Forms.TextBox();
            this.yearBuiltFeedbackLabel = new System.Windows.Forms.Label();
            this.houseNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.valueFeedbackLabel = new System.Windows.Forms.Label();
            this.successFeedbackLabel = new System.Windows.Forms.Label();
            this.parcelNumberDisplayFeedbackLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.publicSpaceField = new System.Windows.Forms.TextBox();
            this.citySearchField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearBuiltField
            // 
            this.yearBuiltField.Location = new System.Drawing.Point(314, 146);
            this.yearBuiltField.MaxLength = 4;
            this.yearBuiltField.Name = "yearBuiltField";
            this.yearBuiltField.Size = new System.Drawing.Size(100, 20);
            this.yearBuiltField.TabIndex = 0;
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Location = new System.Drawing.Point(314, 102);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 21);
            this.typeDropdown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telek lista";
            // 
            // parcelSearchButton
            // 
            this.parcelSearchButton.Location = new System.Drawing.Point(205, 187);
            this.parcelSearchButton.Name = "parcelSearchButton";
            this.parcelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.parcelSearchButton.TabIndex = 15;
            this.parcelSearchButton.Text = "Keresés";
            this.parcelSearchButton.UseVisualStyleBackColor = true;
            this.parcelSearchButton.Click += new System.EventHandler(this.parcelSearchButton_Click);
            // 
            // parcelNumberFeedbackLabel
            // 
            this.parcelNumberFeedbackLabel.AutoSize = true;
            this.parcelNumberFeedbackLabel.Location = new System.Drawing.Point(18, 210);
            this.parcelNumberFeedbackLabel.Name = "parcelNumberFeedbackLabel";
            this.parcelNumberFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.parcelNumberFeedbackLabel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Helyrajzi szám";
            // 
            // parcelNumberField
            // 
            this.parcelNumberField.Location = new System.Drawing.Point(21, 187);
            this.parcelNumberField.MaxLength = 9;
            this.parcelNumberField.Name = "parcelNumberField";
            this.parcelNumberField.Size = new System.Drawing.Size(74, 20);
            this.parcelNumberField.TabIndex = 12;
            // 
            // plotListView
            // 
            this.plotListView.HideSelection = false;
            this.plotListView.Location = new System.Drawing.Point(21, 65);
            this.plotListView.Name = "plotListView";
            this.plotListView.Size = new System.Drawing.Size(259, 97);
            this.plotListView.TabIndex = 11;
            this.plotListView.UseCompatibleStateImageBehavior = false;
            this.plotListView.View = System.Windows.Forms.View.List;
            this.plotListView.SelectedIndexChanged += new System.EventHandler(this.plotListView_SelectedIndexChanged);
            // 
            // parcelNumberDisplayField
            // 
            this.parcelNumberDisplayField.Enabled = false;
            this.parcelNumberDisplayField.Location = new System.Drawing.Point(314, 42);
            this.parcelNumberDisplayField.MaxLength = 9;
            this.parcelNumberDisplayField.Name = "parcelNumberDisplayField";
            this.parcelNumberDisplayField.ReadOnly = true;
            this.parcelNumberDisplayField.Size = new System.Drawing.Size(100, 20);
            this.parcelNumberDisplayField.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Helyrajzi szám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Jelleg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Építés éve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Házszám";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Becsült érték";
            // 
            // houseNumberField
            // 
            this.houseNumberField.Location = new System.Drawing.Point(314, 264);
            this.houseNumberField.MaxLength = 255;
            this.houseNumberField.Name = "houseNumberField";
            this.houseNumberField.Size = new System.Drawing.Size(100, 20);
            this.houseNumberField.TabIndex = 23;
            // 
            // valueField
            // 
            this.valueField.Location = new System.Drawing.Point(314, 324);
            this.valueField.MaxLength = 18;
            this.valueField.Name = "valueField";
            this.valueField.Size = new System.Drawing.Size(100, 20);
            this.valueField.TabIndex = 24;
            // 
            // yearBuiltFeedbackLabel
            // 
            this.yearBuiltFeedbackLabel.AutoSize = true;
            this.yearBuiltFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.yearBuiltFeedbackLabel.Location = new System.Drawing.Point(311, 171);
            this.yearBuiltFeedbackLabel.Name = "yearBuiltFeedbackLabel";
            this.yearBuiltFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.yearBuiltFeedbackLabel.TabIndex = 25;
            this.yearBuiltFeedbackLabel.Text = "label";
            // 
            // houseNumberFeedbackLabel
            // 
            this.houseNumberFeedbackLabel.AutoSize = true;
            this.houseNumberFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.houseNumberFeedbackLabel.Location = new System.Drawing.Point(311, 287);
            this.houseNumberFeedbackLabel.Name = "houseNumberFeedbackLabel";
            this.houseNumberFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.houseNumberFeedbackLabel.TabIndex = 26;
            this.houseNumberFeedbackLabel.Text = "label";
            // 
            // valueFeedbackLabel
            // 
            this.valueFeedbackLabel.AutoSize = true;
            this.valueFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.valueFeedbackLabel.Location = new System.Drawing.Point(311, 347);
            this.valueFeedbackLabel.Name = "valueFeedbackLabel";
            this.valueFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.valueFeedbackLabel.TabIndex = 27;
            this.valueFeedbackLabel.Text = "label";
            // 
            // successFeedbackLabel
            // 
            this.successFeedbackLabel.AutoSize = true;
            this.successFeedbackLabel.ForeColor = System.Drawing.Color.Green;
            this.successFeedbackLabel.Location = new System.Drawing.Point(311, 419);
            this.successFeedbackLabel.Name = "successFeedbackLabel";
            this.successFeedbackLabel.Size = new System.Drawing.Size(131, 13);
            this.successFeedbackLabel.TabIndex = 28;
            this.successFeedbackLabel.Text = "Ingatlan sikeresen felvéve";
            // 
            // parcelNumberDisplayFeedbackLabel
            // 
            this.parcelNumberDisplayFeedbackLabel.AutoSize = true;
            this.parcelNumberDisplayFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.parcelNumberDisplayFeedbackLabel.Location = new System.Drawing.Point(316, 65);
            this.parcelNumberDisplayFeedbackLabel.Name = "parcelNumberDisplayFeedbackLabel";
            this.parcelNumberDisplayFeedbackLabel.Size = new System.Drawing.Size(29, 13);
            this.parcelNumberDisplayFeedbackLabel.TabIndex = 29;
            this.parcelNumberDisplayFeedbackLabel.Text = "label";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(314, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(46, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 23);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Vissza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Közterület";
            // 
            // publicSpaceField
            // 
            this.publicSpaceField.Location = new System.Drawing.Point(314, 207);
            this.publicSpaceField.MaxLength = 255;
            this.publicSpaceField.Name = "publicSpaceField";
            this.publicSpaceField.Size = new System.Drawing.Size(276, 20);
            this.publicSpaceField.TabIndex = 32;
            // 
            // citySearchField
            // 
            this.citySearchField.Location = new System.Drawing.Point(101, 188);
            this.citySearchField.MaxLength = 255;
            this.citySearchField.Name = "citySearchField";
            this.citySearchField.Size = new System.Drawing.Size(98, 20);
            this.citySearchField.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Település";
            // 
            // AddBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
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
            this.Name = "AddBuildingForm";
            this.Text = "Ingatlan hozzáadása";
            this.Load += new System.EventHandler(this.AddBuildingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearBuiltField;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button parcelSearchButton;
        private System.Windows.Forms.Label parcelNumberFeedbackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parcelNumberField;
        private System.Windows.Forms.ListView plotListView;
        private System.Windows.Forms.TextBox parcelNumberDisplayField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox houseNumberField;
        private System.Windows.Forms.TextBox valueField;
        private System.Windows.Forms.Label yearBuiltFeedbackLabel;
        private System.Windows.Forms.Label houseNumberFeedbackLabel;
        private System.Windows.Forms.Label valueFeedbackLabel;
        private System.Windows.Forms.Label successFeedbackLabel;
        private System.Windows.Forms.Label parcelNumberDisplayFeedbackLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox publicSpaceField;
        private System.Windows.Forms.TextBox citySearchField;
        private System.Windows.Forms.Label label8;
    }
}