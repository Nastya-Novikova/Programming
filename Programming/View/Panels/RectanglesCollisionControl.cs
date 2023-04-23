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
    public partial class RectanglesCollisionControl : UserControl
    {
        private BindingList<Rectangle> _rectangles;
        private BindingList<Panel> _rectanglePanels = new BindingList<Panel>();
        private Rectangle _currentRectangle;

        private Random _random = new Random();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitBindingListOfRectangles();
            FillInfoRectanglesListBox();
        }

        private void InitBindingListOfRectangles()
        {
            _rectangles = new BindingList<Rectangle>();
            _rectangles.AllowNew = true;
        }

        private void FillInfoRectanglesListBox()
        {
            InfoRectanglesListBox.DisplayMember = nameof(Rectangle.Info);
            InfoRectanglesListBox.DataSource = _rectangles;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            InfoRectanglesListBox.DisplayMember = null;
            InfoRectanglesListBox.DisplayMember = nameof(Rectangle.Info);
        }

        private void ClearRectanglesInfo()
        {
            SelectedIdTextBox.Clear();
            SelectedHeightTextBox.Clear();
            SelectedYTextBox.Clear();
            SelectedWidthTextBox.Clear();
            SelectedXTextBox.Clear();
        }

        private void InfoRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InfoRectanglesListBox.SelectedItem == null)
            {
                ClearRectanglesInfo();
                return;
            }
            //fix для запятой в текстбоксах
            if (_currentRectangle == _rectangles[InfoRectanglesListBox.SelectedIndex])
            {
                return;
            }
            _currentRectangle = _rectangles[InfoRectanglesListBox.SelectedIndex];
            SelectedHeightTextBox.Text = _currentRectangle.Height.ToString();
            SelectedWidthTextBox.Text = _currentRectangle.Width.ToString();
            SelectedXTextBox.Text = _currentRectangle.Center.X.ToString();
            SelectedYTextBox.Text = _currentRectangle.Center.Y.ToString();
            SelectedIdTextBox.Text = _currentRectangle.Id.ToString();
        }

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

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(CanvasPanel);
            _rectangles.Add(newRectangle);
            AddPanel(newRectangle);
            InfoRectanglesListBox.SelectedItem = newRectangle;
            FindCollisionsOfOne(newRectangle);
        }
        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (InfoRectanglesListBox.SelectedItem == null)
            {
                return;
            }
            CanvasPanel.Controls.RemoveAt(InfoRectanglesListBox.SelectedIndex);
            _rectanglePanels.Remove(_rectanglePanels[InfoRectanglesListBox.SelectedIndex]);
            _rectangles.Remove(_rectangles[InfoRectanglesListBox.SelectedIndex]);
            InfoRectanglesListBox.SelectedIndex = -1;
            _currentRectangle = null;
            FindAndMarkCollisions();
        }

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

        private void UpdateCanvasPanel(Rectangle rectangle)
        {
            int index = _rectangles.IndexOf(rectangle);
            _rectanglePanels[index].Height = (int)rectangle.Height;
            _rectanglePanels[index].Width = (int)rectangle.Width;
            _rectanglePanels[index].Location = new Point((int)(rectangle.Center.X - (rectangle.Width) / 2),
                                                         (int)(rectangle.Center.Y - (rectangle.Height) / 2));
        }

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
                UpdateRectangleInfo(_currentRectangle);
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (InfoRectanglesListBox.SelectedItem != null)
                {
                    SelectedWidthTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

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
                UpdateRectangleInfo(_currentRectangle);
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (InfoRectanglesListBox.SelectedItem != null)
                {
                    SelectedHeightTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

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
                UpdateRectangleInfo(_currentRectangle);
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (InfoRectanglesListBox.SelectedItem != null)
                {
                    SelectedXTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

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
                UpdateRectangleInfo(_currentRectangle);
                UpdateCanvasPanel(_currentRectangle);
                FindAndMarkCollisions();
            }
            catch
            {
                if (InfoRectanglesListBox.SelectedItem != null)
                {
                    SelectedYTextBox.BackColor = AppColor.LightPink;
                }
            }
        }

        private void SelectedIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddIconGreen_30x30;
        }

        private void RemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.RemoveIconRed_30x30;
        }

        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Properties.Resources.RemoveIcon_30x30;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.AddIcon_30x30;
        }
    }
}
