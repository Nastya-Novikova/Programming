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
    public class Contact: INotifyPropertyChanged, IDataErrorInfo
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
        /// Возвращает ошибку.
        /// </summary>
        public string Error => ""; 

        /// <summary>
        /// Возвращает строку, содержащую ошибку.
        /// </summary>
        /// <returns>Строка, содержащая информацию об ошибке.</returns>
        public string this[string propertyName]
        {
            get
            {
                string error = string.Empty;
                switch (propertyName)
                {
                    case nameof(Name):
                        if (Name == null)
                        {
                            break;
                        }
                        else if (Name.Length == 0 || Name.Length > 100)
                        {
                            error = "Имя должно быть от 1 до 100 символов.";
                        }
                        break;

                    case nameof(Phone):
                        if (Phone == null)
                        {
                            break;
                        }
                        if (Phone.Length == 0 || Phone.Length > 100)
                        {
                            error = "Номер телефона должен быть не длиннее 100 символов и может содержать только цифры или символы +-() .";
                        }
                        break;

                    case nameof(Email):
                        if (Email == null)
                        {
                            break;
                        }
                        if (Email.Length == 0 || Email.Length > 100 || !Email.Contains("@"))
                        {
                            error = "Email должен быть не длиннее 100 символов и должен содержать символ @ .";
                        }
                        break;
                }
                return error;
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
