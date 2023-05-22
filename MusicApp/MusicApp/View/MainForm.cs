using MusicApp.Model.Classes;
using MusicApp.Model.Enums;
using System.ComponentModel;
using Song = MusicApp.Model.Classes.Song;

namespace MusicApp.View
{
    public partial class MainForm : Form
    {
        private BindingList<Song> _songs;
        private Song _currentSong;

        public MainForm()
        {
            InitializeComponent();
            InitBindingListOfSongs();
            FillSongsListBox();
        }

        private void InitBindingListOfSongs()
        {
            _songs = new BindingList<Song>();
            _songs.AllowNew = true;
        }

        private void FillSongsListBox()
        {
            SongsListBox.DisplayMember = nameof(Song.Info);
            SongsListBox.DataSource = _songs;
        }

        private void UpdateSongInfo()
        {
            SongsListBox.DisplayMember = null;
            SongsListBox.DisplayMember = nameof(Song.Info);
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
            AdditionalForm f = new AdditionalForm();
            Data.Value = new Song();
            f.ShowDialog();
            try
            {
                Song newsong = new Song(Data.Value.Name, Data.Value.Singer,
                                        Data.Value.Duration, Data.Value.Genre);
                _songs.Add(newsong);
                SongsListBox.SelectedItem = newsong;
                UpdateSongInfo();
            }
            catch
            {
                MessageBox.Show("Объект не был создан.");
            }

        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            AdditionalForm f = new AdditionalForm();
            f.ShowDialog();
            Data.Value = _currentSong;
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                return;
            }
            _songs.RemoveAt(SongsListBox.SelectedIndex);
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