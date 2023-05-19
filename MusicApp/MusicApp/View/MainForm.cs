using MusicApp.Model.Classes;
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


        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            AdditionalForm f = new AdditionalForm();
            Data.Value = new Song();
            f.ShowDialog();
            Song newsong = new Song(Data.Value.Name, Data.Value.Singer,
                                    Data.Value.Duration, Data.Value.Genre);
            _songs.Add(newsong);
            SongsListBox.SelectedItem = newsong;
            UpdateSongInfo();
        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            AdditionalForm f = new AdditionalForm();
            f.Show();
        }
    }
}