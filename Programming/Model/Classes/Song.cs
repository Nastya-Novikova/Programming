﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _name;
        private string _author;
        private int _seconds;
    
        public string Name { get; set; }
        public string Author { get; set; }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _seconds = value;
            }
        }

        public Song ()
        {

        }

        public Song(string name, string author, int seconds)
        {
            Name = name;
            Author = author;
            Seconds = seconds;
        }
    }
}
