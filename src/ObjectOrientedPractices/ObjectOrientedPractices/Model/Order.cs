using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный номер заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private readonly DateTime _date;

        private readonly double _amount;

        private readonly int _customerId;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный номер заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает время создания заказа.
        /// </summary>
        public string Date => _date.ToShortDateString();

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
        /// </summary>
        public BindingList<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get => _status;
            set => _status = value;
        }

        /// <summary>
        /// Возвращает общую стоимость товаров в заказе.
        /// </summary>
        public double Amount => _amount;

        public int CustomerId => _customerId;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="status">Статус заказа.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Order(Address address, BindingList<Item> items, OrderStatus status, double amount, int customerId)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Today;
            Address = address;
            Items = items;
            Status = status;
            _amount = amount;
            _customerId = customerId;
        }
    }
}
