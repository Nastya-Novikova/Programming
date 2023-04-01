using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _seconds;
    
        public string Name { get; set; }
        public string Author { get; set; }
        public int Seconds
        {
            get => _seconds;
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
