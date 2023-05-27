using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для валидации полей.
    /// </summary>
    public class Validator
    {
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
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
    }
}
