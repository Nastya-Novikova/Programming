using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    public class Customer
    {
        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает уникальный номер покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Должно быть от 1 до 200 символов.
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                int min = 1;
                int max = 200;
                ValueValidator.AssertStringOnLength(value, min, max);
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// Должен быть от 1 до 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                int min = 1;
                int max = 500;
                ValueValidator.AssertStringOnLength(value, min, max);
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Имя. Должно быть от 1 до 200 символов.</param>
        /// <param name="address">Адрес. Должен быть от 1 до 500 символов.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Customer(string fullname, string address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> без инициализации.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }
    }
}
