using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для случайной генерации объектов класса <see cref="Rectangle"/>.
    /// </summary>
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        /// <summary>
        /// Создает случайно сгенерированный объект-прямоугольник.
        /// </summary>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize()
        {
            var size = 15;
            var round = 3;
            var colorValues = Enum.GetValues(typeof(Color));
            var height = Math.Round(_random.NextDouble() * size + 1, round);
            var width = Math.Round(_random.NextDouble() * size + 1, round);
            var color = colorValues.GetValue(_random.Next(0, 7)).ToString();
            var center = new Point2D(Math.Round(_random.NextDouble() * size, round),
                                         Math.Round(_random.NextDouble() * size, round));
            return new Rectangle(height, width, color, center);
        }

        /// <summary>
        /// Создает случайно сгенерированный объект-прямоугольник, не выходящий за границы panel.
        /// </summary>
        /// <param name="panel">Панель.</param>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(Panel panel)
        {
            var devider = 2;
            var colorValues = Enum.GetValues(typeof(Color));
            var location = new Point2D(_random.Next(15, panel.Width - 15),
                                         _random.Next(15, panel.Height - 15));
            var height = _random.Next(1, (int)((panel.Height - location.Y) / devider));
            var width = _random.Next(1, (int)((panel.Width - location.X) / devider));
            var center = new Point2D(location.X + width / 2, location.Y + height / 2);
            var color = colorValues.GetValue(_random.Next(0, 7)).ToString();
            return new Rectangle(height, width, color, center);
        }
    }
}
