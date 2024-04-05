using System;
using System.Globalization;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Конвертер массива значений.
    /// </summary>
    public class CombinedValidationConverter : IMultiValueConverter
    {
        /// <summary>
        /// Конвертирует массив значений в булевый результат для свойства IsEnabled.
        /// </summary>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] is bool)
                    {
                        if (values[i] is true)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Value wasn't a boolean type.");
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Конвертирует булевое значение в массив значений.
        /// </summary>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
