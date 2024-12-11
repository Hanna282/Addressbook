namespace AddressBook
{
    partial class FrmAddressBook
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
            lblAddressBook = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblContact = new Label();
            btnSave = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSearchCondition = new Label();
            chkName = new CheckBox();
            chkCity = new CheckBox();
            lstSearchResult = new ListBox();
            btnGetAll = new Button();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // lblAddressBook
            // 
            lblAddressBook.AutoSize = true;
            lblAddressBook.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressBook.Location = new Point(261, 25);
            lblAddressBook.Name = "lblAddressBook";
            lblAddressBook.Size = new Size(196, 37);
            lblAddressBook.TabIndex = 35;
            lblAddressBook.Text = "Address Book";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 365);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 383);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 23);
            txtEmail.TabIndex = 33;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(40, 312);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 30;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(40, 330);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(304, 23);
            txtPhone.TabIndex = 29;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(195, 256);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 28;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(195, 274);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(149, 23);
            txtCity.TabIndex = 27;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(40, 256);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(70, 15);
            lblPostalCode.TabIndex = 26;
            lblPostalCode.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(40, 274);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(149, 23);
            txtPostalCode.TabIndex = 25;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(40, 201);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 24;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(40, 219);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(304, 23);
            txtAddress.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 161);
            txtName.Name = "txtName";
            txtName.Size = new Size(304, 23);
            txtName.TabIndex = 19;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(40, 89);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(88, 30);
            lblContact.TabIndex = 18;
            lblContact.Text = "Contact";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(261, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 23);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(468, 89);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 30);
            lblSearch.TabIndex = 37;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(468, 135);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter a keyword";
            txtSearch.Size = new Size(179, 23);
            txtSearch.TabIndex = 38;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(653, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 39;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearchCondition
            // 
            lblSearchCondition.AutoSize = true;
            lblSearchCondition.Location = new Point(468, 165);
            lblSearchCondition.Name = "lblSearchCondition";
            lblSearchCondition.Size = new Size(62, 15);
            lblSearchCondition.TabIndex = 40;
            lblSearchCondition.Text = "Search on:";
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Location = new Point(536, 165);
            chkName.Name = "chkName";
            chkName.Size = new Size(58, 19);
            chkName.TabIndex = 41;
            chkName.Text = "Name";
            chkName.UseVisualStyleBackColor = true;
            // 
            // chkCity
            // 
            chkCity.AutoSize = true;
            chkCity.Location = new Point(600, 164);
            chkCity.Name = "chkCity";
            chkCity.Size = new Size(47, 19);
            chkCity.TabIndex = 42;
            chkCity.Text = "City";
            chkCity.UseVisualStyleBackColor = true;
            // 
            // lstSearchResult
            // 
            lstSearchResult.FormattingEnabled = true;
            lstSearchResult.ItemHeight = 15;
            lstSearchResult.Location = new Point(468, 195);
            lstSearchResult.Name = "lstSearchResult";
            lstSearchResult.Size = new Size(260, 214);
            lstSearchResult.TabIndex = 43;
            lstSearchResult.SelectedIndexChanged += lstSearchResult_SelectedIndexChanged;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(653, 431);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(75, 23);
            btnGetAll.TabIndex = 44;
            btnGetAll.Text = "Get all";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnOpen
            // 
            btnOpen.Enabled = false;
            btnOpen.Location = new Point(572, 429);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 25);
            btnOpen.TabIndex = 45;
            btnOpen.Text = "Open ";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // FrmAddressBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 474);
            Controls.Add(btnOpen);
            Controls.Add(btnGetAll);
            Controls.Add(lstSearchResult);
            Controls.Add(chkCity);
            Controls.Add(chkName);
            Controls.Add(lblSearchCondition);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnSave);
            Controls.Add(lblAddressBook);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblPostalCode);
            Controls.Add(txtPostalCode);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblContact);
            Name = "FrmAddressBook";
            Text = "AddressBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddressBook;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblName;
        private TextBox txtName;
        private Label lblContact;
        private Button btnSave;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearchCondition;
        private CheckBox chkName;
        private CheckBox chkCity;
        private ListBox lstSearchResult;
        private Button btnGetAll;
        private Button btnOpen;
    }
}