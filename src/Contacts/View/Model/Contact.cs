using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace View.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact
    { 
        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Создает объект контакта с инициализацией полей.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="email">Почта контакта.</param>
        /// <param name="phone">Телефон контакта.</param>
        public Contact (string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        /// <summary>
        /// Создает объект контакта без инициализации полей.
        /// </summary>
        public Contact()
        {

        }

    }
}
