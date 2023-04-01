using System;
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
            get => _hours;
            set
            {
                int min = 0;
                int max = 23;
                Validator.AssertValueInRange(value, min, max);
                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                int min = 0;
                int max = 59;
                Validator.AssertValueInRange(value, min, max);
                _seconds = value;
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
