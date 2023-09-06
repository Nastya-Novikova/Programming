using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private const int Quantity = 5;

        /// <summary>
        /// Массив объектов класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[Quantity];

        /// <summary>
        /// Объект класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает объект типа <see cref="RectanglesControl"/>.
        /// Инициализирует массив объектов класса <see cref="Rectangle"/> и заполняет ими RectanglesListBox.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            for (int i = 0; i < Quantity; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
            }
            FillRectangles(_rectangles);
        }

        /// <summary>
        /// Заполняет RectanglesListBox переданным массивом объектов.
        /// </summary>
        /// <param name="rectangles">Массив объектов класса <see cref="Rectangle"/>.</param>
        private void FillRectangles(Rectangle[] rectangles)
        {
            foreach (var rectangle in rectangles)
            {
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
                RectanglesListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Заполняет текстбоксы соответвующими значениями выбранного элемента.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Находит объект класса с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles">Массив объектов класса <see cref="Rectangle"/>.</param>
        /// <returns>Возвращает индекс элемента с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double maxWidth = -1;
            int index = -1;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Показывает в RectanglesListBox объект класса <see cref="Rectangle"/> с наибольшей шириной.
        /// </summary>
        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Height"/> введенное значение.
        /// Принимает только положительные числа.
        /// </summary>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = AppColor.White;
                _currentRectangle.Height = Double.Parse(HeightTextBox.Text);
            }
            catch
            {
                HeightTextBox.BackColor = AppColor.LightPink;
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Width"/> введенное значение.
        /// Принимает только положительные числа.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = AppColor.White;
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColor.LightPink;
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Color"/> введенное значение.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// Контролирует ввод в XTextBox.
        /// </summary>
        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует ввод в YTextBox.
        /// </summary>
        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует ввод в IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
