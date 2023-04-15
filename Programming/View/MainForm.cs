using Microsoft.VisualBasic.FileIO;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Policy;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int Quantity = 5;
        private Rectangle[] _classesRectangles = new Rectangle[Quantity];
        private Rectangle _classesCurrentRectangle;
        private BindingList<Rectangle> _rectangles;
        private BindingList<Panel> _rectanglePanels = new BindingList<Panel>();
        private Rectangle _currentRectangle;

        private Movie[] _movies = new Movie[Quantity];
        private Movie _currentMovie;

        private Random _random = new Random();
        public MainForm()
        {
            InitializeComponent();

            // массив, содержащий все перечисления
            object[] enums = new object[]
            { 
                typeof(Color),
                typeof(Genre),
                typeof(EducationForm),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };
            // добавление перечислений в ListBox
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);                                                             
            EnumsListBox.SelectedIndex = 0;

            // массив, содержащий элементы перечисления Season
            var seasonValues = Enum.GetValues(typeof(Season));   
            FillHandleComboBox(seasonValues);

            // заполнение RectanglesListBox и MoviesListBox
            for (int i = 0; i < Quantity; i++)
            {
                _classesRectangles[i] = RectangleFactory.Randomize();
            }
            FillRectangles(_classesRectangles);

            InitMovies(_movies);
            FillMovies(_movies);

            InitBindingListOfRectangles();
            FillInfoRectanglesListBox();
        }
    // работа с окном Enums
        // работа с ValuesListBox
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                         
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            // массив из элементов перечисления, выбранного пользователем
            var enumValues = Enum.GetValues(selectedEnum);                                                 

            ValuesListBox.Items.Clear();
            IntTextBox.Clear();

            // добавление элементов перечисления в ValuesListBox
            foreach (var enumValue in enumValues)                                                           
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        // работа с IntTextBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                         
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            var selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }

        // работа с окном Weekday Parsing
        private void ParseButton_Click(object sender, EventArgs e)                                          
        {
            if (ParsingTextBox.Text == null)
            {
                return;
            }

            object enteredDay;
            // результат преобразования пользовательского ввода
            bool result = Enum.TryParse(typeof(Weekday), ParsingTextBox.Text, true, out enteredDay);        

            if (result)
            {
                // получение номера введенного дня недели
                var number = (int)enteredDay + 1;                                                               
                ParsingAnswerLabel.Text = ($"Это день недели ({enteredDay} = {number})");
                return;
            }
            else
            {
                ParsingAnswerLabel.Text = ("Нет такого дня недели");
            }
        }

        private void FillHandleComboBox(Array seasonValues)
        {
            foreach (var seasonValue in seasonValues)
            {
                HandleComboBox.Items.Add(seasonValue);
            }
        }
        // работа с окном Season Handle
        private void HandleButton_Click(object sender, EventArgs e)                                         
        {
            // установка базового цвета MainForm
            this.BackColor = System.Drawing.Color.White;                                                    
            EnumsGroupBox.BackColor = System.Drawing.Color.White;
            WeekdayGroupBox.BackColor = System.Drawing.Color.White;
            SeasonGroupBox.BackColor = System.Drawing.Color.White;
            EnumsTabPage.BackColor = System.Drawing.Color.White;

            if (HandleComboBox.Text == null)
            {
                return;
            }

            string selectedItem = Convert.ToString(HandleComboBox.SelectedItem);
            // реализация действия на выбранный элемент из HandleComboBox
            switch (selectedItem)                                                                          
            {
                case "Winter":
                    {
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    }
                case "Summer":
                    {
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    }
                case "Autumn":
                    {
                        var orange = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                        this.BackColor = orange;
                        EnumsGroupBox.BackColor = orange;
                        WeekdayGroupBox.BackColor = orange;
                        SeasonGroupBox.BackColor = orange;
                        EnumsTabPage.BackColor = orange;
                        break;
                    }
                case "Spring":
                    {
                        var green = System.Drawing.ColorTranslator.FromHtml("#559c45");
                        this.BackColor = green;
                        EnumsGroupBox.BackColor = green;
                        WeekdayGroupBox.BackColor = green;
                        SeasonGroupBox.BackColor = green;
                        EnumsTabPage.BackColor = green;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Выберете сезон из выпадающего списка.");
                        break;
                    }
            }
        }
    // конец работы с окном Enums

    // работа с элементами RectanglesGroupBox (Classes)
        // инициализация массива прямоугольников


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

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(CanvasPanel);
            _rectangles.Add(newRectangle);
            AddPanel(newRectangle);
            InfoRectanglesListBox.SelectedItem = newRectangle;
            FindCollisionsOfOne(newRectangle);
        }

        private void AddPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Height = (int)rectangle.Height;
            panel.Width = (int)rectangle.Width;
            panel.Location = new Point((int)(rectangle.Location.X),
                                       (int)(rectangle.Location.Y));
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            CanvasPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);
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
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void FindCollisionsOfOne(Rectangle rectangle)
        {
            _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor =
                                   System.Drawing.Color.FromArgb(127, 127, 255, 127);
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (rectangle != _rectangles[i] && CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor =
                                  System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                }
            }
        }
        private void UpdateCanvasPanel(Rectangle rectangle)
        {
            int index = _rectangles.IndexOf(rectangle);
            _rectanglePanels[index].Height = (int)rectangle.Height;
            _rectanglePanels[index].Width = (int)rectangle.Width;
            _rectanglePanels[index].Location = new Point((int)(rectangle.Center.X - (rectangle.Width)/2),
                                                         (int)(rectangle.Center.Y - (rectangle.Height)/2));
        }


        // конец работы с элементами RectanglesGroupBox

        // работа с элементами MoviesGroupBox
        // инициализация массива фильмов
        private void InitMovies(Movie[] movies)
        {
            var genreValues = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < Quantity; i++)
            {
                string name = $"Movie {i + 1}";
                int duration = _random.Next(1,181);
                int year = _random.Next(1900,2024);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                double rating = Math.Round(_random.NextDouble() * 10, 1);
                movies[i] = new Movie(name, duration, year,genre,rating);
            }
        }

        private void FillMovies(Movie[] movies)
        {
            int i = 0;
            foreach (var movie in movies)
            {
                i++;
                MoviesListBox.Items.Add($"Movie {i}");
            }
            MoviesListBox.SelectedIndex = 0;
        }
        // заполнение всех элементов TextBox
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            NameTextBox.Text = _currentMovie.Name;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }
        
        // нахождение фильма с максимальным рейтингом
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            double maxRating = -1;
            int index = -1;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        // реализация возможности ручного ввода с формы Rectangles
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = System.Drawing.Color.White;
                _classesCurrentRectangle.Height = Double.Parse(HeightTextBox.Text);
            }
            catch
            {
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                _classesCurrentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _classesCurrentRectangle.Color = ColorTextBox.Text;
        }

        //реализация возможности ручного ввода с формы Rectangles
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
                    SelectedWidthTextBox.BackColor = System.Drawing.Color.LightPink;
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
                    SelectedHeightTextBox.BackColor = System.Drawing.Color.LightPink;
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
                    SelectedXTextBox.BackColor = System.Drawing.Color.LightPink;
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
                    SelectedYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }
        // реализация возможности ручного ввода с формы Movie
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Duration = Int32.Parse(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Int32.Parse(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Rating = Double.Parse(RatingTextBox.Text);
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // Запрет на изменение полей X, Y, ID
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