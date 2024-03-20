using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace View.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact: INotifyPropertyChanged
    {
        /// <summary>
        /// Имя выбранного контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Почта выбранного контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефон выбранного контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name 
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email 
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string Phone 
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

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

        /// <summary>
        /// Зажигается при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обновляет привязанные объекты.
        /// </summary>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
