using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Discounts
{
    /// <summary>
    /// Накопительная карта.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Баллы.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает количество баллов на карте.
        /// Должно быть положительным.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value);
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает информацию о количестве баллов на карте.
        /// </summary>
        public string Info => $"Накопительная - {Points} баллов";

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Random random = new Random();
            Points = random.Next(400);
        }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого
        /// списка продуктов с текущим количеством баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(BindingList<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            if (Points > 0.3*amount)
            {
                return Math.Floor(0.3 * amount);
            }
            else
            {
                return (double)Points;
            }
        }

        /// <summary>
        /// Списывает накопленные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(BindingList<Item> items)
        {
            double totalDiscount = Calculate(items);
            Points = Points - (int)totalDiscount;
            return totalDiscount;
        }

        /// <summary>
        /// Добавляет баллы на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(BindingList<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            Points += (int)Math.Ceiling(0.1*amount);
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
        public int CompareTo(PointsDiscount other)
        {
            if (other == null)
            {
                throw new ArgumentException("Incorrect discount");
            }

            if (Points > other.Points)
            {
                return 1;
            }
            else if (Points < other.Points)
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
