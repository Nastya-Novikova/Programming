using Accessibility;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// Реализует интерфейс INotifyPropertyChanged.
    /// </summary>
    public partial class MainVM : ObservableObject
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
        /// Коллекция контактов
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                NotifyCanExecuteChangedCommands();
            }
        }

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
                NotifyCanExecuteChangedCommands();
            }

        }

        /// <summary>
        /// Подтверждает редактирование или добавление контакта.
        /// Сохраняет данные в файл.
        /// </summary>
        public RelayCommand ApplyCommand => _applyCommand ??=
            new RelayCommand(() =>
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
                NotifyCanExecuteChangedCommands();
            },
            () => CurrentContact != null); 

        /// <summary>
        /// Добавление контакта.
        /// </summary>
        public RelayCommand AddCommand => _addCommand ??=
            new RelayCommand(() =>
            {
                Contact contact = new Contact();
                CurrentContact = contact;
                IsReadOnly = false;
                Visibility = true;
            });

        /// <summary>
        /// Редактирование контакта.
        /// </summary>
        public RelayCommand EditCommand => _editCommand ??=
            new RelayCommand(() =>
            {
                IsReadOnly = false;
                IsEditing = true;
                Visibility = true;
                EditedContact = new Contact(CurrentContact.Name, CurrentContact.Email, CurrentContact.Phone);
            },
            () => Contacts.Count > 0
            && CurrentContact != null &&
            Contacts.IndexOf(CurrentContact) != -1);

        /// <summary>
        /// Удаление контакта.
        /// Сохраняет данные в файл.
        /// </summary>
        public RelayCommand RemoveCommand => _removeCommand ??=
            new RelayCommand(() =>
            {
                int index = Contacts.IndexOf(CurrentContact);
                Contacts.Remove(CurrentContact);
                if (index == Contacts.Count && Contacts.Count != 0)
                {
                    CurrentContact = Contacts[index - 1];
                }
                else if (Contacts.Count != 0)
                {
                    CurrentContact = Contacts[index];
                }
                ContactSerializer.SaveToFile(Contacts);
            },
            () => (Contacts.Count > 0 &&
                   CurrentContact != null &&
                   Contacts.IndexOf(CurrentContact) != -1));

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

        public void NotifyCanExecuteChangedCommands()
        {
            AddCommand.NotifyCanExecuteChanged();
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
            ApplyCommand.NotifyCanExecuteChanged();
        }
    }
}
