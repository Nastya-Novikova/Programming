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

    public static class DataTools
    {
        public static bool SortByCost(Item item)
        {
            return item.Cost > 5000;
        }

        public static bool SortByCategory(Item item)
        {
            return item.Category == Category.PetProducts;
        }

        public static BindingList<Item> Sort(BindingList<Item> items, Func<Item, bool> sort)
        {
            BindingList<Item> sortedItems = new BindingList<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (sort(items[i]))
                {
                    sortedItems.Add(items[i]);
                }
            }
            return sortedItems;
        }
    }
}
