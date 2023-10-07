using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Приоритетный заказ.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Временной интервал доставки.
        /// </summary>
        private string _interval;

        /// <summary>
        /// Возвращает и задает временной интервал доставки.
        /// </summary>
        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        /// <summary>
        /// Создает объект класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="customerId">Идентификатор покупателя.</param>
        public PriorityOrder(Address address, BindingList<Item> items, int customerId)
                             : base(address, items, customerId)
        {
            Interval = "9:00 – 11:00";
        }
    }
}
