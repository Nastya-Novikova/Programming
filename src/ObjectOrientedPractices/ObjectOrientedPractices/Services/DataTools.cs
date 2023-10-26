using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    //public delegate bool SortValues(Item item);
    /// <summary>
    /// Предоставляет методы для сортировки и фильтрации списков.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Выбирает товары со стоимостью больше 5000.
        /// </summary>
        /// <param name="item">Проверяемый элемент.</param>
        /// <returns>true, если цена больше 5000, иначе false.</returns>
        public static bool FilterByCost(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Выбирает товары с категорией PetProducts.
        /// </summary>
        /// <param name="item">Проверяемый элемент.</param>
        /// <returns>true, если категория PetProducts, иначе false.</returns>
        public static bool FilterByCategory(Item item)
        {
            return item.Category == Category.PetProducts;
        }

        /// <summary>
        /// Выбирает товары удовлетворяющие условию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="filter">Внешний делегат</param>
        /// <returns>Список выбранных товаров.</returns>
        public static BindingList<Item> Filter(BindingList<Item> items, Func<Item, bool> filter)
        {
            BindingList<Item> filteredItems = new BindingList<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (filter(items[i]))
                {
                    filteredItems.Add(items[i]);
                }
            }
            return filteredItems;
        }

        /// <summary>
        /// Сортирует список товаров.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <param name="compare">Внешний делегат.</param>
        public static void Sort(BindingList<Item> items, Func<Item, Item, bool> compare)
        {
            for (int i = 1; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
                {
                    if (compare(items[j], items[j+1]))
                    {
                        var temp = items[j];
                        items[j] = items[j+1];
                        items[j+1] = temp;
                    }
                }
            }
        }
    }
}
