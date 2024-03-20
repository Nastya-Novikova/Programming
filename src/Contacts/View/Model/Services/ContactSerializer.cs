using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static void SaveToFile(ObservableCollection<Contact> contacts)
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
            for (int i = 0; i < contacts.Count; i++)
            {
                File.AppendAllText(FileName, JsonConvert.SerializeObject(contacts[i]));

            }
        }

        /// <summary>
        /// Десериализует объект из файла.
        /// </summary>
        /// <returns>Возвращает объект, полученный из файла.</returns>
        public static ObservableCollection <Contact> LoadFromFile()
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
                ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
                JsonTextReader reader = new JsonTextReader(new StreamReader(FileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Contact loadedContact = serializer.Deserialize<Contact>(reader);
                    contacts.Add(loadedContact);
                }
                reader.Close();
                return contacts;
            }
            else
            {
                File.WriteAllText(FileName, string.Empty);
                return new ObservableCollection<Contact>();
            }
        }

    }
}
