using Newtonsoft.Json;

namespace AddressBook.Classes
{
    public class Repository
    {
        private static string _filePath = FileDirectory.GetJsonPath();

        public static void Save(List<Contact> contacts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                using (StreamWriter writer = new(_filePath, false))
                {
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error message: {ex.Message}");
            }
        }

        public static List<Contact> GetContacts()
        {
            if (!File.Exists(_filePath))
                return new List<Contact>();

            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error message: {ex.Message}");
                return new List<Contact>();
            }
        }
    }
}
