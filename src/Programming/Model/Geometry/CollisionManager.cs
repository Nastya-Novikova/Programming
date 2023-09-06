using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для определения наличия пересечений объектов класса <see cref="Rectangle"/> и <see cref="Ring"/>.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый объект.</param>
        /// <param name="rectangle2">Второй проверяемый объект.</param>
        /// <returns>true, если объекты пересекаются; false, если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            return deltaX < (rectangle1.Width + rectangle2.Width) / 2 &&
                    deltaY < (rectangle1.Height + rectangle2.Height) / 2;
        }

        /// <summary>
        /// Проверяет пересечение колец.
        /// </summary>
        /// <param name="ring1">Первый проверяемый объект.</param>
        /// <param name="ring2">Второй проверяемый объект.</param>
        /// <returns>true, если объекты пересекаются; false - если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double deltaX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double deltaY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double sumRadius = ring1.RadiusOut + ring2.RadiusOut;
            return sumRadius > Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
    }
}
