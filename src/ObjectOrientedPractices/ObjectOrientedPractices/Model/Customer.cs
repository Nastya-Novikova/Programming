using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Покупатель.
    /// </summary>
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
        private Address _address;

        /// <summary>
        /// Корзина товаров.
        /// </summary>
        private Cart _cart;

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
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Имя. Должно быть от 1 до 200 символов.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Customer(string fullname)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = new Address(100000, "Country","City", "Street",
                                          "Building", "Apartment");
            Cart = new Cart();
        }
    }
}
