using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни в секундах. Должна быть положительной.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/> без инициализации.
        /// </summary>
        public Song ()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="author">Исполнитель.</param>
        /// <param name="seconds">Продолжительность в секундах. Должна быть положительной.</param>
        public Song(string name, string author, int seconds)
        {
            Name = name;
            Author = author;
            Seconds = seconds;
        }
    }
}
