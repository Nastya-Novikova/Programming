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
    /// Содержит логику пользовательского элемента управления RectanglesCollisionControl.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Rectangle"/>.
        /// </summary>
        private BindingList<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция объектов типа <see cref="Panel"/>.
        /// </summary>
        private BindingList<Panel> _rectanglePanels = new BindingList<Panel>();

        /// <summary>
        /// Объект класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает объект типа <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitBindingListOfRectangles();
            FillRectanglesListBox();
        }

        /// <summary>
        /// Инициализирует массив _rectangles как BindingList.
        /// </summary>
        private void InitBindingListOfRectangles()
        {
            _rectangles = new BindingList<Rectangle>();
            _rectangles.AllowNew = true;
        }

        /// <summary>
        /// Заоплняет RectanglesListBox значениями из массива _rectangles.
        /// </summary>
        private void FillRectanglesListBox()
        {
            RectanglesListBox.DisplayMember = nameof(Rectangle.Info);
            RectanglesListBox.DataSource = _rectangles;
        }

        /// <summary>
        /// Обновляет RectanglesListBox при изменении полей.
        /// </summary>
        private void UpdateRectangleInfo()
        {
            RectanglesListBox.DisplayMember = null;
            RectanglesListBox.DisplayMember = nameof(Rectangle.Info);
        }

        /// <summary>
        /// Очищает все текстбоксы.
        /// </summary>
        private void ClearRectanglesInfo()
        {
            SelectedIdTextBox.Clear();
            SelectedHeightTextBox.Clear();
            SelectedYTextBox.Clear();
            SelectedWidthTextBox.Clear();
            SelectedXTextBox.Clear();
        }

        /// <summary>
        /// Заполняет текстбоксы и изменяет поле _currentRectangle при 
        /// выборе элемента в RectanglesListBox.
        /// Метод ожидает передачу значения не равного null, иначе очищает все поля.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null)
            {
                ClearRectanglesInfo();
                return;
            }

            // Возвращает, если выбранный элемент совпадает с текущим в _currentRectangle.
            if (_currentRectangle == _rectangles[RectanglesListBox.SelectedIndex])
            {
                return;
            }
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            SelectedHeightTextBox.Text = _currentRectangle.Height.ToString();
            SelectedWidthTextBox.Text = _currentRectangle.Width.ToString();
            SelectedXTextBox.Text = _currentRectangle.Center.X.ToString();
            SelectedYTextBox.Text = _currentRectangle.Center.Y.ToString();
            SelectedIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Добавляет прямоугольник на CanvasPanel и в массив _rectanglePanels.
        /// </summary>
        /// <param name="rectangle">Объект класса <see cref="Rectangle"/>.</param>
        private void AddPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Height = (int)rectangle.Height;
            panel.Width = (int)rectangle.Width;
            panel.Location = new Point((int)(rectangle.Location.X),
                                       (int)(rectangle.Location.Y));
            panel.BackColor = AppColor.LightGreen;
            CanvasPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Rectangle"/>, добавляет его на панель и проверяет пересечения.
        /// </summary>
        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(CanvasPanel);
            _rectangles.Add(newRectangle);
            AddPanel(newRectangle);
            RectanglesListBox.SelectedItem = newRectangle;
            UpdateRectangleInfo();
            FindCollisionsOfOne(newRectangle);
        }

        /// <summary>
        /// Удаляет выбранный прямоугольник с CanvasPanel и из массивов _rectanglePanels и _rectangles.
        /// Обновляет пересечение на CanvasPanel.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null)
            {
                return;
            }
            CanvasPanel.Controls.RemoveAt(RectanglesListBox.SelectedIndex);
            _rectanglePanels.Remove(_rectanglePanels[RectanglesListBox.SelectedIndex]);
            _rectangles.Remove(_rectangles[RectanglesListBox.SelectedIndex]);
            RectanglesListBox.SelectedIndex = -1;
            _currentRectangle = null;
            FindAndMarkCollisions();
        }

        /// <summary>
        /// Проверяет пересечение всех прямоугольников на CanvasPanel.
        /// </summary>
        private void FindAndMarkCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColor.LightGreen;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColor.Red;
                        _rectanglePanels[j].BackColor = AppColor.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Проверяет пересечение одного прямоугольника со всеми.
        /// </summary>
        /// <param name="rectangle">Объект класса <see cref="Rectangle"/>.</param>
        private void FindCollisionsOfOne(Rectangle rectangle)
        {
            _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = AppColor.LightGreen;
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (rectangle != _rectangles[i] && CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = AppColor.Red;
                    _rectanglePanels[i].BackColor = AppColor.Red;
                }
            }
        }

        /// <summary>
        /// Обновляет отрисовку прямоугольника на CanvasPanel.
        /// </summary>
        /// <param name="rectangle">Объект класса <see cref="Rectangle"/>.</param>
        private void UpdateCanvasPanel(Rectangle rectangle)
        {
            int index = _rectangles.IndexOf(rectangle);
            _rectanglePanels[index].Height = (int)rectangle.Height;
            _rectanglePanels[index].Width = (int)rectangle.Width;
            _rectanglePanels[index].Location = new Point((int)(rectangle.Center.X - (rectangle.Width) / 2),
                                                         (int)(rectangle.Center.Y - (rectangle.Height) / 2));
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Width"/> введенное значение, обновляет панель, проверяет пересечения.
        /// Принимает положительные числа.
        /// Метод ожидает значение отличное от предыдущего.
        /// </summary>
        private void SelectedWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedWidthTextBox.BackColor = System.Drawing.Color.White;
                if (_currentRectangle.Width == Double.Parse(SelectedWidthTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Width = Double.Parse(SelectedWidthTextBox.Text);
                UpdateRectangleInfo();
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (RectanglesListBox.SelectedItem != null)
                {
                    SelectedWidthTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Height"/> введенное значение, обновляет панель, проверяет пересечения.
        /// Принимает положительные числа.
        /// Метод ожидает значение отличное от предыдущего.
        /// </summary>
        private void SelectedHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedHeightTextBox.BackColor = System.Drawing.Color.White;
                if (_currentRectangle.Height == Double.Parse(SelectedHeightTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Height = Double.Parse(SelectedHeightTextBox.Text);
                UpdateRectangleInfo();
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (RectanglesListBox.SelectedItem != null)
                {
                    SelectedHeightTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Center.X"/> введенное значение, обновляет панель, проверяет пересечения.
        /// Принимает положительные числа.
        /// Метод ожидает значение отличное от предыдущего.
        /// </summary>
        private void SelectedXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedXTextBox.BackColor = System.Drawing.Color.White;
                if (_currentRectangle.Center.X == Double.Parse(SelectedXTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Center.X = Double.Parse(SelectedXTextBox.Text);
                UpdateRectangleInfo();
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (RectanglesListBox.SelectedItem != null)
                {
                    SelectedXTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Rectangle.Center.Y"/> введенное значение, обновляет панель, проверяет пересечения.
        /// Принимает положительные числа.
        /// Метод ожидает значение отличное от предыдущего.
        /// </summary>
        private void SelectedYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedYTextBox.BackColor = System.Drawing.Color.White;
                if (_currentRectangle.Center.Y == Double.Parse(SelectedYTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Center.Y = Double.Parse(SelectedYTextBox.Text);
                UpdateRectangleInfo();
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (RectanglesListBox.SelectedItem != null)
                {
                    SelectedYTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

        /// <summary>
        /// Контролирует ввод в SelectedIdTextBox.
        /// </summary>
        private void SelectedIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Меняет цвет AddPictureBox на зеленый.
        /// </summary>
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddIconGreen_30x30;
        }

        /// <summary>
        /// Меняет цвет RemovePictureBox на красный.
        /// </summary>
        private void RemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.RemoveIconRed_30x30;
        }

        /// <summary>
        /// Меняет цвет RemovePictureBox на серый.
        /// </summary>
        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.RemoveIcon_30x30;
        }

        /// <summary>
        /// Меняет цвет AddPictureBox на серый.
        /// </summary>
        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddIcon_30x30;
        }
    }
}
