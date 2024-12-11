using AddressBook.Classes;

namespace AddressBook
{
    public partial class FrmAddressBook : Form
    {
        public FrmAddressBook()
        {
            InitializeComponent();
            FileDirectory.EnsureJsonFileExists();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("You must enter a keyword to search!");
            else
            {
                try
                {
                    var searchResult = Contact.Search(txtSearch.Text, chkName.Checked, chkCity.Checked);
                    lstSearchResult.Items.Clear();

                    if (searchResult.Count > 0)
                    {
                        foreach (var contact in searchResult)
                        {
                            lstSearchResult.Items.Add(new ContactDisplay { Contact = contact });
                        }
                    }
                    else
                        lstSearchResult.Items.Add("Search not found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}");
                }
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstSearchResult.Items.Clear();
            try
            {
                var contacts = Repository.GetContacts();
                foreach (var contact in contacts)
                {
                    lstSearchResult.Items.Add(new ContactDisplay { Contact = contact });
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error message: {ex.Message}");
            }
        }

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResult.SelectedItem != null)
                btnOpen.Enabled = true;
            else
                btnOpen.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var selectedContact = lstSearchResult.SelectedItem;

            if (selectedContact is ContactDisplay display)
            {
                Contact contactSelected = display.Contact;

                if (contactSelected != null)
                {
                    FrmEditContact frmEditContact = new FrmEditContact(contactSelected);
                    frmEditContact.Show();
                    ClearForm();
                }
            }
            else
                MessageBox.Show("You must select a contact.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lstSearchResult.Items.Clear();

            if (!MandatoryFields())
            {
                MessageBox.Show("All fields must be filled in.");
                return;
            }
            else
            {
                var newContact = new Contact
                {
                    FullName = txtName.Text,
                    Address = txtAddress.Text,
                    PostalCode = txtPostalCode.Text,
                    City = txtCity.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Id = new Random().Next(1, 100)
                };
                try
                {
                    Contact.Create(newContact);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}");
                    return;
                }
                MessageBox.Show("Contact has been saved.");
                ClearForm();
            }
        }

        private void ClearForm()
        {
            lstSearchResult.Items.Clear();
            txtSearch.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPostalCode.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
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
