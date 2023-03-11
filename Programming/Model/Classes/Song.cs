using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Song
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
                if (value > 0)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException(message: "Продолжительность песни должна быть больше 0");
                }
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
