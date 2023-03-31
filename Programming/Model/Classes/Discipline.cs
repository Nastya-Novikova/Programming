using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Discipline
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
                int min = 2;
                int max = 5;
                Validator.AssertValueInRange(value, min, max);
                _mark = value;
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

