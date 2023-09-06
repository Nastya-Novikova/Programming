using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна быть положительной.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма. Должен быть в интервале от 1900 до 2023.
        /// </summary>
        public int Year
        {
            get => _year; 
            set
            {
                int min = 1900;
                int max = 2023;
                Validator.AssertValueInRange(value, min, max);
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть в интервале от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                int min = 0;
                int max = 10;
                Validator.AssertValueInRange(value, min, max);
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/> без инициализации.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="duration">Продолжительность. Должна быть положительной.</param>
        /// <param name="year">Год выпуска. Должен быть в интервале от 1900 до 2023.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг. Должен быть в интервале от 0 до 10.</param>
        public Movie(string name, int duration, int year, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}


