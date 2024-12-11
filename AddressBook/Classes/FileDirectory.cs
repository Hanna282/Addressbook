using System.Reflection;

namespace AddressBook.Classes
{
    public class FileDirectory
    {
        //public static string GetJsonPath()
        //{
        //    string basePath = AppDomain.CurrentDomain.BaseDirectory;
        //    string solutionFolder = Path.Combine(basePath, @"..\..\..\JSON");
        //    string jsonFilePath = Path.Combine(solutionFolder, "Addressbook.json");
        //    return jsonFilePath;
        //}

        //public static string GetJsonPath()
        //{
        //    string basePath = AppDomain.CurrentDomain.BaseDirectory;
        //    string jsonFilePath = Path.Combine(basePath, @"JSON\Addressbook.json");
        //    return jsonFilePath;
        //}

        //public static void EnsureJsonFileExists()
        //{
        //    string jsonFilePath = GetJsonPath();

        //    if (!File.Exists(jsonFilePath))
        //    {
        //        // var resourcePath = "ProjectNamespace.JSON.Addressbook.json";
        //        var resourcePath = "AddressBook.JSON.Addressbook.json";

        //        using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
        //        using (var fileStream = new FileStream(jsonFilePath, FileMode.CreateNew))
        //        {
        //            resourceStream.CopyTo(fileStream);
        //        }
        //    }
        //}

        public static string GetJsonPath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Skapa en undermapp för ditt projekt i AppData (om den inte finns)
            string jsonDirectory = Path.Combine(appDataPath, "AddressBook", "JSON");

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

            // Kontrollera om filen redan finns
            if (!File.Exists(jsonFilePath))
            {
                // Om filen inte finns, skapa en tom JSON-fil
                File.WriteAllText(jsonFilePath, "[]");  // Skapa en tom lista som standard
            }
        }
    }
}
