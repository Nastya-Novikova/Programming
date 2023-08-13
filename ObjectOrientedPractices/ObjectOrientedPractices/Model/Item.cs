using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    ///Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Счетчик созданных товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задает количество созданных товаров.
        /// </summary>
        public static int AllItemsCount
        {
            get => _allItemsCount;
            private set => _allItemsCount = value;
        }

        /// <summary>
        /// Возвращает и задает название песни.
        /// Должно быть от 1 до 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                int min = 1;
                int max = 200;
                ValueValidator.AssertStringOnLength(value, min, max);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// Должно быть от 1 до 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                int min = 1;
                int max = 1000;
                ValueValidator.AssertStringOnLength(value, min, max);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// Должна быть от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                int min = 0;
                int max = 100000;
                ValueValidator.AssertValueInRange(value, min, max);
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть от 1 до 200 символов.</param>
        /// <param name="info">Описание. Должно быть от 1 до 1000 символов.</param>
        /// <param name="cost">Стоимость. Должна быть от 0 до 100000.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Item(string name, string info, double cost)
        {
            _id = AllItemsCount + 1;
            AllItemsCount++;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
