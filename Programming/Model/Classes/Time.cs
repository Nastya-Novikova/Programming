using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы. Должны быть в интервале от 0 до 23.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                int min = 0;
                int max = 23;
                Validator.AssertValueInRange(value, min, max);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть в интервале от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть в интервале от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/> без инициализации.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Должны быть в интервале от 0 до 23.</param>
        /// <param name="minutes">Минуты. Должны быть в интервале от 0 до 59.</param>
        /// <param name="seconds">Секунды. Должны быть в интервале от 0 до 59.</param>
        public Time (int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
