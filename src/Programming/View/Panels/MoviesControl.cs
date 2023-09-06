using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления MoviesControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество фильмов.
        /// </summary>
        private const int Quantity = 5;

        /// <summary>
        /// Массив объектов класса <see cref="Movie"/>.
        /// </summary>
        private Movie[] _movies = new Movie[Quantity];

        /// <summary>
        /// Объект класса <see cref="Movie"/>.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Объект класса <see cref="Random"/>.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создает объект типа <see cref="MoviesControl"/>.
        /// Инициализирует массив объектов класса <see cref="Movie"/> и заполняет ими MoviesListBox.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            InitMovies(_movies);
            FillMovies(_movies);
        }

        /// <summary>
        /// Инициализирует массив объектов.
        /// </summary>
        /// <param name="movies">Массив объектов класса <see cref="Movie"/>.</param>
        private void InitMovies(Movie[] movies)
        {
            var genreValues = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < Quantity; i++)
            {
                string name = $"Movie {i + 1}";
                int duration = _random.Next(1, 181);
                int year = _random.Next(1900, 2024);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                double rating = Math.Round(_random.NextDouble() * 10, 1);
                movies[i] = new Movie(name, duration, year, genre, rating);
            }
        }

        /// <summary>
        /// Заполняет MoviesListBox переданным массивом объектов.
        /// </summary>
        /// <param name="movies">Массив объектов класса <see cref="Movie"/>.</param>
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

        /// <summary>
        /// Заполняет текстбоксы соответвующими значениями выбранного элемента. 
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            NameTextBox.Text = _currentMovie.Name;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Находит объект класса с наибольшим рейтингом. 
        /// </summary>
        /// <param name="movies">Массив объектов класса <see cref="Movie"/>.</param>
        /// <returns>Возвращает индекс элемента с наибольшим рейтингом.</returns>
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

        /// <summary>
        /// Показывает в MoviesListBox объект класса <see cref="Movie"/> с наибольшим рейтингом.
        /// </summary>
        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        /// <summary>
        /// Записывает в поле <see cref="Movie.Name"/> введенное значение.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameTextBox.Text;
        }

        /// <summary>
        /// Записывает в поле <see cref="Movie.Duration"/> введенное значение.
        /// Принимает только положительные числа.
        /// </summary>
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

        /// <summary>
        /// Записывает в поле <see cref="Movie.Year"/> введенное значение.
        /// Принимает числа из интервала от 1900 до 2023.
        /// </summary>
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

        /// <summary>
        /// Записывает в поле <see cref="Movie.Genre"/> введенное значение.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// Записывает в поле <see cref="Movie.Rating"/> введенное значение.
        /// Принимает числа из интервала от 0 до 10.
        /// </summary>
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
    }
}
