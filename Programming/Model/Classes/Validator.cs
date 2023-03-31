﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Validator
    {
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string property = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {property} должно быть положительным");
            }
        }
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string property = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {property} должно быть положительным");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string property = "")
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string property = "")
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Значение в {property} должно быть от {min} до {max}");
            }
        }
    }
}