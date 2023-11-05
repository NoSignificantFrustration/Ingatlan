
namespace Ingatlan
{
    partial class ProfileForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adataimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserDataOption = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telkekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telekFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telekKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingatlanokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingatlanFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingatlanKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adojelLabel = new System.Windows.Forms.Label();
            this.adojelField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.mobileNumberLabel = new System.Windows.Forms.Label();
            this.mobileNumberField = new System.Windows.Forms.TextBox();
            this.mothersNameLabel = new System.Windows.Forms.Label();
            this.mothersNameField = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adataimToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // adataimToolStripMenuItem
            // 
            this.adataimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserDataOption});
            this.adataimToolStripMenuItem.Name = "adataimToolStripMenuItem";
            this.adataimToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.adataimToolStripMenuItem.Text = "Adataim";
            // 
            // updateUserDataOption
            // 
            this.updateUserDataOption.Name = "updateUserDataOption";
            this.updateUserDataOption.Size = new System.Drawing.Size(183, 22);
            this.updateUserDataOption.Text = "Adataim módosítása";
            this.updateUserDataOption.Click += new System.EventHandler(this.updateUserDataOption_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telkekToolStripMenuItem,
            this.ingatlanokToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // telkekToolStripMenuItem
            // 
            this.telkekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telekFelvételeToolStripMenuItem,
            this.telekKezeléseToolStripMenuItem});
            this.telkekToolStripMenuItem.Name = "telkekToolStripMenuItem";
            this.telkekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telkekToolStripMenuItem.Text = "Telkek";
            // 
            // telekFelvételeToolStripMenuItem
            // 
            this.telekFelvételeToolStripMenuItem.Name = "telekFelvételeToolStripMenuItem";
            this.telekFelvételeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.telekFelvételeToolStripMenuItem.Text = "Telek felvétele";
            // 
            // telekKezeléseToolStripMenuItem
            // 
            this.telekKezeléseToolStripMenuItem.Name = "telekKezeléseToolStripMenuItem";
            this.telekKezeléseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.telekKezeléseToolStripMenuItem.Text = "Telek kezelése";
            // 
            // ingatlanokToolStripMenuItem
            // 
            this.ingatlanokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingatlanFelvételeToolStripMenuItem,
            this.ingatlanKezeléseToolStripMenuItem});
            this.ingatlanokToolStripMenuItem.Name = "ingatlanokToolStripMenuItem";
            this.ingatlanokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingatlanokToolStripMenuItem.Text = "Ingatlanok";
            // 
            // ingatlanFelvételeToolStripMenuItem
            // 
            this.ingatlanFelvételeToolStripMenuItem.Name = "ingatlanFelvételeToolStripMenuItem";
            this.ingatlanFelvételeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ingatlanFelvételeToolStripMenuItem.Text = "Ingatlan felvétele";
            // 
            // ingatlanKezeléseToolStripMenuItem
            // 
            this.ingatlanKezeléseToolStripMenuItem.Name = "ingatlanKezeléseToolStripMenuItem";
            this.ingatlanKezeléseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ingatlanKezeléseToolStripMenuItem.Text = "Ingatlan kezelése";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.logoutToolStripMenuItem.Text = "Kilépés";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // adojelLabel
            // 
            this.adojelLabel.AutoSize = true;
            this.adojelLabel.Location = new System.Drawing.Point(50, 60);
            this.adojelLabel.Name = "adojelLabel";
            this.adojelLabel.Size = new System.Drawing.Size(86, 13);
            this.adojelLabel.TabIndex = 4;
            this.adojelLabel.Text = "Adóazonosító jel";
            // 
            // adojelField
            // 
            this.adojelField.Location = new System.Drawing.Point(53, 76);
            this.adojelField.Name = "adojelField";
            this.adojelField.ReadOnly = true;
            this.adojelField.Size = new System.Drawing.Size(100, 20);
            this.adojelField.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(50, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(27, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Név";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(53, 125);
            this.nameField.Name = "nameField";
            this.nameField.ReadOnly = true;
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(50, 160);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(43, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Lakcím";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(53, 176);
            this.addressField.Name = "addressField";
            this.addressField.ReadOnly = true;
            this.addressField.Size = new System.Drawing.Size(100, 20);
            this.addressField.TabIndex = 7;
            // 
            // mobileNumberLabel
            // 
            this.mobileNumberLabel.AutoSize = true;
            this.mobileNumberLabel.Location = new System.Drawing.Point(50, 208);
            this.mobileNumberLabel.Name = "mobileNumberLabel";
            this.mobileNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.mobileNumberLabel.TabIndex = 10;
            this.mobileNumberLabel.Text = "Telefonszám";
            // 
            // mobileNumberField
            // 
            this.mobileNumberField.Location = new System.Drawing.Point(53, 224);
            this.mobileNumberField.Name = "mobileNumberField";
            this.mobileNumberField.ReadOnly = true;
            this.mobileNumberField.Size = new System.Drawing.Size(100, 20);
            this.mobileNumberField.TabIndex = 9;
            // 
            // mothersNameLabel
            // 
            this.mothersNameLabel.AutoSize = true;
            this.mothersNameLabel.Location = new System.Drawing.Point(50, 257);
            this.mothersNameLabel.Name = "mothersNameLabel";
            this.mothersNameLabel.Size = new System.Drawing.Size(60, 13);
            this.mothersNameLabel.TabIndex = 12;
            this.mothersNameLabel.Text = "Anyja neve";
            // 
            // mothersNameField
            // 
            this.mothersNameField.Location = new System.Drawing.Point(53, 273);
            this.mothersNameField.Name = "mothersNameField";
            this.mothersNameField.ReadOnly = true;
            this.mothersNameField.Size = new System.Drawing.Size(100, 20);
            this.mothersNameField.TabIndex = 11;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mothersNameLabel);
            this.Controls.Add(this.mothersNameField);
            this.Controls.Add(this.mobileNumberLabel);
            this.Controls.Add(this.mobileNumberField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.adojelLabel);
            this.Controls.Add(this.adojelField);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProfileForm";
            this.Text = "Profilom";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem adataimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserDataOption;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label adojelLabel;
        private System.Windows.Forms.TextBox adojelField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label mobileNumberLabel;
        private System.Windows.Forms.TextBox mobileNumberField;
        private System.Windows.Forms.Label mothersNameLabel;
        private System.Windows.Forms.TextBox mothersNameField;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telkekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telekFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telekKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingatlanokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingatlanFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingatlanKezeléseToolStripMenuItem;
    }
}