using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Коллекция объектов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задает лист товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает лист покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создает экземляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new BindingList<Item>();
            Customers = new BindingList<Customer>();
        }
    }
}
