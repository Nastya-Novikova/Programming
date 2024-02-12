using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Выполняет загрузку объекта из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Загруженный контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Содержит метод передаваемый в конструктор.
        /// </summary>
        private Action<Contact> _loadContact;
        
        /// <summary>
        /// Создает объект команды.
        /// </summary>
        /// <param name="loadContact">Метод из MainVM.</param>
        public LoadCommand (Action<Contact> loadContact)
        {
            _loadContact = loadContact;
        }

        /// <summary>
        /// Определяет возможность выполнения команды.
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет десериализацию. 
        /// Вызывает метод для обновления CurrentContact.
        /// </summary>
        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                _contact = ContactSerializer.LoadFromFile();
                _loadContact(_contact);
            }
        }
    }
}
