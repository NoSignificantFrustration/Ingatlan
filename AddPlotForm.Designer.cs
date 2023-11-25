
namespace Ingatlan
{
    partial class AddPlotForm
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
            this.pracelNumberLabel = new System.Windows.Forms.Label();
            this.parcelNumberField = new System.Windows.Forms.TextBox();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.zipCodeField = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityField = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.sizeField = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.valueField = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.parcelNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.zipCodeFeedbackLabel = new System.Windows.Forms.Label();
            this.sizeFeedbackLabel = new System.Windows.Forms.Label();
            this.valueFeedbackLabel = new System.Windows.Forms.Label();
            this.successFeedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pracelNumberLabel
            // 
            this.pracelNumberLabel.AutoSize = true;
            this.pracelNumberLabel.Location = new System.Drawing.Point(41, 9);
            this.pracelNumberLabel.Name = "pracelNumberLabel";
            this.pracelNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.pracelNumberLabel.TabIndex = 0;
            this.pracelNumberLabel.Text = "Helyrajzi szám";
            // 
            // parcelNumberField
            // 
            this.parcelNumberField.Location = new System.Drawing.Point(44, 25);
            this.parcelNumberField.MaxLength = 9;
            this.parcelNumberField.Name = "parcelNumberField";
            this.parcelNumberField.Size = new System.Drawing.Size(100, 20);
            this.parcelNumberField.TabIndex = 1;
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Location = new System.Drawing.Point(44, 77);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 21);
            this.typeDropdown.TabIndex = 2;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(41, 61);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(61, 13);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Telek jelleg";
            // 
            // zipCodeField
            // 
            this.zipCodeField.Location = new System.Drawing.Point(44, 127);
            this.zipCodeField.MaxLength = 9;
            this.zipCodeField.Name = "zipCodeField";
            this.zipCodeField.Size = new System.Drawing.Size(100, 20);
            this.zipCodeField.TabIndex = 5;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(41, 111);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.zipCodeLabel.TabIndex = 4;
            this.zipCodeLabel.Text = "Irányítószám";
            // 
            // cityField
            // 
            this.cityField.Location = new System.Drawing.Point(44, 185);
            this.cityField.MaxLength = 255;
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(365, 20);
            this.cityField.TabIndex = 9;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(41, 169);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(53, 13);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "Település";
            // 
            // sizeField
            // 
            this.sizeField.Location = new System.Drawing.Point(44, 230);
            this.sizeField.MaxLength = 18;
            this.sizeField.Name = "sizeField";
            this.sizeField.Size = new System.Drawing.Size(100, 20);
            this.sizeField.TabIndex = 11;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(41, 214);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(34, 13);
            this.sizeLabel.TabIndex = 10;
            this.sizeLabel.Text = "Méret";
            // 
            // valueField
            // 
            this.valueField.Location = new System.Drawing.Point(44, 288);
            this.valueField.MaxLength = 18;
            this.valueField.Name = "valueField";
            this.valueField.Size = new System.Drawing.Size(100, 20);
            this.valueField.TabIndex = 13;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(41, 272);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(69, 13);
            this.valueLabel.TabIndex = 12;
            this.valueLabel.Text = "Becsült érték";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "m^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ft";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(43, 401);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Vissza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(213, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(158, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // parcelNumberFeedbackLabel
            // 
            this.parcelNumberFeedbackLabel.AutoSize = true;
            this.parcelNumberFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.parcelNumberFeedbackLabel.Location = new System.Drawing.Point(41, 48);
            this.parcelNumberFeedbackLabel.Name = "parcelNumberFeedbackLabel";
            this.parcelNumberFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.parcelNumberFeedbackLabel.TabIndex = 18;
            this.parcelNumberFeedbackLabel.Text = "label4";
            // 
            // zipCodeFeedbackLabel
            // 
            this.zipCodeFeedbackLabel.AutoSize = true;
            this.zipCodeFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.zipCodeFeedbackLabel.Location = new System.Drawing.Point(41, 150);
            this.zipCodeFeedbackLabel.Name = "zipCodeFeedbackLabel";
            this.zipCodeFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.zipCodeFeedbackLabel.TabIndex = 19;
            this.zipCodeFeedbackLabel.Text = "label4";
            // 
            // sizeFeedbackLabel
            // 
            this.sizeFeedbackLabel.AutoSize = true;
            this.sizeFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.sizeFeedbackLabel.Location = new System.Drawing.Point(41, 253);
            this.sizeFeedbackLabel.Name = "sizeFeedbackLabel";
            this.sizeFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeFeedbackLabel.TabIndex = 20;
            this.sizeFeedbackLabel.Text = "label4";
            // 
            // valueFeedbackLabel
            // 
            this.valueFeedbackLabel.AutoSize = true;
            this.valueFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.valueFeedbackLabel.Location = new System.Drawing.Point(41, 311);
            this.valueFeedbackLabel.Name = "valueFeedbackLabel";
            this.valueFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.valueFeedbackLabel.TabIndex = 21;
            this.valueFeedbackLabel.Text = "label4";
            // 
            // successFeedbackLabel
            // 
            this.successFeedbackLabel.AutoSize = true;
            this.successFeedbackLabel.ForeColor = System.Drawing.Color.Green;
            this.successFeedbackLabel.Location = new System.Drawing.Point(210, 428);
            this.successFeedbackLabel.Name = "successFeedbackLabel";
            this.successFeedbackLabel.Size = new System.Drawing.Size(35, 13);
            this.successFeedbackLabel.TabIndex = 22;
            this.successFeedbackLabel.Text = "label4";
            // 
            // AddPlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.successFeedbackLabel);
            this.Controls.Add(this.valueFeedbackLabel);
            this.Controls.Add(this.sizeFeedbackLabel);
            this.Controls.Add(this.zipCodeFeedbackLabel);
            this.Controls.Add(this.parcelNumberFeedbackLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueField);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.sizeField);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.zipCodeField);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.parcelNumberField);
            this.Controls.Add(this.pracelNumberLabel);
            this.Name = "AddPlotForm";
            this.Text = "Telek hozzáadása";
            this.Load += new System.EventHandler(this.AddPlotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pracelNumberLabel;
        private System.Windows.Forms.TextBox parcelNumberField;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox zipCodeField;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox sizeField;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox valueField;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label parcelNumberFeedbackLabel;
        private System.Windows.Forms.Label zipCodeFeedbackLabel;
        private System.Windows.Forms.Label sizeFeedbackLabel;
        private System.Windows.Forms.Label valueFeedbackLabel;
        private System.Windows.Forms.Label successFeedbackLabel;
    }
}