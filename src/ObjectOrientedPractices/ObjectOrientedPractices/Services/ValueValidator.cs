using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Предоставляет методы для валидации полей.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки на принадлежность интервалу.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="minLength">Минимум интервала.</param>
        /// <param name="maxLength">Максимум интервала.</param>
        /// <param name="property">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемое число не принадлежит интервалу.</exception>
        public static void AssertStringOnLength(string value, int minLength, int maxLength, [CallerMemberName] string property = "")
        {
            if (value == null)
            {
                return;
            }

            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new ArgumentException($"Значение в {property} должно быть до {maxLength}");
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
            if (value == 0)
            {
                return;
            }

            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
    }
}
