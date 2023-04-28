using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах точки. 
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата x.
        /// </summary>
        private double _x;

        /// <summary>
        /// Координата y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает координату x. Должна быть положительной.
        /// </summary>
        public double X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату y. Должна быть положительной.
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата x. Должна быть положительной.</param>
        /// <param name="y">Координата у. Должна быть положительной.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
