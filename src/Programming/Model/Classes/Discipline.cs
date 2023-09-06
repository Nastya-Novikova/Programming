using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине, преподавателе и оценке.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string NameOfDiscipline { get; set; }

        /// <summary>
        /// Возвращает и задает имя преподавателя.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должно находиться в интервале от 2 до 5.
        /// </summary>
        public int Mark
        {
            get => _mark;
            set
            {
                int min = 2;
                int max = 5;
                Validator.AssertValueInRange(value, min, max);
                _mark = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/> без инициализации.
        /// </summary>
        public Discipline()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="nameOfDiscipline">Дисциплина.</param>
        /// <param name="teacher">Преподаватель.</param>
        /// <param name="mark">Оценка. Должна быть в диапазоне от 2 до 5.</param>
        public Discipline(string nameOfDiscipline, string teacher, int mark)
        {
            NameOfDiscipline = nameOfDiscipline;
            Teacher = teacher;
            Mark = mark;
        }
    }
}

