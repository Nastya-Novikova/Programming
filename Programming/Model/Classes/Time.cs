﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >=0 && value <= 23)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException(message: "Количество часов должно быть больше 0");
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value<60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException(message: "Количество минут должно быть не меньше 0 и меньше 60");
                }
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 && value<60)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException(message: "Количество секунд должно быть не меньше 0 и меньше 60");
                }
            }
        }

        public Time()
        {

        }

        public Time (int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
