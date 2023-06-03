using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song : ICloneable
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _name;

        /// <summary>
        /// Исполнитель песни.
        /// </summary>
        private string _singer;

        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает название песни.
        /// Должна быть от 1 до 50 символов.
        /// </summary>
        public string Name
        {
            get { return _name;}
            set
            {
                int min = 1;
                int max = 50;
                Validator.AssertValueInRange(value.Length, min, max);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает исполнителя песни.
        /// Должен быть от 1 до 50 символов.
        /// </summary>
        public string Singer
        {
            get => _singer;
            set
            {
                const int min = 1;
                int max = 50;
                Validator.AssertValueInRange(value.Length, min, max);
                _singer = value;
            }
        }

        /// <summary>
        /// Возвращает и задает продолжительность песни.
        /// Должна быть от 1 до 7200 секунд.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                int min = 1;
                int max = 7200;
                Validator.AssertValueInRange(value, min, max);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает строку, содержащую исполнителя и название песни.
        /// </summary>
        public string Info => $"{Singer} - {Name}";

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/> без инициализации.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название. От 1 до 50 символов.</param>
        /// <param name="singer">Исполнитель. От 1 до 50 символов.</param>
        /// <param name="duration">Продолжительность. От 1 до 7200 секунд.</param>
        /// <param name="genre">Жанр.</param>
        public Song(string name, string singer, int duration, string genre)
        {
            Name = name;
            Singer = singer;
            Duration = duration;
            Genre = genre;
        }

        /// <summary>
        /// Создает копию объекта.
        /// </summary>
        /// <returns>Возвращает копию объекта.</returns>
        public object Clone()
        {
            return new Song(Name, Singer, Duration, Genre); 
        }
    }
}
