using System.Reflection;

namespace AddressBook.Classes
{
    public class FileDirectory
    {
        public static string GetJsonPath()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string jsonDirectory = Path.Combine(projectDirectory, "JSON");

            if (!Directory.Exists(jsonDirectory))
            {
                Directory.CreateDirectory(jsonDirectory);
            }

            string jsonFilePath = Path.Combine(jsonDirectory, "Addressbook.json");
            return jsonFilePath;
        }

        public static void EnsureJsonFileExists()
        {
            string jsonFilePath = GetJsonPath();

            if (!File.Exists(jsonFilePath))
            {
                File.WriteAllText(jsonFilePath, "[]");
            }
        }
    }
}
