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
    public partial class MoviesControl : UserControl
    {
        private const int Quantity = 5;
        private Movie[] _movies = new Movie[Quantity];
        private Movie _currentMovie;
        private Random _random = new Random();

        public MoviesControl()
        {
            InitializeComponent();

            InitMovies(_movies);
            FillMovies(_movies);
        }

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
    }
}
