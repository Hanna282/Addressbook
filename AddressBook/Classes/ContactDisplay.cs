namespace AddressBook.Classes
{
    public class ContactDisplay
    {
        public Contact Contact { get; set; }

        public override string ToString()
        {
            return $"Name: {Contact.FullName}. City: {Contact.City}";
        }
    }
}

