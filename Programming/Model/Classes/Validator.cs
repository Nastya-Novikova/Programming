using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит методы для валидации полей.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет целое число на положительность.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемое число неположительное.</exception>
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string property = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {property} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет вещественное число на положительность.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемое число неположительное.</exception>
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string property = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {property} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет целое число на принадлежность интервалу.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимум интервала.</param>
        /// <param name="max">Максимум интервала.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемое число не принадлежит интервалу.</exception>
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string property = "")
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет вещественное число на принадлежность интервалу.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимум интервала.</param>
        /// <param name="max">Максимум интервала.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемое число не принадлежит интервалу.</exception>
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string property = "")
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
    }
}
