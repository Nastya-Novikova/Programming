﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private long _number;

        public string Name { get; set; }
        public string Surname { get; set; }
        public long Number
        {
            get { return _number; }
            set
            {
                if (value > 0)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentException(message: "Номер телефона должен быть больше 0");
                }
            }
        }

        public Contact()
        {

        }

        public Contact (string name, string surname, long number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
