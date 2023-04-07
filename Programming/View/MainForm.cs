using Programming.Model.Classes;
using Programming.Model.Enums;
using System.ComponentModel;
using System.Drawing.Text;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int Quantity = 5;
        private Rectangle[] _classesRectangles = new Rectangle[Quantity];
        private Rectangle _classesCurrentRectangle;
        private BindingList<Rectangle> _rectangles;
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
                _classesRectangles[i] = InitRectangle();
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
        private Rectangle InitRectangle()
        {
            var size = 15;
            var round = 3;
            var colorValues = Enum.GetValues(typeof(Color));
            double length = Math.Round(_random.NextDouble() * size + 1, round);
            double width = Math.Round(_random.NextDouble() * size + 1, round);
            string color = colorValues.GetValue(_random.Next(0, 7)).ToString();
            Point2D center = new Point2D(Math.Round(_random.NextDouble() * size, round),
                                         Math.Round(_random.NextDouble() * size, round));
            return new Rectangle(length, width, color, center);  
        }

        private void InitBindingListOfRectangles()
        {
            _rectangles = new BindingList<Rectangle>();
            _rectangles.AllowNew = true;
            for (int i = 0; i < Quantity; i++)
            {
                _rectangles.Add(_classesRectangles[i]);
            }
        }

        private void FillInfoRectanglesListBox()
        {
            InfoRectanglesListBox.DataSource = null;
            InfoRectanglesListBox.DisplayMember = nameof(Rectangle.Info);
            InfoRectanglesListBox.DataSource = _rectangles;
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
            LengthTextBox.Text = _classesCurrentRectangle.Length.ToString();
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
                return;
            }
            _currentRectangle = _rectangles[InfoRectanglesListBox.SelectedIndex];
            SelectedLengthTextBox.Text = _currentRectangle.Length.ToString();
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
            _rectangles.Add(InitRectangle());
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (InfoRectanglesListBox.SelectedItem == null)
            {
                return;
            }
            _rectangles.Remove(_rectangles[InfoRectanglesListBox.SelectedIndex]);
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
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                _classesCurrentRectangle.Length = Double.Parse(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
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
                _currentRectangle.Width = Double.Parse(SelectedWidthTextBox.Text);
                FillInfoRectanglesListBox();
            }
            catch
            {
                SelectedWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void SelectedLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedLengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = Double.Parse(SelectedLengthTextBox.Text);
                FillInfoRectanglesListBox();
            }
            catch
            {
                SelectedLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void SelectedXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedXTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Center.X = Double.Parse(SelectedXTextBox.Text);
                FillInfoRectanglesListBox();
            }
            catch
            {
                SelectedXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void SelectedYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedYTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Center.Y = Double.Parse(SelectedYTextBox.Text);
                FillInfoRectanglesListBox();
            }
            catch
            {
                SelectedYTextBox.BackColor = System.Drawing.Color.LightPink;
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