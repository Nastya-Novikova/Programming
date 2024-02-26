using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Сериализует объект.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public static void SaveToFile(Contact contact)
        {
            string directoryName = 
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            FileName = Path.Combine(directoryName, "contacts.json");
            File.WriteAllText(FileName, string.Empty);
            File.AppendAllText(FileName, JsonConvert.SerializeObject(contact));
        }

        /// <summary>
        /// Десериализует объект из файла.
        /// </summary>
        /// <returns>Возвращает объект, полученный из файла.</returns>
        public static Contact LoadFromFile()
        {
            string directoryName = 
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            FileName = Path.Combine(directoryName, "contacts.json");
            FileInfo fileInfo = new FileInfo(FileName);
            if (fileInfo.Exists)
            {
                JsonTextReader reader = new JsonTextReader(new StreamReader(FileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Contact loadedContact = serializer.Deserialize<Contact>(reader);
                    return loadedContact;
                }
                reader.Close();
                return new Contact();
            }
            else
            {
                File.WriteAllText(FileName, string.Empty);
                return new Contact();
            }
        }

    }
}
