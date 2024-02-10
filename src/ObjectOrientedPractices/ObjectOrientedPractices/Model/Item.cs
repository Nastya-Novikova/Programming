using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    ///Товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Событие, возникающее при изменении имени товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие, возникающее при изменении цены товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие, возникающее при изменении информации о товаре.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

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
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задает название товара.
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
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть от 1 до 200 символов.</param>
        /// <param name="info">Описание. Должно быть от 1 до 1000 символов.</param>
        /// <param name="cost">Стоимость. Должна быть от 0 до 100000.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = Category.Food;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Копия объекта.</returns>
        public object Clone()
        {
            return new Item(Name, Info, Cost);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим.</param>
        /// <returns>True, если объекты равны, иначе False.</returns>
        bool IEquatable<Item>.Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (Name == other.Name &&
                Cost == other.Cost)
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

            if (other is not Item)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var item = (Item)other;
            if (Name == item.Name && 
                Cost == item.Cost)
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
        /// <returns>
        /// 1, если текущий объект больше; 
        /// 0, если объекты равны; 
        /// -1, если текущий объект меньше.</returns>
        /// <exception cref="ArgumentException">Объект равен null.</exception>
        public int CompareTo(Item other)
        {
            if (other == null)
            {
                throw new ArgumentException("Incorrect item");
            }

            if (Cost > other.Cost)
            {
                return 1;
            }
            else if (Cost < other.Cost)
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
