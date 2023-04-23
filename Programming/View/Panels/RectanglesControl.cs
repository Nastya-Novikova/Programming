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
    public partial class RectanglesControl : UserControl
    {
        private const int Quantity = 5;
        private Rectangle[] _classesRectangles = new Rectangle[Quantity];
        private Rectangle _classesCurrentRectangle;
        private Random _random = new Random();
        public RectanglesControl()
        {
            InitializeComponent();

            for (int i = 0; i < Quantity; i++)
            {
                _classesRectangles[i] = RectangleFactory.Randomize();
            }
            FillRectangles(_classesRectangles);
        }

        private void FillRectangles(Rectangle[] rectangles)
        {
            foreach (var rectangle in rectangles)
            {
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
                RectanglesListBox.SelectedIndex = 0;
            }
        }

        // заполнение всех элементов TextBox
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null)
            {
                return;
            }

            _classesCurrentRectangle = _classesRectangles[RectanglesListBox.SelectedIndex];
            HeightTextBox.Text = _classesCurrentRectangle.Height.ToString();
            WidthTextBox.Text = _classesCurrentRectangle.Width.ToString();
            ColorTextBox.Text = _classesCurrentRectangle.Color.ToString();
            XTextBox.Text = _classesCurrentRectangle.Center.X.ToString();
            YTextBox.Text = _classesCurrentRectangle.Center.Y.ToString();
            IdTextBox.Text = _classesCurrentRectangle.Id.ToString();
        }

        // нахождение прямоугольника с максимальной шириной
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

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_classesRectangles);
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = AppColor.White;
                _classesCurrentRectangle.Height = Double.Parse(HeightTextBox.Text);
            }
            catch
            {
                HeightTextBox.BackColor = AppColor.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = AppColor.White;
                _classesCurrentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColor.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _classesCurrentRectangle.Color = ColorTextBox.Text;
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
