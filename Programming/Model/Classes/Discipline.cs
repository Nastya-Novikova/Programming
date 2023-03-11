using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    internal class Discipline
    {
        private string _surname;
        private string _teacher;
        private int _mark;

        public string Surname { get; set; }
        public string Teacher { get; set; }
        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    _mark = value;
                }
                else
                {
                    throw new ArgumentException(message: "Оценка должна быть в диапазоне от 2 до 5");
                }
            }
        }

        public Discipline()
        {

        }

        public Discipline(string surname, string teacher, int mark)
        {
            Surname = surname;
            Teacher = teacher;
            Mark = mark;
        }
    }
}

