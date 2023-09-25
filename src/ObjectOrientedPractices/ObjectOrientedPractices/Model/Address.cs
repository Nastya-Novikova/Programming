using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Адрес.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Должен быть шестизначным числом.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                int min = 100000;
                int max = 999999;
                ValueValidator.AssertValueInRange(value, min, max);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну.
        /// Должна быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                int min = 1;
                int max = 50;
                ValueValidator.AssertStringOnLength(value, min, max);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город.
        /// Должен быть не более 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                int min = 1;
                int max = 50;
                ValueValidator.AssertStringOnLength(value, min, max);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// Должна быть не более 100 символов.
        /// </summary>
        public string Street
        { 
            get => _street;
            set
            {
                int min = 1;
                int max = 100;
                ValueValidator.AssertStringOnLength(value, min, max);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// Должен быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                int min = 1;
                int max = 10;
                ValueValidator.AssertStringOnLength(value, min, max);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// Должен быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                int min = 1;
                int max = 10;
                ValueValidator.AssertStringOnLength(value, min, max);
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна. Должна быть до 50 символов.</param>
        /// <param name="city">Город. Должен быть до 50 символов.</param>
        /// <param name="street">Улица. Должна быть до 100 символов.</param>
        /// <param name="building">Номер дома. Должен быть до 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Должен быть до 10 символов.</param>
        public Address(int index, string country, string city,
                       string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/> без инициализации.
        /// </summary>
        public Address()
        {

        }
    }
}
