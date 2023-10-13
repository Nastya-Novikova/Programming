using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о баллах или скидке
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Возвращает размер скидки, доступной для этого
        /// списка продуктов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        double Calculate(BindingList<Item> items);

        /// <summary>
        /// Списывает накопленные баллы или считает стоимость товаров по категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        double Apply(BindingList<Item> items);

        /// <summary>
        /// Добавляет баллы или изменяет процент скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(BindingList<Item> items);
    }
}
