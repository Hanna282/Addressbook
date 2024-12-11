namespace AddressBook
{
    partial class FrmEditContact
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
            btnUpdate = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnDelete = new Button();
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
            btnClose = new Button();
            lblAddressBook = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 730);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 38);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(69, 625);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 655);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(433, 31);
            txtEmail.TabIndex = 51;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 730);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 38);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(69, 537);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 49;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(69, 567);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(433, 31);
            txtPhone.TabIndex = 48;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(290, 443);
            lblCity.Margin = new Padding(4, 0, 4, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 47;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(290, 473);
            txtCity.Margin = new Padding(4, 5, 4, 5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(211, 31);
            txtCity.TabIndex = 46;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(69, 443);
            lblPostalCode.Margin = new Padding(4, 0, 4, 0);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(106, 25);
            lblPostalCode.TabIndex = 45;
            lblPostalCode.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(69, 473);
            txtPostalCode.Margin = new Padding(4, 5, 4, 5);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(211, 31);
            txtPostalCode.TabIndex = 44;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(69, 352);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 43;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(69, 382);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(433, 31);
            txtAddress.TabIndex = 42;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(69, 255);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 285);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(433, 31);
            txtName.TabIndex = 38;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(69, 170);
            lblContact.Margin = new Padding(4, 0, 4, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(194, 45);
            lblContact.TabIndex = 37;
            lblContact.Text = "Edit contact";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(383, 730);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 54;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblAddressBook
            // 
            lblAddressBook.AutoSize = true;
            lblAddressBook.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressBook.Location = new Point(69, 43);
            lblAddressBook.Margin = new Padding(4, 0, 4, 0);
            lblAddressBook.Name = "lblAddressBook";
            lblAddressBook.Size = new Size(291, 57);
            lblAddressBook.TabIndex = 55;
            lblAddressBook.Text = "Address Book";
            // 
            // FrmEditContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 817);
            Controls.Add(lblAddressBook);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnDelete);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEditContact";
            Text = "Edit Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnDelete;
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
        private Button btnClose;
        private Label lblAddressBook;
    }
}