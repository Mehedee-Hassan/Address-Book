namespace Address_Book
{
    partial class AddressBookForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personalCnTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personalCnLabel = new System.Windows.Forms.Label();
            this.homeCnLabel = new System.Windows.Forms.Label();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.homeCnTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.personListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personalCnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homeCnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.enterValueLabel = new System.Windows.Forms.Label();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGroupBox.SuspendLayout();
            this.informationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(146, 43);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(325, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // personalCnTextBox
            // 
            this.personalCnTextBox.Location = new System.Drawing.Point(146, 69);
            this.personalCnTextBox.Name = "personalCnTextBox";
            this.personalCnTextBox.Size = new System.Drawing.Size(325, 20);
            this.personalCnTextBox.TabIndex = 2;
            this.personalCnTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(95, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(98, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // personalCnLabel
            // 
            this.personalCnLabel.AutoSize = true;
            this.personalCnLabel.Location = new System.Drawing.Point(25, 69);
            this.personalCnLabel.Name = "personalCnLabel";
            this.personalCnLabel.Size = new System.Drawing.Size(108, 13);
            this.personalCnLabel.TabIndex = 5;
            this.personalCnLabel.Text = "Personal Contact No:";
            // 
            // homeCnLabel
            // 
            this.homeCnLabel.AutoSize = true;
            this.homeCnLabel.Location = new System.Drawing.Point(41, 98);
            this.homeCnLabel.Name = "homeCnLabel";
            this.homeCnLabel.Size = new System.Drawing.Size(92, 13);
            this.homeCnLabel.TabIndex = 6;
            this.homeCnLabel.Text = "Home Contact No";
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Location = new System.Drawing.Point(54, 124);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.homeAddressLabel.TabIndex = 11;
            this.homeAddressLabel.Text = "Home Address:";
            // 
            // homeCnTextBox
            // 
            this.homeCnTextBox.Location = new System.Drawing.Point(146, 95);
            this.homeCnTextBox.Name = "homeCnTextBox";
            this.homeCnTextBox.Size = new System.Drawing.Size(325, 20);
            this.homeCnTextBox.TabIndex = 3;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(146, 121);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(325, 20);
            this.homeAddressTextBox.TabIndex = 4;
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.emailColumnHeader,
            this.personalCnColumnHeader,
            this.homeCnColumnHeader,
            this.addressColumnHeader});
            this.personListView.GridLines = true;
            this.personListView.Location = new System.Drawing.Point(12, 333);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(486, 188);
            this.personListView.TabIndex = 9;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 85;
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            this.emailColumnHeader.Width = 100;
            // 
            // personalCnColumnHeader
            // 
            this.personalCnColumnHeader.Text = "Personal Contact No";
            this.personalCnColumnHeader.Width = 110;
            // 
            // homeCnColumnHeader
            // 
            this.homeCnColumnHeader.Text = "Home Contact No";
            this.homeCnColumnHeader.Width = 100;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.Width = 167;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 161);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 26);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(141, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(240, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(398, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 24);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.enterValueLabel);
            this.searchGroupBox.Controls.Add(this.searchByLabel);
            this.searchGroupBox.Controls.Add(this.searchByComboBox);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 230);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(486, 87);
            this.searchGroupBox.TabIndex = 13;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // enterValueLabel
            // 
            this.enterValueLabel.AutoSize = true;
            this.enterValueLabel.Location = new System.Drawing.Point(25, 57);
            this.enterValueLabel.Name = "enterValueLabel";
            this.enterValueLabel.Size = new System.Drawing.Size(0, 13);
            this.enterValueLabel.TabIndex = 14;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(25, 22);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(56, 13);
            this.searchByLabel.TabIndex = 14;
            this.searchByLabel.Text = "Search By";
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Personal Contact No"});
            this.searchByComboBox.Location = new System.Drawing.Point(141, 19);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(240, 21);
            this.searchByComboBox.TabIndex = 7;
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Controls.Add(this.homeCnTextBox);
            this.informationGroupBox.Controls.Add(this.nameTextBox);
            this.informationGroupBox.Controls.Add(this.saveButton);
            this.informationGroupBox.Controls.Add(this.homeAddressTextBox);
            this.informationGroupBox.Controls.Add(this.emailTextBox);
            this.informationGroupBox.Controls.Add(this.button1);
            this.informationGroupBox.Controls.Add(this.personalCnTextBox);
            this.informationGroupBox.Controls.Add(this.homeAddressLabel);
            this.informationGroupBox.Controls.Add(this.nameLabel);
            this.informationGroupBox.Controls.Add(this.homeCnLabel);
            this.informationGroupBox.Controls.Add(this.emailLabel);
            this.informationGroupBox.Controls.Add(this.personalCnLabel);
            this.informationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(486, 203);
            this.informationGroupBox.TabIndex = 14;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Information";
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 533);
            this.Controls.Add(this.informationGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.personListView);
            this.Name = "AddressBookForm";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.AddressBookForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox personalCnTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label personalCnLabel;
        private System.Windows.Forms.Label homeCnLabel;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.TextBox homeCnTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader personalCnColumnHeader;
        private System.Windows.Forms.ColumnHeader homeCnColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Label enterValueLabel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox searchByComboBox;
    }
}

