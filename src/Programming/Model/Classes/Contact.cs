﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о человеке и его контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private long _number;

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта. Должен быть положительным.
        /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _number = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/> без инициализации.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="number">Номер телефона. Должен быть положительным.</param>
        public Contact (string name, string surname, long number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемая строка состоит не только из букв.</exception>
        private void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string property = "")
        {
            string pattern = @"[A-Z]{1}[a-z]{1,}";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(value))
            {
                throw new ArgumentException($"Указано некорректное значение в поле {property}");
            }
        }
    }
}
