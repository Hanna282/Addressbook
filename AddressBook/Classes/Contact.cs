namespace AddressBook.Classes
{
    public class Contact
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public static void Create(Contact contact)
        {
            List<Contact> contacts = Repository.GetContacts() ?? new List<Contact>(); 
            contacts.Add(contact);
            Repository.Save(contacts);
        }

        public static bool Update(int id, Contact editedContact)
        {
            List<Contact> contacts = Repository.GetContacts() ?? new List<Contact>();
            var contact = contacts.FirstOrDefault(con => con.Id == id);

            if (contact == null)
                return false; //Contact not found
            else
            {
                contact.FullName = editedContact.FullName;
                contact.Address = editedContact.Address;
                contact.PostalCode = editedContact.PostalCode;
                contact.City = editedContact.City;
                contact.Phone = editedContact.Phone;
                contact.Email = editedContact.Email;
                Repository.Save(contacts);
                return true; //Successfully updated the contact
            }
        }

        public static bool Delete(int id)
        {
            List<Contact> contacts = Repository.GetContacts() ?? new List<Contact>();
            var contactToDelete = contacts.FirstOrDefault(con => con.Id == id);

            if (contactToDelete == null)
                return false; //Contact not found
            else
            {
                contacts.Remove(contactToDelete);
                Repository.Save(contacts);
                return true; //Successfully deleted the contact
            }
        }

        public static List<Contact> Search(string keyWord, bool name, bool city)
        {
            var contacts = Repository.GetContacts();
            var searchResult = new List<Contact>();

            if (name)
            {
                return searchResult = contacts
                    .Where(con => con.FullName.ToLower().Contains(keyWord.ToLower()))
                    .ToList();
            }
            else if (city)
            {
                return searchResult = contacts
                    .Where(con => con.City.ToLower().Contains(keyWord.ToLower()))
                    .ToList();
            }
            else if (name && city)
            {
                return searchResult = contacts
                    .Where(con => con.FullName.ToLower().Contains(keyWord.ToLower()) ||
                                  con.City.ToLower().Contains(keyWord.ToLower()))
                    .ToList();
            }
            else
            {
                return searchResult = contacts
                    .Where(con => con.FullName.ToLower().Contains(keyWord.ToLower()) ||
                                  con.Address.ToLower().Contains(keyWord.ToLower()) ||
                                  con.PostalCode.ToLower().Contains(keyWord.ToLower()) ||
                                  con.City.ToLower().Contains(keyWord.ToLower()) ||
                                  con.Phone.ToLower().Contains(keyWord.ToLower()) ||
                                  con.Email.ToLower().Contains(keyWord.ToLower()))
                    .ToList();
            }
        }
    }
}

