using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractices.Model.Orders
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Уникальный номер заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Идентификатор покупателя.
        /// </summary>
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
        public double Amount
        {
            get
            {
                double amount = 0.0;
                if (_items == null || _items.Count == 0)
                {
                    return amount;
                }
                for (int i = 0; i < _items.Count; i++)
                {
                    amount += _items[i].Cost;
                }
                return amount;
            }
        }

        /// <summary>
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return (Amount - DiscountAmount);
            }
        }

        /// <summary>
        /// Возвращает идентификатор покупателя.
        /// </summary>
        public int CustomerId => _customerId;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="customerId">Идентификатор покупателя.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Order(Address address, BindingList<Item> items, int customerId)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Today;
            Address = address;
            Items = items;
            Status = OrderStatus.New;
            _customerId = customerId;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим.</param>
        /// <returns>True, если объекты равны, иначе False.</returns>
        bool IEquatable<Order>.Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var order = (Order)other;
            var flag = true;
            for (int i = 0; i < Items.Count; i++)
            {
                flag = Items[i].Equals(order.Items[i]);
                if (flag == false)
                {
                    break;
                }
            }

            if (Date == order.Date &&
                CustomerId == order.CustomerId &&
                Address.Equals(order.Address) &&
                flag &&
                Status == order.Status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим.</param>
        /// <returns>True, если объекты равны, иначе False.</returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (other is not Order)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var order = (Order)other;
            var flag = true;
            for (int i = 0; i < Items.Count; i++)
            {
                flag = Items[i].Equals(order.Items[i]);
                if (flag == false)
                {
                    break;
                }
            }

            if (Date == order.Date &&
                CustomerId == order.CustomerId &&
                Address.Equals(order.Address) &&
                flag &&
                Status == order.Status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
