using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Выполняет сохранение объекта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Создает объект команды.
        /// </summary>
        public SaveCommand ()
        {

        }

        /// <summary>
        /// Определяет возможность выполнения команды.
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет сериализацию переданого объекта.
        /// </summary>
        /// <param name="parameter">Объект для сериализации.</param>
        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                if (parameter is Contact contact)
                {
                    ContactSerializer.SaveToFile(contact);
                }
                
            }
        }
    }
}
