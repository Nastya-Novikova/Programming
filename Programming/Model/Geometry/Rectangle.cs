using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;
        
        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Счетчик созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть положительной.
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительной.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает число прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }

        /// <summary>
        /// Возвращает и задает центр прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает расположение верхнего левого угла прямоугольника.
        /// </summary>
        public Point2D Location =>
            new Point2D(Center.X - Width / 2, Center.Y - Height / 2);

        /// <summary>
        /// Возвращает строку, содержащую Id, Center.X, Center.Y, Width, Height. 
        /// </summary>
        public string Info =>
             $"{Id}: (X = {Math.Round(Center.X)}; Y = {Math.Round(Center.Y)}; " +
                    $"W = {Math.Round(Width)}; H = {Math.Round(Height)})";

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/> без инициализации.
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна быть положительной.</param>
        /// <param name="width">Ширина. Должна быть положительной.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Центр.</param>
        /// Класс контролирует уникальность присвоенного id.
        public Rectangle(double height, double width, string color, Point2D center)
        {
            _id = AllRectanglesCount + 1;
            AllRectanglesCount++;
            Height = height;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}


