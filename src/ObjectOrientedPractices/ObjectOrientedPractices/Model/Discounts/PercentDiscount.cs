using Microsoft.VisualBasic.ApplicationServices;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    /// <summary>
    /// Процентная карта.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Категория товара.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Текущая скидка.
        /// </summary>
        private double _discount;

        /// <summary>
        /// Сумма, на которую покупатель уже сделал покупки.
        /// </summary>
        private double _totalSum;

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            private set { _category = value; }
        }

        /// <summary>
        /// Возвращает и задает текущий размер скидки.
        /// </summary>
        public double Discount
        {
            get { return _discount; }
            private set { _discount = value; }
        }

        /// <summary>
        /// Возвращает и задает сумму, на которую покупатель уже сделал покупки.
        /// </summary>
        public double TotalSum
        {
            get { return _totalSum; }
            private set { _totalSum = value; }
        }

        /// <summary>
        /// Возвращает информацию о скидке по категории.
        /// </summary>
        public string Info => $"Процентная '{Category}' - {Discount*100}%";

        public PercentDiscount(Category category)
        {
            Category = category;
            Discount = 0.01;
            TotalSum = 0;
        }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого
        /// списка продуктов со скидкой на данную категорию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(BindingList<Item> items)
        {
            double totalDiscount = 0;
            foreach (Item item in items)
            {
                if (Category == item.Category)
                {
                    totalDiscount += Discount * item.Cost;
                }
            }
            return totalDiscount;
        }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого
        /// списка продуктов со скидкой на данную категорию.
        /// Обновляет сумму, на которую покупатель уже сделал покупки. 
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(BindingList<Item> items)
        {
            double totalDiscount = Calculate(items);
            foreach (Item item in items)
            {
                if (Category == item.Category)
                {
                    TotalSum += item.Cost;
                }
            }
            return totalDiscount;
        }

        /// <summary>
        /// Обновляет процент скидки по карте.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(BindingList<Item> items)
        {
            if (Discount * 100 < 10)
            {
                if ((Math.Floor(TotalSum / 1000) + 1) <= 10)
                {
                    Discount = (Math.Floor(TotalSum / 1000) + 1) * 0.01;
                }
                else
                {
                    Discount = 0.1;
                }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим.</param>
        /// <returns>
        /// 1, если текущий объект больше; 
        /// 0, если объекты равны; 
        /// -1, если текущий объект меньше.</returns>
        /// <exception cref="ArgumentException">Объект равен null.</exception>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
            {
                throw new ArgumentException("Incorrect discount");
            }

            if (Discount > other.Discount)
            {
                return 1;
            }
            else if (Discount < other.Discount)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
