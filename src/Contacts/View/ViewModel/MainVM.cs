using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// Реализует интерфейс INotifyPropertyChanged.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
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
        /// Команда, выполняющая сохранение объекта.
        /// </summary>
        public SaveCommand Save { get; }

        /// <summary>
        /// Команда, выполняющая загрузку объекта.
        /// </summary>
        public LoadCommand Load { get; }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            { 
               _name = value;
                CurrentContact.Name = _name;
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
                CurrentContact.Email = _email;
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
                CurrentContact.Phone = _phone;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// ВОзвращает и задает выбранный контакт.
        /// </summary>
        public Contact CurrentContact { get; set; }

        /// <summary>
        /// Создает экземпляр объекта MainVM, SaveCommand, LoadCommand.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();
            Save = new SaveCommand();
            Load = new LoadCommand(LoadContact);
        }

        /// <summary>
        /// Обновляет поля при загрузке контакта из файла.
        /// </summary>
        /// <param name="contact">Контакт, полученный из файла.</param>
        private void LoadContact(Contact contact)
        {
            if (contact != null)
            {
                Name = contact.Name;
                Email = contact.Email;
                Phone = contact.Phone;
            }
        }

        /// <summary>
        /// Зажигается при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обновляет привязанные объекты
        /// </summary>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
