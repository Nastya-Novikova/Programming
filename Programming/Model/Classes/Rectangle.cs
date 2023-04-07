using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private int _id;
        private double _length;
        private double _width;
        private static int _allRectanglesCount;

        public int Id => _id;

        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        public string Color { get; set; }

        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }
        

        public Point2D Center { get; set; }

        public string Info =>
             $"{Id}: (X = {Math.Round(Center.X)}; Y = {Math.Round(Center.Y)}; " +
                    $"W = {Math.Round(Width)}; L = {Math.Round(Length)})";

        public Rectangle()
        {

        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            _id = AllRectanglesCount + 1;
            AllRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}


