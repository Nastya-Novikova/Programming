﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Корзина товаров.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость товаров в корзине.
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
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public Cart(BindingList<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Копия объекта.</returns>
        public object Clone()
        {
            BindingList<Item> copiedItems = new BindingList<Item>();
            for (int i = 0; i < Items.Count; i++)
            {
                copiedItems.Add(new Item(Items[i].Name, Items[i].Info, Items[i].Cost));
            }
            return new Cart(copiedItems);
        }
    }
}
