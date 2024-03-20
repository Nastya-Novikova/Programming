using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// Реализует интерфейс INotifyPropertyChanged.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Команда, применяющая изменения.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Команда, добавляющая новый контакт.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Команда для редактирования контакта.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Команда, удаляющая контакт.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Определяет доступ для чтения и редактирования.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Видимость кнопки.
        /// </summary>
        private bool _visibility;

        /// <summary>
        /// Возвращает и задает состояние объекта при редактировании.
        /// </summary>
        public bool IsEditing { get; set; }

        /// <summary>
        /// Возвращает и задает копию редактируемого объекта.
        /// </summary>
        public Contact EditedContact { get; set; }

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает возможность редактировать объект.
        /// </summary>
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            private set
            {
                _isReadOnly = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает видимость кнопки.
        /// </summary>
        public bool Visibility
        {
            get { return _visibility; }
            private set
            {
                _visibility = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// При изменении текущего контакта в режиме добавления/редактирования
        /// возвращает старые значения полей.
        /// </summary>
        public Contact CurrentContact 
        { 
            get { return _currentContact; }
            set 
            { 
                if (IsEditing == true)
                {
                    IsEditing = false;
                    CurrentContact.Name = EditedContact.Name;
                    CurrentContact.Email = EditedContact.Email;
                    CurrentContact.Phone = EditedContact.Phone;
                }
                IsReadOnly = true;
                Visibility = false;
                _currentContact = value;
                OnPropertyChanged();
            }

        }

        /// <summary>
        /// Подтверждает редактирование или добавление контакта.
        /// Сохраняет данные в файл.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get { 
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(obj =>
                    {
                        IsReadOnly = true;
                        if (IsEditing == true)
                        {
                            IsEditing = false;
                        }
                        else
                        {
                            Contacts.Add(CurrentContact);
                        }
                        Visibility = false;
                        ContactSerializer.SaveToFile(Contacts);
                    }));
            }
        }

        /// <summary>
        /// Добавление контакта.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        Contact contact = new Contact();
                        CurrentContact = contact;
                        IsReadOnly = false;
                        Visibility = true;
                    },
                    (obj) => (IsReadOnly != false)));
            }
        }

        /// <summary>
        /// Редактирование контакта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new RelayCommand(obj =>
                    {
                        IsReadOnly = false;
                        IsEditing = true;
                        Visibility = true;
                        EditedContact = new Contact(CurrentContact.Name, CurrentContact.Email, CurrentContact.Phone);
                    },
                    (obj) => (Contacts.Count > 0 && CurrentContact != null &&
                              Contacts.IndexOf(CurrentContact) != -1 && 
                              IsReadOnly != false)));
            }
        }

        /// <summary>
        /// Удаление контакта.
        /// Сохраняет данные в файл.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        int index = Contacts.IndexOf(CurrentContact);
                        Contacts.Remove(CurrentContact);
                        if (index == Contacts.Count && Contacts.Count != 0)
                        {
                            CurrentContact = Contacts[index-1];
                        }
                        else if (Contacts.Count != 0)
                        {
                            CurrentContact = Contacts[index];
                        }
                        ContactSerializer.SaveToFile(Contacts);
                    },
                    (obj) => (Contacts.Count > 0 && CurrentContact != null && 
                              Contacts.IndexOf(CurrentContact) != -1 &&
                              IsReadOnly != false)));
            }
        }

        /// <summary>
        /// Создает экземпляр объекта MainVM.
        /// Загружает информацию из файла.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();
            EditedContact = new Contact();
            Contacts = new ObservableCollection<Contact>();
            Contacts = ContactSerializer.LoadFromFile();
            IsReadOnly = true;
            IsEditing = false;
            Visibility = false;
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
