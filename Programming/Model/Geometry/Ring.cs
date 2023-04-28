using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _radiusOut;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _radiusIn;

        /// <summary>
        /// Возвращает и задает центр кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть больше внутреннего.
        /// </summary>
        public double RadiusOut
        {
            get => _radiusOut;
            set
            {
                if (_radiusIn == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, RadiusIn, double.MaxValue);
                }
                _radiusOut = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть меньше внешнего.
        /// </summary>
        public double RadiusIn
        {
            get => _radiusIn;
            set
            {
                if (_radiusOut == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, 0, RadiusOut);
                }
                _radiusIn = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area =>
            Math.PI * (Math.Pow(RadiusOut, 2) - Math.Pow(RadiusIn, 2));

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Центр.</param>
        /// <param name="radiusOut">Внешний радиус.</param>
        /// <param name="radiusIn">Внутренний радиус.</param>
        public Ring(Point2D center, double radiusOut, double radiusIn)
        {
            Center = center;
            RadiusOut = radiusOut;
            RadiusIn = radiusIn;
        }
    }
}
