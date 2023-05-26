﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model.Classes
{
    public class Song
    {
        private string _name;
        private string _singer;
        private int _duration;

        public string Name
        {
            get { return _name;}
            set
            {
                int min = 1;
                int max = 50;
                Validator.AssertValueInRange(value.Length, min, max);
                _name = value;
            }
        }

        public string Singer
        {
            get => _singer;
            set
            {
                int min = 1;
                int max = 50;
                Validator.AssertValueInRange(value.Length, min, max);
                _singer = value;
            }
        }

        public int Duration
        {
            get => _duration;
            set
            {
                int min = 1;
                int max = 7200;
                Validator.AssertValueInRange(value, min, max);
                _duration = value;
            }
        }

        public string Genre { get; set; }

        public string Info => $"{Singer} - {Name}";


        public Song()
        {

        }

        public Song(string name, string singer, int duration, string genre)
        {
            Name = name;
            Singer = singer;
            Duration = duration;
            Genre = genre;
        }
    }
}
