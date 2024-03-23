using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Конвертер значений.
    /// </summary>
    public class CombinedValidationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 0)
            {
                return true;
            }
            else
            {
                for (int i=0; i<values.Length; i++)
                {
                    if (values[i] is true)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
