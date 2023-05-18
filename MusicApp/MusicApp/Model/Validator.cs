using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model
{
    public class Validator
    {
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string property = "")
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
    }
}
