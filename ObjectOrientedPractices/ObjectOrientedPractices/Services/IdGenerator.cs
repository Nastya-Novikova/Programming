using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет метод генерации Id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Уникальный идентификатор объекта.
        /// </summary>
        private static int _id;

        /// <summary>
        /// Создает Id.
        /// </summary>
        /// <returns>Уникальный идентификатор объекта.</returns>
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
