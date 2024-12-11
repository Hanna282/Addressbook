using AddressBook.Classes;

namespace AddressBook
{
    public partial class FrmEditContact : Form
    {
        Contact selectedContact = new();

        public FrmEditContact(Contact contact)
        {
            InitializeComponent();
            this.selectedContact = contact;

            txtName.Text = contact.FullName;
            txtAddress.Text = contact.Address;
            txtPostalCode.Text = contact.PostalCode;
            txtCity.Text = contact.City;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!MandatoryFields())
            {
                MessageBox.Show("All fields must be filled in.");
                return;
            }
            else
            {
                var editedContact = new Contact
                {
                    FullName = txtName.Text,
                    Address = txtAddress.Text,
                    PostalCode = txtPostalCode.Text,
                    City = txtCity.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Id = this.selectedContact.Id, //Keeps the same Id 
                };

                if (Contact.Update(this.selectedContact.Id, editedContact))
                    MessageBox.Show("Contact updated successfully.");
                else
                    MessageBox.Show("Contact not found.");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm deletion",
                                           MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes && Contact.Delete(this.selectedContact.Id))
                this.Close();
            else if(!Contact.Delete(this.selectedContact.Id))
                MessageBox.Show("Contact not found.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool MandatoryFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text) || string.IsNullOrWhiteSpace(txtCity.Text) ||
                 string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                return false;
            else
                return true;
        }
    }
}
