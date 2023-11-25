
namespace Ingatlan
{
    public partial class UpdateUserDataForm
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.mobileNumberField = new System.Windows.Forms.TextBox();
            this.dateOfBirthYearField = new System.Windows.Forms.TextBox();
            this.mothersNameField = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirthMonthField = new System.Windows.Forms.TextBox();
            this.dateOfBirthDayField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mobileNumberFeedbackLabel = new System.Windows.Forms.Label();
            this.dateOfBirthFeedbackLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(164, 37);
            this.nameField.MaxLength = 100;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(187, 20);
            this.nameField.TabIndex = 0;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(164, 98);
            this.addressField.MaxLength = 200;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(187, 20);
            this.addressField.TabIndex = 1;
            // 
            // mobileNumberField
            // 
            this.mobileNumberField.Location = new System.Drawing.Point(164, 157);
            this.mobileNumberField.MaxLength = 13;
            this.mobileNumberField.Name = "mobileNumberField";
            this.mobileNumberField.Size = new System.Drawing.Size(187, 20);
            this.mobileNumberField.TabIndex = 2;
            // 
            // dateOfBirthYearField
            // 
            this.dateOfBirthYearField.Location = new System.Drawing.Point(164, 226);
            this.dateOfBirthYearField.MaxLength = 4;
            this.dateOfBirthYearField.Name = "dateOfBirthYearField";
            this.dateOfBirthYearField.Size = new System.Drawing.Size(40, 20);
            this.dateOfBirthYearField.TabIndex = 3;
            // 
            // mothersNameField
            // 
            this.mothersNameField.Location = new System.Drawing.Point(164, 294);
            this.mothersNameField.MaxLength = 100;
            this.mothersNameField.Name = "mothersNameField";
            this.mothersNameField.Size = new System.Drawing.Size(187, 20);
            this.mothersNameField.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CancelButton.Location = new System.Drawing.Point(164, 360);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Mégse";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lakcím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefonszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Születési dátum";
            // 
            // dateOfBirthMonthField
            // 
            this.dateOfBirthMonthField.Location = new System.Drawing.Point(223, 226);
            this.dateOfBirthMonthField.MaxLength = 2;
            this.dateOfBirthMonthField.Name = "dateOfBirthMonthField";
            this.dateOfBirthMonthField.Size = new System.Drawing.Size(40, 20);
            this.dateOfBirthMonthField.TabIndex = 11;
            // 
            // dateOfBirthDayField
            // 
            this.dateOfBirthDayField.Location = new System.Drawing.Point(282, 226);
            this.dateOfBirthDayField.Name = "dateOfBirthDayField";
            this.dateOfBirthDayField.Size = new System.Drawing.Size(40, 20);
            this.dateOfBirthDayField.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anyja neve";
            // 
            // mobileNumberFeedbackLabel
            // 
            this.mobileNumberFeedbackLabel.AutoSize = true;
            this.mobileNumberFeedbackLabel.Location = new System.Drawing.Point(161, 180);
            this.mobileNumberFeedbackLabel.Name = "mobileNumberFeedbackLabel";
            this.mobileNumberFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.mobileNumberFeedbackLabel.TabIndex = 14;
            // 
            // dateOfBirthFeedbackLabel
            // 
            this.dateOfBirthFeedbackLabel.AutoSize = true;
            this.dateOfBirthFeedbackLabel.Location = new System.Drawing.Point(161, 249);
            this.dateOfBirthFeedbackLabel.Name = "dateOfBirthFeedbackLabel";
            this.dateOfBirthFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.dateOfBirthFeedbackLabel.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(276, 360);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // UpdateUserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateOfBirthFeedbackLabel);
            this.Controls.Add(this.mobileNumberFeedbackLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthDayField);
            this.Controls.Add(this.dateOfBirthMonthField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.mothersNameField);
            this.Controls.Add(this.dateOfBirthYearField);
            this.Controls.Add(this.mobileNumberField);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.nameField);
            this.Name = "UpdateUserDataForm";
            this.Text = "Adataim módosítása";
            this.Load += new System.EventHandler(this.UpdateUserDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.TextBox mobileNumberField;
        private System.Windows.Forms.TextBox dateOfBirthYearField;
        private System.Windows.Forms.TextBox mothersNameField;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateOfBirthMonthField;
        private System.Windows.Forms.TextBox dateOfBirthDayField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mobileNumberFeedbackLabel;
        private System.Windows.Forms.Label dateOfBirthFeedbackLabel;
        private System.Windows.Forms.Button saveButton;
    }
}