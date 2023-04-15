using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
