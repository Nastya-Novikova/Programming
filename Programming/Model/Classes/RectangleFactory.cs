using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;

namespace Programming.Model.Classes
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();
        public static Rectangle Randomize()
        {
            var size = 15;
            var round = 3;
            var colorValues = Enum.GetValues(typeof(Color));
            double height = Math.Round(_random.NextDouble() * size + 1, round);
            double width = Math.Round(_random.NextDouble() * size + 1, round);
            string color = colorValues.GetValue(_random.Next(0, 7)).ToString();
            Point2D center = new Point2D(Math.Round(_random.NextDouble() * size, round),
                                         Math.Round(_random.NextDouble() * size, round));
            return new Rectangle(height, width, color, center);
        }

        public static Rectangle Randomize(Panel panel)
        {
            int devider = 2;
            var colorValues = Enum.GetValues(typeof(Color));
            Point2D location = new Point2D((double)(_random.Next(15, panel.Width - 15)),
                                         (double)(_random.Next(15, panel.Height - 15)));
            double height = _random.Next(1, (int)((panel.Height - location.Y)/devider));
            double width = _random.Next(1, (int)((panel.Width - location.X)/devider));
            Point2D center = new Point2D(location.X + (width / 2), location.Y + (height / 2));
            string color = colorValues.GetValue(_random.Next(0, 7)).ToString();
            return new Rectangle(height, width, color, center);
        }
    }
}
