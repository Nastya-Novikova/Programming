using MusicApp.Model.Classes;
using MusicApp.Model.Enums;
using System.ComponentModel;
using Song = MusicApp.Model.Classes.Song;
using System.Linq;

namespace MusicApp.View
{
    public partial class MainForm : Form
    {
        private List<Song> _songs = new List<Song>();
        private Song _currentSong;

        public MainForm()
        {
            InitializeComponent();
            FillSongsListBox();
        }

        private void FillSongsListBox()
        {
            SongsListBox.DisplayMember = nameof(Song.Info);
            SongsListBox.DataSource = _songs;
        }

        private void UpdateSongsListBox()
        {
            SongsListBox.DataSource = null;
            SongsListBox.DataSource = _songs;
            SongsListBox.DisplayMember = nameof(Song.Info);
        }

        private void SortAlphabetically()
        {
             var sortedSongs = from song in _songs
                               orderby song.Singer, song.Name
                               select song;
             _songs = sortedSongs.ToList();
        }

        private void ClearSongsInfo()
        {
            NameTextBox.Clear();
            SingerTextBox.Clear();
            DurationTextBox.Clear();
            GenreTextBox.Clear();
        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                ClearSongsInfo();
                return;
            }

            _currentSong = _songs[SongsListBox.SelectedIndex];
            NameTextBox.Text = _currentSong.Name.ToString();
            SingerTextBox.Text = _currentSong.Singer.ToString();
            DurationTextBox.Text = _currentSong.Duration.ToString();
            GenreTextBox.Text = _currentSong.Genre.ToString();
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Data.Value = new Song();
            Data.Flag = false;
            AdditionalForm f = new AdditionalForm();
            f.ShowDialog();
            if (Data.Flag == true)
            {
                _songs.Add(Data.Value);
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = Data.Value;
            }
        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                return;
            }
            Data.Flag = false;
            Data.Value = new Song(_currentSong.Name, _currentSong.Singer,
                                  _currentSong.Duration, _currentSong.Genre);
            AdditionalForm f = new AdditionalForm();
            f.ShowDialog();
            if (Data.Flag == true)
            {
                _currentSong.Name = Data.Value.Name;
                _currentSong.Singer = Data.Value.Singer;
                _currentSong.Duration = Data.Value.Duration;
                _currentSong.Genre = Data.Value.Genre;
                Data.Value = _currentSong;
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = Data.Value;
            }
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                return;
            }
            _songs.RemoveAt(SongsListBox.SelectedIndex);
            UpdateSongsListBox();
            SongsListBox.SelectedIndex = -1;
            _currentSong = null;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SingerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DurationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GenreComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GenreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}