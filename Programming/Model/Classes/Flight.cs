using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Продолжительность полета.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Возвращает и задает пункт отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность полета. Должна быть положительной.
        /// </summary>
        public int FlightTime
        {
            get => _flightTime;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/> без инициализации.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTime">Продолжительность полета. Должна быть положительной.</param>
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}
